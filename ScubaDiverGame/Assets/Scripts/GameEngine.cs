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
        private static GameObject UrchinFishPrefab;
        //Properties
        public GameObject Player
        {
            get { return player; }
            set
            {
                if (value == null || value.tag != "Player")
                {
                    throw new InvalidProgramException("Player Not Imported");
                }else
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
            UrchinFishPrefab = Resources.Load("UrchinFish") as GameObject;
            StartCoroutine(LoadEnemies());
            Player = GameObject.FindGameObjectWithTag("Player");
        }


        //Methods
        private IEnumerator LoadEnemies()
        {
            for (int i = 0; i < 20; i++)
            {
                yield return new WaitForSeconds(2);
                var temp = Fish.CreateRandomFish(UrchinFishPrefab);

            }

        }
    }
}
