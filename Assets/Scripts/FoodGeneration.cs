using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour
{

    public float XSize = 8.5f;
    public float ZSize = 8.0f;
    public GameObject foodPrefab;
    public Vector3 curPos;
    public GameObject curFood;
   
    
   
    void AddNewFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }
    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), -0.7f, Random.Range(ZSize * -1, ZSize));
    }

    void Update()
    {
        if (!curFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
