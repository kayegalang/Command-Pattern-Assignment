using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class BeerSpawner : MonoBehaviour
{
    public GameManager GameManager;
    
    public GameObject BeerPrefab;

    private float secondsUntilCreation;

    private void Start()
    {
        StartCoroutine(SpawnBeer());
    }

    private IEnumerator SpawnBeer()
    {
        while (GameManager.GetIsGameRunning())
        {
            secondsUntilCreation = Random.Range(GameParameters.BeerMinimumTimeToCreate, GameParameters.BeerMaximumTimeToCreate);
            yield return new WaitForSeconds(secondsUntilCreation);
            PlaceBeer();
        }
    }

    private void PlaceBeer()
    {
        Instantiate(BeerPrefab, SpriteTools.RandomTopOfScreenLocationWorldSpace(), Quaternion.identity);
    }
}
