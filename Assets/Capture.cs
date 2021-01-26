using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capture : MonoBehaviour
{
    public Camera captureCamera;
    public RenderTexture renderTexture;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(CaptureImage());
        }
    }

    IEnumerator CaptureImage()
    {
        captureCamera.targetTexture = renderTexture;
        yield return null;
        captureCamera.targetTexture = null;
    }
}
