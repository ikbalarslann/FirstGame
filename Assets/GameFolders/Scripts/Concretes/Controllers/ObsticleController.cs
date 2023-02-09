using FirstGame.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public class ObsticleController : EnemyController
    {
        public override void SetEnemyPool()
        {
            ObsticlePool.Instance.Set(this);
        }
    }
}

