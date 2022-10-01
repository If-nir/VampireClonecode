using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_Bomb : MonoBehaviour
{
    bombMove bombLockOn;
    Transform bombsize;
    CircleCollider2D bomb_rn;
    SpriteRenderer changeColor;

    playerMove playerstatus;

    void Start()
    {
        //bomb status read
        bombLockOn = this.gameObject.GetComponent<bombMove>();
        bombsize = this.gameObject.GetComponent<Transform>();
        bomb_rn = this.GetComponent<CircleCollider2D>();
        changeColor = this.GetComponent<SpriteRenderer>();
        bomb_rn.enabled = false;

        //player status
        playerstatus = GameObject.Find("player").GetComponent<playerMove>();
    }


    void Update()
    {
        if (bombLockOn.targetlockSet)
        {
            if (bomb_rn.radius < 0.6f)
            {
                bomb_rn.enabled = true;
                changeColor.color = new Color(255, 0, 0, 255);
                bombsize.localScale += new Vector3(1.4f, 1.4f, 0);
                bomb_rn.radius += 0.01f;
            }
            else
                Destroy(this.gameObject);
        }
    }

    //collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("player"))
        {
            playerstatus.curHp -= 30;
        }
    }
}
