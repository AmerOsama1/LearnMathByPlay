using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Numbers;
    List<GameObject> spawnedNumbers = new List<GameObject>(); // List to keep track of spawned numbers
 public int  Number_Item=5;
 public int MaxNumber;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RespawnNumbers", 10, 10);
        SpawnInitialNumbers();
    }

    // Update is called once per frame
    void Update()
    {
        // Add any update logic here
    }

    void SpawnInitialNumbers()
    {
        for (int i = 0; i < Number_Item; i++)
        {
            int j = Random.Range(0,MaxNumber);
            Vector3 pos = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);
            GameObject num = Instantiate(Numbers[j], pos, Quaternion.identity);
            spawnedNumbers.Add(num); // Add the spawned object to the list
        }
    }

    void RespawnNumbers()
    {
        // Destroy all previously spawned numbers
        foreach (var num in spawnedNumbers)
        {
            Destroy(num);
        }

        spawnedNumbers.Clear(); // Clear the list

        // Respawn new numbers
        for (int i = 0; i < Number_Item; i++)
        {
            int j = Random.Range(0, MaxNumber);
            Vector3 pos = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);
            GameObject num = Instantiate(Numbers[j], pos, Quaternion.identity);
            spawnedNumbers.Add(num); // Add the spawned object to the list
        }
    }
}
