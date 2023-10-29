using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement_test : MonoBehaviour
{
    Vector3 myMovement = new Vector3(0, 0, 0);
    public float mySpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        myMovement = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            myMovement += new Vector3(0f, mySpeed, 0f);
            //transform.position
        }
        if (Input.GetKey(KeyCode.D))
        {
            myMovement += new Vector3(mySpeed, 0f, 0f);
            //transform.position
        }

        if (Input.GetKey(KeyCode.S))
        {
            myMovement += new Vector3(0f, -mySpeed, 0f);
            //transform.position
        }
        if (Input.GetKey(KeyCode.A))
        {
            myMovement += new Vector3(-mySpeed, 0f, 0f);
            //transform.position
        }
        if (myMovement.magnitude != 0)
        {
            //print("Value before normalisation: " + myMovement);
            myMovement.Normalize();
            //print("Value after normalisation: " + myMovement);
        }
        transform.position = transform.position + myMovement * mySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
