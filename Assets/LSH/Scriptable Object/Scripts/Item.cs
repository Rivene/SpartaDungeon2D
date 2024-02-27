using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
