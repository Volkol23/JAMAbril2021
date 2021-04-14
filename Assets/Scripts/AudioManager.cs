using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource[] mysounds;

    private AudioSource clicked;
    private AudioSource backgroundMusic;

    // Start is called before the first frame update
    private void Awake()
    {
        mysounds = GetComponentsInParent<AudioSource>();
        //mysounds[0] = clicked;
        //Debug.Log(mysounds[0]);
        clicked = mysounds[0];
        backgroundMusic = mysounds[1];
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClicked()
    {
        clicked.Play();
    }
    public void PlayBackground()
    {
        backgroundMusic.Play();
    }

}
