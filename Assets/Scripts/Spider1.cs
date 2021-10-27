using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider1 : MonoBehaviour
{
    public float Speed;
    public float RSpeed;

    //public Rigidbody rigidbody;

    private void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    public void Update()
    {
        SpdierMove();
    }

     public void SpdierMove()
     {
        float RotateSpeed = RSpeed * Time.deltaTime;
        float MoveSpeed = Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
         {
             transform.Translate(0f, 0f, MoveSpeed);
         }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -RotateSpeed);
            transform.Translate(-MoveSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, RotateSpeed);
            transform.Translate(MoveSpeed, 0f, 0f);
        }
    }
    /*public void SpiderJump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector3.up * 10f;
        }

    }*/
}
