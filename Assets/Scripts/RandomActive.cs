using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomActive : MonoBehaviour
{
    public GameObject[] Cubes;
    public GameObject[] Spheres;
    public GameObject[] Capsules;

    public void Start()
    {
        // Get all game objects with the tag "Cube_Tiles"
        GameObject[] cubeTiles = GameObject.FindGameObjectsWithTag("Cube_Tiles");
        // Assign the found game objects to the Cubes array
        Cubes = cubeTiles;

        // Get all game objects with the tag "Cube_Tiles"
        GameObject[] SphereTiles = GameObject.FindGameObjectsWithTag("Sphere_Tiles");
        // Assign the found game objects to the Cubes array
        Spheres = SphereTiles;

        // Get all game objects with the tag "Cube_Tiles"
        GameObject[] CapsuleTiles = GameObject.FindGameObjectsWithTag("Capsule_Tiles");
        // Assign the found game objects to the Cubes array
        Capsules = CapsuleTiles;

        // Deactivate all cubes
        foreach (GameObject cube in Cubes)
        {
            cube.SetActive(false);
        }

        // Deactivate all spheres
        foreach (GameObject sphere in Spheres)
        {
            sphere.SetActive(false);
        }

        // Deactivate all capsules
        foreach (GameObject capsule in Capsules)
        {
            capsule.SetActive(false);
        }
    }

    public void active_cube_tiles()
    {
        foreach(GameObject Cube in Cubes)
        {
            Cube.SetActive(true);
        }
    }

    public void active_sphere_tiles()
    {
        foreach (GameObject Sphere in Spheres)
        {
            Sphere.SetActive(true);
        }
    }

    public void active_Capsule_tiles()
    {
        foreach (GameObject Capsule in Capsules)
        {
            Capsule.SetActive(true);
        }
    }
}
