using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System; 

public class Teleport : MonoBehaviour
{
    public Transform targetPos;
    public GameObject player; 

    void OnTriggerEnter(Collider col)
    {
        player.transform.position = targetPos.transform.position; 
    }
}
