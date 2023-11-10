using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_collision : MonoBehaviour
{
    Rigidbody2D Object_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Object_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("HIT!");
        }
    }
}
