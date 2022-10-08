using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_E_Lv1 : MonoBehaviour
{
    public GameObject enemy;
    Transform target;
    float spawnTime;
    void Start()
    {
        spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime += Time.deltaTime;
        if (spawnTime > 5.0f)
        {
            float ranx = Random.Range(-25, 25);
            float rany = Random.Range(-25, 25);
            target = GameObject.Find("Player").GetComponent<Transform>();
            Instantiate(enemy, new Vector3(target.position.x + ranx, target.position.y + rany, target.position.z), Quaternion.identity);
            spawnTime = 0;
        }
    }
}
