using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer myRenderer;
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }
    /*------- Week 6: ------  ------  Challenge 1 ------  ------  Intermediate ------
     * 1. Write a function that changes the colour of the player whenever they press "c". 
     *      Use Random.Range and randomise the colour of our player game object by using the code in the update function below. 
     *      Try to implemented this with both RGB values between 0-255 (Color32) and 0-1 (Color) 
     *      
     * 2. Write a function that flips the player sprite whenever the player presses "f" 
*/

    public void player_colourChanger() // changes colour for sprite
    {
        //NewColor ver
        /*
        float randomRedvalue = Random.Range(0, 1f);
        float randomGreenvalue = Random.Range(0, 1f);
        float randomBluevalue = Random.Range(0, 1f);
        float randomAlphavalue = Random.Range(0, 1f);

        myRenderer.color = new Color(randomRedvalue, randomGreenvalue, randomBluevalue, randomAlphavalue);
        */

        //NewColor32 ver (thanks Unity forum for byte conversion! https://forum.unity.com/threads/how-to-convert-to-byte.268585/)


        byte randomRedvalueBYTE = (byte)Random.Range(0, 255);
        byte randomGreenvalueBYTE = (byte)Random.Range(0, 255);
        byte randomBluevalueBYTE = (byte)Random.Range(0, 255);
        byte randomAlphavalueBYTE = (byte)Random.Range(0, 255);

        myRenderer.color = new Color32(randomRedvalueBYTE, randomGreenvalueBYTE, randomBluevalueBYTE, randomAlphavalueBYTE);

    }

    // -----------------------------------------------------------------------------------
    
    /*public void player_colourChanger_Minus()
    {
        
        Color32 currentColour = gameObject.GetComponent<Renderer>().material.color;
        byte Redvalue = currentColour.r;
        byte Greenvalue = currentColour.g;  // -=1;
        byte Bluevalue = currentColour.b;    // -=1;
        byte Alphavalue = (byte)(currentColour.a - 25);

        if (Alphavalue <= 0)
        {
            Alphavalue = 0;
        }


        myRenderer.color = new Color32(Redvalue, Greenvalue, Bluevalue, Alphavalue);
    }*/
    
    /*public void player_colourChanger_Plus()
    {
        Color32 currentColour = gameObject.GetComponent<Renderer>().material.color;
        byte Redvalue = currentColour.r;
        byte Greenvalue = currentColour.g;  // += 1;
        byte Bluevalue = currentColour.b;   // += 1;
        byte Alphavalue = (byte)(currentColour.a + 25);
        if(Alphavalue >= 255)
        {
            Alphavalue = 255;
        }

        myRenderer.color = new Color32(Redvalue, Greenvalue, Bluevalue, Alphavalue);
    }*/
    // -----------------------------------------------------------------------------------


    void player_YaxisChanger() //changes Y axis for sprite
    {
       if (myRenderer.flipY == true)
        {
            myRenderer.flipY = false;
        }
       else
        {
            myRenderer.flipY = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //myRenderer.color = new Color(1f,0,1f,0.5f);
        if (Input.GetKeyDown(KeyCode.C))
        {

            player_colourChanger();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            player_YaxisChanger();
        }

    }
    /*------- Week 6: ------  ------  Challenge 3 ------  ------  Hard ------
     * 1. Write a public function that allows you to change the opacity of your player object based on their healthchanges the colour of the player whenever they press "c". 
     * 2. As the player health changes, call the function above from the "health manager" class to update the colour okf player.
     *    note: - 100 health is 100% opacity and 0 health is 0% opacity
     *          - Both Color and Color32 accept Red,Green,Blue, Alpha (RGBA) values
     *      
     * 2. Write a function that flips the player sprite whenever the player presses "f" 
    */
}
