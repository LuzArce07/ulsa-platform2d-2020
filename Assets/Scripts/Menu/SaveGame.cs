using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platform2DUtils.MemorySystem;


public class SaveGame : MonoBehaviour
{
    [SerializeField]
    Button btnSave;

    [SerializeField]
    Text txtName;

    void Awake()
    {
        btnSave = GetComponent<Button>();
    }

    public string fileName
    {
        get => txtName.text;
        set => txtName.text = value;
    }

}
