using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource[] mysounds;

    private AudioSource clicked;
    private AudioSource backgroundMusic;
    private AudioSource death;
    private AudioSource hit;
    private AudioSource bat;
    private AudioSource MoveMenu;
    private AudioSource spider;
    private AudioSource switchClip;
    private AudioSource walk;

    // Start is called before the first frame update
    private void Awake()
    {
        mysounds = GetComponentsInParent<AudioSource>();
        //mysounds[0] = clicked;
        //Debug.Log(mysounds[0]);
        clicked = mysounds[0];
        backgroundMusic = mysounds[1];
        death = mysounds[2];
        hit = mysounds[3];
        bat = mysounds[4];
        MoveMenu = mysounds[5];
        spider = mysounds[6];
        switchClip = mysounds[7];
        walk = mysounds[8];

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitSound(AudioSource audio)
    {
        audio.Play();
        yield return new WaitUntil(() => audio.isPlaying == false);
    }
    public void PlayClicked()
    {
        StartCoroutine(WaitSound(clicked));
    }
    public void PlayBackground()
    {
        backgroundMusic.Play();
    }
    public void PlayDeath()
    {
        StartCoroutine(WaitSound(death));
    }
    public void PlayHit()
    {
        StartCoroutine(WaitSound(hit));
    }
    public void PlayBat()
    {
        bat.Play();
    }
    public void PlayMoveMenu()
    {
        MoveMenu.Play();
    }
    public void PlaySpider()
    {
        spider.Play();
    }
    public void PlaySwitch()
    {
        StartCoroutine(WaitSound(switchClip));
    }
    public void PlayWalk()
    {
        walk.Play();
    }
}
