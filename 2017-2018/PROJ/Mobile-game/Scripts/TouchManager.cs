using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public Rigidbody rb;
    public LayerMask layer;
    private GameObject theObject = null;
    private Plane theBackground;
    private Vector3 m0;
    private int layermask;

    void Start()
    {
        layermask = LayerMask.GetMask("Default");
    }

    Ray GenerateMouseRay()
    {
        Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
        Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
        Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

        Ray theRay = new Ray(mousePosN, mousePosF - mousePosN);
        return theRay;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = GenerateMouseRay();
            RaycastHit hit;

            if (Physics.Raycast(mouseRay.origin, mouseRay.direction, out hit, 200, layermask))
            {
                if (hit.transform.tag == "dragAble")
                {
                    theObject = hit.transform.gameObject;
                    theBackground = new Plane(Camera.main.transform.forward * -1, theObject.transform.position);

                    Ray theRay2 = Camera.main.ScreenPointToRay(Input.mousePosition);
                    float rayDistance;
                    theBackground.Raycast(theRay2, out rayDistance);
                    m0 = theObject.transform.position - theRay2.GetPoint(rayDistance);
                }
            }
        }
        else if (Input.GetMouseButton(0) && theObject)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, layer))
            {
                Ray theRay3 = Camera.main.ScreenPointToRay(Input.mousePosition);
                float rayDistance2;
                if (theBackground.Raycast(theRay3, out rayDistance2))
                {
                    theObject.GetComponent<Rigidbody>().MovePosition(theRay3.GetPoint(rayDistance2) + m0);// = theRay3.GetPoint(rayDistance2) + m0;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0) && theObject)
        {
            theObject = null;
        }
    }
}
