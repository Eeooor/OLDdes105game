using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    //-----------------------------------------------

    // Generic Health Storage Script (Work in Progress) that can be used to store and edit health values for any game object!
    // Made by Lior "Eeooor" Kahanov

    //-----------------------------------------------

    // Set Up variables
    [SerializeField] int healthAmount = 100;    // Base Health Ammount


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name + "'s health is " + healthAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damageTaken)
    {
        healthAmount -= damageTaken;
        Debug.Log("Health is now " +  healthAmount);

        if (healthAmount <= 0)
        {
            // Do other stuff (perhaps call other scripts?)
           Destroy(gameObject);
        }
    }
}
