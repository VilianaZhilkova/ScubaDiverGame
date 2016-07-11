using UnityEngine;
using Assets.Scripts.Enumerations;

namespace Assets.Scripts.Fishes
{
    public class BoneFish : Fish
    {
        //Fields
        //TODO: MAKE PRIVATECONST!;
        //private const float moveSpeed = 0.08f;

        private float moveSpeed;

        //Constructor
        public BoneFish(GameObject obj) : base(obj)
        {
        }
        

        //Properties
        public float MoveSpeed
        {
            get
            {
                return ((float)FishesMoveSpeed.BoneFishMoveSpeed )/ 100;
            }
        }

        //Methods


        //UnityMethods
        public new void Update()
        {
            Move(MoveSpeed);
        }
    }
}
