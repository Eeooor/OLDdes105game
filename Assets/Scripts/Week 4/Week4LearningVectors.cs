using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4LearningVectors : MonoBehaviour
{
    Vector3 myPosition; 
    Vector3 myTargetDestination = new Vector3(0,10,0);
    // Start is called before the first frame update
    void Start()
    {
        myPosition = transform.position;
        myTargetDestination = Vector3.zero;
        myTargetDestination = new Vector3(0f,0f,0f);
        print("the object position is: " + myPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
