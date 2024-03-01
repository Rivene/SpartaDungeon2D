using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform Player { get; private set; }
    [SerializeField] private string playerTag = "Player";

    [SerializeField] private Slider playerHpSlider;
    private CharacterStatsHandler characterStatsHandler;
    private HealthSystem healthSystem;

    private void Awake()
    {
        instance = this;
        Player = GameObject.FindGameObjectWithTag(playerTag).transform;
        healthSystem = Player.GetComponent<HealthSystem>();
        characterStatsHandler = Player.GetComponent<CharacterStatsHandler>();
        healthSystem.OnDamage += HpUpdateUI;
        healthSystem.OnHeal += HpUpdateUI;
    }

    public void HpUpdateUI() // 플레이어 체력바
    {
        playerHpSlider.value = healthSystem.CurrentHealth / healthSystem.MaxHealth;
    }

}