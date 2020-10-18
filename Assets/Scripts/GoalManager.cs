using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public GameObject player;
    public GameObject goalText;
    private bool isGoal = false;
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        restart = new RestartManager(player, goalText);
    }

    // Update is called once per frame
    void Update()
    {
        if(isGoal && Input.GetMouseButton(0))
        {
            restart.Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == player.name)
        {
            restart.PrintGoal();
            isGoal = true;
        }
    }
}
