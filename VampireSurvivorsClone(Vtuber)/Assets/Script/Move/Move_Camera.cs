using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour
{
    Move_Player scr_PlayerStatus;
    Transform playerpt;
    float cameraspeed;
    void Start()
    {
        
    }


    void Update()
    {
        //find player speed & postion
        playerpt = GameObject.Find("Player").GetComponent<Transform>();
        scr_PlayerStatus = GameObject.Find("Player").GetComponent<Move_Player>();
        //set speed & postion
        cameraspeed = scr_PlayerStatus.Player_Speed;
        this.transform.position = Vector3.Lerp(this.transform.position,
            new Vector3(playerpt.position.x, playerpt.position.y, this.transform.position.z),
            cameraspeed * Time.deltaTime);
    }
}
