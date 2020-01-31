using UnityEngine;
using System.Collections;
//@author : Sai Vinay Gangadharabhatla - sganga10
//version : 1.0 
public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}