using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private Inventory inventory;
    private bool canPickup = false;
    [SerializeField] private LayerMask pickup;


    public TextMeshProUGUI pickupText;

    private void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    // 충돌한 아이템으로부터 한번 호출되기 때문에 겹쳐있는 아이템 동시에 줍는 것을 방지
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (pickup.value == (pickup.value | (1 << other.gameObject.layer)))
        {
            canPickup = true;
        }
    }

    //충돌하고 있는 상태에서 아이템을 줍게 되면 오브젝트 삭제
    private void OnTriggerStay2D(Collider2D other)
    {
        if (pickup.value == (pickup.value | (1 << other.gameObject.layer)))
        {
            PickUpText();
            if (other != null && canPickup) //아이템 줍기
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    inventory.AquireItem(other.transform.GetComponent<Items>().item); //아이템 정보
                    Destroy(other.gameObject);
                    canPickup = false;
                }
            }

        }
    }

    // 아이템과 충돌에서 벗어날 때
    private void OnTriggerExit2D(Collider2D other)
    {
        canPickup = false;
        pickupText.text = "";
    }

    private void PickUpText()
    {
        Vector3 offset = new Vector3(0, 2f, 0);
        Vector3 pickupTextPosition = transform.position + offset;
        //플레이어 위치를 기준 스크린 좌표
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(pickupTextPosition);
        pickupText.rectTransform.position = screenPosition;

        pickupText.text = "[Space] 줍기";
    }
}
