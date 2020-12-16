using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprinkler : MonoBehaviour
{
    public float LifeTime;
    public GameObject WaterParticlePrefab;
    public bool infected;
    bool breath;
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        breath = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer>50){
            breath = !breath;
            timer = 0;
        }
        if(breath){
            
            GameObject Particle = Instantiate(WaterParticlePrefab);
            Particle.transform.position = transform.position + transform.forward;
            Destroy(Particle, LifeTime);
            Particle.GetComponent<Rigidbody>().AddForce(Random.Range(-2,2), Random.Range(-2,4), Random.Range(-2,2));
            Physics.IgnoreCollision(Particle.GetComponent<Collider>(), GetComponent<Collider>());

            if(infected){
                Particle.GetComponent<InfectController>().infected = true;
            }
        }
        timer++;

    }
}
