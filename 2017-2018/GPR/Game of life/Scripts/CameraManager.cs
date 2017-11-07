using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    RaycastHit theRaycastHit;
    Ray theRay;

    public GridPieceManager theGridPieceManager;

    void Start()
    {
    }

    void Update()
    {
        theRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawLine(theRay.origin, theRaycastHit.point, Color.green);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(theRay, out theRaycastHit))
            {
                theRaycastHit.collider.GetComponent<GridPieceManager>().ToggleActive();

                if (theRaycastHit.transform.tag == "Block")
                {
                    Debug.Log("This is a block");
                    print(theRaycastHit.collider.gameObject.name);
                }

            }
        }
    }
}
