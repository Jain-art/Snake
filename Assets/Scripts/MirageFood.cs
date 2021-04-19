using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirageFood : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            Destroy(gameObject);
           
        }
    }
}
