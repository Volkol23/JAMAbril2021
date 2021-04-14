using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource[] mysounds;

    private AudioSource clicked;
    //private AudioSource death;

    // Start is called before the first frame update
    void Start()
    {
        mysounds = GetComponentsInParent<AudioSource>();
        mysounds[0] = clicked;
        //mysounds[1] = death;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClicked()
    {
        clicked.Play();
    }
    public void PlayDeath()
    {
        //death.Play();
    }

}
