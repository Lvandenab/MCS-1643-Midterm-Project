using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileshoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public KeyCode shoot;
    private int bulletout = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (bulletout == 0.0f)
        {
            if (Input.GetKeyDown(shoot))
            {
                //bulletout = + 1;
                Instantiate(BulletPrefab, transform.position, Quaternion.identity);

            }

        }

    }
    /*public void add()
    { 
        bulletout++;
    
    }
    public void adding(int bulletout)
    {
        add();
    
    }*/
}
