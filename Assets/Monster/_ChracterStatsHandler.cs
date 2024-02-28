using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] private _CharacterStats baseStats;
    public _CharacterStats CurrentStates { get; private set; }
    public List<_CharacterStats> statsModifiers = new List<_CharacterStats>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        _AttackSO attackSO = null;
        if (baseStats.attackSO != null)
        {
            attackSO = Instantiate(baseStats.attackSO);
        }

        CurrentStates = new _CharacterStats { attackSO = attackSO };
        // TODO
        CurrentStates.statsChangeType = baseStats.statsChangeType;
        CurrentStates.maxHealth = baseStats.maxHealth;
        CurrentStates.speed = baseStats.speed;

    }
}