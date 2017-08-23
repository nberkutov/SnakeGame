using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverText : MonoBehaviour {

    private void Update()
    {
        if (GameManager.lives == 0)
        {
            GetComponent<Text>().enabled = true;
        }
    }
}
