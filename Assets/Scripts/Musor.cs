using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Musor : MonoBehaviour
{
    private int engen;
  
    private void Start()
    {
        Destroy(gameObject,1);
    }

    public void Update()
    {
        engen++;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, engen);
    }
    

}