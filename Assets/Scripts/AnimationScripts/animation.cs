﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.Play("animMagnit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
