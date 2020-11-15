using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float speed;
    public float max;
    public char tra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tra == 'x')
        {
            this.gameObject.transform.Translate(speed, 0, 0);
            if (this.gameObject.transform.position.x > max || this.gameObject.transform.position.x < (-max))
            {
                speed *= -1;
            }
            return;
        }

        if (tra == 'z')
        {
            this.gameObject.transform.Translate(0, 0, speed);
            if (this.gameObject.transform.position.z > max || this.gameObject.transform.position.z < (-max))
            {
                speed *= -1;
            }
            return;
        }
    }
}
