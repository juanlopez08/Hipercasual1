using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador1 : MonoBehaviour
{
    public bool activar2enemy = false;

   
    public Activador1()
    {
        
    }


    

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name.Equals("Player"))
        {
            activar2enemy = true;
            Debug.Log("Activar 2do Enemy");
            Debug.Log(activar2enemy);

        }
    }

   

    // Update is called once per frame
    void Update()
    {

    }
}
