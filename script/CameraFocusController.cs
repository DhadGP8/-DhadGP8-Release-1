using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraFocusController : MonoBehaviour
{
    void Start()
    {
        var vuforia = VuforiaApplication.Instance;
        vuforia.OnVuforiaStarted += OnVuforiaStarted;
        vuforia.OnVuforiaPaused += OnPaused;
    }

    private void OnVuforiaStarted()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
        Vuforia.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        if (!paused) // resumed
        {
            // Set again autofocus mode when app is resumed
            VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
            Vuforia.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}