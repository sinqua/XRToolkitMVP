using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashlightFeature : BaseFeature
{
    [Header("Flashlight Configuration")]
    [SerializeField]
    private Transform flashlightPivot;

    [SerializeField]
    private bool on = false;

    [Header("Interaction Configuration")]
    [SerializeField]
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable?.activated.AddListener((s) =>
        {
            ToggleFlashlight();
        });
    }
    private void ToggleFlashlight()
    {
        on = !on;
        flashlightPivot.GetComponentInChildren<Light>().enabled = on;
        
        if(on) PlayOnStarted();
        else PlayOnEnded();
    }
}
