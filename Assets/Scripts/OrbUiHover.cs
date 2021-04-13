using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbUiHover : MonoBehaviour
{
    [SerializeField] GameObject[] Orbs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowOrbs()
    {
        foreach (var orb in Orbs)
        {
            orb.gameObject.SetActive(true);
        }
    }

    public void HideOrbs()
    {
        foreach (var orb in Orbs)
        {
            orb.gameObject.SetActive(false);
        }
    }
}
