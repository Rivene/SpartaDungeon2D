using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLevel : MonoBehaviour
{
    public int dungeonLevel = 0;

    public void UpDungeon()
    {
        dungeonLevel++;
    }

    private void Reset() //던전층수 리셋
    {
        dungeonLevel = 0;
    }
}
