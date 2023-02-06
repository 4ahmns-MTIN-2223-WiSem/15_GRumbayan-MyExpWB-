using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBbottleFall : MonoBehaviour
{
    //public Rigidbody bottleLightBlue;
    //public bool through = false;
    public AudioSource source;
    public Collider soundTrigger;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            source.Play();
            Debug.Log("Duhaunawdnwaidwad");
        }

    }
}
