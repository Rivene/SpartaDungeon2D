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
            SceneManager.LoadScene("DungeonScene"); //´øÀü¾À
        }
        else
        {
            SceneManager.LoadScene("LobbyScene"); //·Îºñ¾À
        }
    }

    public void isExitPortal()
    {
        SceneManager.LoadScene("LobbyScene"); //·Îºñ¾À
    }

    public void isStartBtn()
    {
        SceneManager.LoadScene("LobbyScene"); //·Îºñ¾À
    }

    public void isEnding()
    {
        SceneManager.LoadScene("EndingScene"); //¿£µù
    }
}
