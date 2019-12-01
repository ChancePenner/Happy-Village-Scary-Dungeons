/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 SpriteOrderSystem.cs
  * \Date:   12/01/2019
*/
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpriteOrderSystem : MonoBehaviour
{

    /*
     * @ pre none
     * @ param none
     * @ post update each frame
     * @ return none
     */
    public void Update()
    {
        SpriteRenderer[] renderers = FindObjectsOfType <SpriteRenderer>();
        TilemapRenderer[] tileRenderers = FindObjectsOfType<TilemapRenderer>();

        foreach (TilemapRenderer tileRenderer in tileRenderers)
        {
            tileRenderer.sortingOrder = (int)(tileRenderer.transform.position.y * -100);
        }

        foreach(SpriteRenderer renderer in renderers)
        {
            renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
        }
    }
}
