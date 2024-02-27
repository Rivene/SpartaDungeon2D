using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public float plusHp;
    public float plusSpeed;
    public float plusAttack;

}
