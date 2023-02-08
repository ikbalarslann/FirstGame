using FirstGame.Abstracts.Controllers;
using FirstGame.Uis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FirstGame.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        //Projectile collisionu enemy collisionuna carptiginda unity bunu algilayamiyor bunun nedeni Projectile kinematic rigidbodye sahip enemylerde ayni skilde kinemeatic unit manualinde matrix yazar.
        

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            GameManager.Instance.IncreaseScore();
            
        }

    }

}
