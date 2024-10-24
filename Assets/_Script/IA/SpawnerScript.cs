using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject mobPrefab;
    private GameObject newMob;
    public List<GameObject> spawnedMob;
    private float spawnTimer;
    private int spawnDelay = 30;
    private bool spawning;
    public int spawnCount;

    private void Start()
    {
        spawnTimer = 0;
        spawning = true;    

        for (int i = 0; i < spawnCount; i++)
        {
            spawnedMob.Add(null);
        }
    }

    private void Update()
    {
        print(spawning);
        print(spawnTimer);

        if (spawnedMob.Contains(null))
            spawning = true;
 
        if (spawning)
            spawnTimer += Time.deltaTime;

        EmptySlot();
        SpawnNewMob();
    }

    private void EmptySlot()
    {
        if (!spawnedMob.Contains(null))
        {
            foreach (GameObject mob in spawnedMob)
            {
                if (newMob.GetComponent<MobStatsManager>().isDead)
                {
                    spawnedMob.Remove(mob);
                }
            }
        }
    }

    private void SpawnNewMob()
    {
        if (spawnTimer >= spawnDelay)
        {
            newMob = Instantiate(mobPrefab);
            newMob.transform.SetParent(gameObject.transform);
            newMob.GetComponent<MobStatsManager>();

            if (spawnedMob.Contains(null))
            {
                for (int i = 0;i < spawnCount; i++)
                {
                    if (spawnedMob[i] == null)
                    {
                        spawnedMob[i] = newMob;
                        break;
                    }
                }
            }
            else
            {
                spawnedMob.Add(newMob);
            }

            spawnTimer = 0;
            spawning = false;
        }
    }
}
