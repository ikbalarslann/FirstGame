using FirstGame.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Movemets
{
    public class Mover : MonoBehaviour
    {
     
     [SerializeField]   float _moveSpeed = 3f;
        [SerializeField] DirectionEnum direction;
        Rigidbody2D _rigidbody2D;
        //problem ne? player oldugunde obsticleTreeler sola dogru gitmeye devam ediyor.
        //bunu duzeltmek icin mover scriptini degistirmen gerekiyor.
        private void Awake()
        {
            _rigidbody2D= GetComponent<Rigidbody2D>();
        }

        void Start()
        {
            _rigidbody2D.velocity = SelectNewDirection() * _moveSpeed;
        }
       private Vector2 SelectNewDirection()
        {
            Vector2 selectedDirection;
            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }
            return selectedDirection;
        }
    }
}

