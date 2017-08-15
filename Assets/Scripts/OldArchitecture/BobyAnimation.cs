using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobyAnimation : MonoBehaviour {

    public float speed = 1f;
    private void Update()
    {
        transform.Rotate(Vector3.left, -10f * speed);
    }
}
