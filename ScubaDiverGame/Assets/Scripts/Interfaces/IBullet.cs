using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts.Player.Bullets
{
    public interface IBullet
    {
        float Speed { get; }
        float Damage { get; }
    }
}
