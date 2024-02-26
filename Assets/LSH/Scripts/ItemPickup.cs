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
            pickupText.text = "[Space] 아이템 줍기";

            if(Input.GetKeyDown(KeyCode.Space))
            {
                //인벤토리
            }

            if (destroyOnPickup) // 픽업시 오브젝트 삭제
            {
                Destroy(gameObject);
            }
        }
    }

    private void ItemSpawn(Vector3 spawnPos)
    {
        //스폰 포지션 위치
    }
}
