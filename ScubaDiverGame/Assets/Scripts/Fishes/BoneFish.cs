using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Fishes
{
    public class BoneFish : Fish
    {
        //Fields
        //TODO: MAKE PRIVATECONST!;
        private const float moveSpeed = 0.08f;
        public int demage;

        public BoneFish(GameObject obj) : base(obj)
        {

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
