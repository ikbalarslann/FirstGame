using FirstGame.Abstracts.Spawners;
using FirstGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
        
        [SerializeField] EnemyController[] enemys;
        
        
     protected override  void Spawn()
        {
          int enemyindex= Random.Range(0,enemys.Length);
            Instantiate(enemys[enemyindex],this.transform);
            
        }
    }
}

