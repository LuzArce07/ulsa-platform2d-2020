using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    
    [SerializeField]
    float moveSpeed = 3.0f;



    void Update()
    {

        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        
    }



}
