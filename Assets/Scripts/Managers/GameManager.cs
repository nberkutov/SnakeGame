using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static int startLives = 3;
    public static int score = 0;

    public static Game game;

    private void Awake()
    {
        DataManager.Load();
    }

    public static void LoadMenu()
    {
        Application.LoadLevel(0);
    }

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }

    public void StartGame()
    {
        game = new Game();
        Application.LoadLevel(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
