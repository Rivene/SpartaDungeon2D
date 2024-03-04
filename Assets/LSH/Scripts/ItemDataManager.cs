using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataManager : MonoBehaviour
{
    public static ItemDataManager I;

    //public AttackSO attackSO;

    private Item item;

    private HpBar hpBar;
    private FloorCount count;

    private void Awake()
    {
        I = this;
        hpBar = FindObjectOfType<HpBar>();
        count = FindObjectOfType<FloorCount>();
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

        count.hp += item.healup;
        count.hp = Mathf.Clamp(count.hp, 0, 100f);
    }

    public void SpeedUP(CharacterStatsHandler statsHandler,Item item)
    {
        statsHandler.CurrentStates.speed += item.speedup;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);
    }

}
