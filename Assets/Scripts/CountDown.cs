using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public int time = 3;
    public float delay = 1f;

    Text text;

    private void Awake()
    {
        //Time.timeScale = 0;
        text = GetComponent<Text>();

        
        StartCoroutine(StartCountDown());
    }

    private IEnumerator StartCountDown()
    {
        Snake.stop = true;
        for (int i = time; i > 0; i--)
        {
            text.text = string.Empty + i;
            yield return new WaitForSeconds(delay);
        }
        Snake.stop = false;
        gameObject.SetActive(false);
    }
}
