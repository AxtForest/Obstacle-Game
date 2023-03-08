using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    private int carpma;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            carpma++;
            Debug.Log("You've bumped into a thing this many times : " + carpma);
        }
        
    }
}
