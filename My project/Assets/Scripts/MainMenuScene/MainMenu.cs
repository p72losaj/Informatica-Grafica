using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Load the scene
    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    // Exit game
    public void ExitGame()
    {
        Application.Quit();
    }
}
