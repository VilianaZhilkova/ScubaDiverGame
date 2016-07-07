using UnityEngine;
using Assets.Scripts;
using System;
using Assets.Scripts.Interfaces;
using System.Collections;

namespace Assets.Scripts.Player
{
    public class PlayerController : MonoBehaviour, IPlayer, IGameObject
    {
        //effectively public
        [SerializeField]
        private float movementSpeed = 1;
        private float maxX = 7.4f;
        private float minX = -3.9f;
        private float maxY = 3.1f;
        private float minY = -3.1f;
        private bool facingRight;
        private bool didPressSpace;
        private Weapon weap;

        public void Start()
        {
            facingRight = true;
            this.weap = new Weapon();
        }

        //read input / change graphics
        public void Update()
        {
            
            float[] horizontalAndVertical = GetHorizontalAndVertival();
            Move(movementSpeed, horizontalAndVertical[0], horizontalAndVertical[1]);
            Flip(horizontalAndVertical[0]);
            didPressSpace = Input.GetButtonDown("Jump");
            if (didPressSpace)
            {
                this.weap.Shoot(this.gameObject);
            }
        }

       

        //Methods
        private void Move(float speed, float horizontal, float vertical)
        {

            this.transform.Translate(speed * Time.deltaTime * horizontal, 0, 0);
            this.transform.Translate(0, speed * Time.deltaTime * vertical, 0);

            if (this.transform.position.x > maxX)
            {
                this.transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
            }
            else if (this.transform.position.x < minX)
            {
                this.transform.position = new Vector3(minX, transform.position.y, transform.position.z);
            }

            if (this.transform.position.y > maxY)
            {
                this.transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
            }
            else if (this.transform.position.y < minY)
            {
                this.transform.position = new Vector3(transform.position.x, minY, transform.position.z);
            }
        }

        private void Flip(float horizontal)
        {
            if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
            {
                facingRight = !facingRight;
                Vector3 scale = this.transform.localScale;
                scale.x *= -1;
                this.transform.localScale = scale;
            }
        }

        private float[] GetHorizontalAndVertival()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new float[] { horizontal, vertical };
        }

    }
}
