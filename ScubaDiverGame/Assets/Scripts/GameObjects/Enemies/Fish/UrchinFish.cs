using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Fishes
{
    public class UrchinFish : Fish
    {
        //Fields
        private static float moveSpeed = 0.04f;
        private int angryNumber;

        //Constructor
        public UrchinFish(GameObject obj) : base(obj)
        {

        }
        //Properties
        public float MoveSpeed
        {
            get { return moveSpeed; }
        }
       
        //UnityMethods
        public new void Update()
        {
            Move(moveSpeed);
        }

        public override void Start()
        {
            base.Start();
            moveSpeed = 0.04f;
            StartCoroutine(AngryGenerator());
        }
        //Methods
        public IEnumerator AngryGenerator()
        {
            yield return new WaitForSeconds(1);
            angryNumber = Rand.Next(40, 50);
            if (angryNumber == 42)
            {
                moveSpeed = 0;
                Anim.SetBool("IsAngry", true);
                yield return new WaitForSeconds(1);
                moveSpeed = 0.1f;
            }
        }
    }
}
