using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Exceptions;

namespace Assets.Scripts.Player
{
    public class PlayerController : MonoBehaviour, IPlayer
    {
        //effectively public
        [SerializeField]
        private float movementSpeed = 1;
        private float maxX = 7.4f;
        private float minX = -3.9f;
        private float maxY = 2.0f; //3.1f; - changed due to health and progress bars
        private float minY = -3.1f;
        private bool facingRight;
        private bool didPressSpace;
        private static Weapon weap;

        public Weapon Weapon
        {
            get { return weap; }
            set { weap = value; }
        }

        public void Start()
        {
            facingRight = true;
            weap = new Weapon();
        }

        //read input / change graphics
        private void Update()
        {
            //change location
            float[] horizontalAndVertical = GetHorizontalAndVertical();
            Move(movementSpeed, horizontalAndVertical[0], horizontalAndVertical[1]);
            Flip(horizontalAndVertical[0]);

            didPressSpace = Input.GetButtonDown("Jump");
            if (didPressSpace)
            {
                weap.Shoot(this.gameObject);
            }
        }

        //Methods
        public void Move(float speed, float horizontal, float vertical)
        {

            this.transform.Translate(speed * Time.deltaTime * horizontal, 0, 0);
            this.transform.Translate(0, speed * Time.deltaTime * vertical, 0);

            try
            {
                CheckLocation();
            }
            catch (ObjectOutOfScreenException ex)
            {
                if (ex.IsMaxX)
                {
                    this.transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
                }
                else if (ex.IsMinX)
                {
                    this.transform.position = new Vector3(minX, transform.position.y, transform.position.z);
                }

                if (ex.IsMaxY)
                {
                    this.transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
                }
                else if (ex.IsMinY)
                {
                    this.transform.position = new Vector3(transform.position.x, minY, transform.position.z);
                }
            }
        }

        public void Flip(float horizontal)
        {
            if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
            {
                facingRight = !facingRight;
                Vector3 scale = this.transform.localScale;
                scale.x *= -1;
                this.transform.localScale = scale;
            }
        }

        public float[] GetHorizontalAndVertical()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new float[] { horizontal, vertical };
        }

        private void CheckLocation()
        {

            if (this.transform.position.x < minX || this.transform.position.x > maxX || 
                this.transform.position.y < minY || this.transform.position.y > maxY)
            {
                throw new ObjectOutOfScreenException(message: "Player is getting outside of the screen.",
                    minX: this.transform.position.x < minX,
                    maxX: this.transform.position.x > maxX,
                    minY: this.transform.position.y < minY,
                    maxY: this.transform.position.y > maxY);

            }
        }


    }
}