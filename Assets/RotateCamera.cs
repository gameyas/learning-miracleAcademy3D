using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    public float speedX = 2.0f;
    public float speedY = 2.0f;

    float axisY = 0.0f;
    float axisX = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axisX += speedX * Input.GetAxis("Mouse X");
        axisY -= speedY * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(axisY, axisX, 0f);
    }
}
