using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public KeyCode right;
    public KeyCode left;
    public KeyCode down;
    public KeyCode up;

    

    public float playerspeed = 5.0f;
    
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.position += Vector3.right * playerspeed * Time.deltaTime;
        }
        else if (Input.GetKey(left))
        {
            transform.position += Vector3.left * playerspeed * Time.deltaTime;
        }
        else if (Input.GetKey(down))
        {
            Quaternion lookdown = Quaternion.AngleAxis(180, Vector3.up);
            transform.rotation = lookdown;
        }
        else if (Input.GetKey(up))
        {
            Quaternion lookup = Quaternion.AngleAxis(0, Vector3.up);
            transform.rotation = lookup;
        }
    }
    

}
