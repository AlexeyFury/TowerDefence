using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToJSON<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
{
    public void OnBeforeSerialize()
    {
        //foreach (KeyValuePair<TKey, TValue) pair in this)
        //{
        //    ;
        //}
    }

    public void OnAfterDeserialize()
    {
        this.Clear();

    }
   
}
