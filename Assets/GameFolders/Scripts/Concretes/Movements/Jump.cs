using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Movemets
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float _jumpForce = 450f;
        public float JumpForce
        {
            get
            {
                return _jumpForce;
            }

            private set
            {
                if (value < 400f || value > 1000f)
                {
                    _jumpForce = 450f;
                }
                else
                {
                    _jumpForce = value;
                }

            }
        }


       public void JumpAction(Rigidbody2D  rigidbody2D)
        {
            
            rigidbody2D.AddForce(Vector3.up * JumpForce);
        }
    }
}

