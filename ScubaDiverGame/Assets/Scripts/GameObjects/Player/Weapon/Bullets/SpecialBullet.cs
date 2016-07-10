using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.Bullets
{
    public class SpecialBullet : Bullet, IBullet
    {
        //fields
        private const float dmg = 8;
        //constructor

        public SpecialBullet(GameObject obj) : base(obj)
        {
            this.Damage = dmg;
        }
        //properties

        //UnityMethods
        public void Update()
        {
            Move();
        }
        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Enemy")
            {
                this.KillCount += 1;
                Debug.Log("Kill Count: " + this.KillCount);
                this.Speed = 0;
                this.gameObject.GetComponent<Animator>().SetBool("didExplode", true);
                col.SendMessage("ApplyDamage", dmg);
                Destroy(this.gameObject, 0.2f);
            }
        }

        public void Move()
        {
            var obj = this.gameObject;
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x + this.Speed;
            obj.transform.position = pos;
        }
    }
}
