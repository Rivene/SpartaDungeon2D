using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private Inventory inventory;
    private bool pickupActivated = false;
    [SerializeField] private LayerMask pickup;

    
    public TextMeshProUGUI pickupText;

    private void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(pickup.value == (pickup.value | (1<< other.gameObject.layer)))
        {
            Vector3 offset = new Vector3(0, 2f, 0);
            Vector3 pickupTextPosition = transform.position + offset;
            //플레이어 위치를 기준 스크린 좌표
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(pickupTextPosition);
            pickupText.rectTransform.position = screenPosition;

            pickupText.text = "[Space] 줍기";

            if(Input.GetKeyDown(KeyCode.Space)) //아이템 줍기
            {
                inventory.AquireItem(other.transform.GetComponent<Items>().item); //아이템 정보
                Destroy(other.gameObject);
                
            }
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickupText.text = "";
    }
}
