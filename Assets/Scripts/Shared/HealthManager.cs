using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    // Base Health Ammount
    [SerializeField] float healthAmount;


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
