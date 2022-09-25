using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void sceneChange()
    {
        SceneManager.LoadScene("GameMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
