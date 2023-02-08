using FirstGame.Combats;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace FirstGame.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        Dead _dead;
        private void Awake()
        {
            _dead=FindObjectOfType<Dead>();
            gameOverPanel = transform.GetChild(1).gameObject;
            // script uzerinden gameOverPaneli set etmis olduk.
        }
        //player oldugunde gameOverPanelin acilmasini istiyorum.bunun icin tetiklenebilen event yapilarina ihtiyacim var dead scripti icinde event olusturalim.
        // eventi olusturduk simdi icine methot doldurmamiz gerekiyor.

        private void Start()
        {
            _dead.OnDead += _dead_OnDead;
            
        }

        private void _dead_OnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

