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

    [SerializeField] private TextMeshProUGUI countText;

    private CharacterStatsHandler statsHandler;
    private HealItem heal;
    private SpeedItem speed;
    private AttackItem attack;
    private AttackSO attackSO;

    private void Start()
    {
        statsHandler = FindObjectOfType<CharacterStatsHandler>();
        heal = FindObjectOfType<HealItem>();
        speed = FindObjectOfType<SpeedItem>();
        attack = FindObjectOfType<AttackItem>();
        attackSO = FindObjectOfType<AttackSO>();
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
                Debug.Log("아이템 사용");
                //스탯변화

                switch (item.type)
                {
                    case ItemType.Heal:
                        heal.UseHeal(statsHandler);
                        break;

                    case ItemType.Speed:
                        speed.UseSpeed(statsHandler);
                        break;

                    case ItemType.Attack:
                        attack.UseAttack(attackSO);
                        break;
                }

                SetSlotCount(-1);
            }
        }

    }

}
