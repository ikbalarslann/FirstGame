using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
       public void yesButton()
        {
            GameManager.Instance.StartGame();
        }
        public void NoButton()
        {
            GameManager.Instance.OpenMenu();
        }
    }
}

