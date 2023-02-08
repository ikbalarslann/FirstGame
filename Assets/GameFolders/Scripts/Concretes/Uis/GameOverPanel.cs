using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
       public void yesButton()
        {
            GameManager.Instance.ReStartGame();
        }
        public void NoButton()
        {
            Debug.Log("Normally it should send it to the menu scene but since i didn't do it yet i am writing it instead.");
        }
    }
}

