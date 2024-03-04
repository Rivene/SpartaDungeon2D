using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    public GameObject[] enemies;
    //public int count;
    void Start()
    {
        
    }

    void Update()
    {
        //count = enemies.Length;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }
}
