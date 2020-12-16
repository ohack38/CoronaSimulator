using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanController : MonoBehaviour
{
    //public GameObject destination;
    public Transform[] waypoints;
    int WayPointPicker;
    public GameObject Sphere;
    NavMeshAgent agent;
    bool infected;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.SetDestination(destination.transform.position);
        SetRandomDestination();
        infected = Sphere.GetComponent<Sprinkler>().infected;
        if(infected){
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.red;
        }
    }
    void SetRandomDestination(){
        agent.destination = waypoints[Random.Range(0,4)].position;

    }
    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
                SetRandomDestination();
    }
    
   
}
