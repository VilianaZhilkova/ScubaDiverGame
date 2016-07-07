using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Fishes
{
    public class Squid : Fish
    {
        //Fields
        //TODO: MAKE PRIVATECONST!;
        private const float moveSpeed = 0.01f;
        public int demage;

        public Squid(GameObject obj) : base(obj)
        {
            Debug.Log("Made Squid");
        }

        //Constructor


        //Properties
        public float MoveSpeed
        {
            get { return moveSpeed; }
        }

        //Methods


        //UnityMethods
        public void Update()
        {
            Move(MoveSpeed);
        }
    }
}
