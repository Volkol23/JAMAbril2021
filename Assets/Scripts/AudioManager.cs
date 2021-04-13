using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource[] mysounds;

    private AudioSource damage;
    // Start is called before the first frame update
    void Start()
    {
        mysounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
