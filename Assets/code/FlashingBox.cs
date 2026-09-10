using UnityEngine;

public class FlashingBox : LightRegulate
{

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        targetLight.intensity = Mathf.PingPong(timer * SppedMeaningIntensity,
                                               MaxMeaningIntensity - MinMeaningIntensity)
                                               + MinMeaningIntensity;
    }
}
