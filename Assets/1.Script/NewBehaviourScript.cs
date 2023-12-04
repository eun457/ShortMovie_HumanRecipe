using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject TImeLine1;
    public GameObject TImeLine2;

    float count = 0;

    // Update is called once per frame
    private void Start()
    {
        TImeLine1.SetActive(false);
        TImeLine2.SetActive(false);
    }
    void Update()
    {
        count += Time.deltaTime;

        if (count < 20)
        {
            TImeLine1.SetActive(true);
        }
        else if (count > 20)
        {
            TImeLine1.SetActive(false);
            TImeLine2.SetActive(true);
        }
    }
}
