using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // [SerializeField]private Player player; 
    void OnTriggerEnter(Collider other)
    {   
            Destroy(gameObject);
    }
}
