using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_MoveObject : MonoBehaviour
{

    //Speed Variables
    public float minXSpeed; 
    public float maxXSpeed;
    public float minYSpeed;
    public float maxYSpeed;

    // Gameplay Variables
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
    // throw the object in movement up
        gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 
        (
        Random.Range(minXSpeed, maxXSpeed),
        Random.Range(minYSpeed, maxYSpeed)
        );
        
        // wait and destroy the object
        Destroy (gameObject, lifeTime);
    }


   
}
