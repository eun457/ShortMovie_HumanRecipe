using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePanelFadeOut : MonoBehaviour
{
    [SerializeField] CanvasGroup titleCanvas;
    [SerializeField] bool fadeOut = false;
    [SerializeField] float speed = 0.2f;

    private void Start()
    {
        titleCanvas.alpha = 1f;
        fadeOut = true;
    }

    public void Update()
    {
        if (fadeOut)
        {
            if(titleCanvas.alpha >= 0)
            {
                titleCanvas.alpha -= Time.deltaTime * speed;
                if(titleCanvas.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }
}
