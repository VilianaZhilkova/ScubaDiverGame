using Assets.Scripts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.GameObjects
{
    public abstract class InGameObject : MonoBehaviour, IGameObject
    {
        private GameObject obj;
        private Rigidbody2D rb;
        private Vector3 possiton;
        private Vector3 scale;
        private Animator anim;

        //Constructor
        public InGameObject(GameObject obj)
        {

        }

        public GameObject Obj
        {
            get { return this.obj; }
            protected set { this.obj = value; }
        }
        
        public Rigidbody2D Rb
        {
            get { return this.rb; }
            protected set { this.rb = value; }
        }
        public Vector3 Possition
        {
            get { return this.possiton; }
            protected set { this.possiton = value; }
        }
        public Vector3 Scale
        {
            get { return this.scale; }
            protected set { this.scale = value; }
        }
        public Animator Anim
        {
            get { return this.anim; }
            protected set { this.anim = value; }
        }

        //Unity Methods
        public virtual void Start()
        {
            this.obj = this.gameObject;
            this.rb = this.GetComponent<Rigidbody2D>();
            this.possiton = this.transform.position;
            this.scale = this.transform.localScale;
            this.anim = this.GetComponent<Animator>();
        }
    }
}
