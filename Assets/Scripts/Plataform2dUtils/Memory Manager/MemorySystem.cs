using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Platform2DUtils.MemorySystem
{

    public class MemorySystem
    {

        public static void SaveData(GameData gameData)
        {
            string path = $"{Application.persistentDataPath}/myGame.data";

            BinaryFormatter bf = new BinaryFormatter(); //Objeto que sirve para dar espacio 
            FileStream file = File.Create(path); //Esta manera es como poner el más para concatenar 

            string json = JsonUtility.ToJson(gameData);

            bf.Serialize(file, json);
            file.Close();

            Debug.Log(path);

        }

    }


}