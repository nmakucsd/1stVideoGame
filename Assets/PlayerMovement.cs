using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the Rigidbody component called "rb"
	public Rigidbody rb; 

    public float forwardForce = 2000;
    public float moveForce = 800f;
    public float jumpForce = 5000f;
    // Start is called before the first frame update
    void Start () {
        //rb.useGravity = false;                  //deactivate gravity
    }

    // Update is called once per frame
    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force of 2000 on the z-axis
        
        //move forward
        if(Input.GetKey("w") ){
            rb.AddForce(0, 0, moveForce * Time.deltaTime);
        }
        //move forward
        if(Input.GetKey("s") ){
            rb.AddForce(0, 0, -moveForce * Time.deltaTime);
        }
        //move left
        if(Input.GetKey("a") ){
            rb.AddForce(-moveForce * Time.deltaTime, 0, 0);
        }
        //move right
        if(Input.GetKey("d") ){
            rb.AddForce(moveForce * Time.deltaTime, 0, 0);
        }


        
       if (Input.GetKey("space") ){
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }    
    } 
}
