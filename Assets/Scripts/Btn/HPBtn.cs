using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBtn : MonoBehaviour
{
    private HpBar hpBar;

    private void Awake()
    {
        hpBar = FindObjectOfType<HpBar>();
    }

    public void isHP()
    {
        hpBar.maxHealth += 10f;
    }
}
