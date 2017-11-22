using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public void RestartGame()
    {
        print("Restart button pressed");
        Time.timeScale = 1;
        Application.LoadLevel(Application.loadedLevel);
    }

}
