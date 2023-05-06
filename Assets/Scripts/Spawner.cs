using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawner : MonoBehaviour
{
   public Transform zmea;
   public GameObject[] musor;
   public GameObject[] SpawnPoint;
 
   private void Start()
   {
      InvokeRepeating("SpawnMusor",1, Random.Range(0,5));
   }

   private void Update()
   {
      transform.position = zmea.position;
   }

 

   void SpawnMusor()
   {

      Instantiate(musor[Random.Range(0,2)],SpawnPoint[Random.Range(0,4)].transform.position,Quaternion.identity);
   }
}
