using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
       [SerializeField] float _jumpForce=450f;
        public float JumpForce
        { 
            get 
            { 
                return _jumpForce;
            }
            
            private set
            {
                if (value<400f ||value>1000f)
                {
                    _jumpForce = 450f;
                }
                else
                {
                    _jumpForce = value;
                }
                
            }
        }


        private void Awake()
        {
            _rigidbody2D= GetComponent<Rigidbody2D>();  
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //transform.Translate(Vector3.right * 0.01f); this script just for practising.
            //transform.position += Vector3.right * 0.01f; still practising.
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody2D.AddForce(Vector3.up * JumpForce);
            }            }
            
        }
    }


