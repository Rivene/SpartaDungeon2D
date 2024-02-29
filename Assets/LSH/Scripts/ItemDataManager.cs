using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataManager : MonoBehaviour
{
    public static ItemDataManager I;

    public AttackItem attackItem;
    public HealItem healItem;
    public SpeedItem speedItem;


    private void Awake()
    {
        I = this;

    }

    public void AttackUP()
    {
        attackItem.UseAttack();
    }
    
    public void HealUP(CharacterStatsHandler statsHandler)
    {
        healItem.UseHeal(statsHandler);
    }

}
