using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
  private GameObject player;
  public void startGame()
  {
//    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //will use for loading town for real game
    SceneManager.LoadScene("Town");
  }

  public void exitGame()
  {
//    Debug.Log("Exiting game");
    Application.Quit();
  }

  public void Test()
  {
    SceneManager.LoadScene("TestScene");
//    Debug.Log("Test Suite");
  }
}
