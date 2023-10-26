//Ignore the first three lines for now and don't change them!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//We are going to engage with the code that is just inside the class. From line 7 onwards.
public class PlayerManager : MonoBehaviour
{ //curly brackets are used to tell the compiler where things start and end. They should always have a matching closing curly bracket.
    public float myHealth = 100.0f;
    int myStrength = 1000;



    // Start is called before the first frame update
    // The start function is where you initialise values and settings for different objects.
    void Start()
    {
        myHealth = 100.0f;
        myStrength = 1000;

    }

    // Update is called once per frame
    /*
     * Challenge 4 ------ Intermediate --------
    //Expand on the lines below to add more keys.
    //Write a function to check inputs and do the translate. Call the checkInput function from update function below. 
    */
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            transform.Translate(0, 0.5f, 0);
            /*for (int i = 0; i <= 20; i++)
            {
               transform.Translate(0, 0.1f, 0);
            }*/

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.05f, 0, 0);
        }
    }
    // Use these four functions and test your code with the buttons in the scene.
    // Remember your project should be in play mode when testing the buttons and your code. 

    //1. Maximum value for Health should be 100 - Done
    //2. Minimum value for Health should be 0 - Done

    /* TODO:
     * Challenge 1  | Beginner |  
     * ----- Please add the following conditions to all strength functions. 
     * ----- remember to also add the health check we implemented above to decrease health function too
     * 
     * Maximum value for Strength should be 1000 
     * Minimum value for Strength should be 0
    */



    //When health is above 70, increase health by half the amount - Done
    //When health is below 50, increase health by double the amount amount - Done


    /*
     * TO DO: -------------  Challenge 2 --------Intermediate--------
     * 
     * If any of the 4 buttons are clicked, update health and strength values based on the following conditions:
     * 1. When health is below 30, 
     *      - decrease strength by double amount
     *      - increase health by the amount
     * 2. When health is above 80 and strength is above 800
     *      - increase strength by by half the amount
     *      - increase health by double the amount
     * 3. Otherwise, increase and decrease health by the amount
     * 
     * 
    */


    /*TODO: ------------------Challenge 3 --------Hard--------
     * 
     *  - Write a function to check and control the value of strength between 0-1000. 
     *  - Write a function to check player health and prints the following messages
     *      - when health is between 1-20 print "be careful, you are about to die!"
     *      - when health is 0, print "You are dead!"
     *      - When health is above 90, print "What are you scared of?"
     */

    public void IncreaseHealth(float amount)
    {

        // Challenge 2 code
        if (myHealth < 30.0f)
        {
            myHealth += amount;
        }
        if (myHealth > 80.0f && myStrength > 800)
        {
            myHealth += 2 * amount;
        }

        //When health is above 70, increase health by half the amount
        if (myHealth >= 70.0f)
        {
            myHealth += (amount / 2.0f); //same as saying myHealth = myHealth + amount/2.0f;
        }
        //When health is below 50, increase health by double the amount amount
        else if (myHealth <= 50)
        {
            myHealth += (amount * 2.0f);
        }
        else
        {
            myHealth += amount;
        }
        //Controlling the maximum and minimum value of player health
        CheckHealth();


        Debug.Log(myHealth + " ");
    }

    void CheckHealth()
    {
        if (myHealth > 100.0f)
        {
            myHealth = 100.0f;
        }
        else if (myHealth > 90.0f) // Challenge 3 stuff
        {
            Debug.Log("You are good");
        }
        else if (myHealth < 20 && myHealth > 0)
        {
            Debug.Log("Watch out!");
        }
        else if (myHealth < 0f)
        {
            myHealth = 0f;
            Debug.Log("You are dead");
        }
    }


    public void ReduceHealth(float amount)
    {
        myHealth -= amount;
        Debug.Log(myHealth + " ");
        //Controlling the maximum and minimum value of player health
        CheckHealth();
    }
    public void IncreaseStrength(int amount)
    {
        // Challenge 2 code
        if (myHealth < 30.0f)
        {
            myStrength -= (2 * amount);
        }
        else if (myHealth > 80.0f && myStrength > 800)
        {
            myStrength -= (2 / amount);
        }
        else
        {
            myStrength += amount;
        } 
            

        CheckStrength(); //Max/min strength check

        Debug.Log(myStrength + " ");

    }
    public void ReduceStrength(int amount)
    {
        myStrength -= amount;
        Debug.Log(myStrength + " ");


    }

    void CheckStrength() //Altered Health check code (challenge 1)
    {
        if (myStrength > 1000)
        {
            myStrength = 1000;
        }
        if (myStrength <= 0)
        {
            myStrength = 0;
            Debug.Log("You have no strength");
        }
    }
}
