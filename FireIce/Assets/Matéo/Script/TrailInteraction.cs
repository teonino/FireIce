using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailInteraction : MonoBehaviour
{
    public string Element;
    public GameObject WaterPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator IceInWater()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(WaterPrefab, gameObject.transform.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
