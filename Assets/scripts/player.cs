using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float speed = 0;
    private float shootCoolTime;
    private float angle = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("start วิ");
        print(speed);
    }

    // Update is called once per frame
    void Update()
    {
        speed = speed*(float)0.998;
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                angle -= (float)0.05;
                speed -= (float)0.01;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                angle += (float)0.05;
                speed -= (float)0.01;
            }
            

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                angle -= (float)0.05;
                speed += (float)0.01;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                angle += (float)0.05;
                speed += (float)0.01;
            }
            
        }
        angle = angle * (float)0.998;
        transform.Rotate(0, angle, 0);
        transform.Translate(0, 0, speed/2);
        

    }
}
