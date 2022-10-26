using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStatement : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        //if player presses w key
        if (!isWalking && forwardPressed)
        { 
            // then set the isWalking boolean to be true
            animator.SetBool(isWalkingHash, true);
        }

        //if the player is not pressing w key
        if (isWalking && !forwardPressed)
        {
            //then set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);
        }
    }
}
