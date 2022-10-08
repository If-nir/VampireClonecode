using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_W_Charging : MonoBehaviour
{
    public GameObject W_Charging;

    float CoolTime;
    Vector2 mouse;
    // Start is called before the first frame update
    void Start()
    {
        CoolTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CoolTime -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R) && CoolTime < 0) //Â÷Â¡¹«±â
        {
            Instantiate(W_Charging, new Vector2(mouse.x, mouse.y), Quaternion.identity);
            CoolTime = 30;
        }
    }
}
