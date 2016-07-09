using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player.Bullets
{
    public class SimpleBullet : Bullet
    {
        //fields
        private const float dmg = 3;
        //constructor

        public SimpleBullet(GameObject obj) : base(obj)
        {
            this.Damage = dmg;
            
        }
        //properties

        //UnityMethods
        public void Update()
        {
            var obj = gameObject;
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x + this.Speed;
            obj.transform.position = pos;
        }

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Enemy")
            {
                Debug.Log("Kill Count: "+KillCount);
                this.Speed = 0;
                this.gameObject.GetComponent<Animator>().SetBool("didExplode", true);
                col.SendMessage("ApplyDamage", dmg);
                Destroy(this.gameObject,0.2f);
                KillCount += 1;
            }
        }

    }
}
