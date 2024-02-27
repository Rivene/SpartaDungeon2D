using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void isDungeonPortal()
    {
        SceneManager.LoadScene("TestMoveScene"); // 던전씬으로 변경 << 씬이름은 변경
    }
}
