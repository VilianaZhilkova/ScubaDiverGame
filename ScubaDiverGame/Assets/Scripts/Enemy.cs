using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Interfaces;
using System.Collections;

namespace Assets.Scripts
{
    
    public abstract class Enemy : MonoBehaviour, IEnemy
    {
        //Fields
        private GameObject obj;
        private Rigidbody2D rb;
        private Vector2 possiton;
        private Vector3 scale;
        private Animator anim;
        private double switchTime = 2f;
        private static System.Random rand = new System.Random();
        private float life;
        private bool updateHealhBar = false;
        private PlayerHealth health;

        //Props

        public float Life
        {
            get { return this.life; }
            set { this.life = value; }
        }
        public Vector2 Possition
        {
            get { return this.possiton; }
            set { this.possiton = value; }
        }
        public Rigidbody2D Rb
        {
            get { return this.rb; }
            set { this.rb = value; }
        }
        public GameObject Obj
        {
            get { return this.obj; }
            set { this.obj = value; }
        }
        public Vector3 Scale
        {
            get; set;
        }
        public Animator Anim
        {
            get { return this.anim; }
            set { this.anim = value; }
        }
        public System.Random Rand
        {
            get { return rand; }
            private set { rand = value; }
        }



        //Constructor

        public Enemy(GameObject obj) : base()
        {
            
        }

        public virtual void Start()
        {
            this.anim = this.GetComponent<Animator>();
            this.rb = this.GetComponent<Rigidbody2D>();
          //  health = GetComponent<PlayerHealth>();
        }

        public void Move(float speed)
        {
            var obj = gameObject;
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x - speed;
            obj.transform.position = pos;
        }
        //Unity Methods

        public abstract void ApplyDamage(float dmg);

        public virtual void FixedUpdate()
        {
            if(this.life <= 0)
            {
                Destroy(this.gameObject);
            }

            if (updateHealhBar)
            {
                GameObject go = GameObject.Find("PlayerHealth");
                go.GetComponent<PlayerHealth>().UpdateStat(2);
               // health.UpdateStat(2);
                updateHealhBar = false;

            }
        }

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                updateHealhBar = true;
                
            //  this.Speed = 0;
            // this.gameObject.GetComponent<Animator>().SetBool("didExplode", true);
          //  col.SendMessage("ApplyDamage", 2);
           // Destroy(this.gameObject, 0.2f);
            // KillCount += 1;
            }
        }

    }
}
