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
        //TODO: MAKE PRIVATECONST!;

        //TODO: FIX CONSTANTS!
        private float moveSpeed;
        public int demage;
        private int angryNumber;



        //Constructor
        public UrchinFish(GameObject obj) : base(obj)
        {

        }

        //Properties
        public float MoveSpeed
        {
            get { return this.moveSpeed; }
        }

        //Methods
        public IEnumerator AngryGenerator()
        {
            yield return new WaitForSeconds(1);
            angryNumber = Rand.Next(40, 50);
            if (angryNumber == 42)
            {
                this.moveSpeed = 0;
                Anim.SetBool("IsAngry", true);
                yield return new WaitForSeconds(1);
                this.moveSpeed = 0.1f;
            }
        }
        //UnityMethods
        public void Update()
        {
            Move(moveSpeed);
        }

        public override void Start()
        {
            base.Start();
            this.moveSpeed = 0.04f;
            StartCoroutine(AngryGenerator());
        }
    }
}
