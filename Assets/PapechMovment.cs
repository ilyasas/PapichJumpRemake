using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapechMovment : MonoBehaviour
{
    public float Speed = 1f;
    public float move;
    public bool moveLeft, moveRight;
    Rigidbody2D Player;
    Camera cameramain;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        cameramain = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        size=cameramain.orthographicSize*cameramain.aspect;        
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    public void leftMove()
    {
        moveLeft = true;
    }
    public void leftStop()
    {
        moveLeft = false;
    }
    public void rightMove()
    {
        moveRight = true;
    }
    public void rightStop()
    {
        moveRight = false;
    }

    void Update()
    {
        if (moveLeft == true)
        {
            move = -1f;
        }
        else if (moveRight == true)
        {
            move = 1f;
        }
        else
        {
            move = Input.GetAxisRaw("Horizontal");
        }
        //if (Input.touchCount>0)
        //{
        //    Vector3 pos = Input.GetTouch(0).position;
        //    if (pos.x<Camera.main.pixelWidth/3)
        //    {
        //        move = -1f;
        //    }
        //    else if (pos.x > 2*Camera.main.pixelWidth / 3)
        //    {
        //        move = 1f;
        //    }
        //}
        //else
        //{
        //    move = 0;
        //}
    }
    void FixedUpdate()
    {
        Player.velocity = new Vector3(move * Speed,Player.velocity.y);
        if (transform.position.x>size)
        {
            transform.position = new Vector3(-size, transform.position.y);
        };
        if (transform.position.x < -size)
        {
            transform.position= new Vector3(size, transform.position.y);
        }

    }
}
