using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPortal : MonoBehaviour
{
    private SceneLoader loader;
    private void Awake()
    {
        loader = FindObjectOfType<SceneLoader>();
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
            Debug.Log("Exit");
            loader.isExitPortal();
        }
    }
}
