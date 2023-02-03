using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        float _currentTime;
        void Start()
        {

        }

        void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime>3)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

