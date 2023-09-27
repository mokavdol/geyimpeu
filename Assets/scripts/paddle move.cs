using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemove : MonoBehaviour
{
    public float spawnRate;
    public float angle = 0;
    public int rl;
    // Start is called before the first frame update
    void Start()
    {


    }
    void paddleMove()
    {
        angle = 1*rl;
        Invoke("paddleDown", (float)0.2);
    }
    void paddleDown()
    {
        angle = -1 * rl;
        Invoke("paddleEnd", (float)0.2);
    }
    void paddleEnd()
    {
        angle = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(rl == -1)
            {
                paddleMove();
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if(rl == 1)
            {
                paddleMove();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            paddleMove();
        }
        transform.Rotate(0, 0, angle);
    }
}
