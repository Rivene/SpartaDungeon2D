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
        int spawnChance = Random.Range(0, 2);//������ �������� ���� ����

        if (spawnChance == 0) //�������� ������ ��
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
