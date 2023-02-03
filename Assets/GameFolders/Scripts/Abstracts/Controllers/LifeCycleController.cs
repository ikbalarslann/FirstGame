using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Abstracts.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        float _currentTime;

        void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > 5)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
