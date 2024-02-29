using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject plusHp;
    public GameObject plusSpeed;
    public GameObject plusPower;

    Vector3 monsterPosition;

    private void Start()
    {
        monsterPosition = transform.position;
        ItemRandom();
        Debug.Log(monsterPosition);
    }
    private void ItemRandom()
    {
        int spawnChance = Random.Range(0, 2);//������ �������� ���� ����

        if (spawnChance == 0) //�������� ������ ��
        {
            int randomNum = Random.Range(0, 3);
            Quaternion rotation = Quaternion.identity;

            if (randomNum == 0)
            {
                Instantiate(plusHp, monsterPosition, rotation);
            }
            else if (randomNum == 1)
            {
                Instantiate(plusSpeed, monsterPosition, rotation);
            }
            else
            {
                Instantiate(plusPower, monsterPosition, rotation);
            }
        }

    }


}
