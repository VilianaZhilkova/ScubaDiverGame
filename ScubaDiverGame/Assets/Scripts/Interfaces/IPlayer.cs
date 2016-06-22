using System;

namespace Assets.Scripts
{
    interface IPlayer
    {
        void Move(int speed);
        void Jump(int jumpLenght);

    }
}
