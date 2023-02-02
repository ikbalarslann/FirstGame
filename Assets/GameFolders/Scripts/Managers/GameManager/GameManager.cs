using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{// ozellikle namespace koymadik cunku heryerden erisilmesini istiyoruz.
    // Start is called before the first frame update

    public static GameManager Instance { get; private set; }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Singleton();
    }


    private void Singleton()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void ReStartGame()
    {
        StartCoroutine(RestartGameAsync());
    }

    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }
}
