using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Interfaces
{
    public interface IEnemy
    {
        float Life { get; set; }
        void Move(float speed);
        void ApplyDamage(float dmg);
    }
}
