using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : MonoBehaviour
{

   [SerializeField] int healValue = 10;
    
    public void UseHeal(CharacterStatsHandler statsHandler)
    {
        statsHandler.CurrentStates.maxHealth += healValue;
        Debug.Log("Ã¼·Â : " + statsHandler.CurrentStates.maxHealth);
        
    }
}
