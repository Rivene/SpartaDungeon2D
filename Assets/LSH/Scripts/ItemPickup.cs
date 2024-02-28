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
            //�÷��̾� ��ġ�� ���� ��ũ�� ��ǥ
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(pickupTextPosition);
            pickupText.rectTransform.position = screenPosition;

            pickupText.text = "[Space] �ݱ�";

            if(Input.GetKeyDown(KeyCode.Space)) //������ �ݱ�
            {
                inventory.AquireItem(other.transform.GetComponent<Items>().item); //������ ����
                Destroy(other.gameObject);
                
            }
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickupText.text = "";
    }
}
