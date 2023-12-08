using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePanelFadeIn : MonoBehaviour
{
    [SerializeField] CanvasGroup titleCanvas;
    [SerializeField] bool fadeIn = false;
    [SerializeField] float speed = 1.2f;

    private void Start()
    {
        titleCanvas.alpha = 0.0f;
        fadeIn = true;
    }

    public void Update()
    {
        if (fadeIn)
        {
            if(titleCanvas.alpha < 1)
            {
                titleCanvas.alpha += Time.deltaTime * speed;
                if(titleCanvas.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }
    }
}
