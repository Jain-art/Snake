using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirageFood : MonoBehaviour
{
    oid OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<FoodGeneration>().AddNewFood();
            Destroy(gameObject);
        }
    }
}
