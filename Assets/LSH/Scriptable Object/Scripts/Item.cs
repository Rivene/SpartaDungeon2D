using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsType
{
    Health,
    Speed,
    AttackSpeed,
}

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject
{
    [Header("Info")]
    public string ItemName;
    public string discription;
    public Sprite icon;

    [Header("Stacking")]
    public int maxAmount;

}
