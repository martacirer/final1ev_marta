using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MC_ScoreScript : MonoBehaviour
{
    private int currentScore = 0;
    public TextMeshProUGUI score;
 
    void Start () 
    {
        ScoreUpdate(0);
    }
 
    // plus points
    public void ScoreUpdate(int value)
    {
        Debug.Log("tu madre ha chocado");
        currentScore += value;
        score.text = "Score: " + currentScore;
        
    	PlayerPrefs.SetInt("score", currentScore);

    }
}
