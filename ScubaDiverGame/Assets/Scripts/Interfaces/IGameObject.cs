namespace Assets.Scripts.Interfaces
{
    using UnityEngine;

    public interface  IGameObject
    {        
        GameObject Obj { get; }
        Rigidbody2D Rb { get; }
        Vector3 Possition { get; }
        Vector3 Scale { get; }
        Animator Anim { get; }

    }
}
