using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPortal : MonoBehaviour
{
    private SceneLoader loader;
    private EnemyCount enemyCount;
    private FloorCount floorCount;
    private void Awake()
    {
        loader = FindObjectOfType<SceneLoader>();
        enemyCount = FindObjectOfType<EnemyCount>();
        floorCount = FindObjectOfType<FloorCount>();
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "DungeonPortal")
        {
            Debug.Log("Dungeon");
            loader.isDungeonPortal();
        }
        else if (coll.gameObject.tag == "ExitPortal")
        {
            if(enemyCount.enemies.Length <= 0)
            {
                if(floorCount.floor == 3)
                {
                    Debug.Log("Ending");
                    loader.isEnding();
                }
                else
                {
                    Debug.Log("Exit");
                    floorCount.floor++;
                    loader.isExitPortal();
                }
            }
            else
            {
                Debug.Log("kill Enemy");
                return;
            }
        }
    }
}
