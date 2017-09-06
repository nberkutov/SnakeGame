using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveResultWindow : MonoBehaviour {

    [SerializeField] private InputField inputField;

    public void Save()
    {
        DataManager.Save(inputField.text, Game.score);
        GameManager.LoadMenu();
    }

    public void Cancel()
    {
        GameManager.LoadMenu();
    }

	public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
