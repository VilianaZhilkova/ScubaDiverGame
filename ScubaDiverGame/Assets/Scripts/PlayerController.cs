using UnityEngine;
using Assets.Scripts;
using System;
using Assets.Scripts.Interfaces;

public class PlayerController : MonoBehaviour, IPlayer, IGameObject {
    //public
    public int jumpLenght;
    public int movementSpeed;
    //private
    private Rigidbody2D rb;
    private bool isClicked;
    
    

    
    public void Start () {
        this.rb = this.GetComponent<Rigidbody2D>();
	}
	
    //read input / change graphics
	public void Update () {

        this.isClicked = Input.GetButtonDown("Fire1");
        
    }
    //apply physics
    public void FixedUpdate()
    {
        Move(movementSpeed);
        if (isClicked)
        {
            Console.WriteLine("Clicked");
            Jump(jumpLenght);
            isClicked = false;
        }
    }

    //Methods
    public void Move(int speed)
    {
        this.rb.AddForce(new Vector2(movementSpeed, 0));
        Console.WriteLine("Move");
    }

    public void Jump(int jumpLenght)
    {
        this.rb.AddForce(new Vector2(0, jumpLenght));
    }
}
