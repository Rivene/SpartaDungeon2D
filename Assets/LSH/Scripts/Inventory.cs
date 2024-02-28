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
        slots = slotsGridUi.GetComponentsInChildren<Slot>(); // 부모 밑 slot
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

            if(activated) // true면 인벤토리 열림
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
                if (slots[i].item.itemName == _item.itemName) //같은 이름의 아이템일 때 갯수 추가
                {
                    slots[i].SetSlotCount(count);
                    return;
                }
            }
        }

        for(int i=0; i < slots.Length;i++)
        {
            if (slots[i].item == null) // 없다면 빈슬롯에 아이템 추가
            {
                slots[i].AddItem(_item, count);
                return;
            }
        }
    }

}
