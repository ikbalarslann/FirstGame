using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        //ates topunun firlatildigi pozisyon . scripti attach ettigimiz yapi.
        [SerializeField] Transform ProjectileTransform;
        //firlatilacak yapi
        [SerializeField] ProjectileController projectile;
        //ne kadar surede firlatilacagi
        [SerializeField] float delayProjectile = 1f;

        
        //2=> right mouse clicklendiginde baslangicta fireball atmiyor.

        float _currentDelayTime;
        bool _canLaunch = false;
        private void Start()
        {
            _currentDelayTime = delayProjectile;
        }
        private void Update()
        {
            Delay();
        }

        private void Delay()
        {
            _currentDelayTime += Time.deltaTime;
            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }

        public void Fire()
        {
            if (_canLaunch)
            {
                Instantiate(projectile, ProjectileTransform.position,ProjectileTransform.rotation);
                _canLaunch = false;
            }
               
        }
        
    }
}

