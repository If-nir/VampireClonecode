using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    SpriteRenderer render;
    Transform target;
    private float enemySpeed = 0.3f;


    void Start()
    {
        //enemy Animator
        render = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        //find player transform & move to player
        target = GameObject.Find("player").GetComponent<Transform>();
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, enemySpeed * Time.deltaTime);

        //turn to player
        if (this.transform.position.x > target.transform.position.x)
            render.flipX = true;
        else
            render.flipX = false;
    }
}
