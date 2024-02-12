using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame1_easy()
    {
        Main_1Player.difficulty = 0;
        SceneManager.LoadScene("1 Player");
    }

    public void PlayGame1_medium()
    {
        Main_1Player.difficulty = 1;
        SceneManager.LoadScene("1 Player");
    }

    public void PlayGame1_hard()
    {
        Main_1Player.difficulty = 2;
        SceneManager.LoadScene("1 Player");
    }
}
