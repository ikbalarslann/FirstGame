using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{// ozellikle namespace koymadik cunku heryerden erisilmesini istiyoruz.
    // Start is called before the first frame update
   
    public static GameManager Instance { get; private set; }

   [SerializeField]  int _score;
    public event Action <int> onScoreChanged;
   
    private void Awake()
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
    public void StartGame()
    {
        StartCoroutine(StartGameAsync());
    }

    private IEnumerator StartGameAsync()
    {
        _score = 0;
        Time.timeScale = 1f;
        yield return SceneManager.LoadSceneAsync("Game");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void OpenMenu()
    {
        StartCoroutine(OpenMenuAsync());
    }

    private IEnumerator OpenMenuAsync()
    {
        yield return SceneManager.LoadSceneAsync("Menu");
    }

    public void IncreaseScore()
    {
        _score += 10;
        onScoreChanged?.Invoke(_score);

    }
    
}
