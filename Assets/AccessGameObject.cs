using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessGameObject : MonoBehaviour
{

    public GameObject cube1;
    public GameObject cube2;

    // Start is called before the first frame update
    void Start()
    {
        //      GameObject.Find("Cube").transform.localScale = new Vector3(2, 5, 10);
       /* cube.transform.localScale = new Vector3(2, 5, 10);
        cube.transform.localPosition = new Vector3(3, 0, 0);
        cube.transform.localRotation = Quaternion.Euler(3, 5, 9);*/
    }

    // Update is called once per frame
    void Update()
    {
        cube1.transform.position += new Vector3(0, 0, 2 * Time.deltaTime);
    }

    void FixedUpdate()
    {
    //    cube1.transform.position += 
    }

    void OnEnable()
    {
        Debug.Log("Enable");
    }

    void OnDisable() {
        Debug.Log("Disable");
    }

}
