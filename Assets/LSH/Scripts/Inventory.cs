using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool activated = false;

    [SerializeField] private GameObject inventoryUi;
    [SerializeField] private GameObject slotsGridUi;

    private Slot[] slots;


    void Start()
    {
        slots = slotsGridUi.GetComponentsInChildren<Slot>(); // �θ� �� slot
    }

    
    void Update()
    {
        KeyOpenInventroy();
    }

    private void KeyOpenInventroy()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activated = !activated;

            if(activated) // true�� �κ��丮 ����
            {               
                OpenInventory();
            }
            else
            {               
                CloseInventory();
            }
        }
    }

    private void OpenInventory()
    {
        
        inventoryUi.SetActive(true);
    }

    private void CloseInventory()
    {
        inventoryUi.SetActive(false);
    }

    public void AquireItem(Item _item, int count = 1)
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item != null)
            {
                if (slots[i].item.itemName == _item.itemName) //���� �̸��� �������� �� ���� �߰�
                {
                    slots[i].SetSlotCount(count);
                    return;
                }
            }
        }

        for(int i=0; i < slots.Length;i++)
        {
            if (slots[i].item == null) // ���ٸ� �󽽷Կ� ������ �߰�
            {
                slots[i].AddItem(_item, count);
                return;
            }
        }
    }

}
