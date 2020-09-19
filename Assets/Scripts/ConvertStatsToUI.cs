using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConvertStatsToUI : MonoBehaviour
{
    TextMeshProUGUI textContent;
    GameObject targetStats;
    BasicStats content;
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        textContent = gameObject.GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        targetStats = BasicStats.currentMouseOver;
        content = targetStats.GetComponent<BasicStats>();
        textContent.text = BasicStats.statOutput;
        textContent.color = BasicStats.randColor;
        if (BasicStats.isEntering == false)
        {
            animator.SetBool("IsEntering", false);
        }
    }
}
