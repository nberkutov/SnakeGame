using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    [SerializeField] private Text scoreText;
    [SerializeField] private Text livesText;
    [SerializeField] private GameObject gameOverMessage;
    [SerializeField] private SaveResultWindow saveResult;

    private void Update()
    {
        scoreText.text = "Score: " + Game.score;
        livesText.text = "Lives: " + Game.lives;

        if(Game.lives == 0)
        {
            gameOverMessage.SetActive(true);
        }
    }
}
