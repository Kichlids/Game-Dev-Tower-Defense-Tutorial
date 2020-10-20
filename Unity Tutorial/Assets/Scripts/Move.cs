using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform cubeTransform;

    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        cubeTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move with WASD

        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) {
            direction.z = 1;
        }
        if (Input.GetKey(KeyCode.A)) {
            direction.x = -1;
        }
        if (Input.GetKey(KeyCode.S)) {
            direction.z = -1;
        }
        if (Input.GetKey(KeyCode.D)) {
            direction.x = 1;
        }

        cubeTransform.Translate(direction.normalized * speed);
    }
}
