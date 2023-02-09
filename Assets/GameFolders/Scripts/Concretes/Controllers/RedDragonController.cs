using FirstGame.Abstracts.Controllers;
using FirstGame.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }
}

