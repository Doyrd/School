using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    /*private bool stopCounting = false;

    private float startTime;*/

    public Text theTimeText;

    public float timeLeft;

    public GameObject theFailedMenu;

    void Start()
    {
        /*startTime = Time.deltaTime;*/
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        theTimeText.text = Mathf.Round(timeLeft).ToString();

        if (timeLeft <= 0)
        {
            OnFailing();
        }

        /*if (stopCounting)
        return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        theTimeText.text = minutes + ":" + seconds;*/
    }

    public void OnFailing()
    {
        theFailedMenu.SetActive(true);
        Time.timeScale = 0;
    }

    /*public void StopCounting()
    {
        stopCounting = true;
        theTimeText.color = Color.green;

    }

    public void ResetCounting()
    {
        stopCounting = false;
        theTimeText.color = Color.black;
        startTime = 0;
    }*/

}

