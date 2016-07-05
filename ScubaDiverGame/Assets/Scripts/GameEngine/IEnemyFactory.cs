using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IEnemyFactory
    {
        IEnemy CreateRandomFish();
        IEnemy CreateBoneFish(GameObject prefab);
        IEnemy CreateBubbleFish(GameObject prefab);
    }
}
