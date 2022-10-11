using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button b_OpenVideo;
    [SerializeField] private Button b_OpenWebCamera;
    [SerializeField] private Button b_WebPage;

    [Header("Windows")]
    [SerializeField] private DiscriptionController discriptionModule;
    [SerializeField] private VideoPlayerController videoModule;
    [SerializeField] private WebCamController webCamModule;
    [SerializeField] private WebViewController webPageModule;

    #region functional windows
    private void Start()
    {
        if (videoModule)
            b_OpenVideo.onClick.AddListener(() =>
            {
                if (!videoModule.gameObject.activeInHierarchy)
                {
                    videoModule.gameObject.SetActive(true);
                    webPageModule.gameObject.SetActive(false);
                    webCamModule.gameObject.SetActive(false);
                    discriptionModule.gameObject.SetActive(false);
                }
                else
                    videoModule.gameObject.SetActive(false);
            });
        else
            b_OpenVideo.interactable = false;

        if (webCamModule)
            b_OpenWebCamera.onClick.AddListener(() =>
            {
                if (!webCamModule.gameObject.activeInHierarchy) { 
                    webCamModule.gameObject.SetActive(true);
                    webPageModule.gameObject.SetActive(false);
                    discriptionModule.gameObject.SetActive(false);
                    videoModule.gameObject.SetActive(false);
                    webCamModule.ActivateWebCam();
                }
                else {
                    webCamModule.DeactivateWebCam();
                    webCamModule.gameObject.SetActive(false);
                }
            });
        else
            b_OpenWebCamera.interactable = false;

        if (webPageModule)
            b_WebPage.onClick.AddListener(() =>
            {
                if (!webPageModule.gameObject.activeInHierarchy)
                {
                    webPageModule.gameObject.SetActive(true);
                    webCamModule.gameObject.SetActive(false);
                    discriptionModule.gameObject.SetActive(false);
                    videoModule.gameObject.SetActive(false);

                    webPageModule.ActivateWindows();
                }
                else
                    webPageModule.gameObject.SetActive(false);
            });
        else
            b_WebPage.interactable = false;

        discriptionModule.gameObject.SetActive(false);
        webPageModule.gameObject.SetActive(false);
        webCamModule.gameObject.SetActive(false);
        videoModule.gameObject.SetActive(false);
    }
    #endregion

    #region parametrs windows
    private void OnMouseDown()
    {
        if (discriptionModule)
        {
            if (!discriptionModule.gameObject.activeInHierarchy)
            {
                discriptionModule.gameObject.SetActive(true);
                webPageModule.gameObject.SetActive(false);
                webCamModule.gameObject.SetActive(false);
                videoModule.gameObject.SetActive(false);

                discriptionModule.ActivateWindows();
            }
            else
            {
                discriptionModule.DeactivateWindows();
                discriptionModule.gameObject.SetActive(false);
            }
        }
    }
    #endregion
}