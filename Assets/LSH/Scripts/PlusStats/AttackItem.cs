using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackItem : MonoBehaviour
{
    [SerializeField] private float attackValue = 1f;

    public void UseAttack(AttackSO attackSO)
    {
        attackSO.power += attackValue;
        Debug.Log("°ø°Ý·Â : " + attackSO.power);

    }
}
