using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    public Rigidbody rb;
    public Transform player;
    public float forwardForce = 400f; //f because double (d) is the default float datatype in c# but unitys default is float so we force C# compiler to treat this as float by adding f
    public float sidewaysForce = 400f;

    // Update is called once per frame
    //FixedUpdate because Unity likes it more when we mess with physics
    void FixedUpdate()
    {
        //rb.AddForce(forwardForce * Time.deltaTime, 0, 0); //added force on x axis, Time.deltaTime is 1/FPS to even out the force on all devices with different framerates

        if( Input.GetKey("d") ){
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if( Input.GetKey("a") ){
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if( Input.GetKey("w") ){
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if( Input.GetKey("s") ){
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
