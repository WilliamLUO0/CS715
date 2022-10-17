using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyCtrl : MonoBehaviour
{

    private Animator ator;
    // save animation controller

    private MoveAvatar moveAvatar;
    // The movement class that stores the character, in order to get the movement state of the character

	// Use this for initialization
	void Start ()
	{
	    ator = gameObject.GetComponent<Animator>();
        // Get the animation controller component of the character

	    moveAvatar = transform.parent.GetComponent<MoveAvatar>();
        // Get the character movement class on the parent object (character controller)
	}
	
	// Update is called once per frame
	void Update () {
	    if (moveAvatar.animationState==MoveAvatar.AvatarAnimationState.Idle)
            // If the character animation state in the character controller is the defined standby state then
	    {
	        if (!ator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                // If the animation controller is not currently playing a standby animation then
	        {
	            ator.SetTrigger("Idle");
            }
	        
            // Trigger standby animation in animation controller
	    }else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Walk)
	    {
	        if (!ator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
	        {
	            ator.SetTrigger("Walk");
            }        
        }
	    else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Run)
	    {
	        if (!ator.GetCurrentAnimatorStateInfo(0).IsName("Run"))
	        {
	            ator.SetTrigger("Run");
            }
	        
	    }
    }
}
