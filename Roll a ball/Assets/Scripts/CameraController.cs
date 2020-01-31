using UnityEngine;
using System.Collections;
//@author : Sai Vinay Gangadharabhatla - sganga10
//version : 1.0 
public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}