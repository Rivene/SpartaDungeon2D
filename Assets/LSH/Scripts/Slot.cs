using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public Item item;
    public int itemCount;
    public Image itemImage;
    private HealthSystem healthSystem;
    

    [SerializeField] private TextMeshProUGUI countText;

    private CharacterStatsHandler statsHandler;


    public void Start()
    {
        statsHandler = FindObjectOfType<CharacterStatsHandler>();
        healthSystem = FindObjectOfType<HealthSystem>();
    }
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

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right) // 오른쪽 클릭시 아이템 사용
        {
            if (item != null)
            {
                switch (item.type)
                {
                    case ItemType.Heal:
                        ItemDataManager.I.HealUP(healthSystem,item);
                        break;

                    case ItemType.Speed:
                        ItemDataManager.I.SpeedUP(statsHandler,item);
                        break;

                    case ItemType.Attack:
                        ItemDataManager.I.AttackUP(item);
                        break;
                }

                SetSlotCount(-1);
            }
        }

    }

}
