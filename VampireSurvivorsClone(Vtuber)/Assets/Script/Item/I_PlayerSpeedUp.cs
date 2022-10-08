using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_PlayerSpeedUp : MonoBehaviour
{
    Move_Player scr_PlayerStatus;
    bool PlayerSpeedUp;
    float SpeedTime;

    //player status
    float Player_CurSp;
    void Start()
    {
        scr_PlayerStatus = GameObject.Find("Player").GetComponent<Move_Player>();
        PlayerSpeedUp = false;
        SpeedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerSpeedUp)
        {
            Player_CurSp = scr_PlayerStatus.Player_Speed;
            SpeedTime += Time.deltaTime;
            //if()
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            PlayerSpeedUp = true;
            Destroy(this.gameObject);
        }
    }
}
