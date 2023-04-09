using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndGameMenu : MonoBehaviour
{

    public static EndGameMenu instance;
    private static int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
         
    }

    // Singleton
    private void Awake()
    {
        // Create the instance
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        // Delete the instance
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }


    // Get Score
    public int GetScore()
    {
        return score;
    }

    // Set Score
    public void SetScore(int i)
    {
        score = i;
    }

    


}
