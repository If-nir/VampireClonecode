using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_W_Axe : MonoBehaviour
{
    public GameObject W_Axe;
    bool IsShoot;
    float coolTime;
    float updateTime;
    
    void Start()
    {
        IsShoot = false;
        coolTime = 0;
        updateTime = 0;
    }

    
    void Update()
    {
        coolTime += Time.deltaTime;
        updateTime += Time.deltaTime;
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (IsShoot == false && coolTime > 2.0f)
                {
                    IsShoot = true;
                    if (updateTime < 5) // Level_1
                    {
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                    }
                    else if (updateTime <= 10) // Level_2
                    {
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                    }
                    else if (updateTime <= 15) // Level_3
                    {
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                    }
                    else if (updateTime <= 20) // Level_4
                    {
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                    }
                    else // Level_5
                    {
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Instantiate(W_Axe, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                    }
                    coolTime = 0f;
                }
                else
                {
                    IsShoot = false;
                }
            }
        }
    }
}