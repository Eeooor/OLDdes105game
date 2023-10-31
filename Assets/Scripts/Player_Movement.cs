using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Vector3 PlayerMovement;
    Rigidbody2D RigidbodyPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = new Vector3();
        RigidbodyPlayer = GetComponent<Rigidbody2D>();
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
    }

}
