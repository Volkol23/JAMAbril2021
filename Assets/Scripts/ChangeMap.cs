using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour
{
    [SerializeField] GameObject lightMap;
    //[SerializeField] Animator animator;
    [SerializeField] GameObject darkMap;
    [SerializeField] GameObject emptyPos;

    public AudioManager audioManager;
    public int mapLevel; // 0 DARK 1 LIGHT
    private int Level;
    private Vector3 lightCurrentPos;
    private Vector3 DarkCurrentPos;
    // Start is called before the first frame update
    private void Awake()
    {
        lightMap = GameObject.FindGameObjectWithTag("Light");
        darkMap = GameObject.FindGameObjectWithTag("Dark");
        emptyPos = GameObject.FindGameObjectWithTag("Empty");
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        lightCurrentPos = lightMap.transform.position;
        DarkCurrentPos = darkMap.transform.position;
        mapLevel = -1;
        Level = 0;
        SwitchDark();
    }
    void Start()
    {
        //animator = GetComponent<Animator>();
       
        
        //SwitchLight(lightSwitch);
    }

    // Update is called once per frame
    void Update()
    {
        if(audioManager == null)
        {
            audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();

        }
        if(lightMap == null)
        {
            lightMap = GameObject.FindGameObjectWithTag("Light");
        }
        if (darkMap == null)
        {
            darkMap = GameObject.FindGameObjectWithTag("Dark");
        }
        if(emptyPos == null)
        {
            emptyPos = GameObject.FindGameObjectWithTag("Empty");
        }
        if (Input.GetKeyDown(KeyCode.E) && mapLevel == -1)
        {
            audioManager.PlaySwitch();
            mapLevel = 2;
            if (mapLevel == 2 && Level == 0) {
                SwitchLight();
                Level = 1;
            } else if (mapLevel == 2 && Level == 1)
            {
                SwitchDark();
                Level = 0;
            }
        }
    }

    public void SwitchDark()
    {
        MakeInvisible(lightMap);
        MakeVisible(darkMap);
        mapLevel = -1;
    }
    public void SwitchLight()
    {
        MakeInvisible(darkMap);
        MakeVisible(lightMap);
        mapLevel = -1;
    }
    public int GetMapLevel()
    {
        return mapLevel;
    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (lightMap.activeInHierarchy)
        {
            //animator.SetBool("ChangeToDark", true);
            lightMap.SetActive(false);
            darkMap.SetActive(true);
        }
        else if (darkMap.activeInHierarchy)
        {
            //animator.SetBool("ChangeToDark", false);
            lightMap.SetActive(true);
            darkMap.SetActive(false);
        }
    }*/
   void MakeInvisible(GameObject map)
   {
        map.transform.position = emptyPos.transform.position;
   }
    void MakeVisible(GameObject map)
    {
        if (map.gameObject.tag == "Light") map.transform.position = lightCurrentPos;
        else if (map.gameObject.tag == "Dark") map.transform.position = DarkCurrentPos;
    }
}
