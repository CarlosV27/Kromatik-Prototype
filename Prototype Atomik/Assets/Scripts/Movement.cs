using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public Text velocimeter;
    public AudioSource corridosBienTumbadotes;

    private float speed;
    private Rigidbody rigid_car;
    private Transform transf_car;

    private void Start()
    {
        rigid_car = GetComponent<Rigidbody>();
        transf_car = GetComponent<Transform>();
        speed = 0.0f;
        corridosBienTumbadotes.Play();
    }
    

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            if (speed < 150.0f)
            {
                speed += 2.0f;
            }

            rigid_car.AddForce(0, 0, speed);
        }
        else
        {
            if (speed > 0.0f)
            {
                speed -= 2.0f;
            }
        }

        if(Input.GetKey(KeyCode.D))
        {
            transf_car.Rotate(0 ,0.5f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transf_car.Rotate(0 ,-0.5f, 0);
        }
        
        velocimeter.text = speed.ToString();
    }
}
