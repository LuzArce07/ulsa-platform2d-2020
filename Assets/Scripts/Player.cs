using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Platform2DUtils.GameplaySystem;

public class Player : Character2D
{
    [SerializeField]
    Score score;

      void Update()
    {
        GameplaySystem.TMovementDelta(this.transform,moveSpeed);
        
    }

    void FixedUpdate()
    {
        if(GameplaySystem.JumpBtn)
        {

            //Debug.Log("im working");
            
            if(Grounding)
            {
                anim.SetTrigger("jump");
                GameplaySystem.Jump(rb2D,jumpForce);
            }

        }

        anim.SetBool("grounding", Grounding);
        
    }

    //hace lo mismo que el update pero se ejecuta despues de el
    void LateUpdate()
    {
        spr.flipX = FlipSprite;
        anim.SetFloat("axisX", Mathf.Abs(GameplaySystem.Axis.x));
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("collectable"))
        {
            Collectable collectable = other.GetComponent<Collectable>();
            score.AddPoints(collectable.Points);
            Destroy(other.gameObject);
        }

    }


}

