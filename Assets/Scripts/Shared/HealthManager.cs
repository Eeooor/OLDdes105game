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
        maxHealth = healthAmount;
    }

    // Call to damage attached object
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

    // Call to heal attatched object
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
