using FirstGame.Abstracts.Controllers;
using FirstGame.Pools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public abstract class EnemyController :LifeCycleController
    {
        
        public override void KillGameObject()
        {
            _currentTime = 0f;
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();

        //problem ne? hem obsticle hem de redDragon EnemyController ile kontrol ediliyor RedDragon  ve Obsticle icin ayri ayri iki farkli pool hazirladik.bunlari ayirabilmemiz ve redDragonPoolu kullanabimemiz icin enemyControlleri abstract yapmamiz gerekiyor.

    }
}

