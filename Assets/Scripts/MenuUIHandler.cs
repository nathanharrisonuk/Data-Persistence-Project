using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
   

    public void toMain()
    {
        SceneManager.LoadScene(1);
    }
}
