using Assets.Scripts.Interfaces;
using System;
using System.Collections;
using UnityEngine;


namespace Assets.Scripts
{
    public class Fish : Enemy
    {
        //Fields
        private static GameObject urchinPrefab;
        private static Quaternion quat = new Quaternion();

        private float x;
        private float y;
        private float scaleZ;
        
        public const float startingPos = 10;
        private const float fishDmg = 3;


        //Constructor
        public Fish(GameObject obj) : base(obj)
        {
            this.X = StartingPos;
            this.Obj = obj;

            this.Possition = new Vector3(this.X, this.Y, -1);
            this.Obj.transform.position = this.Possition;

            this.Scale = new Vector3(1, 1, ScaleZ);
            this.Obj.transform.localScale = this.Scale;

            this.Rb = obj.GetComponent<Rigidbody2D>();
        }


        //Properties
        public static float StartingPos
        {
            get { return startingPos; }
        }
        public float X
        {
            get { return this.x; }
            private set { this.x = value; }
        }
        public float Y
        {
            get { return float.Parse((Rand.Next(-3, 5) * Rand.NextDouble()).ToString()); }
            private set { this.y = value; }
        }
        public float ScaleZ
        {
            get { return float.Parse((Rand.Next(3, 6) * Rand.NextDouble()).ToString()); }
            private set { this.scaleZ = value; }
        }





        //Methods
        public void Move(float speed)
        {
            var obj = gameObject;
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x - speed;
            obj.transform.position = pos;
        }
        public IEnumerator Charge()
        {
            yield return new WaitForSeconds(2);

        }



        //Unity Methods

        private void Attack()
        {
            //  var obj = GameEngine.FindObjectOfType<Fish>();
            // var pos = obj.transform.position;
            // pos.x = obj.transform.position.x - 0.002f;
            // obj.transform.position = pos;
        }
    }
}
