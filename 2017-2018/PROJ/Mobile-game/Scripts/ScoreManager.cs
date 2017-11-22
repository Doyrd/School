using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public float scoreValue;

	void Start ()
    {
        scoreValue = 0;
	}
	
	void Update ()
    {
        scoreText.text = "Coins collected: " + scoreValue;
	}

    public void AddValueToScore(float Value)
    {
        scoreValue += 1;
    }

}
