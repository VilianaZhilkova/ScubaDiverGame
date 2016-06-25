using Assets.Scripts.Interfaces;
using System;
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
        public const float startingPos = 5;
        private const float fishDmg = 3;

        System.Random rand = new System.Random();



        //Properties
        public static float StartingPos
        {
            get { return startingPos; }
        }
        public float FishDmg
        {
            get { return Dmg; }
        }
        public float X
        {
            get { return this.x; }
            private set { this.x = value; }
        }
        public float Y
        {
            get { return float.Parse((rand.Next(-3, 3) * rand.NextDouble()).ToString()); }
            private set
            {
                if (value > 3 || value < -3)
                {
                    throw new InvalidProgramException("Cannot Generate Enemy Outside the bounds of the camera");
                }
                else
                {
                    this.y = value;
                }
            }
        }



        //Constructor
        public Fish(GameObject obj) : base(obj)
        {
            this.X = StartingPos;
            this.Obj = obj;
            this.Possition = new Vector3(this.X, this.Y, -1);
            this.Obj.transform.position = this.Possition;
            this.Rb = Obj.GetComponent<Rigidbody2D>();
        }


        //Methods

        public static Fish CreateRandomFish(GameObject prefab)
        {
            var temp = new Fish(Instantiate(prefab) as GameObject);
            
            return temp;

        }

        public void MoveForward()
        {

        }

        //Unity Methods
        public  void Start()
        {

            urchinPrefab = Resources.Load("UrchinFish") as GameObject;
        }
        public void Update()
        {
            Debug.Log("ataka");
            var obj = gameObject;//GameEngine.FindObjectOfType<Fish>();
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x - 0.01f;
            obj.transform.position = pos;
        }

        private void Attack()
        {
           //  var obj = GameEngine.FindObjectOfType<Fish>();
           // var pos = obj.transform.position;
           // pos.x = obj.transform.position.x - 0.002f;
           // obj.transform.position = pos;
        }
    }
}
