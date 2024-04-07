using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;



public class UnitType : MonoBehaviour
{
    [SerializeField]
    private string id;
    private EntityData entityData;
    public void Start()
    {
        string fileName = "config.json";
        string path = Path.Combine(Application.dataPath, "Scripts", fileName);

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path).Trim();
            EntityList entityList = JsonConvert.DeserializeObject<EntityList>(json) ??
                                    throw new InvalidOperationException(
                                        "Failed to deserialize json to EntityList object.");
            foreach (var entity in entityList.Entity)
            {
                EntityData data = entity.Value;
                data.id = entity.Key;
                if (data.id == id)
                {
                    entityData = data;
                }
                Debug.Log("Entity ID: " + data.id);
            }
        }
        else
        {
            Debug.Log("File " + fileName + " not found.");
        }
    }
}
