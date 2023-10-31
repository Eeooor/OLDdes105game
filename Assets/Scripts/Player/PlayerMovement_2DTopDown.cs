using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2DTopDown : MonoBehaviour
{
    //---------------------------------------------------------------------------------

    // Basic script intended for controlling a object from a topdown 2d perspective 
    // REQUIRES Rigidbody2D TO BE ATTATCHED TO GAMEOBJECT! Gravity must be set to 0!
    // Made by Lior "Eeooor" Kahanov

    //---------------------------------------------------------------------------------

    // Set Up variables

    Vector3 PlayerMovement; //Defines vector for player movement

    Rigidbody2D Player_Rigidbody; //Defines Ridgidbody

    [SerializeField] float PlayerMovementSpeed = 5; // Speed variable
    

    // Start is called before the first frame update
    void Start()
    {
        //set up on start: sets PlayerMovement to a new vector and gets ridgidbody component of attached GameObject
        PlayerMovement = new Vector3();
        Player_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    void CheckInputs()
    {
        // sets X and Y axis movement and allows WASD, Arrow Keys and Controler input to be used for movement)
        PlayerMovement.x = Input.GetAxisRaw("Horizontal");
        PlayerMovement.y = Input.GetAxisRaw("Vertical");

        // Add speed to movement
        PlayerMovement = PlayerMovement * PlayerMovementSpeed;

        // Directly assigns values to Attached Ridgidbody
        Player_Rigidbody.velocity = PlayerMovement;
    }

}
