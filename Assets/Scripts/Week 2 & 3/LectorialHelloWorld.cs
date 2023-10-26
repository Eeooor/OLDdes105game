using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// single line comment
/*
 Developed by: Hadi Mehrpouya
 modified on: 26/09/23

 */

/*The purpose of the classes in here is to experiment with variables and if statements.*/
public class LectorialHelloWorld : MonoBehaviour
{
    // Start is called before the first frame update

    //Up here
    int myFirstInteger = 0 ;
    int mySecondInteger = 0;
    float roomTemprature = 33.5f ;
    public float myHeight = 180.1f;
    public string myName = "Hadi";

    void Start()
    {
        // if (conditio) { code when it is true}
        if (myHeight > 210) {
            Debug.Log("Wow you are tall");
        }


    Debug.Log( "Hello " + myName );
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
