using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRotador : MonoBehaviour
{

    public int speed = 100;

    int rotatingSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0), Space.World);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0), Space.World);
        }
    }
}
