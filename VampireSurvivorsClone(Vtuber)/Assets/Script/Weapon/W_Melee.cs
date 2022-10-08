using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Melee : MonoBehaviour
{
    Collider2D cd_W_melee;
    SpriteRenderer W_meleeRender;
    Move_Player playerstauts;
    //meleeWp status
    public float W_meleeAtk=30;
    public float W_drainHp;
    float rotationWp;
    bool W_Dm_On;

    void Start()
    {
        W_meleeRender = this.GetComponent<SpriteRenderer>();
        cd_W_melee = this.GetComponent<Collider2D>();
        playerstauts = GameObject.Find("Player").GetComponent<Move_Player>();
        //meleeWp set
        W_meleeAtk = 30;
        rotationWp = 100f;
    }


    void Update()
    {
        //Dm_On;
        if (Input.GetKey(KeyCode.Z))
        {
            W_Dm_On = true;
        }

        else if (Input.GetKeyUp(KeyCode.Z))
        {
            W_Dm_On = false;
        }

        //RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            W_meleeRender.flipX = true;
            this.transform.localPosition = new Vector3(2, 0, 0);
            rotationWp = Mathf.Abs(rotationWp) * -1;
        }

        //LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            W_meleeRender.flipX = false;
            this.transform.localPosition = new Vector3(-2, 0, 0);
            rotationWp = Mathf.Abs(rotationWp);
        }
        
        if (W_Dm_On)
        {
            cd_W_melee.enabled = true;
            transform.rotation *= Quaternion.Euler(0f, 0f, Time.deltaTime * rotationWp);
        }
        else
        {
            cd_W_melee.enabled = false;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    //collsion
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("E_LV1"))
        {
            W_drainHp = (playerstauts.Player_MaxHp / 100) * 5;
            playerstauts.Player_CurHp += W_drainHp;
        }
    }
}
