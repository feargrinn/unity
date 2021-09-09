using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float turn = 1000;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardKey = Input.GetKey(KeyCode.W);
        animator.SetBool("Forward", forwardKey);
    
        bool leftKey = Input.GetKey(KeyCode.A);
        bool rightKey = Input.GetKey(KeyCode.D);
        bool runKey = Input.GetKey(KeyCode.LeftShift);
        
        if (leftKey) {
            gameObject.transform.Rotate(0f, -turn * Time.deltaTime, 0f); // i added Time.deltaTime ;-;
        }

        if (rightKey) {
            gameObject.transform.Rotate(0f, turn * Time.deltaTime, 0f);
        }
        
        if (runKey) {
            animator.speed = 10;
        }
        else {
            animator.speed = 1;
        }


    }
}
