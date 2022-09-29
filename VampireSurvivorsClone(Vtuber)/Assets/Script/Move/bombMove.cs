using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombMove : MonoBehaviour
{
    Transform target;

    float bombMoveSpeed;
    float timecheck;

    bool targetlock;
    public bool targetlockSet;
    void Start()
    {
        targetlock = false;
        targetlockSet = false;
        bombMoveSpeed = 5.0f;
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
            target = GameObject.Find("player").GetComponent<Transform>();
            targetToX = target.position.x - this.gameObject.transform.position.x;
            targetToY = target.position.y - this.gameObject.transform.position.y;
            targetToBomb = Mathf.Sqrt(Mathf.Pow(targetToX, 2) + Mathf.Pow(targetToY, 2));
            if (targetToBomb < 20.0f)
            {
                targetlock = true;
            }
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, bombMoveSpeed * Time.deltaTime);
    }
}
