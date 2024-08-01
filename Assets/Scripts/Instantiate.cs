using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject[] prefabs; // Array to hold all prefabs you want to instantiate

    void Start()
    {
        // Loop through each prefab in the array
        foreach (GameObject prefab in prefabs)
        {
            // Instantiate the prefab at the current object's position and rotation
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
