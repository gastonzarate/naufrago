using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    
    void Start()
    {

    }

    public void lowQuality()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void mediumQuality()
    {
        QualitySettings.SetQualityLevel(2);
    }

    public void HighQuality()
    {
        QualitySettings.SetQualityLevel(4);
    }

    public void UltraQuality()
    {
        QualitySettings.SetQualityLevel(5);
    }
}
