using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataManager : MonoBehaviour
{
    public static ItemDataManager I;

    public AttackSO attackSO;
    [SerializeField] private PlayerController playerController;

    private Item item;

    private void Awake()
    {
        I = this;
        playerController = GameManager.instance.Player.GetComponent<PlayerController>();
    }

    public void AttackUP(Item item)
    {
        //attackItem.UseAttack();
        attackSO.power += item.powerup;
        Debug.Log("공격력 : " + attackSO.power);
    }
    
    public void HealUP(CharacterStatsHandler statsHandler, Item item)
    {
        //healItem.UseHeal(statsHandler);
        statsHandler.CurrentStates.maxHealth += item.healup;
        Debug.Log("체력 : " + statsHandler.CurrentStates.maxHealth);
    }

    public void SpeedUP(CharacterStatsHandler statsHandler,Item item)
    {
        playerController.moveSpeed += item.speedup;
        statsHandler.CurrentStates.speed = playerController.moveSpeed;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);
    }

}
