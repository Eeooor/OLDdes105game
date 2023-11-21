using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItemManager : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D other)
    {
        //Checks if other object collided with has tag "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Interacted with item!"); //Prints Hit message to Unity console
            //call player heal
            //destroy Health item
        }
    }

}
