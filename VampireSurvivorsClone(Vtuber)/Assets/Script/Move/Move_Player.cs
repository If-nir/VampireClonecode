using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Move_Player : MonoBehaviour
{
    public Slider playerHp_bar;

    SpriteRenderer playerRender;
    Animator Ani_Player;

    public bool Enemy_Pause;

    //playerstatus
    public float Player_Speed;
    public float Player_MaxHp;
    public float Player_CurHp;

    public bool isdead;
    void Start()
    {
        //player Animator
        playerRender = this.GetComponent<SpriteRenderer>();
        Ani_Player = this.GetComponent<Animator>();
        Ani_Player.SetBool("iswalking", false);

        //player status
        Player_Speed = 10.0f;
        Player_MaxHp = 100;
        Player_CurHp = Player_MaxHp;

        //player condition
        isdead = false;

        Enemy_Pause = false;
    }

    void Update()
    {
        //player status
        playerHp_bar.value = Player_CurHp / Player_MaxHp;


        //UP
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0, 1, 0) * Player_Speed * Time.deltaTime);
            Ani_Player.SetBool("iswalking", true);

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Ani_Player.SetBool("iswalking", false);
        }

        //DOWN
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, -1, 0) * Player_Speed * Time.deltaTime);
            Ani_Player.SetBool("iswalking", true);

        }

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Ani_Player.SetBool("iswalking", false);
        }


        //RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(1, 0, 0) * Player_Speed * Time.deltaTime);
            playerRender.flipX = true;
            Ani_Player.SetBool("iswalking", true);

        }

        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Ani_Player.SetBool("iswalking", false);
        }

        //LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-1, 0, 0) * Player_Speed * Time.deltaTime);
            playerRender.flipX = false;
            Ani_Player.SetBool("iswalking", true);

        }

        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Ani_Player.SetBool("iswalking", false);
        }
        if (Player_CurHp <= 0)
        {
            isdead = true;
        }

    }


}
