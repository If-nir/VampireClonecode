using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_PlayerHp : MonoBehaviour
{
    Transform target;
    Camera camera;
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player").transform;
        this.transform.position = camera.WorldToScreenPoint(target.transform.position + new Vector3(0, -1, 0));
    }
}
