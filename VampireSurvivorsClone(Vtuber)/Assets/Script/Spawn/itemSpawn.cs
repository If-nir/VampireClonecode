using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawn : MonoBehaviour
{
    //item list
    public GameObject I_SpeedUp;

    //set player postion
    Transform playertarget;

    //check Time
    float itemSpawnTime;
    void Start()
    {
        itemSpawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        itemSpawnTime += Time.deltaTime;
        //set player postion
        playertarget = GameObject.Find("player").GetComponent<Transform>();
        if (itemSpawnTime >= 5.0f)
        {
            float ranx = Random.Range(-10, 10);
            float rany = Random.Range(-10, 10);
            Instantiate(I_SpeedUp, new Vector3(playertarget.position.x + ranx, playertarget.position.y + rany, playertarget.position.z), Quaternion.identity);
            itemSpawnTime = 0;
        }
    }
}
