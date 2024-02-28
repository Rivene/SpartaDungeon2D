using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    [SerializeField] float speedValue = 2f;
    [SerializeField] private PlayerController playerController;


    private void Awake()
    {
       controller = FindObjectOfType<PlayerController>();
    }
    public void UseSpeed(CharacterStatsHandler statsHandler)
    {
        playerController.moveSpeed += speedValue;
        statsHandler.CurrentStates.speed = playerController.moveSpeed;
        Debug.Log("�̵��ӵ�: " + statsHandler.CurrentStates.speed);      
    }
   
}
