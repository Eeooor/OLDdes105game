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
    [SerializeField] float healthAmount;    // Base Health Ammount


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name + "'s health is " + healthAmount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(float damageTaken)
    {
        healthAmount -= damageTaken;
        Debug.Log(gameObject.name + " Health is now " +  healthAmount);

        if (healthAmount <= 0)
        {
            //do nothing
        }
    }
    
    public float GetHealth() 
    {
        return healthAmount;
    }
}
