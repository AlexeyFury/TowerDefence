using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class EntityData
{
    public string id;
    public string Name;
    public string type;
    public float MoveSpeed;
    public float AttackSpeed;
    public int Health;
    public int Durability;
    public int Vulnerability;
}

[System.Serializable]
public class EntityList
{
    public Dictionary<string, EntityData> Entity;
    public Dictionary<string, Dictionary<string, string>> TownHolders;
}
public class UnitAttributes : MonoBehaviour
{
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
            }
            else
            {
                Debug.Log("File " + fileName + " not found.");
            }
        }
}
