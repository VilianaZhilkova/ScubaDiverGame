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

        private IEnumerator Attack()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(0.5f);
                var temp = ObjectFactory.FirstAttack();
            }
            yield return new WaitForSeconds(5);
            for (int i = 0; i < 15; i++)
            {
                yield return new WaitForSeconds(0.5f);
                var temp = ObjectFactory.SecondAttack();
            }
            yield return new WaitForSeconds(5);
            for (int i = 0; i < 40; i++)
            {

                yield return new WaitForSeconds(0.2f);
                var temp = ObjectFactory.LastAttack();
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
            StartCoroutine(Attack());
        }
        public override void FixedUpdate()
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
