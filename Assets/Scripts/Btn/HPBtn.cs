using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBtn : MonoBehaviour
{
    private FloorCount count;

    private void Awake()
    {
        count = FindObjectOfType<FloorCount>();
    }

    public void isHP()
    {
        count.hp += 10f;
    }
}
