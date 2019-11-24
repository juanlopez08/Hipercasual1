using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    Activador1 act = new Activador1();
    public float speed;
    private Transform target;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (act.activar2enemy == true)
            {
                target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }

            Debug.Log(act.activar2enemy);
        
    }
}
