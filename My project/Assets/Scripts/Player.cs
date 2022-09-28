using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0f;
    private float speed;
    private Vector3 velocity;
    private Vector3 distance;

    void start()
    {
        speed = movementSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        speed = movementSpeed;
        velocity = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);
        distance = velocity * speed * Time.deltaTime;
        transform.Translate(distance);
    }
}
