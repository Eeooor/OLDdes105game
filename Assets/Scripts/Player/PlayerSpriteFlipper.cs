using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteFlipper : MonoBehaviour
{
    
    // Flips game object sprite based on it's velocity

    Rigidbody2D Rigidbody2D;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Rigidbody2D.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (Rigidbody2D .velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
}
