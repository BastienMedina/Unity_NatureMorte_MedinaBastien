using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ReduceSmoothness : MonoBehaviour
{
    [Range(0f, 1f)]
    public float smoothness = 0.15f;

    private Renderer rend;
    private MaterialPropertyBlock block;

    void Awake()
    {
        rend = GetComponent<Renderer>();
        block = new MaterialPropertyBlock();

        rend.GetPropertyBlock(block);
        block.SetFloat("_Smoothness", smoothness);
        rend.SetPropertyBlock(block);
    }
}
