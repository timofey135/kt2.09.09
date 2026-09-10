using UnityEngine;

public class LightRegulate : MonoBehaviour
{
    [SerializeField] public Light targetLight;
    [SerializeField] protected float MaxMeaningIntensity = 4f;
    [SerializeField] protected float MinMeaningIntensity = 0f;
    [SerializeField] protected float SppedMeaningIntensity = 0.1f;
}
