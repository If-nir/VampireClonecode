using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_Bomb : MonoBehaviour
{
    bombMove bombLockOn;
    Transform bombsize;
    CircleCollider2D bomb_rn;
    SpriteRenderer changeColor;

    float timecheck;

    void Start()
    {
        bombLockOn = this.gameObject.GetComponent<bombMove>();
        bombsize = this.gameObject.GetComponent<Transform>();
        bomb_rn = this.GetComponent<CircleCollider2D>();
        changeColor = this.GetComponent<SpriteRenderer>();
        timecheck = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (bombLockOn.targetlockSet && bomb_rn.radius<0.6f)
        {
            changeColor.color=new Color(255,0,0,255);
            bombsize.localScale += new Vector3(1.4f, 1.4f, 0);
            bomb_rn.radius += 0.01f;
        }
    }
}
