using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MC_SceneChange : MonoBehaviour
{
	public Texture2D cursorTexture;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;

	private void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
	// button to another scene
	public void ChangeScene (string name)
	{
		SceneManager.LoadScene (name);
	}
}
