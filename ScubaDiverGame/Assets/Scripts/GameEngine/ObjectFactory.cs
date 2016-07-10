using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Interfaces;
using Assets.Scripts.Player;
using Assets.Scripts.Player.Bullets;
using UnityEngine;

namespace Assets.Scripts
{

    public class ObjectFactory : MonoBehaviour
    {
        private static System.Random rand = new System.Random();
        //Fishes
        private static GameObject urchinPrefab;
        private static GameObject bonePrefab;
        private static GameObject squidPrefab;
        private static List<GameObject> fishEnemies;

        //Bullet
        private static GameObject bullet;
        private static GameObject specialBullet;

        //Boss
        private static GameObject bossPrefab;
        private static GameObject bossAttack1;
        private static GameObject bossAttack2;
        private static GameObject bossAttack3;

        //Bullets Creation
        public static IBullet CreateSimpleBullet(Vector3 pos)
        {
            return new SimpleBullet(Instantiate(bullet, pos, new Quaternion()) as GameObject);
        }
        public static IBullet CreateSpeshialBullet(Vector3 pos)
        {
            return new SpecialBullet(Instantiate(specialBullet, pos, new Quaternion()) as GameObject);
        }

        //Enemies Creaation
        public static IEnemy CreateRandomFish()
        {
            var fishRNG = rand.Next(0, 3);
            var temp = new Fish(Instantiate(fishEnemies[fishRNG]) as GameObject);
            return temp;
        }
        public static IEnemy FirstAttack()
        {
            return new Fish(Instantiate(bossAttack3) as GameObject);
        }
        public static IEnemy SecondAttack()
        {
            return new Fish(Instantiate(bossAttack2) as GameObject);
        }
        public static IEnemy LastAttack()
        {
            return new Fish(Instantiate(bossAttack1) as GameObject);
        }
        public static IEnemy CreateBoss()
        {
            return new Boss(Instantiate(bossPrefab));
        }

        public void Start()
        {
            //LoadBoss
            bossPrefab = (Resources.Load("BOSS") as GameObject);
            bossAttack1 = (Resources.Load("bossAttack1") as GameObject);
            bossAttack2 = (Resources.Load("bossAttack2") as GameObject);
            bossAttack3 = (Resources.Load("bossAttack3") as GameObject);

            //LoadFishes
            urchinPrefab = (Resources.Load("UrchinFish") as GameObject);
            bonePrefab = (Resources.Load("BoneFish") as GameObject);
            squidPrefab = (Resources.Load("Squid") as GameObject);

            //load Bullet
            bullet = (Resources.Load("Bullet") as GameObject);
            specialBullet = (Resources.Load("SpecialBullet") as GameObject);
            fishEnemies = new List<GameObject> { urchinPrefab, bonePrefab, squidPrefab };
        }


    }
}
