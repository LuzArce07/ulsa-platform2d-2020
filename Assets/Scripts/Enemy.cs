using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IFlip
{

    
    [SerializeField]
    float moveSpeed = 3.0f;
    [SerializeField]
    float delay;

    float timer;

    [SerializeField]
    Vector2 dir;


    void Update()
    {

        transform.Translate(dir * moveSpeed * Time.deltaTime);
        
        timer += Time.deltaTime;
        if(timer >= delay)
        {

            timer = 0f;
            dir = dir == Vector2.right ? Vector2.left : Vector2.right;
            //dir.x = dir.x > 0 ? -1 : 1;


        }



    }

    public void FlipSprite()
    {
        
    }



}
