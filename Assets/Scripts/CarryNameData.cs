using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryNameData : MonoBehaviour
{
    public static string Instance;

    private void Awake()
    {
        Instance = DataHandler.nameText;
        DontDestroyOnLoad(gameObject);
    }
}
