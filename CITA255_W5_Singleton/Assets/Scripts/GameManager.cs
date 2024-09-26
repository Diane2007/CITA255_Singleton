using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int number;

    void Start()
    {
        number = 2;
    }

    void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        //whenever I press the space bar, we go to scene 2
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void HelloWorld()
    {
        Debug.Log("Hello, scene 2!");
    }
    
}
