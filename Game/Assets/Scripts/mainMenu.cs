/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 mainMenu.cs
  * \Date:   12/01/2019
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
  private GameObject player;
  
  /*
   * @ pre none
   * @ param none
   * @ post start the game if you pressed button
   * @ return none
   */
  public void startGame()
  {
    SceneManager.LoadScene("Town");
  }

  /*
   * @ pre none
   * @ param none
   * @ post exit the game if you pressed button
   * @ return none
   */
  public void exitGame()
  {
    Application.Quit();
  }

  /*
   * @ pre none
   * @ param none
   * @ post load the test scene if you pressed the button
   * @ return none
   */
  public void Test()
  {
    SceneManager.LoadScene("TestScene");
  }
}
