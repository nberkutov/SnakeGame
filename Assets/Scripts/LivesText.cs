using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour {

    private int lives;

    private void Start()
    {
        lives = GameManager.lives;
        Text text = GetComponent<Text>();
        text.text = "Lives: " + lives;
    }
}
