using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SnakeMovment : MonoBehaviour
{
    public float Speed=3;
    public float RotationSpeed=90;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float z_offset = 0.5f;

    public GameObject TailPrefab;
    void Start()
    {
        tailObjects.Add(gameObject);
    }

    void Update()
    {
       
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -1 * RotationSpeed * Time.deltaTime);
        }
    }

    public void AddTail()
    {
        
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }
}
