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
        playerController = GameManager.instance.Player.GetComponent<PlayerController>(); // �÷��̾��� PlayerController ��������

    }

    public void AttackUP(Item item)
    {
        //attackItem.UseAttack();
        attackSO.power += item.powerup;
        Debug.Log("���ݷ� : " + attackSO.power);
    }
    
    public void HealUP(HealthSystem healthSystem, Item item)
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        healthSystem = playerObject.GetComponent<HealthSystem>();
        //healItem.UseHeal(statsHandler);
        healthSystem.ChangeHealth(item.healup);
        healthSystem.CurrentHealth = Mathf.Clamp(healthSystem.CurrentHealth, 0, healthSystem.MaxHealth);
        Debug.Log("ü�� : " + healthSystem.CurrentHealth);
    }

    public void SpeedUP(CharacterStatsHandler statsHandler,Item item)
    {
        playerController.moveSpeed += item.speedup;
        statsHandler.CurrentStates.speed = playerController.moveSpeed;
        Debug.Log("�̵��ӵ�: " + statsHandler.CurrentStates.speed);
    }

}
