using UnityEngine;

public class CandleAnimation : MonoBehaviour
{
    [SerializeField] private float Rotation_Speed = 100f;
    [SerializeField] private float MinScale = 1f;
    [SerializeField] private float MaxScale = 1.2f;
    [SerializeField] private float ScaleFrequency = 4.5f;

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.AngleAxis(Rotation_Speed * Time.deltaTime, Vector3.up);
        float amplitude2 = (MaxScale - MinScale);
        float sinY = amplitude2 + Mathf.Sin(Time.time * ScaleFrequency) * amplitude2 * 0.5f;
        transform.localScale = new Vector3(1, MinScale + sinY, 1);
    }
}
