using FirstGame.Abstracts.Spawners;
using FirstGame.Controllers;
using FirstGame.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        
        protected override void Spawn()
        {
            EnemyController newEnemy = RedDragonPool.Instance.Get();
            newEnemy.transform.position=transform.position;
            newEnemy.gameObject.SetActive(true);
            
        }
    }
}

