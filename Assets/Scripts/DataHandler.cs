using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataHandler : MonoBehaviour
{
    public InputField inputText;
    public static string nameText;



    private void Start()
    {
        nameText = PlayerPrefs.GetString("nameTextKeyName");
        inputText.text = nameText;
    }

    public void saveName()
    {
        nameText = inputText.text;
        PlayerPrefs.SetString("nameTextKeyName", nameText);
    }
 
}
