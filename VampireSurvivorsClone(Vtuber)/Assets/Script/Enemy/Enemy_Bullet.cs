using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{
    public GameObject Bullet; // ÃÑ¾Ë
    Move_Player GM;
    //Animator Ani_BulletEnemy;
    float coolTime = 1.5f;
    float Delay;
    // 
    public float Cur_Hp, Max_Hp;
    //
    public float MoveSpeed = 1.0f;
    public float Dis;

    Transform target; // ÇÃ·¹ÀÌ¾î ÁÂÇ¥Á¤º¸
    public bool Attacking = false;

    void Start()
    {
        //Ani_BulletEnemy = GetComponent<Animator>();
        //Ani_BulletEnemy.SetBool("BulletEnemyWalking", false);
        GM = GameObject.Find("Player").GetComponent<Move_Player>();
        Delay = 0f;

        Max_Hp = 100;
        Cur_Hp = Max_Hp;
    }

    void Update()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        Dis = Vector3.Distance(target.transform.position, this.transform.position);
        if (Dis >= 30.0f)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, MoveSpeed * Time.deltaTime);
            Attacking = false;

        }
        else
        {
            Delay += Time.deltaTime;
            if (Delay >= coolTime)
            {
                Attacking = true;
                Instantiate(Bullet, this.transform.position, Quaternion.identity);
                Delay = 0f;
            }
            //Ani_BulletEnemy.SetBool("BulletEnemyWalking", false);
        }
        if (Cur_Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
