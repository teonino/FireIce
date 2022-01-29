using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public GameObject fires0;
    public GameObject fires1;
    public GameObject fires2;
    public string Element;
    void Start()
    {
        fires0.SetActive(false);
        fires1.SetActive(false);
        fires2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator BurnBridge()
    {

        fires0.SetActive(true);
        fires1.SetActive(true);
        fires2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
