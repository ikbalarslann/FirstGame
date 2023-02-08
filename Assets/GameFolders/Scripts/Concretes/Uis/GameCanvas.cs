using FirstGame.Combats;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace FirstGame.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        Dead dead;
        private void Awake()
        {
            Dead dead=FindObjectOfType<Dead>();
            gameOverPanel = transform.GetChild(1).gameObject;
            // script uzerinden gameOverPaneli set etmis olduk.
        }
        //player oldugunde gameOverPanelin acilmasini istiyorum.bunun icin tetiklenebilen event yapilarina ihtiyacim var dead scripti icinde event olusturalim.
        // eventi olusturduk simdi icine methot doldurmamiz gerekiyor.
        private void Start()
        {
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

