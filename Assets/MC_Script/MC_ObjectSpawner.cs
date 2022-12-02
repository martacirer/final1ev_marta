using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;

    public float interval;
    public float minX;
    public float maxX;
    public float y;

    public Sprite[] sprites;

    public Texture2D cursorTexture;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        InvokeRepeating ("Spawn", interval, interval);
    }

   private void Spawn()
   {
   //instantiate the object and position
     GameObject instance = Instantiate (prefab);
     instance.transform.position = new Vector2 (Random.Range(minX,maxX), y);

     instance.transform.SetParent (transform);

       //select a random Sprite
     Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
     instance.GetComponent<SpriteRenderer> ().sprite = randomSprite;
   }


}
