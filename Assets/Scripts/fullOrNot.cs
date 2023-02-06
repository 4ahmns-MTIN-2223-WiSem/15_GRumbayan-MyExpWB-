using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullOrNot : MonoBehaviour
{
    //public MeshCollider colliderSphereCup;
    public float timer = 150;
    public int count = 0;
    public Collider triggerCounter;
    public Text countText;
    public Text finishedText;
    public GameObject sexText;
    void Start()
    {
        count = 0;
        countText.text = count.ToString() + "/35";
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 34)
        {
            count = 34;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ballCountable")
        {
            count++;
            countText.text = count.ToString() + "/35";
            if (count == 35)
            {
                sexText.SetActive(true);
                finishedText.text = "Danke für deine Hilfe! Du kannst nun weiter den Christkindlmarkt besuchen.";
                StartCoroutine(WaitAbitHabibi());
                
            }
        }
        
        IEnumerator WaitAbitHabibi()
        {
            yield return new WaitForSeconds(5);
            sexText.SetActive(false);
        }
    }
    //public int BodenKollision()
    //{
       
   // }
}
