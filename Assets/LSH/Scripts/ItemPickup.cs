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

    // �浹�� ���������κ��� �ѹ� ȣ��Ǳ� ������ �����ִ� ������ ���ÿ� �ݴ� ���� ����
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (pickup.value == (pickup.value | (1 << other.gameObject.layer)))
        {
            canPickup = true;
        }
    }

    //�浹�ϰ� �ִ� ���¿��� �������� �ݰ� �Ǹ� ������Ʈ ����
    private void OnTriggerStay2D(Collider2D other)
    {
        if (pickup.value == (pickup.value | (1 << other.gameObject.layer)))
        {
            PickUpText();
            if (other != null && canPickup) //������ �ݱ�
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    inventory.AquireItem(other.transform.GetComponent<Items>().item); //������ ����
                    Destroy(other.gameObject);
                    canPickup = false;
                }
            }

        }
    }

    // �����۰� �浹���� ��� ��
    private void OnTriggerExit2D(Collider2D other)
    {
        canPickup = false;
        pickupText.text = "";
    }

    private void PickUpText()
    {
        Vector3 offset = new Vector3(0, 2f, 0);
        Vector3 pickupTextPosition = transform.position + offset;
        //�÷��̾� ��ġ�� ���� ��ũ�� ��ǥ
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(pickupTextPosition);
        pickupText.rectTransform.position = screenPosition;

        pickupText.text = "[Space] �ݱ�";
    }
}
