using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailInteraction : MonoBehaviour
{
    public string Element;
    public GameObject WaterPrefab;
    public GameObject IcePrefab;
    public GameObject Fire;
    void Start()
    {
        Fire.SetActive(false);
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
    public void WaterInIce()
    {
        Instantiate(IcePrefab, gameObject.transform.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public void CampfireActivation()
    {
        Fire.SetActive(true);
    }
}
