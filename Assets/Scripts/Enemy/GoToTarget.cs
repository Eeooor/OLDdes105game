using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToTarget : MonoBehaviour
{
    // Generic script that tells gameobject to follow target object

    public GameObject PlayerCharacter;

    Vector3 Target = Vector3.zero;

    [SerializeField] float Objectspeed;

    Rigidbody2D Object_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Object_Rigidbody = GetComponent<Rigidbody2D>();
        PlayerCharacter = GameObject.Find("Player");
    }

    //Fixed Update is used for physics as framerate and physics are updated at different intervals 
    private void FixedUpdate()
    {
        Target = PlayerCharacter.transform.position;

        Vector3 direction = (Target - transform.position).normalized;  //Gets direction of target
        
        Object_Rigidbody.velocity = direction * Objectspeed;    //Sets Object velocity
    }
}
