using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponSpawn : MonoBehaviour
{
    GameObject read;
    public GameObject W_meleeWp;
    public float meleeDm;
    Transform target;
    void Start()
    {
        target = GameObject.Find("player").GetComponent<Transform>();
        read=Instantiate(W_meleeWp, new Vector3(target.position.x, target.position.y, target.position.z), Quaternion.identity);
        read.transform.SetParent(GameObject.Find("player").transform);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
