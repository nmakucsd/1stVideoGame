using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    //this vector stores 3 values for the offset of the camera
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        //FollowPlayer script is under the Main Camera Object

        //1st Person Code
            //the position of the camera is the position of the player
            //transform.position = player.position;

        //3rd Person Code
            //the position of the camera is the position of the player + offset
            transform.position = player.position + offset;


    }
}
