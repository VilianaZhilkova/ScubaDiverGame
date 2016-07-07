using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Boss : Enemy
    {
        private const int startingHP = 100;

        public Boss(GameObject obj) : base(obj)
        {
            this.Obj = obj;
            this.Possition = new Vector3(20, 0, -1);
            this.Obj.transform.position = this.Possition;
        }

        public void Update()
        {
            if (this.transform.position.x > 7)
            {
                Move(0.05f);
            }
        }

        public override void ApplyDamage(float dmg)
        {
            Debug.Log(this.Life);
            this.Life -= dmg;
        }

        public override void Start()
        {
            base.Start();
            this.Life = startingHP;
        }
        public void FixedUpdate()
        {
            if (this.Life <= 0)
            {
                this.Anim.SetBool("IsDead", true);
                this.Rb.isKinematic = false;
                this.Scale = new Vector3(5, 5, 2);
                this.transform.localScale = this.Scale;
                StartCoroutine(LoadGameOver());
            }
        }

        public IEnumerator LoadGameOver()
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("GameOver");
        }
    }
}
