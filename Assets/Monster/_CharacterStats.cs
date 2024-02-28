using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class _CharacterStats
{
    public _StatsChangeType statsChangeType;
    [Range(1, 100)] public int maxHealth;
    [Range(1f, 20f)] public float speed;
    public _AttackSO attackSO;
}