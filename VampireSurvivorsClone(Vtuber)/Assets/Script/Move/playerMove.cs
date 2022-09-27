using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    public Slider playerHp_bar;

    SpriteRenderer playerRender;
    Animator playerAni;

    //playerstatus
    public float playerspeed;
    public float maxHp;
    public float curHp;

    public bool playerSpeedUp;
    public bool isdead;
    public bool W_dmOn;
    void Start()
    {
        //player Animator
        playerRender = this.GetComponent<SpriteRenderer>();
        playerAni = this.GetComponent<Animator>();
        playerAni.SetBool("iswalking", false);

        //player status
        playerspeed = 10.0f;
        maxHp = 100;
        curHp = maxHp;

        //player condition
        playerSpeedUp = false;
        isdead = false;
        W_dmOn = false;
    }

    void Update()
    {
        //player status
        playerHp_bar.value = curHp / maxHp;


        //UP
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0, 1, 0) * playerspeed * Time.deltaTime);
            playerAni.SetBool("iswalking", true);

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            playerAni.SetBool("iswalking", false);
        }

        //DOWN
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, -1, 0) * playerspeed * Time.deltaTime);
            playerAni.SetBool("iswalking", true);

        }

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            playerAni.SetBool("iswalking", false);
        }


        //RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(new Vector3(1, 0, 0) * playerspeed * Time.deltaTime);
            playerRender.flipX = true;
            playerAni.SetBool("iswalking", true);

        }

        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerAni.SetBool("iswalking", false);
        }

        //LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(new Vector3(-1, 0, 0) * playerspeed * Time.deltaTime);
            playerRender.flipX = false;
            playerAni.SetBool("iswalking", true);

        }

        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerAni.SetBool("iswalking", false);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            W_dmOn = true;
        }

        else if (Input.GetKeyUp(KeyCode.Z))
        {
            W_dmOn = false;
        }
    }

    //collision
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("E_LV1"))
        {
            curHp--;
            if (curHp <= 0)
            {
                isdead = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("I_SpeedUp"))
        {
            Destroy(collision.gameObject);
            playerspeed *=10;
        }
    }
}
