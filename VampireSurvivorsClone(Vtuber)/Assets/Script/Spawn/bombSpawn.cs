using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawn : MonoBehaviour
{
    public GameObject E_bomb;
    Transform target;
    float spawnTime;
    void Start()
    {
        spawnTime = 0;
    }


    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime > 5.0f)
        {
            float ranx = Random.Range(-25, 25);
            float rany = Random.Range(-25, 25);
            target = GameObject.Find("player").GetComponent<Transform>();
            Instantiate(E_bomb, new Vector3(target.position.x + ranx, target.position.y + rany, target.position.z), Quaternion.identity);
            spawnTime = 0;
        }
    }
}
