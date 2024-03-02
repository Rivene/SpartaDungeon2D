using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataManager : MonoBehaviour
{
    public static ItemDataManager I;

    public AttackSO attackSO;
    [SerializeField] private TopDownCharacterController playerController;

    private Item item;
    [SerializeField] private ToolTip slotToolTip;

    private void Awake()
    {
        I = this;
       // playerController = GameManager.instance.Player.GetComponent<TopDownCharacterController>(); // �÷��̾��� PlayerController ��������
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

    public void ShowToolTip(Vector3 position, Item item)
    {
        slotToolTip.OpenToolTipUI(position, item);
    }

    public void HideToolTip()
    {
        slotToolTip.CloseToolTipUI();
    }
}
