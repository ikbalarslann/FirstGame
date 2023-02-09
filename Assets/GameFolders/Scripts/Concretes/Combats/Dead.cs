using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Combats
{
    public class Dead : MonoBehaviour
    {
        [SerializeField] bool _isDead = false;
        public bool IsDead => _isDead;
        public event System.Action  OnDead;
      

        
        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead= true;
            Time.timeScale=0f;
            
            OnDead?.Invoke();
        }
    }
}

