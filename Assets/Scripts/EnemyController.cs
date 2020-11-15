using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityChan;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!target.GetComponent<UnityChanControlScriptWithRgidBody>().enabled)
        {
            agent.isStopped = true;
        }

        agent.destination = target.position;
    }
}
