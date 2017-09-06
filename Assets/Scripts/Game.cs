using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {

    public static int score = GameManager.score;
    public static int lives = GameManager.startLives;
    public static int currentLevel;

    public Game()
    {
        score = 0;
        lives = GameManager.startLives;
    }
}
