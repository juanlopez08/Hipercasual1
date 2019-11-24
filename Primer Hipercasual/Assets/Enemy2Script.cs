using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    private int contador = 0;

    void OnCollisionEnter(Collision other)
    {
        
        
        if (other.gameObject.name.Equals("paredeste"))
        {
            contador = contador + 1;
            Debug.Log("CHOQUE");
        }
        if (other.gameObject.name.Equals("paredOeste"))
        {
            contador = contador - 1;
        }

       

    }


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (this.contador == 0)
        {
            this.transform.Translate(new Vector3(1, 0, 0) * 20f * Time.deltaTime);
        }
        if (contador == 1)
        {
            this.transform.Translate(new Vector3(-1, 0, 0) * 20f * Time.deltaTime);
        }


    }
}
