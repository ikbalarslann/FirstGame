using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace FirstGame.Uis
{
    public class DisplayScore : MonoBehaviour
    {
        
        TextMeshProUGUI _scoreText;
         
        private void Awake()
        {
            _scoreText=GetComponent<TextMeshProUGUI>();
        }
        
        private void Start()
        {
            GameManager.Instance.onScoreChanged += OnHandleScoreChanged;
        }
        public void OnHandleScoreChanged(int score)
        {
            _scoreText.text = $"Score : {score}";
        }
    }
}

