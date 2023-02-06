using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ballsssy;
    public GameObject spawnLocation;
    public GameObject bottle;
    //public bool spawned = false;
    //float timer = Time.time + 1f;
    public float spawnInterval = 1f;
    public float time = 0.1f;
    public float localEul;
    void Start()
    {
       
    }

    void Update()
    {

        localEul = bottle.transform.localEulerAngles.x;
        if ((bottle.transform.localEulerAngles.x >= 80 && bottle.transform.localEulerAngles.x <= 280) || bottle.transform.localEulerAngles.z >= 80 && bottle.transform.localEulerAngles.z <= 280)
        {
            time -= Time.deltaTime;
            if (time<=0)
            {
                Debug.Log(time);
                time = 0.1f;
                SpawnObject();
            }
 
        }

    }

    void SpawnObject()
    {
        Instantiate(ballsssy, spawnLocation.transform.position, Quaternion.identity);
    }

}
