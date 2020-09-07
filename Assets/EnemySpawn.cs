using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float MaxTime;
    public float CurrentTime;

    private void Awake()
    {
        CurrentTime = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= Time.deltaTime;
        if (CurrentTime <= 0)
        {
            CurrentTime = MaxTime;
            Debug.Log("Reseting Timer...");
        }
    }
}
