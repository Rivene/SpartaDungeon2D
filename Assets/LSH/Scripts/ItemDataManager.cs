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
        playerController = GameManager.instance.Player.GetComponent<PlayerController>(); // 플레이어의 PlayerController 가져오기

    }

    public void AttackUP(Item item)
    {
        //attackItem.UseAttack();
        attackSO.power += item.powerup;
        Debug.Log("공격력 : " + attackSO.power);
    }
    
    public void HealUP(HealthSystem healthSystem, Item item)
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        healthSystem = playerObject.GetComponent<HealthSystem>();
        //healItem.UseHeal(statsHandler);
        healthSystem.ChangeHealth(item.healup);
        healthSystem.CurrentHealth = Mathf.Clamp(healthSystem.CurrentHealth, 0, healthSystem.MaxHealth);
        Debug.Log("체력 : " + healthSystem.CurrentHealth);
    }

    public void SpeedUP(CharacterStatsHandler statsHandler,Item item)
    {
        playerController.moveSpeed += item.speedup;
        statsHandler.CurrentStates.speed = playerController.moveSpeed;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);
    }

}
