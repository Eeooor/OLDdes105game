using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    // Set Up variables

    Animator animator;

    public float HorizontalMovement;

    // Start is called before the first frame update
    void Start()
    {
        //Gets animator from Child Component (in this case, the Sprite manager)
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("HorizontalMovement", HorizontalMovement);
    }
}
