using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.GameplaySystem;

public class NPCFlip : IFlip
{

    public bool FlipSprite(float x, SpriteRenderer spr)
    {

        return x > 0 ? false : true;
       //get => dir.x > 0 ? false : true;
       
    }
   
}

