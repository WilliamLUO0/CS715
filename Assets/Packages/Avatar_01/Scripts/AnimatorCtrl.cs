using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCtrl : MonoBehaviour {

    private Animator Ator;
    private MoveAvatar moveAvatar;

    // Use this for initialization
    void Start () {
        Ator = gameObject.GetComponent<Animator>();
        //获取动画控制器
        moveAvatar = transform.parent.GetComponent<MoveAvatar>();
        //获取GOMap中移动角色的脚本
	}

    //根据角色运动的状态来切换动画
    // Update is called once per frame
    void Update()
    {
        if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Idle)
        {
            if (!Ator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                Ator.SetTrigger("Idle");
            }
        }
        else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Walk)
        {
            if (!Ator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
            {
                Ator.SetTrigger("Walk");
            }
        }
        else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Run)
        {
            if (!Ator.GetCurrentAnimatorStateInfo(0).IsName("Run"))
            {
                Ator.SetTrigger("Run");
            }
        }
    }

    //用于GoMap自带的状态切换事件，不好用
    //public void ChangeState() {
    //    if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Idle)
    //    {        
    //            Ator.SetTrigger("Idle");         
    //    }
    //    else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Walk)
    //    {
    //            Ator.SetTrigger("Walk");
    //    }
    //    else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Run)
    //    {
    //            Ator.SetTrigger("Run");
    //    }
    //}
}
