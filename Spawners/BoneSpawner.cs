using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneSpawner : MonoBehaviour
{
    public GameManager GameManager;
    
    public GameObject BonePrefab;

    private float secondsUntilCreation;

    private void Start()
    {
        StartCoroutine(SpawnBone());
    }

    private IEnumerator SpawnBone()
    {
        while (GameManager.GetIsGameRunning())
        {
            secondsUntilCreation = Random.Range(GameParameters.BoneMinimumTimeToCreate, GameParameters.BoneMaximumTimeToCreate);
            yield return new WaitForSeconds(secondsUntilCreation);
            PlaceBone();
        }
    }

    private void PlaceBone()
    {
        Instantiate(BonePrefab, SpriteTools.RandomTopOfScreenLocationWorldSpace(), Quaternion.identity);
    }
}
