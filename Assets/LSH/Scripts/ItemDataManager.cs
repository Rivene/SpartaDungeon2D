using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataManager : MonoBehaviour
{
    public static ItemDataManager I;

    //public AttackSO attackSO;

    private Item item;

    private HpBar hpBar;

    private void Awake()
    {
        I = this;
        hpBar = FindObjectOfType<HpBar>();
    }

    //public void AttackUP(Item item)
    //{
    //    // CharacterStatsHandler의 AttackSO를 수정
    //    attackSO.power += item.powerup;
    //    Debug.Log("공격력 : " + attackSO.power);
    //}


    public void HealUP(Item item)
    {
        //GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        //healthSystem = playerObject.GetComponent<HealthSystem>();
        ////healItem.UseHeal(statsHandler);
        //healthSystem.ChangeHealth(item.healup);
        //healthSystem.CurrentHealth = Mathf.Clamp(healthSystem.CurrentHealth, 0, healthSystem.MaxHealth);
        //Debug.Log("체력 : " + healthSystem.CurrentHealth);

        hpBar.maxHealth += item.healup;
        hpBar.maxHealth = Mathf.Clamp(hpBar.maxHealth, 0, 100f);
    }

    public void SpeedUP(CharacterStatsHandler statsHandler,Item item)
    {
        statsHandler.CurrentStates.speed += item.speedup;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);
    }

}
