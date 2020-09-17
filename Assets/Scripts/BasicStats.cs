using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStats : MonoBehaviour
{
    public static GameObject currentMouseOver;
    public static Color randColor;
    public GameObject textToDisplay;
    public int health;
    public string characterName;
    public string characterType;

    void Start()
    {
        randColor = new Color32((byte)Random.Range(60, 255), (byte)Random.Range(60, 255), (byte)Random.Range(60, 255), 255);
    }


    void OnMouseEnter()
    {
        currentMouseOver = gameObject;
        textToDisplay.SetActive(true);
    }

    void OnMouseExit()
    {
        textToDisplay.SetActive(false);
        randColor = new Color32((byte)Random.Range(60, 255), (byte)Random.Range(60, 255), (byte)Random.Range(60, 255), 255);
    }
    
}
