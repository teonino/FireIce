using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Ice"))
        {
            other.transform.parent.GetComponent<TrailInteraction>().IceOnRiver();
        }
        if (other.CompareTag("PlayerFire"))
        {
            Destroy(other.gameObject);
        }
    }
}
