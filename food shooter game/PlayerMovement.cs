using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float xRange= 20; 
    public float speed = 15f;

    public GameObject projectileFood;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <-xRange) {
            transform.position=  new Vector3(-xRange,transform.position.y,transform.position.z);
        }else if (transform.position.x>xRange) {
              transform.position=  new Vector3(xRange,transform.position.y,transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
      
        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectileFood,transform.position, projectileFood.transform.rotation);
        }
     
    }   
}
