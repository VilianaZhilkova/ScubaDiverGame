using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
using Assets.Scripts.Interfaces;
using Assets.Scripts;
using Assets.Scripts.Walls_And_Regulations;
using UnityEngine.UI;

namespace Assets.Scripts
{

    class GameEngine : MonoBehaviour
    {
        //Fields
        private static GameObject player;
        private static SliderController slider;
        private bool reachedBoss = false;
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
            slider = new SliderController();
            Player = GameObject.FindGameObjectWithTag("Player");
            StartCoroutine(LoadEnemies());
        }

        public void Update()
        {
            if (slider.Progress >0.7f && reachedBoss == false)
            {
                reachedBoss = true;
                LoadBoss();
            }
        }


        //Methods
        private IEnumerator LoadEnemies()
        {
            while (!reachedBoss)
            {
                yield return new WaitForSeconds(1);
                var temp = ObjectFactory.CreateRandomFish();
            }
        }
        private void LoadBoss()
        {
            var temp = ObjectFactory.CreateBoss();
        }
    }
}
