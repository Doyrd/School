using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int col;
    public int row;

    public float colFloat;
    public float rowFloat;

    private int activeNeighbours;

    public float sec;

    private float neighbours;

    public GameObject gridPiece;
    public GameObject gridSpace;

    GameObject[,] boardArray;

    private bool spacePressed;

    public InputField inputFieldCollum;

    void Start()
    {
        CreateGrid();
    }

    void Update()
    {

        /*col = int.Parse(inputFieldCollum.text);
        row = int.Parse(inputFieldRow.text);*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = !spacePressed;
            StartCoroutine(protocolGOL());
        }
    }

        public void CreateGrid()
    {
        boardArray = new GameObject[col, row];

        for (int c = 0; c < row; c++)
        {
            for (int r = 0; r < col; r++)
            {
                boardArray[c, r] = (GameObject)Instantiate(gridPiece, new Vector2(c, r), Quaternion.identity);
                boardArray[c, r].name = "grid " + c + ", " + r;
            }
        }
    }

    private IEnumerator protocolGOL()
    {
        while (spacePressed)
        {
            /*for (int x = 1; x < row; x=x+1)
            {
                for (int y = 1; y < col; y=y+1)
                {
                    int count = neighbours(x, y);

                }
            }*/

            //1. Search for neighbours(total)
            //2. Apply rules game of life on neighbours
            //3. Continue from there
        }

        yield return new WaitForSeconds(sec);
    }

    int GetAliveNeighBours(int xIndex, int yIndex)
    {
        /*
        activeNeighbours = 0;
        for ()
        {
            
        }

        if (boardArray[xIndex + g, yIndex = h].GetComponent<CubeColor>().active
        {
            activeNeighbours += 1;
        }   
        */
        return activeNeighbours;
    }

}
