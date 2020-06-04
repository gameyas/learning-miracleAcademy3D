using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiggidBodyMove : MonoBehaviour
{

    public Rigidbody playerRB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, speed), ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.AddForce(new Vector3(0, 0, -speed), ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddForce(new Vector3(-speed, 0, 0), ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddForce(new Vector3(speed, 0, 0), ForceMode.VelocityChange);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            playerRB.Sleep();
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            playerRB.Sleep();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerRB.Sleep();
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerRB.Sleep();
        }
    }
}
