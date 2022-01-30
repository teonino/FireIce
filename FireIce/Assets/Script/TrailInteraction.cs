using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailInteraction : MonoBehaviour
{
    public string Element;
    public GameObject WaterPrefab;
    public GameObject IcePrefab;
    public GameObject IceRiverPrefab;
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
        Instantiate(WaterPrefab, new Vector3 (gameObject.transform.transform.position.x, gameObject.transform.transform.position.y, gameObject.transform.transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
    public void WaterInIce()
    {
        Instantiate(IcePrefab, gameObject.transform.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public void IceOnRiver()
    {
        Debug.Log("Plop2");
        Instantiate(IceRiverPrefab, new Vector3(gameObject.transform.transform.position.x, gameObject.transform.transform.position.y-1, gameObject.transform.transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
    
   
}
