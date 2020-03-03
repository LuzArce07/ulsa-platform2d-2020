using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveObject : MonoBehaviour
{
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
