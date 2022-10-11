using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebViewController : MonoBehaviour
{
    [SerializeField] private Button b_close;

    [SerializeField] private string web_addres = "https://yandex.ru";

    void Start()
    {
        b_close.onClick.AddListener(() => gameObject.SetActive(false));
    }

    public void ActivateWindows() {
        Application.OpenURL(web_addres);
    }
}
