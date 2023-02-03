using FirstGame.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Movemets
{
    public class Mover : MonoBehaviour
    {
     
     [SerializeField]   float _moveSpeed = 0.03f;
        [SerializeField] DirectionEnum direction;

        

        
        void Update()
        {
            if (direction==DirectionEnum.Left) 
            { 
                transform.Translate(Vector2.left * _moveSpeed); 
            }
            else
            {
                transform.Translate(Vector2.right * _moveSpeed);
            }
            
        }
       
    }
}

