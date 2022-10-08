using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Debuff : MonoBehaviour
{

    //DEBUFF
    public GameObject E_DebuffScale; //����� ����
    GameObject destry_debuff; //������ E_DebuffScale �Ҵ�

    //�Ӽ�
    private float Cur_Hp;
    private float Max_Hp;

    //����


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
