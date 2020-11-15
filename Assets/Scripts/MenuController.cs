using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && text.GetComponent<Text>().text == "Unity-Chan!\nRun Game\n\nClick to start.")
        {
            text.GetComponent<Text>().text = "Select stage\n\n1, 2, 3";
            return;
        }

        if (Input.GetKey("1") && text.GetComponent<Text>().text == "Select stage\n\n1, 2, 3")
        {
            SceneManager.LoadScene("Game");
            return;
        }

        if (Input.GetKey("2") && text.GetComponent<Text>().text == "Select stage\n\n1, 2, 3")
        {
            SceneManager.LoadScene("Game2");
            return;
        }

        /* if (Input.GetKey("3") && text.GetComponent<Text>().text == "Select stage\n\n1, 2, 3")
        {
            SceneManager.LoadScene("Game3");
            return;
        } */
    }
}
