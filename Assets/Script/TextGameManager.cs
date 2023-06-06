using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI
        storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storyText;
    public int hpValue;
    public int staminaValue;
    // Start is called before the first frame update
    void Start()
    {
        storyTextMeshPro.text = storyText; 
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        storyText = "";
        hpTextMeshPro.text = hpValue.ToString();
        staminaTextMeshPro.text = staminaValue.ToString();
    }
}
