using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   // private bool isJump = false;
    public float Speed;
    public float RSpeed;
    // Start is called before the first frame update
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AxisMove();

        if (Input.GetKey(KeyCode.Mouse0))
        {
            StartCoroutine(AttackCor());
        }
    }

    public void AxisMove()
    {
        bool Horizental = false;
        bool Vertical = false;
        float axisValueH = Input.GetAxis("Horizontal");
        float axisValueV = Input.GetAxis("Vertical");

        //Debug.Log(axisValueH);
        float RotateSpeed = RSpeed * Time.deltaTime;
        float SpeedPerSec = Speed * Time.deltaTime;
        float yRotate = RotateSpeed * axisValueH;
        float xSpeed = SpeedPerSec * axisValueH;
        float zSpeed = SpeedPerSec * axisValueV;

        Horizental = BisWalk (axisValueH);
        Vertical = BisWalk(axisValueV);
        animator.SetBool("isWalking", Horizental);
        animator.SetBool("isWalking", Vertical);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -RotateSpeed);
            animator.SetBool("isWalking", true);
            //transform.Translate(-zSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(0f, 0f, -zSpeed);
            transform.Rotate(Vector3.up, RotateSpeed);
            animator.SetBool("isWalking", true);
        }
        /*if(Mathf.Abs(axisValueH) > 0)
        {
            transform.Rotate(Vector3.up,RotateSpeed);
        }*/
       

        transform.Translate(xSpeed, 0, zSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 5, 0));


        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 30f;
            animator.SetBool("isRun", true);
            RSpeed = 200;

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = 10f;
            animator.SetBool("isRun", false);
            RSpeed = 100;
        }
    }

    private bool BisWalk(float axisValue/*,float axisValueV*/)
    {

        if (Mathf.Abs(axisValue) > 0)return true;
       // if (Mathf.Abs(axisValueV) > 0) return true;
        return false;
        
    }


    IEnumerator AttackCor()
    {
        animator.SetBool("isAttack", true);
        Speed = 0;
       // RSpeed = 0;
        yield return new WaitForSeconds(0.2f);

        animator.SetBool("isAttack", false);
        Speed = 10;
       // RSpeed = 0;
    }
}

