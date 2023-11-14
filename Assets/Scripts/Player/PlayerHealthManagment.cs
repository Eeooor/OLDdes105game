using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManagment : MonoBehaviour
{
    
    HealthManager healthManager;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = GetComponent<HealthManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        //Checks if other object collided with has tag "Enemy"
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (healthManager.GetHealth() != 0) //if health is not 0
            {
                healthManager.takeDamage(1.0f); // take 1.0f damage per ammount of contact
            }
            else if (healthManager.GetHealth() == 0)
            {
                
            }
            
        }
    }
}
