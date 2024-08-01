using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public GameObject[] Tiles;
    public int CurrentTileModel = 0;
    public GameObject object_to_hide;

    public void Start()
    {
        CurrentTileModel = PlayerPrefs.GetInt("SelectTileModel", 0);
        foreach(GameObject Tile in Tiles)
        {
            Tile.SetActive(false);
        }
        Tiles[CurrentTileModel].SetActive(true);
        object_to_hide.SetActive(true);
    }

    public void Sphere()
    {
        Tiles[CurrentTileModel].SetActive(false);
        CurrentTileModel = 1;
        Tiles[CurrentTileModel].SetActive(true);
        PlayerPrefs.SetInt("SelectTileModel", CurrentTileModel);
        object_to_hide.SetActive(false);
    }

    public void Capsule()
    {
        Tiles[CurrentTileModel].SetActive(false);
        CurrentTileModel = 2;
        Tiles[CurrentTileModel].SetActive(true);
        PlayerPrefs.SetInt("SelectTileModel", CurrentTileModel);
        object_to_hide.SetActive(false);

    }

    public void Cube()
    {
        Tiles[CurrentTileModel].SetActive(false);
        CurrentTileModel = 0;
        Tiles[CurrentTileModel].SetActive(true);
        PlayerPrefs.SetInt("SelectTileModel", CurrentTileModel);
        object_to_hide.SetActive(false);

    }
}
