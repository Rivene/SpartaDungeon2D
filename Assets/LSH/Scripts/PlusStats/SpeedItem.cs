using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    [SerializeField] float speedValue = 2f;
    [SerializeField] private PlayerController playerController;


    private void Awake()
    {
        playerController= GameObject.Find("Player").GetComponent<PlayerController>();
    }
    public void UseSpeed(CharacterStatsHandler statsHandler)
    {
        playerController.moveSpeed += speedValue;
        statsHandler.CurrentStates.speed = playerController.moveSpeed;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);      
    }
   
}
