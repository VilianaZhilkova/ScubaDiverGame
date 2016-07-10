using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.GameObjects;

namespace Assets.Scripts
{

    public abstract class Enemy : InGameObject, IEnemy
    {
        //Fields

        private const double switchTime = 2f;
        private static System.Random rand = new System.Random();
        private float life;
        private bool updateHealhBar = false;
        GameObject health;

        //Constructor
        public Enemy(GameObject obj) : base(obj)
        {

        }

        //Properties
        public float Life
        {
            get { return this.life; }
            set { this.life = value; }
        }
        //Unity Methods
        public override void Start()
        {
            base.Start();
            health = GameObject.Find("PlayerHealth");
        }
        public System.Random Rand
        {
            get { return rand; }

        }

        public virtual void FixedUpdate()
        {
            if (this.life <= 0)
            {
                Destroy(this.gameObject);
            }

            if (updateHealhBar)
            {

                var heathObject = health.GetComponent<PlayerHealth>();
                heathObject.UpdateStat(2);
                heathObject.CheckForEnd();
                Destroy(this.gameObject, 0.2f);
                updateHealhBar = false;
            }
        }

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                updateHealhBar = true;
            }
        }
        //Methods
        public abstract void ApplyDamage(float dmg);

        public void Move(float speed)
        {
            var pos = this.Possition;
            pos.x = this.Obj.transform.position.x - speed;
            this.Obj.transform.position = pos;
        }


    }
}
