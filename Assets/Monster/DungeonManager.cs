using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DungeonManager : MonoBehaviour
{
    [SerializeField] private int mapSpawnCount = 2;

    public List<GameObject> enemyPrefabs = new List<GameObject>();
    [SerializeField] private Transform spawnPosRoot;
    private List<Transform> spawnPos = new List<Transform>();
    public GameObject bossPrefab;

    private FloorCount floor;

    private void Awake()
    {
        for (int i = 0; i < spawnPosRoot.childCount; i++)
        {
            spawnPos.Add(spawnPosRoot.GetChild(i));
        }

        floor = FindObjectOfType<FloorCount>();
    }

    private void Start()
    {
        if (floor.floor < 3)
            StartCoroutine(CreateMonster());
        else if(floor.floor == 3)
            CreateBoss();
    }

    IEnumerator CreateMonster()
    {
        for (int i = 0; i < mapSpawnCount; i++)
        {
            int posIdx = Random.Range(0, spawnPos.Count);
            int prefabIdx = Random.Range(0, enemyPrefabs.Count);
            GameObject enemy = Instantiate(enemyPrefabs[prefabIdx], spawnPos[posIdx].position, Quaternion.identity);

            yield return new WaitForSeconds(1f);

        }
    }

    void CreateBoss()
    {
        GameObject enemy = Instantiate(bossPrefab);
    }
}
