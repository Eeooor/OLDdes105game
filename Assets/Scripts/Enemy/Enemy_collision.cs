using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_collision : MonoBehaviour
{
    //-----------------------------------------------

    // Collision detection script (Work In Proggress)
    // REQUIRES Rigidbody2D TO BE ATTATCHED TO GAMEOBJECT!
    // This itteration is intended for an enemy to detect a player
    // uses Unity Tag System for detection so make sure to make a tag called "Player" and set your player to have this tag
    // Made by Lior "Eeooor" Kahanov

    //-----------------------------------------------

    // Set Up variables


    Rigidbody2D Object_Rigidbody; //Defines Ridgidbody for object this script is attatched to


    // Start is called before the first frame update
    void Start()
    {
        Object_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detects if object is remaining collided with another object
    private void OnCollisionStay2D(Collision2D other)
    {
        //Checks if other object collided with has tag "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("HIT!"); //Prints Hit message to Unity console
        }
    }
}
