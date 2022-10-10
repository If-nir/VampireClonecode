using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Axe : MonoBehaviour
{
    public float W_AxeAtk;
    float RotationSpeed = 30f;
    Rigidbody2D rigid;
    float rand1;

    void Start()
    {
        W_AxeAtk = 50;
        rand1 = Random.Range(-3, 3);
        rigid = this.GetComponent<Rigidbody2D>();
        rigid.AddForce(new Vector2(rand1, 10), ForceMode2D.Impulse);
    }
    void Update()
    {
        this.transform.Rotate(Vector3.forward * RotationSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("E_Bullet"))
        {
            Debug.Log("AxeDm: " + W_AxeAtk);
            collision.gameObject.GetComponent<Enemy_Bullet>().Cur_Hp -= W_AxeAtk;
        }
    }
}
