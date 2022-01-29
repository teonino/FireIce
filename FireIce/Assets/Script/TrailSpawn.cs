using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailSpawn : MonoBehaviour
{
    public string Element;
    public GameObject FirePrefab;
    public GameObject WaterPrefab;
    public GameObject IcePrefab;
    public bool inTrail;
    void Start()
    {
        if (Element == "Fire")
        {
            Instantiate(FirePrefab, gameObject.transform.transform.position, Quaternion.identity);
        }
        else if (Element == "Ice")
        {
            Instantiate(IcePrefab, gameObject.transform.transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (inTrail == false)
        {
            if (Element == "Fire")
            {
                Instantiate(FirePrefab, gameObject.transform.transform.position, Quaternion.identity);
            }
            else if (Element == "Ice")
            {
                Instantiate(IcePrefab, gameObject.transform.transform.position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        inTrail = true;

            /*if (Element == "Fire")
            {
                if (CompareTag("Water"))
                {
                    Debug.Log("Eau");
                }
                else if (CompareTag("Fire"))
                {
                    Debug.Log("Feu");
                }
                else if (CompareTag("Ice"))
                {

                }
            } 

            /*try
            {
                if (!(collision.transform.GetComponent<TrailElement>().Element == "Fire" && ))
               {

                }
            }
            catch
            {
                Instantiate(FirePrefab, gameObject.transform.transform.position, Quaternion.identity);
            } */
        }
    private void OnTriggerEnter(Collider collision)
    {
        if (Element == "Fire")
        {
            if (collision.GetComponent<TrailInteraction>().Element == "Ice")
            {
                StartCoroutine(collision.GetComponent<TrailInteraction>().IceInWater());
            }
            else if (collision.GetComponent<TrailInteraction>().Element == "Water")
            {
                Destroy(transform.parent.gameObject);
            }
            else if (collision.GetComponent<TrailInteraction>().Element == "Campfire")
            {
                collision.GetComponent<TrailInteraction>().CampfireActivation();
            }
            else if (collision.GetComponent<Bridge>().Element == "Bridge")
            {
                StartCoroutine(collision.GetComponent<Bridge>().BurnBridge());
            }
        }
        else if (Element == "Ice")
        {
            if (collision.GetComponent<TrailInteraction>().Element == "Water")
            {
                collision.GetComponent<TrailInteraction>().WaterInIce();
            }
            else if (collision.GetComponent<TrailInteraction>().Element == "Fire")
            {
                Destroy(transform.parent.gameObject);
            }
        }

    }
    private void OnTriggerExit(Collider collision)
    {
        inTrail = false;
    }

}
