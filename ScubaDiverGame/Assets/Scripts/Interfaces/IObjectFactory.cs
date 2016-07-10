using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Interfaces;
using UnityEngine;
using Assets.Scripts.Player.Bullets;

namespace Assets.Scripts
{
    public interface IObjectFactory
    {
        IBullet CreateSimpleBullet(Vector3 pos);
        IBullet CreateSpeshialBullet(Vector3 pos);

        IEnemy CreateRandomFish();
        IEnemy CreateBoss();

        IEnemy FirstAttack(GameObject prefab);
        IEnemy SecondAttack(GameObject prefab);
        IEnemy LastAttack();
    }
}
