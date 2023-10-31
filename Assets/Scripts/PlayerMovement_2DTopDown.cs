using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2DTopDown : MonoBehaviour
{
    // IMPORTANT NOTES FOR REUSE!
    // REQUIRES RIDIDBODY2D TO BE ATTATCHED TO GAMEOBJECT!


    //----------------------------------------------

    Vector3 PlayerMovement; //Defines vector for player movement

    Rigidbody2D Player_Rigidbody; //Defines Ridgidbody

    public float PlayerMovementSpeed = 1;

    //----------------------------------------------

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
        //define input
        PlayerMovement.x = Input.GetAxisRaw("Horizontal");
        PlayerMovement.y = Input.GetAxisRaw("Vertical");

        // Add speed to movement
        PlayerMovement = PlayerMovement * PlayerMovementSpeed;

        // Directly assigns values to Attached Ridgidbody
        Player_Rigidbody.velocity = PlayerMovement;
    }

}
