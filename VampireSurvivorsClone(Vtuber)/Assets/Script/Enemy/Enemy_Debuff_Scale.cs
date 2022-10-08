using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Debuff_Scale : MonoBehaviour
{
    //player Status
    Move_Player scr_playerStatus;

    bool SpeedDown;
    void Start()
    {

    }

    void Update()
    {
        scr_playerStatus = GameObject.Find("Player").GetComponent<Move_Player>();
        this.transform.localScale =
       new Vector3(this.transform.localScale.x + 0.3f * Time.deltaTime, transform.localScale.y + 0.3f * Time.deltaTime, 1);

        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name.Contains("Player"))
        {
            Debug.Log("good");
        }
    }
}
