using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomGeneration : MonoBehaviour
{
    public float XSize = 8.5f;
    public float ZSize = 8.0f;
    public Vector3 curPos;
    public GameObject mushroomPrefab;
    public GameObject curMushroom;


    void AddNewMirageMushroom()
    {
        RandomPos();
        curMushroom = GameObject.Instantiate(mushroomPrefab, curPos, Quaternion.identity) as GameObject;
    }

    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize), -0.7f, Random.Range(ZSize * -1, ZSize));
    }
    void Update()
    {
        if (!curMushroom)
        {
            AddNewMirageMushroom();
        }
        else
        {
            return;
        }
    }
}
