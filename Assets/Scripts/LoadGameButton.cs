using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameButton : MonoBehaviour
{

    Button btnLoadGame;

    void Awake()
    {

        btnLoadGame = GetComponent<Button>();
        btnLoadGame.onClick.AddListener(LoadGame);
        
    }

    void LoadGame()
    {

        Debug.Log("Game loaded");
    
    }



}


