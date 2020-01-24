using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Platform2DUtils.GameplaySystem;

public class Player : Character2D
{
      void Update()
    {
        GameplaySystem.TMovementDelta(this.transform,moveSpeed);
        
    }

    //hace lo mismo que el update pero se ejecuta despues de el
    void LateUpdate()
    {
        spr.flipX = FlipSprite;
        anim.SetFloat("axisX", Mathf.Abs(GameplaySystem.Axis.x));
        
        anim.SetBool("grounding", Grounding);
        
        if(GameplaySystem.JumpBtn)
        {
            anim.SetTrigger("jump");
            GameplaySystem.Jump(rb2D,jumpForce);
        }

    }
}