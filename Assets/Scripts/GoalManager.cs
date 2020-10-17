using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{
    public GameObject player;
    public GameObject goalText;
    private bool isGoal = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGoal && Input.GetMouseButton(0))
        {
            Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            goalText.GetComponent<Text>().text = "Goal!\n画面クリックで再スタート";
            goalText.SetActive(true);
            isGoal = true;
        }
    }

    private void Restart()
    {
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
    }
}
