using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follower2D : MonoBehaviour
{
    //-----------------------------------------------

    // Basic script that sets an object to go to another object (intended as basic enemy for a VS style game)
    // REQUIRES Rigidbody2D TO BE ATTATCHED TO GAMEOBJECT!
    // Made by Lior "Eeooor" Kahanov

    //-----------------------------------------------

    // Set Up variables

    [SerializeField] Transform Target;   //variable where target object is set

    [SerializeField] float Objectspeed;  //variable dictating object speed

    Rigidbody2D Object_Rigidbody;   //Defines Ridgidbody for object this script is attatched to



    // Start is called before the first frame update
    void Start()
    {
        Object_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Fixed Update is used for physics as framerate and physics are updated at different intervals 
    private void FixedUpdate()
    {
        Vector3 direction = (Target.position - transform.position).normalized;  //Gets direction of target
        
        Object_Rigidbody.velocity = direction * Objectspeed;    //Sets Object velocity
    }
}
