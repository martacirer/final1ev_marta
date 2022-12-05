using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MC_Cut : MonoBehaviour
{	

  public ParticleSystem explosion;

	private MC_hand mc_HandScript;
	private MC_ScoreScript scoreScript;

	public AudioClip sonidoEspada;

	void Start()
	{
		mc_HandScript = FindObjectOfType<MC_hand>();
		scoreScript = FindObjectOfType<MC_ScoreScript>();

	}
	// when the colliders collides, the sprite is been destroyed
    void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag("bomb"))
		{
		 //when the sprite is destroyed , a hart desapeared
			mc_HandScript.lives--;
			mc_HandScript.UpdateLiveImage();
			Destroy(other.gameObject);
			Instantiate(explosion, other.transform.position, explosion.transform.rotation);
			

			// when ther aren't a hert , game over
			if(mc_HandScript.lives <= 0)
			{
				SceneManager.LoadScene("MC_GameOver");
				
			}			
		}
		//when the colliders collides, the sprite is been destroyed
		if(other.gameObject.CompareTag("MC_face1"))
		{
			scoreScript.ScoreUpdate(1);
			Destroy(other.gameObject);			
		}
		//when the colliders collides, the sprite is been destroyed
		if(other.gameObject.CompareTag("bonus"))
		{
			scoreScript.ScoreUpdate(3);
			Destroy(other.gameObject);			
		}			
	}
}
