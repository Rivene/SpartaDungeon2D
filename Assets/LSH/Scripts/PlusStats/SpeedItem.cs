using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    [SerializeField] float speedValue = 2f;
    private PlayerController controller;

    private void Awake()
    {
        controller = FindObjectOfType<PlayerController>();
    }
    public void UseSpeed(CharacterStatsHandler statsHandler)
    {
        controller.moveSpeed += speedValue;
        statsHandler.CurrentStates.speed = controller.moveSpeed ;
        Debug.Log("이동속도: " + statsHandler.CurrentStates.speed);

    }
}
