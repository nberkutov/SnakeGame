using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SnakeOld : MonoBehaviour
{
    public float speed = 5f;
    public float rotSpeed = 5f;
    public float distanceBetweenSegments = 1.5f;
    public GameObject tailPrefab;

    private bool ate = false;
    private bool lose = false;
    private List<Transform> tail;

    private void Start()
    {
        tail = new List<Transform>();
    }

    private void Update()
    {
        float axisRaw = 0;
        if (Input.anyKeyDown)
        {
            axisRaw = Input.GetAxisRaw("Horizontal");
        }
        
        //Debug function
        if (Input.GetKey(KeyCode.Q))
        {
            ate = true;
        }
        Move();
        Turn();
    }

    private void Move()
    {
        Vector3 pos = transform.position;
        Quaternion rotation = transform.rotation;
        Vector3 movement = Vector3.forward * speed * Time.deltaTime;
        transform.Translate(movement);

        if (ate)
        {
            GameObject g = Instantiate(tailPrefab, pos, transform.rotation);
            tail.Insert(0, g.transform);
            ate = false;
            Debug.Log(tail.Count);
        }
        else if (tail.Count > 0 && Vector3.Distance(transform.position, tail[0].position) >= distanceBetweenSegments)
        {
            tail.Last().rotation = rotation;
            tail.Last().position = pos;
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }

    public void Turn()
    {
        transform.Rotate(Vector3.up, rotSpeed * Input.GetAxis("Horizontal"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Food>() != null)
        {
            Debug.Log("Snake");
            ate = true;
        }
        else
        {
            lose = true;
            //Debug.Log("Lose");
        }
    }
}
