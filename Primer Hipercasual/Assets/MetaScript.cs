using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name.Equals("Player"))
        {
            Debug.Log("YOU WIN");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
