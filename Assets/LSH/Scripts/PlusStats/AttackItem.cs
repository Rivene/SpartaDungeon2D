using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AttackItem
{
    [SerializeField] private float attackValue = 1f;
    public AttackSO attackSO;

    public void UseAttack()
    {
        
        if (attackSO != null)
        {
            attackSO.power += attackValue;
            Debug.Log("°ø°Ý·Â : " + attackSO.power);
        }

    }
}
