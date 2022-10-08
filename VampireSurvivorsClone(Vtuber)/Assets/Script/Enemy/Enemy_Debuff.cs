using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Debuff : MonoBehaviour
{

    //DEBUFF
    public GameObject E_DebuffScale; //디버프 범위
    GameObject destry_debuff; //생성된 E_DebuffScale 할당

    //속성
    private float Cur_Hp;
    private float Max_Hp;

    //무기


    void Start()
    {
        Max_Hp = 50;
        Cur_Hp = Max_Hp;


        destry_debuff = Instantiate(E_DebuffScale, this.transform.position, Quaternion.identity);

    }

    void Update()
    {
        if (Cur_Hp <= 0)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)//weapon Holy
        {

            Destroy(destry_debuff.gameObject);

            Destroy(this.gameObject);
        }

    }
}
