using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverText : MonoBehaviour {

    private void Update()
    {
        if (Snake.loss)
        {
            GetComponent<Text>().enabled = true;
        }
    }
}
