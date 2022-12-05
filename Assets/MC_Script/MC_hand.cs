using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MC_hand : MonoBehaviour
{
    public GameObject cutPrefab;
    public float cutLifeTime;

    private bool dragging;
    private Vector2 swipeStart;

    public int lives = 3;
    public Image live;
    public Sprite[] liveArray;

  

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
        {
         dragging = true;
         swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         
        } else if (Input.GetMouseButtonUp(0) && dragging)
            {
            dragging = false;
                SpawnCut ();
            }
    }

    private void SpawnCut()
        {
        //wehere the swipe end
           Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);

           //spawn the cut object
           GameObject cutInstance = Instantiate(cutPrefab, swipeStart, Quaternion.identity);
           cutInstance.GetComponent<LineRenderer> ().SetPosition(0, swipeStart);
           cutInstance.GetComponent<LineRenderer> ().SetPosition(1, swipeEnd);

           //adjust collider
           Vector2[] colliderPoints = new Vector2[2];
           colliderPoints [0] = Vector2.zero;
           colliderPoints [1] = swipeEnd - swipeStart;
           cutInstance.GetComponent<EdgeCollider2D> ().points = colliderPoints;

           // program de destruction of the cut object
           Destroy (cutInstance, cutLifeTime);
        }

    public void UpdateLiveImage()
    {
    live.sprite = liveArray[lives];

    }
}
