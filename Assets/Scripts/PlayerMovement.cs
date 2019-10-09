using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to the Rigidbody component called "rb"
	public Rigidbody rb; 

    public float forwardForce = 2000;
    public float sidewaysForce = 100f;
    public float jumpForce = 5000f;
    // Start is called before the first frame update
    void Start () {
        //rb.useGravity = false;                  //deactivate gravity
    }

    // Update is called once per frame
    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force of 2000 on the z-axis
        
        //move forwards
        if(Input.GetKey("w") ){
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }
        //move backwards
        if(Input.GetKey("s") ){
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }
        //move left
        if(Input.GetKey("a") ){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //move right
        if(Input.GetKey("d") ){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        
       if (Input.GetKey("space") ){
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }    
    } 
}
