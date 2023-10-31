using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2DTopDown : MonoBehaviour
{
    //---------------------------------------------------------------------------------

    // IMPORTANT NOTES FOR REUSE!
    // REQUIRES Rigidbody2D TO BE ATTATCHED TO GAMEOBJECT! Gravity must be set to 0!
    // Controls WASD, Arrow Keys and Controler input for movement in a 2d top down game

    //---------------------------------------------------------------------------------

    // Set Up variables

    Vector3 PlayerMovement; //Defines vector for player movement

    Rigidbody2D Player_Rigidbody; //Defines Ridgidbody

    public float PlayerMovementSpeed = 5; // Speed variable
    //ideally you want to use a hardcoded value (in this case, 5) but by setting to public allows for editing in Unity Editor

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
        // sets X and Y axis movement based on any changes to preset Unity input variables (this allows WASD, Arrow Keys and Controler input to be used for movement)
        PlayerMovement.x = Input.GetAxisRaw("Horizontal");
        PlayerMovement.y = Input.GetAxisRaw("Vertical");

        // Add speed to movement
        PlayerMovement = PlayerMovement * PlayerMovementSpeed;

        // Directly assigns values to Attached Ridgidbody
        Player_Rigidbody.velocity = PlayerMovement;
    }

}
