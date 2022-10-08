using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_E_Bullet : MonoBehaviour
{
    public GameObject Enemy;
    public Transform[] Summon_Point;
    int RanNum;
    float SpawnTime = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RanNum = Random.Range(0, 9);
        SpawnTime += Time.deltaTime;
        if (SpawnTime > 2.0f)
        {
            SpawnTime = 0;
            //Instantiate(Enemy, Summon_Point[RanNum].position, Quaternion.identity);
        }
    }
}
