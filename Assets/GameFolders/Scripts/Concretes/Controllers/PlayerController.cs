using FirstGame.Combats;
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
        LaunchProjectile _loungeProjectile;
        AudioSource _audioSource;

      

        bool _isLeftMouseClicked = false;
        bool _isRightMouseClicked = false;
        
        
        

        private void Awake()
        {
            _rigidbody2D= GetComponent<Rigidbody2D>(); 
            
            _jump= GetComponent<Jump>();
            _input = GetComponent<PcInputController>();
            _loungeProjectile= GetComponent<LaunchProjectile>();   
            _audioSource = GetComponent<AudioSource>();
        }
        
      

        void Update()
        {
           
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;
            }
            if (_input.RightMouseClickDown)
            {
                _isRightMouseClicked= true;
            }
            
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _isLeftMouseClicked = false;
                _audioSource.Play();
            }
            if (_isRightMouseClicked)
            {
                _loungeProjectile.Fire();
                _isRightMouseClicked = false;
            }
            
            
        }

       

    }
    
    }


