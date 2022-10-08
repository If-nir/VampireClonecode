using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_W_Melee : MonoBehaviour
{
    GameObject read;
    public GameObject W_MeleeWp;
    public float meleeDm;
    Transform target;

    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        read=Instantiate(W_MeleeWp, new Vector3(target.position.x, target.position.y, target.position.z), Quaternion.identity);
        read.transform.SetParent(GameObject.Find("Player").transform);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
