using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Holy_property : MonoBehaviour
{
    public float W_HolyAtk;
    float rotSpeed = 1.0f;

    void Start()
    {
        W_HolyAtk = 40;
    }

    void Update()
    {
        this.transform.Rotate(Vector3.forward * -rotSpeed); //È¸Àü

    }
}
