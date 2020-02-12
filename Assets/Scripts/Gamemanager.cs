using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    
    public static Gamemanager instance;
    [SerializeField]
    Score score;

    public Score Score { get => score; }

    void Awake()
    {
        
        
        if(instance)
        {
            Destroy(gameObject);
        } else 
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

    }


}
