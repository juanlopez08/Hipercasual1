﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{

    public float speed;
    private Transform target;
    


    void OnCollisionEnter(Collision collision)
    {

        
        if (collision.gameObject.name.Equals("DestructorEnemigo"))
        {
            
                Destroy(this.gameObject);
                
            

        }
    }


    // Start is called before the first frame update
    void Start()
    {

        
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        

    }


  

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }
}
