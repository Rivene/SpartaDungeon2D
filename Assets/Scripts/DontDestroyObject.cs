using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObject: MonoBehaviour
{
    private static DontDestroyObject instance = null;
    private void Awake()
    {
        if(instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
        //var obj = FindObjectsOfType<DontDestroyObject>();
        //if (obj.Length == 1)
        //{
        //    DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }
}
