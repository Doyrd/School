using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPieceManager : MonoBehaviour
{

    private Renderer theRenderer;

    public Color theFirstColor = Color.white;
    public Color theSecondColor = Color.black;

    public bool activated;

    void Start()
    {
        theRenderer = GetComponent<Renderer>();
        theRenderer.material.color = theFirstColor;
    }

    void Update()
    {
        if (activated)
        {
            theRenderer.material.color = theSecondColor;
        }

        if (!activated)
        {
            theRenderer.material.color = theFirstColor;
        }
    }

    public void ToggleActive()
    {
        activated = !activated;
    }

}

