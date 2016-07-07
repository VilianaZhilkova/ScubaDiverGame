using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class Boss : Enemy
    {
        private int hp = 100;
        public Boss(GameObject obj) : base(obj)
        {
            this.Obj = obj;
            this.Possition = new Vector3(20, 0, -1);
            this.Obj.transform.position = this.Possition;
        }

        public void Start()
        {
            
        }
        public void Update()
        {

        }
        public void FixedUpdate()
        {
            if(this.transform.position.x > 7 )
            {
                Move(0.05f);
            }
        }
    }
}
