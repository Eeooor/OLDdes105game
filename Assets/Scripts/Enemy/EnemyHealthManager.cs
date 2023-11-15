using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    //Similar to PlayerHealth Manager
    //But for enemies
    Rigidbody2D Object_Rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        Object_Rigidbody = GetComponent<Rigidbody2D>();
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
