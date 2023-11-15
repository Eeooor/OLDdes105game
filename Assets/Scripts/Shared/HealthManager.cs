using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    // Generic Health Storeage script that tracks health and can decrease / increase it

    // Base Health Amount
    [SerializeField] float healthAmount;
    // Max Health Amount
    float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name + "'s health is " + healthAmount);
        maxHealth = healthAmount;
    }

    public void takeDamage(float damageTaken)
    {
        healthAmount -= damageTaken;
        Debug.Log(gameObject.name + " Health is now " +  healthAmount);

        if (healthAmount < 0)
        {
            healthAmount = 0;
            // Backup should health go below 0. Probably useless.
        }
    }
    public void addHealth(float amountHealed)
    {
        healthAmount += amountHealed;
        Debug.Log(gameObject.name + " Health is now " + healthAmount);

        if (healthAmount > maxHealth)
        {
            healthAmount = maxHealth;
            // Backup should health go above Max Health.
        }
    }

    //Health getter function
    public float GetHealth() 
    {
        return healthAmount;
    }
}
