using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Uis
{
    public class MenuCanvas : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.StartGame();
        }
        public void NoButton()
        {
            GameManager.Instance.ExitGame();
        }
    }
}

