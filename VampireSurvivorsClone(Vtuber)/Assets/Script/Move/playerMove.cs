using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    SpriteRenderer playerRender;
    Animator playerAni;
    public float playerspeed;
    void Start()
    {
        //player Animator
        playerRender = this.GetComponent<SpriteRenderer>();
        playerAni = this.GetComponent<Animator>();
        playerAni.SetBool("iswalking", false);

        //player status
        playerspeed = 10.0f;
    }

    
    void Update()
    {
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
    }
}
