using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float speed = 0;
    private float shootCoolTime;
    private float angle = 0;
    private float ySpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("start วิ");
        print(speed);
    }

    // Update is called once per frame
    void Update()
    {
        speed = speed*(float)0.98;
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                angle -= (float)0.5;
                speed -= (float)0.1;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                angle += (float)0.5;
                speed -= (float)0.1;
            }
            

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                angle -= (float)0.5;
                speed += (float)0.1;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                angle += (float)0.5;
                speed += (float)0.1;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ySpeed = 10;
        }
        angle = angle * (float)0.98;
        transform.Rotate(0, angle*5*Time.deltaTime, 0);
        transform.Translate(0, 0, speed*10*Time.deltaTime);
        if (ySpeed > 1)
        {
            ySpeed -= 1;
        }

    }
}
