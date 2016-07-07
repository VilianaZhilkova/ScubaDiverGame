using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Interfaces;
using System.Collections;

namespace Assets.Scripts
{
    public enum Enemies
    {

    }
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



        //Props

        public Vector2 Possition
        {
            get; set;
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
            get; set;
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

        public void Move(float speed)
        {

            var obj = gameObject;
            var pos = obj.transform.position;
            pos.x = obj.transform.position.x - speed;
            obj.transform.position = pos;
        }
       

        //Unity Methods

        public virtual void Attack(float damage, float speed)
        {

            //this.rb.AddForce(new Vector2(-speed, 0));
        }

    }
}
