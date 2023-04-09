using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public GameObject ball;
    private bool endGame;
    private float limitPosition = 0.0f;
    public static EndGameMenu instance;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindWithTag("Ball");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Load endGame scene
        if (ball.transform.position.y < limitPosition)
        {
            endGame = true;
        }
        else
        {
            endGame = false;
        }
    }

    // Print the score
    private void OnGUI()
    {
        GUILayout.Label("Score: " + score.ToString());
        if(endGame == true)
        {

            // Save the score
            EndGameMenu.instance.SetScore(score);
            // Load the EndGame Scene
            SceneManager.LoadScene("ScoreScene");
        }
    }

    
}
