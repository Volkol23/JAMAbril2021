using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Camara para moverte en sitios cerrados no atravesar paredes
public class CameraClamp : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    public float leftx;
    public float rightx;
    public float upy;
    public float downy;

    void Update()
    {
        transform.position = new Vector4(
            Mathf.Clamp(player.transform.position.x, leftx, rightx),
            Mathf.Clamp(player.transform.position.y, upy, downy),
            transform.position.z);
    }

  
}