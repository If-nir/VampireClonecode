using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime05 : MonoBehaviour
{
    Transform target;
    float moveSpeed;
    public float Cur_Hp;
    private float Max_Hp;
    // Start is called before the first frame update
    void Start()
    {
        Max_Hp = 2;
        Cur_Hp = Max_Hp;
        moveSpeed = 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.position, moveSpeed * Time.deltaTime);// 플레이어 방향으로 움직임
        
        if (Cur_Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("W_Charging"))
        {
            Cur_Hp -= collision.GetComponent<W_Charging>().W_ChargingAtk;
        }
    }
}
