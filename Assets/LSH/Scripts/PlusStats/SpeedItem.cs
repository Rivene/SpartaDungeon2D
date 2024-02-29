using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpeedItem
{
    [SerializeField] float speedValue = 2f;
    [SerializeField] private PlayerController playerController;


    private void Awake()
    {
       playerController = GameManager.instance.Player.GetComponent<PlayerController>();
    }
    public void UseSpeed(CharacterStatsHandler statsHandler)
    {
        playerController.moveSpeed += speedValue;
        statsHandler.CurrentStates.speed = playerController.moveSpeed;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);      
    }
   
}
