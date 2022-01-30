using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    GameObject GameOverPopUp;

    // Start is called before the first frame update
    void Start()
    {
        GameOverPopUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount < 2)
        {
            SpawnGameOverPopUp();
        }
    }

    public void SpawnGameOverPopUp()
    {
        GameOverPopUp.SetActive(true);
    }


}
