using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.Bullets
{
    public abstract class Bullet : Weapon
    {
        private GameObject obj;
        private static float speed = 0.2f;
        private float dmg;

        public Bullet(GameObject obj)
        {
            this.obj = obj;
        }
        public GameObject Obj
        {
            get { return this.obj; }
        }
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public float Damage
        {
            get { return this.dmg; }
            internal set { this.dmg = value; }
        }
        public void Start()
        {
            speed = 0.2f;
        }
    }
}
