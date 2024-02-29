using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : MonoBehaviour
{
    [SerializeField] int healValue = 5;
    private HealthSystem healthSystem;

    public void UseHeal(CharacterStatsHandler statsHandler)
    {
        statsHandler.CurrentStates.maxHealth += healValue;
        Debug.Log("ü�� : " + statsHandler.CurrentStates.maxHealth);

    }

}

//[SerializeField] int healValue = 10;

//private HealthSystem healthSystem;

//private void Awake()
//{
//    healthSystem = FindObjectOfType<HealthSystem>();
//}

//public void UseHeal()
//{
//    healthSystem.ChangeHealth(healValue);
//    Debug.Log("ü���� ȸ���߽��ϴ�: " + CurrentHealth);

//}







