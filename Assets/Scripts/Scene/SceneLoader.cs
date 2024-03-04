using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void isDungeonPortal()
    {
        if(SceneManager.GetActiveScene().name == "LobbyScene")
        {
            SceneManager.LoadScene("DungeonScene"); //������
        }
        else
        {
            SceneManager.LoadScene("LobbyScene"); //�κ��
        }
    }

    public void isExitPortal()
    {
        SceneManager.LoadScene("LobbyScene"); //�κ��
    }

    public void isStartBtn()
    {
        SceneManager.LoadScene("LobbyScene"); //�κ��
    }

    public void isEnding()
    {
        SceneManager.LoadScene("EndingScene"); //����
    }
}
