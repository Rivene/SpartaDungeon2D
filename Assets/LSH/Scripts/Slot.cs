using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public int itemCount;
    public Image itemImage;

    [SerializeField] private TextMeshProUGUI countText;


    public void AddItem(Item _item, int count = 1)
    {
        item = _item;
        itemCount = count;
        itemImage.sprite = item.icon;
        countText.text = itemCount.ToString();

    }

    

    public void SetSlotCount(int count)
    {
        itemCount += count;
        countText.text = itemCount.ToString(); 

        if (itemCount <= 0)
        {
            ClearSlot();
        }
    }

    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        countText.text = "0";

    }



}
