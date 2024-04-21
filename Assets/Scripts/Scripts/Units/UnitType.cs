using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;


[System.Serializable]
public class EntityData
{
    public string id { get; }
    public string Name;
    public string type;
    public float MoveSpeed;
    public float AttackSpeed;
    public int Health;
    public int Durability;
    public int Vulnerability;


    //EntityData(string Id) {
    //    id = Id;

    //    getConfig(id);
    //}
    //private void getConfig(string id)
    //{

    //}
}
public class EntityList
{
    public Dictionary<string, EntityData> Entity;
    public Dictionary<string, Dictionary<string, string>> TownHolders;
}

public class JsonAdapt : MonoBehaviour
{
 
}
