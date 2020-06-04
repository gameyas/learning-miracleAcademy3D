using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardScript : MonoBehaviour
{

    [SerializeField] Button[] btn;
    bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Button btn in btn)
        {
            Button choice = btn; // need to store in separate variable to have the right button in the lamda expression
            btn.onClick.AddListener(() => TaskOnClick(choice));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Panah Atas");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Panah Bawah");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Panah Kiri");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Panah Kanan");
        }

        ///////
        
        else if (Input.GetKeyDown("a"))
        {
            Debug.Log("A");
        }
        else if (Input.GetKeyDown("b"))
        {
            Debug.Log("B");
        }
        else if (Input.GetKeyDown("c"))
        {
            Debug.Log("C");
        }
        else if (Input.GetKeyDown("d"))
        {
            Debug.Log("D");
        }

        

    }

    void TaskOnClick(Button choice)
    {
        if (choice.gameObject.tag == "buttonA")
        {
            Debug.Log("Tombol A");
        }
        else if (choice.gameObject.tag == "buttonB")
        {
            Debug.Log("Tombol B");
        }
        else if (choice.gameObject.tag == "buttonC")
        {
            Debug.Log("Tombol C");
        }
        else if (choice.gameObject.tag == "buttonD")
        {
            Debug.Log("Tombol D");
        }
    }

}
