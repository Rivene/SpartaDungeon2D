using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private bool destroyOnPickup = true;
    [SerializeField] private LayerMask pickup;

    public TextMeshProUGUI pickupText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(pickup.value == (pickup.value | (1<< other.gameObject.layer)))
        {
            pickupText.text = "[Space] ������ �ݱ�";

            if(Input.GetKeyDown(KeyCode.Space))
            {
                //�κ��丮
            }

            if (destroyOnPickup) // �Ⱦ��� ������Ʈ ����
            {
                Destroy(gameObject);
            }
        }
    }

    private void ItemSpawn(Vector3 spawnPos)
    {
        //���� ������ ��ġ
    }
}
