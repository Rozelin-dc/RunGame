using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class DeadWallController : MonoBehaviour
{
    public float speed;
    public float max;
    public char tra;
    public GameObject player;
    public GameObject text;
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        restart = new RestartManager(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        if (restart.IsGameOver() && Input.GetMouseButton(0))
        {
            restart.Restart();
        }

        if (tra == 'x')
        {
            this.gameObject.transform.Translate(speed, 0, 0);
            if (this.gameObject.transform.position.x > max || this.gameObject.transform.position.x < (-max))
            {
                speed *= -1;
                return;
            }
        }

        if (tra == 'z')
        {
            this.gameObject.transform.Translate(0, 0, speed);
            if (this.gameObject.transform.position.z > max || this.gameObject.transform.position.z < (-max))
            {
                speed *= -1;
                return;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == player.name)
        {
            restart.PrintGameOver();
        }
    }
}
