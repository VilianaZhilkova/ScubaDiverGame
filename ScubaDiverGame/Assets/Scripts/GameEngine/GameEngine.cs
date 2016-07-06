using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts;

namespace Assets.Scripts
{
    class GameEngine : MonoBehaviour
    {
        //Fields
        private static GameObject player;
        private GameObject obj;
        //Properties
        public GameObject Player
        {
            get { return player; }
            set
            {
                if (value == null || value.tag != "Player")
                {
                    throw new InvalidProgramException("Player Not Imported");
                }
                else
                {
                    player = value;
                }
            }
        }

        //Constructor
        public GameEngine()
        {

        }


        //Unity Methods
        public void Start()
        {
            Player = GameObject.FindGameObjectWithTag("Player");
            StartCoroutine(LoadEnemies());
        }
        public void Update()
        {

        }


        //Methods
        private IEnumerator LoadEnemies()
        {
            while (true)
            {
                yield return new WaitForSeconds(2);
                var temp = ObjectFactory.CreateRandomFish();
            }
        }
    }
}
