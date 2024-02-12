using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_1Player: MonoBehaviour
{
    private int P1Score;
    private int P2Score;
    public static int difficulty;

    public TextMeshProUGUI Score1;
    public TextMeshProUGUI Score2;

    // Start is called before the first frame update
    void Start()
    {
        P1Score = 0;
        P2Score = 0;
        difficulty = 0; 
    }

    void Update()
    {
        Score1.text = P1Score.ToString();
        Score2.text = P2Score.ToString();
    }
    
    
    public void incrementP1Score()
    {
        P1Score++;
    }
    public void incrementP2Score()
    {
        P2Score++;
    }
    public int getDifficulty()
    {
        return difficulty;
    }
    public void setDifficulty(int d)
    {
        difficulty = d;
    }
}

