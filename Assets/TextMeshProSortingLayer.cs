using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class TextMeshProSortingLayer : MonoBehaviour
{
    public string sortingLayerName = "Default";
    public int sortingOrder = 0;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.sortingLayerName = sortingLayerName;
            renderer.sortingOrder = sortingOrder;
        }
    }
}
