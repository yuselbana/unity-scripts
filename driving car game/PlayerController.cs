using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput  = Input.GetAxis("Vertical");

        //lowercase is the instance of class for that specific object, Translate is a method for that class. 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput) ;
        
        
    }
}

