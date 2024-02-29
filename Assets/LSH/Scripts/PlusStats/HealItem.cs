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
        Debug.Log("체력 : " + statsHandler.CurrentStates.maxHealth);

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
//    Debug.Log("체력을 회복했습니다: " + CurrentHealth);

//}







