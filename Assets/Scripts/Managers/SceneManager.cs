using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public static FoodManager foodManager;
    public static bool pause = false;

    void Start () {
        foodManager = GetComponent<FoodManager>();
        foodManager.SpawnFood();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
        }
        Time.timeScale = pause ? 0 : 1;
    }

    public void LoadMenu()
    {
        Application.LoadLevel(0);
    }
}
