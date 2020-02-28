using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platform2DUtils.MemorySystem;
using System.IO;
using UnityEngine.UI;

public class SearchSaves : MonoBehaviour
{
    
    [SerializeField]
    GameObject container;
    [SerializeField]
    Text content;

    
    void OnEnable()
    {

        DirectoryInfo info = new DirectoryInfo(MemorySystem.SavePath);
        FileInfo[] fileInfo = info.GetFiles();

        foreach(FileInfo f in fileInfo)
        {
            Debug.Log(f);
        }
    
    
    }


}

