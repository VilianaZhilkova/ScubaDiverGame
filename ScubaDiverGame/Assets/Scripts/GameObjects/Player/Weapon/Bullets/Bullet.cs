using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.Bullets
{
    public abstract class Bullet : Weapon, IBullet
    {
        private GameObject obj;
        private static float speed;
        private float dmg;

        public Bullet(GameObject obj) 
        {
            this.obj = obj;
        }
        public float Speed
        {
            get { return speed; }
            protected set { speed = value; }
        }
        public float Damage
        {
            get { return this.dmg; }
            protected set { this.dmg = value; }
        }
        public new void Start()
        {
            speed = 0.2f;
        }
    }
}
