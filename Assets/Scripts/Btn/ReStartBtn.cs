using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStartBtn : MonoBehaviour
{
    private FloorCount floorCount;
    private SceneLoader loader;
    void Start()
    {
        floorCount = FindObjectOfType<FloorCount>();
        loader = FindObjectOfType<SceneLoader>();
    }

    public void isRestartBtn()
    {
        floorCount.floor = 1;
        floorCount.hp = 100f;
        loader.isStartBtn();
    }
}
