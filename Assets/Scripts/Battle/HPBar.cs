﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] GameObject health;

    private void Start()
    {
        
    }

    public void SetHP(float hpNormalised)
    {
        health.transform.localScale = new Vector3(hpNormalised, 1f);
    }
}
