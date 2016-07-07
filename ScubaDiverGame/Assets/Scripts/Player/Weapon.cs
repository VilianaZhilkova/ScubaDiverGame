using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Player
{
    public class Weapon : MonoBehaviour
    {
        public float fireRate = 0.5F;
        private float nextFire = 0.0F;

        public void Shoot(GameObject shooter)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                var possition = new Vector3(shooter.transform.position.x + 1, shooter.transform.position.y, 0);
                var bullet = ObjectFactory.CreateBullet(possition);
            }


        }

    }

}
