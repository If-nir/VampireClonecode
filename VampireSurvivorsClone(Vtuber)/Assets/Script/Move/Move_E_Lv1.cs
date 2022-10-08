using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_E_Lv1 : MonoBehaviour
{
    //playerStatus
    Move_Player scr_PlayerStatus;

    SpriteRenderer render;
    Transform target;
    private float E_Lv1_Speed = 2.5f;
    float E_Lv1_MaxHp;
    float E_Lv1_CurHp;

    void Start()
    {
        E_Lv1_MaxHp = 100;
        E_Lv1_CurHp = E_Lv1_MaxHp;
        //enemy Animator
        render = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        scr_PlayerStatus = GameObject.Find("Player").GetComponent<Move_Player>();
        //find player transform & move to player
        target = GameObject.Find("Player").GetComponent<Transform>();
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, E_Lv1_Speed * Time.deltaTime);

        //turn to player
        if (this.transform.position.x > target.transform.position.x)
            render.flipX = true;
        else
            render.flipX = false;
        if (E_Lv1_CurHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    //collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("W_melee"))
        {
            E_Lv1_CurHp -= collision.GetComponent<W_Melee>().W_meleeAtk;
        }
        if (collision.gameObject.name.Contains("E_Bomb"))
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            scr_PlayerStatus.Player_CurHp--;

        }
    }
}
