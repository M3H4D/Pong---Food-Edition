using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MainGameLoop : MonoBehaviour
{
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getScore()
    {
        return Score;
    }

    public void setScore(int score)
    {
        Score = score;
    }
}

