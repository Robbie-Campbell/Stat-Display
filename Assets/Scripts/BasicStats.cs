using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStats : MonoBehaviour
{
    public GameObject textToDisplay;
    public int health;
    public string characterType;
    public string characterName;

    public static GameObject currentMouseOver;
    public static Color randColor;
    public static bool isEntering = false;
    public static string statOutput;


    private AudioSource playEntry;
   
    IEnumerator enterTurnOff()
    {
        yield return new WaitForSeconds(0.1f);
        isEntering = false;
    }
    void Start()
    {
        randColor = new Color32((byte)Random.Range(60, 255), (byte)Random.Range(60, 255), (byte)Random.Range(60, 255), 255);
        playEntry = gameObject.GetComponent<AudioSource>();
    }

    void OnMouseEnter()
    {
        statOutput = string.Format("Health: {0}\nName: {1}\nChar Type: {2}\n", health, characterName, characterType);
        isEntering = true;
        StartCoroutine(enterTurnOff());
        playEntry.Play();
        currentMouseOver = gameObject;
        textToDisplay.SetActive(true);
    }

    void OnMouseExit()
    {
        textToDisplay.SetActive(false);
        randColor = new Color32((byte)Random.Range(60, 255), (byte)Random.Range(60, 255), (byte)Random.Range(60, 255), 255);
    }
    
}
