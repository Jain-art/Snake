using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFood : MonoBehaviour
{
    public float Speed = 2;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Random.Range(380 * -1, 80) * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Random.Range(100 * -1, 80) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test");
        if (other.CompareTag("Bord"))
        {
            
            transform.Rotate(Vector3.up *( 180f+Random.Range(80 * -1, 80) )* Time.deltaTime);
            return;
        }
       
    }
}
