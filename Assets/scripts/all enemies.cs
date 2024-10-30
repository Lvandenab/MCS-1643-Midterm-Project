using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allenemies : MonoBehaviour
{
    public float movespeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * movespeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("wall"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-0.25f);
            movespeed *= -1.0f;
        }
    }
}
