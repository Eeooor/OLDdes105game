using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2DTopDown : MonoBehaviour
{
    // Set Up variables

    Vector3 PlayerMovement;
    Rigidbody2D Player_Rigidbody;
    [SerializeField] float PlayerMovementSpeed = 5;
    PlayerAnimationManager PlayerAnimationManager;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = new Vector3();
        Player_Rigidbody = GetComponent<Rigidbody2D>();
        PlayerAnimationManager = GetComponent<PlayerAnimationManager>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    void CheckInputs()
    {
        PlayerMovement.x = Input.GetAxisRaw("Horizontal");
        PlayerMovement.y = Input.GetAxisRaw("Vertical");

        PlayerAnimationManager.HorizontalMovement = PlayerMovement.x;

        PlayerMovement = PlayerMovement * PlayerMovementSpeed;

        Player_Rigidbody.velocity = PlayerMovement;
    }

}
