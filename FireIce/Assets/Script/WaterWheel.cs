using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWheel : MonoBehaviour
{
    public bool isFrozen;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFrozen)
        {
            transform.Rotate(new Vector3(1, 0, 0) * speed * Time.deltaTime, Space.Self);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerFire"))
        {
            isFrozen = false;
        }
        else if (other.CompareTag("PlayerIce"))
        {
            isFrozen = true;
        }

    }
}
