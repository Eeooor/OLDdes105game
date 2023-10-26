using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MySecondPlayerController : MonoBehaviour
{
    /* ^^^^^ -------- Beginner --- Challenge 2 --- Beginner -------- ^^^^^ 
     *  Change this code to move the second player using the keys up, down, right and left
     */
    Vector3 myMovement = new Vector3(0, 0, 0);
    public float mySpeed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
    }

    

    // Update is called once per frame
    /*
     
     */
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        myMovement = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myMovement += new Vector3(0f, mySpeed, 0f);
            //transform.position
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myMovement += new Vector3(mySpeed, 0f, 0f);
            //transform.position
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            myMovement += new Vector3(0f, -mySpeed, 0f);
            //transform.position
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myMovement += new Vector3(-mySpeed, 0f, 0f);
            //transform.position
        }
        if (myMovement.magnitude != 0)
        {
            print("Value before normalisation: " + myMovement);
            myMovement.Normalize();
            print("Value after normalisation: " + myMovement);
        }
        transform.position = transform.position + myMovement * mySpeed;
    }
}
