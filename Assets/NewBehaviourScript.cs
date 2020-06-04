using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int[] angka;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World Start");
        Debug.Log(angka[0]);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World Update");
    }
}
