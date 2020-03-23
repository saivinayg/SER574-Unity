using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    public GameObject Doves;
    public GameObject Hawks;
    public GameObject Fooditems;
    public new Text name;
    private Vector3 Min;
    private Vector3 Max;
    private float axisX;
    private float axisY;
    private float axisZ;
    private Vector3 _randomPos;
    public bool _canInstant;

    void Start()
    {
        setRanges();
    }

    private void setRanges() 
    {
        Min = new Vector3(2, 4, 0);
        Max = new Vector3(20, 40, 0);
    }

    private void initRandom()
    {
        axisX = UnityEngine.Random.Range(Min.x, Max.x);
        axisY = UnityEngine.Random.Range(Min.y, Max.y);
        axisZ = UnityEngine.Random.Range(Min.z, Max.z);
        _randomPos = new Vector3(axisX, axisY, axisZ);
    }

    void Update()
    {
        initRandom();
        Instantiate(Doves, _randomPos, Quaternion.identity);
        initRandom();
        Instantiate(Hawks, _randomPos, Quaternion.identity);
        initRandom();
        Instantiate(Fooditems, _randomPos, Quaternion.identity);
        if (_canInstant)
        {

        }
    }
}
