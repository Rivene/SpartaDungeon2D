using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HealItem
{
    [SerializeField] int healValue = 5;
    private HealthSystem healthSystem;

    public void UseHeal(CharacterStatsHandler statsHandler)
    {
        statsHandler.CurrentStates.maxHealth += healValue;
        Debug.Log("Ã¼·Â : " + statsHandler.CurrentStates.maxHealth);

    }

}







