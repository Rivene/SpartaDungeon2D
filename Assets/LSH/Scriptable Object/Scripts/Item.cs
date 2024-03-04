using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public enum ItemType //���� ����� ���� 
{
    Heal,
    Speed,
}

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject
{
    [Header("Info")]
    public string itemName;
    public string discription;
    public Sprite icon;

    [Header("Stacking")]
    public int maxAmount;

    [Header("Stats")]
    public int healup;
    public int speedup;
    
    [Header("Type")]
    public ItemType type;

}
