using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_E_Bomb : MonoBehaviour
{
    Transform target;

    float E_Bomb_Speed;
    float timecheck;

    bool targetlock;
    public bool targetlockSet;
    void Start()
    {
        targetlock = false;
        targetlockSet = false;
        E_Bomb_Speed = 5.0f;
    }


    void Update()
    {
        //set player to bomb distance
        float targetToX;
        float targetToY;
        float targetToBomb;

        //stop bomb
        if (targetlock)
        {
            timecheck += Time.deltaTime;
            target = this.gameObject.GetComponent<Transform>();
            if (timecheck > 5.0f)
            {
                targetlockSet = true;
            }
        }
        //movetowards player
        else
        {
            target = GameObject.Find("Player").GetComponent<Transform>();
            targetToX = target.position.x - this.gameObject.transform.position.x;
            targetToY = target.position.y - this.gameObject.transform.position.y;
            targetToBomb = Mathf.Sqrt(Mathf.Pow(targetToX, 2) + Mathf.Pow(targetToY, 2));
            if (targetToBomb < 20.0f)
            {
                targetlock = true;
            }
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, E_Bomb_Speed * Time.deltaTime);
    }
}
