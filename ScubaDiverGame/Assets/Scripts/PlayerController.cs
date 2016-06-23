using UnityEngine;
using Assets.Scripts;
using System;
using Assets.Scripts.Interfaces;

public class PlayerController : MonoBehaviour, IPlayer, IGameObject
{
    //public
    public float movementSpeed = 1;
    //public int jumpLenght;
    //private
    //private Rigidbody2D rb;
    //private bool isClicked;
    private float maxX = 7.4f;
    private float minX = -3.9f;
    private float maxY = 3.1f;
    private float minY = -3.1f;

    public void Start()
    {
        //this.rb = this.GetComponent<Rigidbody2D>();
    }

    //read input / change graphics
    public void Update()
    {
        Move(movementSpeed);
    }

    //Methods
    public void Move(float speed)
    {
        //this.isClicked = Input.GetButtonDown("Fire1");

        this.transform.Translate(speed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
        this.transform.Translate(0, speed * Time.deltaTime * Input.GetAxis("Vertical"), 0);
        

        if (this.transform.position.x > maxX)
        {
            this.transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        else if (this.transform.position.x < minX)
        {
            this.transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        if (this.transform.position.y > maxY)
        {
            this.transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
        else if(this.transform.position.y < minY)
        {
            this.transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
    }

    //apply physics
    public void FixedUpdate()
    {
        //Move(movementSpeed);
        //if (isClicked)
        //{
        //    Console.WriteLine("Clicked");
        //    Jump(jumpLenght);
        //    isClicked = false;
        //}
    }

}
