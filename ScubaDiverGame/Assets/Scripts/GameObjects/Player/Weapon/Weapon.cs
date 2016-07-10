using Assets.Scripts.GameObjects;
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
        private float fireRate = 1F;
        private float nextFire = 0.0F;
        private static int killCount;

        public Weapon()
        {
        }


        public int KillCount
        {
            get { return killCount; }
            set { killCount = value; }
        }
        public void Shoot(GameObject shooter)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                var possition = new Vector3(shooter.transform.position.x + 1, shooter.transform.position.y, 0);
                if (killCount < 20)
                {
                    var bullet = ObjectFactory.CreateSimpleBullet(possition);
                }
                else
                {
                    var bullet = ObjectFactory.CreateSpeshialBullet(possition);
                }
            }
        }
        public void Start()
        {
            killCount = 0;
        }

    }

}
