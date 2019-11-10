using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
  public void startGame()
  {
//    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //will use for loading town for real game
    SceneManager.LoadScene("Dungeon1");
  }

  public void exitGame()
  {
    Debug.Log("Exiting game");
    Application.Quit();
  }
}
