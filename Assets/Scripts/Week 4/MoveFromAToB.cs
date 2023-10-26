using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
/* ^^^^^ -------- HARD --- Challenge 3 --- HARD -------- ^^^^^ 
 There is one public variable in this class myTarget.
 - You can update the values of the target vector from inside Unity or change it here in the code. 
   select the follower game object and update its my target from the inspector window
- Define a variable for speed of type float. 
- Write the code inside the MoveToTarget function to move the follower game object to "my target" using the speed variable 
*/

public class MoveFromAToB : MonoBehaviour
{
    public Vector3 myTarget;
    Vector3 Direction = new Vector3 (0, 0, 0);
    float objectSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }
    void MoveToTarget() {
        print("This is where the object is at start of function: " + transform.position);
        //1. Create a new Vector3 in this function and call it direction.
        Direction = new Vector3(0, 0, 0);

        //2. Once you calculated the direction vector between myTarget and transform.position by subtracting them
        Direction = myTarget - transform.position;
        print("this is Direction: " + Direction);

        //2. Remember to use Vector3.Normalize() to get the direction unit vector.
        Vector3.Normalize(Direction);
        print("this is Normalized Direction: " + Direction);

        //3. multiply the unit vector by speed and add it to transform.position.
        transform.position += (Direction * objectSpeed);

        //4. You need to update transform.position
        print("This is where the object is now: " + transform.position);

        //5. Check the distance between tranform.position and myTarget by using Vector3.Distance()
        //   add an if statement to check if the distance is less than 1 and then stop the movement. 
        if (Vector3.Distance(transform.position, myTarget) <= 1)
        {
            objectSpeed = 0;
        }
    }

}
