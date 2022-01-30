using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatanaMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //move left
            this.transform.position = this.transform.position + new Vector3(.05f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //move right
            this.transform.position = this.transform.position + new Vector3(-.05f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //move up
            this.transform.position = this.transform.position + new Vector3(0, 0, -.05f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //move down
            this.transform.position = this.transform.position + new Vector3(0, 0, .05f);
        }
    }
}
