using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Bullet : MonoBehaviour
{
    private float destroyer; //소멸
    private float angle; //각도 
    private Vector2 Player, mouse;
    private Rigidbody2D rigid;
    public float W_BlletAtk; // 대미지

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform.position; //마우스 방향
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - Player.y, mouse.x- Player.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rigid = gameObject.GetComponent<Rigidbody2D>();
        W_BlletAtk = 1;
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(new Vector3(mouse.x - Player.x, mouse.y - Player.y, -5) * 1, ForceMode2D.Impulse);
        destroyer += Time.deltaTime; //소멸시간
        if(destroyer > 5) //소멸
        {
            Destroy(this.gameObject);
        }
    }
}
