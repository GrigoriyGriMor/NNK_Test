using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamController : MonoBehaviour
{
    [SerializeField] private Button b_close;

    [SerializeField] private RawImage i_webCamVisual;
    [SerializeField] private TMPro.TMP_Text t_cameraNotFound;

    WebCamTexture web_texture;

    private void Start()
    {
        b_close.onClick.AddListener(() =>
        {
            DeactivateWebCam();
            gameObject.SetActive(false);
        });
    }

    public void ActivateWebCam()
    {
        if (WebCamTexture.devices.Length < 1)
        {
            t_cameraNotFound.gameObject.SetActive(true);
            t_cameraNotFound.text = "Cannot find webcam device no camera available..";
            return;
        }

        web_texture = new WebCamTexture(); 
        i_webCamVisual.texture = web_texture;
        i_webCamVisual.material.mainTexture = web_texture;

        web_texture.Play();
    }

    public void DeactivateWebCam() {
        if (web_texture) web_texture.Stop();
        t_cameraNotFound.gameObject.SetActive(false);
    }
}
