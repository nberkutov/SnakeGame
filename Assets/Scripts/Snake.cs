using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour {

    public int startTailLength = 0;
    public float speed = 5f;
    public float rotSpeed = 5f;
    public float distanceBetweenSegments = 1.5f;
    public GameObject tailPrefab;

    public static bool stop = false;

    private List<Transform> tail;
    
    private bool isPaused = false;

    delegate void Delay(int num);

    private void Start()
    {
        tail = new List<Transform>();
        for(int i = 0; i < startTailLength; i++)
        {
            IncreaseTail();
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            IncreaseTail();
        }
        if (!stop)
        {
            Move();
            Turn();
        }
    }

    public void Move()
    {
        Vector3 pos = transform.position;
        Quaternion rotation = transform.rotation;
        Vector3 movement = Vector3.forward * speed * Time.deltaTime;

        transform.Translate(movement);       
        if (tail.Count > 0 && Vector3.Distance(transform.position, tail[0].position) >= distanceBetweenSegments)
        {
            tail.Last().rotation = rotation;
            new WaitForEndOfFrame();
            tail.Last().position = pos;
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }

    public void Turn()
    {
        transform.Rotate(Vector3.up, rotSpeed * Input.GetAxis("Horizontal"));
    }

    public void IncreaseTail()
    {
        GameObject g = Instantiate(tailPrefab, transform.position, transform.rotation);
        g.name = "tail" + tail.Count();
        tail.Insert(0, g.transform);

        Debug.Log(tail.Count);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Food>() != null)
        {
            IncreaseTail();
        }
        else if((tail.Count > 0 && other.gameObject != tail[0].gameObject && other.gameObject != tail[1].gameObject) || !(other.name.StartsWith("tail")))
        {
            stop = true;
            GameManager.lives--;

            //Debug.Log("Lose! " + other.name);
            if (GameManager.lives > 0)
            {
                Application.LoadLevel(1);
            }
        }
    }
}
