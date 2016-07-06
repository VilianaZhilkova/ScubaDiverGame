using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts
{

    public  class ObjectFactory : MonoBehaviour
    {
        private static System.Random rand = new System.Random();
        //Fishes
        private static GameObject urchinPrefab;
        private static GameObject bonePrefab;
        private static GameObject squidPrefab;
        private static List<GameObject> fishEnemies;
        //Bullet
        private static GameObject bullet;
        

        public static Bullet CreateBullet(Vector3 pos)
        {
            return new Bullet(Instantiate(bullet,pos,new Quaternion()) as GameObject);
        }

        public static IEnemy CreateRandomFish()
        {
            var fishRNG = rand.Next(0, 3);
            var temp = new Fish(Instantiate(fishEnemies[fishRNG]) as GameObject);
            return temp;
        }

        public IEnemy CreateRandom(GameObject prefab)
        {
            throw new NotImplementedException();
        }

        public IEnemy CreateBubbleFish(GameObject prefab)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            //LoadFishes
            urchinPrefab = (Resources.Load("UrchinFish") as GameObject);
            bonePrefab = (Resources.Load("BoneFish") as GameObject);
            squidPrefab = (Resources.Load("Squid") as GameObject);

            //load Bullet
            bullet = (Resources.Load("Bullet") as GameObject);
            fishEnemies = new List<GameObject> { urchinPrefab, bonePrefab,squidPrefab };
        }


    }
}
