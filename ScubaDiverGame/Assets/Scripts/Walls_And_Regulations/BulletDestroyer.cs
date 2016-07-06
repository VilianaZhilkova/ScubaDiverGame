using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Walls_And_Regulations
{
    class BulletDestroyer : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Bullet")
            {
                Destroy(col.gameObject);
            }
        }
    }
}
