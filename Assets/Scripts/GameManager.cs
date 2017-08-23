using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int lives = 3;
    public static int currentLevel = 0;

    
    //public static int score = 0;

    public void LoadMenu()
    {
        Application.LoadLevel(0);
    }

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
