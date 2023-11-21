using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManagment : MonoBehaviour
{
    // Manages Player Health and collision

    HealthManager healthManager;

    bool isNotDead = true; //if false, means player is dead

    // Start is called before the first frame update
    void Start()
    {
        healthManager = GetComponent<HealthManager>();
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        //Checks if other object collided with has tag "Enemy"
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (healthManager.GetHealth() != 0) //if health is not 0
            {
                healthManager.takeDamage(1.0f); // take 1.0f damage per ammount of contact
            }
            else if (healthManager.GetHealth() == 0)
            {
                isNotDead = false; //sets isNotDead to false (player is dead)
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Checks if other object collided with has tag "Health"
        if (other.gameObject.CompareTag("Health"))
        {
            Debug.Log("Player Interacted with item!");
            healthManager.addHealth(10.0f);
            Debug.Log("Added 10 to player health!" + healthManager.GetHealth());
            Destroy(other.gameObject);
        }
    }

    //Getter function for isNotDead bool
    public bool checkIfAlive()
    {
        if (isNotDead == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
