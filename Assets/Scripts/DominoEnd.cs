﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoEnd : MonoBehaviour
{
    public GameObject stage3Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        stage3Door.SetActive(false);
    }
}
