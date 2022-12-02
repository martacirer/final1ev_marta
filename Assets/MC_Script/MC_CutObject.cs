using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_CutObject : MonoBehaviour
{
	private MC_ScoreScript scoreScript;

	private void Start()
	{
		scoreScript = FindObjectOfType<MC_ScoreScript>();
	}

    void OnTriggerEnter2D (Collider2D other)
	{
		if(other.CompareTag("cut"))
		{
			Destroy(gameObject);
			scoreScript.ScoreUpdate();
		}
	}
}