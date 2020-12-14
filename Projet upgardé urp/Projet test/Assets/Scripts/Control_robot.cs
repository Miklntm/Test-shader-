using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_robot : MonoBehaviour
{



    //Here I declare the speed of movement and speed of rotation
    public float speed = 1f;
    public float RotSpeed = 6f;
    //Here I declare two gameobjects which I've assigned in the inspector
    public GameObject Camera;
    public GameObject PauseMenu;
    public GameObject Player;
    //this boolean to to tell if game should be paused or not
    public static bool GamePaused;
    //Boolean to detect if player is grounded
    public bool Grounded;
    //movement forward-backwards
    float MoveFB;
    //movement left-right
    float MoveLR;
    //rotation on x and y axis
    float rotX;
    float rotY;

    void Update()
    {
        //first declare a float to hold the value of the virtual axis
        //and multiply it by the speed
        if (GamePaused == false)
        {

            MoveFB = Input.GetAxis("Vertical") * speed;
            //use transform.translate to then move the player along that axis
            //at that speed
            transform.Translate(0, 0, MoveFB);
            MoveLR = Input.GetAxis("Horizontal") * speed;
            transform.Translate(MoveLR, 0, 0);

            //now for the mouse rotation
            rotX = Input.GetAxis("Mouse X") * RotSpeed;
            rotY = Input.GetAxis("Mouse Y") * RotSpeed;



            //Camera rotation only allowed if game us not paused
            Camera.transform.Rotate(-rotY, 0, 0);
            transform.Rotate(0, rotX, 0);

        }
    }

}


