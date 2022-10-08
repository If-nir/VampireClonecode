using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W_Holy_Book : MonoBehaviour
{
    public GameObject W_HolyBible;
    GameObject[] Weapon_DE = new GameObject[8];

    //¼Ó¼º
    float rotSpeed = 1.0f;
    float cooltime;
    float duration;

    int BibleCount;
    public int update_Count; 
    bool isCreate;

    void Start()
    {
        update_Count = 0;
        isCreate = false;
        BibleCount = 1;
      
        cooltime = 2.0f;
        duration = 5.0f;
    }

    void Update()
    {
        if(isCreate == false)
        {
            cooltime -= Time.deltaTime;
            if (cooltime <= 0 && BibleCount > 0)
            {
                Create_HolyBible();
                cooltime = 4.0f;
            }
        }
        else
        {
            
            duration -= Time.deltaTime;
            if(duration <= 0)
            {
                Destroy_HolyBible();
                
                duration = 5.0f;
            }
        }
       

        
    }
    void Destroy_HolyBible()
    {
        for (int i = 0; i < BibleCount; i++)
        {
            Destroy(Weapon_DE[i].gameObject);
        }

        isCreate = false;

        if(BibleCount + update_Count > 8)
        {
            BibleCount = 8;
        }
        else
        {
            BibleCount += update_Count;
        }

        update_Count = 0;
    }

    void Create_HolyBible()
    {
        isCreate = true;
        for(int i = 0; i < BibleCount; i++)
        {
            float rotate = 360 / BibleCount;

            Weapon_DE[i] = Instantiate(W_HolyBible, this.transform.position, Quaternion.Euler(0, 0, rotate * i));
            Weapon_DE[i].transform.parent = this.transform;
        }

    }


}
