using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MC_Cut : MonoBehaviour
{	

	private MC_hand mc_HandScript;

	void Start()
	{
		mc_HandScript = FindObjectOfType<MC_hand>();
	}

    void OnTriggerEnter2D (Collider2D other)
	{
		if(other.CompareTag("bomb"))
		{
			mc_HandScript.lives--;
			mc_HandScript.UpdateLiveImage();

			if(mc_HandScript.lives <= 0)
			{
				SceneManager.LoadScene("MC_GameOver");
			}			
		}
	}
}
