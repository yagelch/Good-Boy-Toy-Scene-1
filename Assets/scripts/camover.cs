﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(float deltaX)
    {
        this.transform.position = new Vector3(deltaX*0.2f, this.transform.position.y, this.transform.position.z);
    }
}
