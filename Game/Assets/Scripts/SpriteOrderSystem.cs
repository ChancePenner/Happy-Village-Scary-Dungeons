//using UnityEngine;
//using yaSingleton;
//
//[CreateAssetMenu(fileName = "SpriteOrderSystem", menuName = "Systems/SpriteOrderSystem")]
//public class SpriteOrderSystem : Singleton<SpriteOrderSystem>
//{
//
//    public override void OnUpdate()
//    {
//        SpriteRenderer[] renderers = FindObjectsOfType <SpriteRenderer>();
//
//        foreach (SpriteRenderer renderer in renderers)
//        {
//            renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
//        }
//    }
//}

using UnityEngine;
using UnityEngine.Tilemaps;

public class SpriteOrderSystem : MonoBehaviour
{

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
