using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_meleeStatus : MonoBehaviour
{
    Collider2D cd_W_melee;
    SpriteRenderer W_meleeRender;
    playerMove playerstauts;
    //meleeWp status
    public float W_meleeAtk;
    public float W_drainHp;
    void Start()
    {
        W_meleeRender = this.GetComponent<SpriteRenderer>();
        cd_W_melee = this.GetComponent<Collider2D>();
        playerstauts = GameObject.Find("player").GetComponent<playerMove>();
        //meleeWp set
        W_meleeAtk = 30;
    }


    void Update()
    {
        //RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            W_meleeRender.flipX = true;
            this.transform.localPosition = new Vector3(2, 0, 0);
        }

        //LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            W_meleeRender.flipX = false;
            this.transform.localPosition = new Vector3(-2, 0, 0);
        }
        
        if (playerstauts.W_dmOn)
        {
            cd_W_melee.enabled = true;
        }
        else
        {
            cd_W_melee.enabled = false;
        }
    }

    //collsion
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("E_LV1"))
        {
            Debug.Log("check");
            W_drainHp = (playerstauts.maxHp / 100) * 5;
            playerstauts.curHp += W_drainHp;
        }
    }
}
