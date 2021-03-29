using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirageMushroom : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<MirageFoodGenerate>().AddNewMirageFood();
            Destroy(gameObject);
        }
    }
}
