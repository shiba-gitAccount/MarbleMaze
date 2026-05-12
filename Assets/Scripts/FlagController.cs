using UnityEngine;

public class FlagController : MonoBehaviour
{
    public Material barMaterial;
    public Material clothMaterial;
    Renderer[] childRenderers;

    void Start()
    {
        childRenderers = GetComponentsInChildren<Renderer>();
    }

    public void ColorChange()
    {
        foreach (Renderer ren in childRenderers)
        {
            if (ren.gameObject.name == "Cloth")
            {
                ren.material = clothMaterial;
            }
            else
            {
                ren.material = barMaterial;
            }
        }
    }
}
