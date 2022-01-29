using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    public GameObject campFire;
    void Start()
    {
        campFire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerFire"))
        {
            campFire.SetActive(true);
        }

    }
}

