using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public float rotSpeed = 0.5f;

    private void Awake()
    {
        StartCoroutine(Animate());    
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Snake>() != null)
        {
            Debug.Log("Food");
            ScoreManager.score += 10;
            Manager.FoodMr.SpawnFood();
            Destroy(this.gameObject);
        }
    }

    private IEnumerator Animate()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        yield return new WaitForEndOfFrame();
    }
}
