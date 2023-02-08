using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Abstracts.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        float _currentTime = 0f;

        void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > 8f)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
