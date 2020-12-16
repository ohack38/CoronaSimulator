using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfectController : MonoBehaviour
{
    public bool infected;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(infected);
    }

    void OnTriggerEnter(Collider col){
        if(infected){
            if(col.gameObject.name == "Human" ){
                col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }
}

