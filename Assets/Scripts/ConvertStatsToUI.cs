using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConvertStatsToUI : MonoBehaviour
{
    TextMeshProUGUI textContent;
    GameObject targetStats;
    BasicStats content;

    void Start()
    {
        textContent = gameObject.GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        targetStats = BasicStats.currentMouseOver;
        content = targetStats.GetComponent<BasicStats>();
        string statOutput = string.Format("Health: {0}\nName: {1}\nChar Type: {2}", content.health, content.characterName, content.characterType);
        textContent.text = statOutput;
        textContent.color = BasicStats.randColor;
    }
}
