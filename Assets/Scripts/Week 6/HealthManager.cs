using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    float myHealth = 80;
    float maxHealth = 100;
    float minHealth = 0;

    //------------------------------------------------

    ColorChanger playerColourChanger;

    //------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        playerColourChanger = GetComponent<ColorChanger>();
    }

    /*------- Week 6: ------  ------  Challenge 3 (Continued on colorchanger script)------  ------  Hard ------
     * 1. Make a local variable to store ColorChanger 
     * 2. When health value changes, update the colour accordingly by calling the ChangeColour function iin ColorChager that you are going to implement.
     */

    public void TakeDamage(float damageAmount) {
    myHealth -= damageAmount;
    if (myHealth < minHealth)
        {
            myHealth = minHealth;
        }
       //playerColourChanger.player_colourChanger_Minus();



    print("player is taking damage! " + myHealth);
    }
    public void Heal(float healAmount)
    {
        myHealth += healAmount;
        if(myHealth>maxHealth)
        {
            myHealth = maxHealth;
        }

        //playerColourChanger.player_colourChanger_Plus();


        print("player is healing! " + myHealth);
    }
    void AddHealth() {
        myHealth += 0.1f;
    }

    public void SetHealth(float HealthSet)
    {
        myHealth = HealthSet;
        //health check to ensure it dose not go over max value
        if (myHealth > maxHealth)
        {
            myHealth = maxHealth;
        }
    }

    public float GetHealth() { 
        return myHealth;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
