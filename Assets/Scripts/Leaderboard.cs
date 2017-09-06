using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {

    [SerializeField] Text table;

    private void Update()
    {
        Show();
    }
    public void Show()
    {
        if (DataManager.results.Count > 0)
        {
            table.text = string.Empty;
            for (int i = 0; i < DataManager.results.Count; i++)
            {
                table.text += DataManager.results[i].name + "   " + DataManager.results[i].score + "\n";
            }
            Debug.Log(table.text);
        }
        else
        {
            table.text = " No results";
        }
    }

    public void OpenWindow()
    {
        gameObject.SetActive(true);
    }

    public void CloseWindow()
    {
        gameObject.SetActive(false);
    }
}
