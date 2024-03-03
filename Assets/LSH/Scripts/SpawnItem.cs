using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject plusHp;
    public GameObject plusSpeed;
    //public GameObject plusPower;

    public void ItemRandom(Vector3 position)
    {
        int spawnChance = Random.Range(0, 2);//아이템 생성할지 말지 랜덤

        if (spawnChance == 0) //아이템을 생성할 때
        {
            int randomNum = Random.Range(0, 2);
            Quaternion rotation = Quaternion.identity;

            if (randomNum == 0)
            {
                Instantiate(plusHp, position, rotation);
            }
            else 
            {
                Instantiate(plusSpeed, position, rotation);
            }
            //else
            //{
            //    Instantiate(plusPower, position, rotation);
            //}
        }

    }


}
