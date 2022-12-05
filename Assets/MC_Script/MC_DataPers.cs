using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MC_DataPers : MonoBehaviour
{
    public static MC_DataPers Record;
    
    public int Score;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("score");
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", Score);
    }
}
