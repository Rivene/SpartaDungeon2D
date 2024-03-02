using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    [SerializeField] private GameObject toolTipUi;
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemDescriptionText;

    public void OpenToolTipUI(Vector3 position, Item item)
    {
        toolTipUi.SetActive(true);
        position += new Vector3(toolTipUi.GetComponent<RectTransform>().rect.width * 0.5f,
            -toolTipUi.GetComponent<RectTransform>().rect.width * 0.5f, 0);

        toolTipUi.transform.position = position;
        
        itemNameText.text = item.name;
        itemDescriptionText.text = item.discription;
    }

    public void CloseToolTipUI()
    {
        toolTipUi?.SetActive(false);
    }

}
