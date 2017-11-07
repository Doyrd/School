using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InputField : MonoBehaviour
{
    public GridManager theGridManager;

    int newValueCollum;
    int newValueRow;

    void Start()
    {
    }

    public void SubmitCollum(string newCollum)
    {
        System.Convert.ToInt32(newCollum);
        newValueCollum = int.Parse(newCollum);
        theGridManager.col = newValueCollum;
        Debug.Log("You typed: " + newValueCollum);
        theGridManager.CreateGrid();
    }

    public void SubmitRow(string newRow)
    {
        System.Convert.ToInt32(newRow);
        newValueRow = int.Parse(newRow);
        theGridManager.col = newValueRow;
        Debug.Log("You typed: " + newValueRow);
    }
}
