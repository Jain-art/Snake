using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SnakeMovment : MonoBehaviour
{
    public float Speed=3.5f;
    public float RotationSpeed=90;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float z_offset = 0.5f;

    public GameObject TailPrefab;

    public float XSize = 8.5f;
    public float ZSize = 8.0f;
    public Vector3 curPos;
    public GameObject mushroomPrefab;
    public GameObject curMushroom;

    public GameObject MiragePrefab;
    public GameObject curMirage;

    public GameObject foodPrefab;
    public GameObject curFood;


    //public Text ScoreText;
    //public float score = 0;
    void AddNewMirageMushroom()
    {
        RandomPos();
        curMushroom = GameObject.Instantiate(mushroomPrefab, curPos, Quaternion.identity) as GameObject;
    }

    public void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }

    public void AddNewMirageFood()
    {

        RandomPos();
        curMirage = GameObject.Instantiate(MiragePrefab, curPos, Quaternion.identity) as GameObject;
    }

    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), -0.7f, Random.Range(ZSize * -1, ZSize));
    }

    void Start()
    {
        tailObjects.Add(gameObject);
    }

    void Update()
    {
        //ScoreText.text = score.ToString();
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
        return;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MirageMushroom"))
        {
            //score = score + 5;
            Speed = Speed + 1f;
            AddTail();
            Destroy(other.gameObject);
            AddNewFood();
            AddNewMirageFood();
            return;
        }
        if (other.CompareTag("Food"))
        {
            //score = score + 2;
            Speed = Speed + 0.5f; ;
            Destroy(other.gameObject);
            AddNewFood();
            AddTail();
            return;
        }
        if (other.CompareTag("MirageFood"))
        {
            //score = score - score*20/100;
            Speed = Speed - 0.3f;
            Destroy(other.gameObject);
            AddNewMirageMushroom();
            AddNewFood();
            return;
        }
        if (other.CompareTag("Bord"))
        {
            
            Application.LoadLevel(Application.loadedLevel);
            return;
        }
        if (other.CompareTag("Оbstacle"))
        {
            if (Speed > 3) { Speed = Speed - Speed*50/100; }
            else { Speed = Speed - Speed * 20 / 100; }
            
            return;
        }
        
        return; 
    }
}
