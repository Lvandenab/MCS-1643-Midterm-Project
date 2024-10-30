using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbullet : MonoBehaviour
{
    public float movespeed = 2.0f;
    public float direction = 1.0f;
    public KeyCode down;
    public KeyCode up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(down))
        {
            direction = 0.0f;
        }
        else if (Input.GetKey(up))
        {
            direction = 1.0f;
        }
        if (direction == 0.0f)
        {
            Quaternion lookdown = Quaternion.AngleAxis(180, Vector3.up);
            transform.rotation = lookdown;
        }
        else if (direction == 1.0f)
        {
            Quaternion lookup = Quaternion.AngleAxis(0, Vector3.up);
            transform.rotation = lookup;
        }
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("hittem");
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
      
        }
        else if (other.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
            
        }

    }

}
