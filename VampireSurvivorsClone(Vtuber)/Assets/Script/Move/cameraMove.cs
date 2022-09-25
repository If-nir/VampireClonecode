using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    playerMove playerStatus;
    Transform playerpt;
    float cameraspeed;
    void Start()
    {
        
    }


    void Update()
    {
        //find player speed & postion
        playerpt = GameObject.Find("player").GetComponent<Transform>();
        playerStatus = GameObject.Find("player").GetComponent<playerMove>();
        //set speed & postion
        cameraspeed = playerStatus.playerspeed;
        this.transform.position = Vector3.Lerp(this.transform.position,
            new Vector3(playerpt.position.x, playerpt.position.y, this.transform.position.z),
            cameraspeed * Time.deltaTime);
    }
}
