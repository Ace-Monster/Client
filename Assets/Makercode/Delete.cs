﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Delete : MonoBehaviour
{
    public string str;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == str)
        {
            if (gameObject.transform.localPosition.x < -20 && gameObject.activeSelf == true)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
