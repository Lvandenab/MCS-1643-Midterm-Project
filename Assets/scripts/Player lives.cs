using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Playerlives : MonoBehaviour
{
    public int lives = 5;
    public TextMeshProUGUI numlivestmp;


    // Start is called before the first frame update
    void Start()
    {
        //numlivestmp.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        numlivestmp.text = lives.ToString();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            lives -= 1;
            if (lives < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
