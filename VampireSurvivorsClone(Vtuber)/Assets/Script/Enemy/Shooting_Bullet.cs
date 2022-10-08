using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_Bullet : MonoBehaviour
{
    Transform Pos;
    Vector2 target;
    Rigidbody2D rig;
    void Start()
    {
        target = GameObject.Find("Player").transform.position;
        rig = gameObject.GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(target.x - this.transform.position.x, target.y - this.transform.position.y, -5), ForceMode2D.Impulse);
    }

    void Update()
    {
        /*if (BE.Attacking)
        {
            
            //Pos = GameObject.FindWithTag("Player").GetComponent<Transform>();
            //this.transform.Translate(new Vector2(Pos.position.x, Pos.position.y) * 0.5f * Time.deltaTime);
        }*/
    }
}