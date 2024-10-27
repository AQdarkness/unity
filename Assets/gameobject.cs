using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameobject : MonoBehaviour
{
    public GameObject waterDropPrefab;
    public float spawnInterval = 1f;
    public float spawnRangeX = 10f;
    public float spawnHeight = 5f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            spawnWaterDrop();
            timer = spawnInterval;
        }
    }

    void spawnWaterDrop()
    {
        // بررسی اینکه آبجکت آب (waterDropPrefab) نال نیست
        if (waterDropPrefab != null)
        {
            float spawnPosx = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = new Vector3(spawnPosx, spawnHeight, 0);
            Instantiate(waterDropPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("WaterDropPrefab is not assigned!");
        }
    }
}
