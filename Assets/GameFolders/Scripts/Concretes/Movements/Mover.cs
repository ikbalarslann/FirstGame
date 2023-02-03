using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Movemets
{
    public class Mover : MonoBehaviour
    {
        
       
        float _moveSpeed = 0.03f;

        private void Awake()
        {
            
        }
        void Start()
        {

        }

       
        void Update()
        {
            transform.Translate(Vector3.left* _moveSpeed);
        }
    }
}

