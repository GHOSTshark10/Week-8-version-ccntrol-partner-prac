using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0f;
    private float speed;
    private Vector3 velocity;
    private Vector3 distance;


    private int playerIndex = -1;

    private Player[] player;

    void Start()
    {
        speed = movementSpeed;
        if(gameObject.CompareTag("Player 1"))
        {
            playerIndex = 0;
        }
        else if(gameObject.CompareTag("Player 2"))
        {
            playerIndex= 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(playerIndex ==0)
        {
            //MoveMethod(0)

            velocity = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        }
        else if(playerIndex ==1)
        {

            velocity = new Vector3(Input.GetAxis("Horizontal1"),0,Input.GetAxis("Vertical1"));

        }
        MoveMethod();
    }

    void MoveMethod()
    {
        distance = velocity * speed * Time.deltaTime;
        transform.Translate(distance);
    }
}
