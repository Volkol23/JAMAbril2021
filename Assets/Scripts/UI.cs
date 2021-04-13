using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Text BlackText;
    [SerializeField] Text WhiteText;
    // Start is called before the first frame update
    void Start()
    {
        BlackText.text = "0/8";
        WhiteText.text = "0/8";
    }

    // Update is called once per frame
    void Update()
    {
        BlackText.text = GameManager.instance.GetBlackPoints().ToString() + "/8";
        WhiteText.text = GameManager.instance.GetWhitePoints().ToString() + "/8";
    }
}
