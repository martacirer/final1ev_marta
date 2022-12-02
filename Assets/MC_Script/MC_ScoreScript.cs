using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MC_ScoreScript : MonoBehaviour
{
    private int currentScore;
    public TextMeshProUGUI score;
 
    void Start () 
    {
        currentScore = -1;
        ScoreUpdate();
    }
 
    public void ScoreUpdate()
    {
        Debug.Log("tu madre ha chocado");
        currentScore ++;
        score.text = "Score: " + currentScore;  
    }
}
