using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirageFoodGenerate : MonoBehaviour
{
    public float XSize = 8.5f;
    public float ZSize = 8.0f;
    public Vector3 curPos;
    public GameObject MiragePrefab;
    public GameObject curFood;


    void AddNewMirageFood()
    {
        RandomPos();
        curFood = GameObject.Instantiate(MiragePrefab, curPos, Quaternion.identity) as GameObject;
    }

    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), -0.7f, Random.Range(ZSize * -1, ZSize));
    }
    
}
