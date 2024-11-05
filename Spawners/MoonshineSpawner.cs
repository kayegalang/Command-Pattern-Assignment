using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonshineSpawner : MonoBehaviour
{
    public GameManager GameManager;
    
    public GameObject MoonshinePrefab;
    
    private float secondsUntilCreation;

    private void Start()
    {
        StartCoroutine(SpawnMoonshine());
    }

    private IEnumerator SpawnMoonshine()
    {
        while (GameManager.GetIsGameRunning())
        {
            secondsUntilCreation = Random.Range(GameParameters.MoonshineMinimumTimeToCreate, GameParameters.MoonshineMaximumTimeToCreate);
            yield return new WaitForSeconds(secondsUntilCreation);
            PlaceMoonshine();
        }
    }

    private void PlaceMoonshine()
    {
        Instantiate(MoonshinePrefab, SpriteTools.MoonshineLocationWorldSpace(), Quaternion.identity);
    }
}
