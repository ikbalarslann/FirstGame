using FirstGame.Movemets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FirstGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _input;
      

        bool _isLeftMouseClicked = false;
        
        

        private void Awake()
        {
            _rigidbody2D= GetComponent<Rigidbody2D>(); 
            
            _jump= GetComponent<Jump>();
            _input = GetComponent<PcInputController>();
        }
        
      

        void Update()
        {
           
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;
            }
            
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _isLeftMouseClicked = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.ReStartGame();
        }

    }
    
    }


