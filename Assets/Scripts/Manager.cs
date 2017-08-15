using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public static FoodManager FoodMr;
	void Start () {
        FoodMr = GetComponent<FoodManager>();
        FoodMr.SpawnFood();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
