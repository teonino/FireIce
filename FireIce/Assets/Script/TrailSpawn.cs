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
            Instantiate(FirePrefab, new Vector3(gameObject.transform.transform.position.x, gameObject.transform.transform.position.y + 1, gameObject.transform.transform.position.z), Quaternion.identity);
        }
        else if (Element == "Ice")
        {
            Instantiate(IcePrefab, new Vector3(gameObject.transform.transform.position.x, gameObject.transform.transform.position.y + 1, gameObject.transform.transform.position.z), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrail == false)
        {
            if (Element == "Fire")
            {
                Instantiate(FirePrefab, new Vector3(gameObject.transform.transform.position.x, gameObject.transform.transform.position.y + 1, gameObject.transform.transform.position.z), Quaternion.identity);
            }
            else if (Element == "Ice")
            {
                Instantiate(IcePrefab, new Vector3(gameObject.transform.transform.position.x, gameObject.transform.transform.position.y + 1, gameObject.transform.transform.position.z), Quaternion.identity);
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        
            
        try
        {
            if (collision.GetComponent<TrailInteraction>().Element == "Something")
            {

            }
            inTrail = true;
        }
        catch
        {

        }
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
        try
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
        catch
        {

        }
    }
    private void OnTriggerExit(Collider collision)
    {
        try
        {
            if (collision.GetComponent<TrailInteraction>().Element == "Something")
            {

            }
            inTrail = false;
        }
        catch
        {

        }
    }

}
