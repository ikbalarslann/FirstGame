using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers 
{
    public class PcInputController : MonoBehaviour
    {
        public bool LeftMouseClickDown  => Input.GetMouseButtonDown(0); 
        public bool RightMouseClickDown => Input.GetMouseButtonDown(1); 
    }
}

