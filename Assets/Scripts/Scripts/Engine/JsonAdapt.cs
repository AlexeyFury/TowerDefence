using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

//[System.Serializable]




public class ConfigApi : MonoBehaviour
{
    [Header("Config settings")]
    [SerializeField]
    public string path;
    public string fileName;
    [SerializeField]
    public string json;
    public void jsontodata (string jsonName, string dataName)
    {
         string path = Path.Combine(Application.dataPath, "Configs", fileName);
         string json = File.ReadAllText(path).Trim();
    }

    private GameData dataName = null;
    public void Save() 
    { 
        if (File.Exists(path))
        {
           dataName= JsonConvert.DeserializeObject<GameData>(json) ??
                                    throw new InvalidOperationException(
                                        "Failed to deserialize json to JSON object.");

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataName);
                }
            }
        }
        else
        {
            Debug.Log("File " + fileName + " not found.");
        }
    }



    //public EntityData GetConfig(string id)
    //{

    //}

}