using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Image : MonoBehaviour
{
    public Sprite curImage;
    Image MainWp1;


    void Start()
    {
        MainWp1 = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        MainWp1.sprite = curImage;
    }
}
