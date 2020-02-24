using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
    [SerializeField]
    Button btnNewGame;
    [SerializeField]
    Button btnLoadGame;
    [SerializeField]
    Button btnQuitGame;

    void Awake()
    {
        btnNewGame.onClick.AddListener(NewGame);
        btnLoadGame.onClick.AddListener(LoadGame);
        btnQuitGame.onClick.AddListener(QuitGame);
    }

    void Start()
    {
        btnLoadGame.gameObject.SetActive(MemorySystem.DataExist);
    }

    public void LoadGame()
    {
        Debug.Log("Load Game");
    }

    public void NewGame()
    {
        Gamemanager.instance.gameData = new GameData();
        MemorySystem.SaveData(Gamemanager.instance.gameData);

        SceneManager.LoadScene(1);
        btnLoadGame.gameObject.SetActive(false);
        Gamemanager.instance.Score.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
    }


}
