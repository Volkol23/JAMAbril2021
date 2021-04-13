using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour
{
    [SerializeField] GameObject lightMap;
    //[SerializeField] Animator animator;
    [SerializeField] GameObject darkMap;
    [SerializeField] GameObject emptyPos;

    public int mapLevel; // 0 DARK 1 LIGHT
    private Vector3 lightCurrentPos;
    private Vector3 DarkCurrentPos;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        lightMap = GameObject.FindGameObjectWithTag("Light");
        darkMap = GameObject.FindGameObjectWithTag("Dark");
        lightCurrentPos = lightMap.transform.position;
        DarkCurrentPos = darkMap.transform.position;
        mapLevel = 0;
        SwitchDark();
        //SwitchLight(lightSwitch);
    }

    // Update is called once per frame
    void Update()
    {
        if(lightMap == null)
        {
            lightMap = GameObject.FindGameObjectWithTag("Light");
        }
        if (darkMap == null)
        {
            darkMap = GameObject.FindGameObjectWithTag("Dark");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mapLevel == 0) {
                SwitchLight();
                mapLevel = 1;
            } else if (mapLevel == 1)
            {
                SwitchDark();
                mapLevel = 0;
            }
        }
    }

    public void SwitchDark()
    {
            MakeInvisible(lightMap);
            MakeVisible(darkMap);
    }
    public void SwitchLight()
    {
            MakeInvisible(darkMap);
            MakeVisible(lightMap);
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
