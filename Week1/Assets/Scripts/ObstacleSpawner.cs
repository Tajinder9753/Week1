using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstaclePrefab;
    [SerializeField] float spawnTime = 1f;
    [SerializeField] float timer = 0;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTime)
        {
            int rand = Random.Range(0, obstaclePrefab.Length);
            GameObject obj = Instantiate(obstaclePrefab[rand]);
            obj.transform.position = new Vector3(player.transform.position.x - 15, 0, 0);
            Destroy(obj, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
