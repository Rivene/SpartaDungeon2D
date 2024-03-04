using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private EnemyCount enemyCount;
    private FloorCount floorCount;
    public Text floorText;
    public Text enemyText;
    void Start()
    {
        enemyCount = FindObjectOfType<EnemyCount>();
        floorCount = FindObjectOfType<FloorCount>();
    }

    // Update is called once per frame
    void Update()
    {
        floorText.text = "Floor: " + floorCount.floor.ToString();
        enemyText.text = "Count: " + enemyCount.enemies.Length.ToString();
    }
}
