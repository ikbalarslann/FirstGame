using FirstGame.Abstracts.Spawners;
using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;
        protected override void Spawn()
        {
            
            Instantiate(enemy, this.transform);
        }
    }
}

