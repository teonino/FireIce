using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideRotatingBridge : MonoBehaviour
{
    public WaterWheel waterWheel;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!waterWheel.isFrozen)
        {
            transform.Rotate(new Vector3(0, 0, -1) * speed * Time.deltaTime, Space.Self);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

    }
}
