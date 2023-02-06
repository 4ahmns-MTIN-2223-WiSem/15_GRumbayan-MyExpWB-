using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuerOeffner : MonoBehaviour
{
    public GameObject tuer; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tuer.transform.Translate(-1.560065f, 0f, 0f);
            Debug.Log("amkwmdkwmadwa");
        }
    }
}
