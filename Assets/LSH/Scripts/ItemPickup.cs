using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [SerializeField] private LayerMask pickup;

    public TextMeshProUGUI pickupText;


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

            if(Input.GetKeyUp(KeyCode.Space)) //������ �ݱ�
            {
                //�κ��丮
                Destroy(other.gameObject);
                
            }
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pickupText.text = "";
    }
}
