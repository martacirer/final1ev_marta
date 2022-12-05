using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MC_MenuPause : MonoBehaviour
{

[SerializeField] private GameObject botonPausa;
[SerializeField] private GameObject menuPausa;
// the function of the bottons
  public void Pause(){
		Time.timeScale = 0f;
		botonPausa.SetActive(false);
		menuPausa.SetActive(true);
  }

  public void Reanudar(){
	    Time.timeScale = 1f;
		botonPausa.SetActive(true);
		menuPausa.SetActive(false);
  }

  public void Restart(){
	    Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

    public void Close(){
	    Application.Quit();
  }
}
