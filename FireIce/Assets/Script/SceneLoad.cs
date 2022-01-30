using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Tutorial scene");
    }
    public void LoreRules()
    {
        SceneManager.LoadScene("Lore&Rules");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Quitter()
    {
        Application.Quit();
    }
}
