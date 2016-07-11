using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Enumerations;

namespace Assets.Scripts.Fishes
{
    public class Squid : Fish
    {
        //Fields
        //TODO: MAKE PRIVATECONST!;
        //private const float moveSpeed = 0.01f;   SquidMoveSpeed = 0.01f;
        private float moveSpeed;
        public int demage;

        public Squid(GameObject obj) : base(obj)
        {
            Debug.Log("Made Squid");
        }

        //Constructor


        //Properties
        public float MoveSpeed
        {
            get
            {
                return ((float)FishesMoveSpeed.SquidMoveSpeed)/100;
            }
        }

        //Methods


        //UnityMethods
        public new void Update()
        {
            Move(MoveSpeed);
        }
    }
}
