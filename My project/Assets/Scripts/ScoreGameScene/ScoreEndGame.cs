using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreEndGame : MonoBehaviour
{
    // Variable para asociar el textField de score
    public TMP_Text scoreText;
    // Script EndGameMenu
    private EndGameMenu EndGameMenu;
    // Score Game
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mostramos el score
        score = EndGameMenu.instance.GetScore();
        // Modificamos el scoreText
        scoreText.text = "Score: " + score.ToString();
    }

    
}
