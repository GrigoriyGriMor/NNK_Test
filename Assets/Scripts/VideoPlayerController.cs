using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoPlayerController : MonoBehaviour
{
    [SerializeField] private Button b_close;

    void Start()
    {
        b_close.onClick.AddListener(() => gameObject.SetActive(false));
    }
}
