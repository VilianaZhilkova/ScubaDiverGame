using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Assets.Scripts;
using Assets.Scripts.Interfaces;

namespace Assets.Scripts
{
    public enum Enemies
    {
        
    }
    public abstract class Enemy : MonoBehaviour , IEnemy
    {
        //Fields
        private GameObject obj;
        private  Rigidbody2D rb;
        private  Vector2 possiton;
        private float dmg;



        //Props
        public float Dmg
        {
            get;set;
        }

        public  Vector2 Possition
        {
            get;set;
        }
        public Rigidbody2D Rb
        {
            get;set;
        }
        public GameObject Obj
        {
            get;set;
        }
       

        //Constructor
       

        public Enemy(GameObject obj) : base()
        {
           // Debug.Log(Rb.transform.position.x);
        }





        //Unity Methods

        public virtual void Attack(float damage, float speed)
        {

            //this.rb.AddForce(new Vector2(-speed, 0));
        }
        
    }
}
