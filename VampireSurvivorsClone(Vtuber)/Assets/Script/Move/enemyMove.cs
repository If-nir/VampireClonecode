using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    SpriteRenderer render;
    Transform target;
    private float enemySpeed = 2.5f;
    float enemyMaxHp;
    float enemyCurHp;

    void Start()
    {
        enemyMaxHp = 100;
        enemyCurHp = enemyMaxHp;
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
        if (enemyCurHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("W_"))
        {
            enemyCurHp -= collision.GetComponent<W_meleeStatus>().W_meleeAtk;
        }
        if (collision.gameObject.name.Contains("E_LV2"))
        {
            Destroy(this.gameObject);
        }
    }

}
