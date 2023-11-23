using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //人物控制器
    private CharacterController controller;
    //人物移动速度
    public float speed = 2f;
    public float gravity = -15f;
    Vector3 velocity;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
       Move();
    }
    public void Move()
    {
        //键盘输入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x != 0 || z!= 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube01")
        {
            TipsMgr.Instance.SetTipsText("欢迎来到太空");
        }
        else if (other.gameObject.name == "Cube02")
        {
            TipsMgr.Instance.SetTipsText("欢迎进入太空站");
        } 
        else if (other.gameObject.name == "Cube03")
        {
            TipsMgr.Instance.SetTipsText("太空站蔬菜培训室");
        } 
        else if (other.gameObject.name == "Cube04")
        {
            TipsMgr.Instance.SetTipsText("太空站办公区域");
        } 
        else if (other.gameObject.name == "Cube05")
        {
            TipsMgr.Instance.SetTipsText("太空站操作区域");
        } 
        else if (other.gameObject.name == "Cube06")
        {
            TipsMgr.Instance.SetTipsText("太空站休闲区域");
        } 
        else if (other.gameObject.name == "Cube07")
        {
            TipsMgr.Instance.SetTipsText("太阳能组1");
        }
        else if (other.gameObject.name == "Cube08")
        {
            TipsMgr.Instance.SetTipsText("太阳能组2");
        }
        else if (other.gameObject.name == "Cube09")
        {
            TipsMgr.Instance.SetTipsText("太阳能组3");
        }
        else if (other.gameObject.name == "Cube10")
        {
            TipsMgr.Instance.SetTipsText("太阳能组4");
        }
    }
}
