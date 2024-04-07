using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;



public class UnitType : MonoBehaviour
{
    [SerializeField]
    private string id;
    private EntityList entityList;
    [SerializeField]
    private EntityData entityData;

    public void Start()
    {
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
}
