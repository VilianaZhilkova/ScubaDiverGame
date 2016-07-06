using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Bullet : MonoBehaviour
    {
        //fields
        private GameObject obj;
        private static float speed = 0.2f;
        //constructor

        public Bullet(GameObject obj)
        {
            this.obj = obj;
        }
        //properties

        //UnityMethods
        public void Update()
        {
            var obj = gameObject;
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x + speed;
            obj.transform.position = pos;
        }
        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Enemy")
            {
                var anim = col.GetComponent<Animator>();
                anim.SetBool("IsDead", true);
                Destroy(col.gameObject, 0.3f);
                Destroy(this.gameObject);
            }
        }

    }
}
