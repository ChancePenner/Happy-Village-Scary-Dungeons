using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void exitGame()
    {
//    Debug.Log("Exiting game");
        Application.Quit();
    }
}
