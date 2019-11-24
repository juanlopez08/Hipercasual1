using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCubo : MonoBehaviour
{

    protected Joystick joystick;
    protected Joybutton joybutton;


    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

    }

    // Update is called once per frame
    void Update()
    {
        
        


        
    }

}
