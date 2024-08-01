using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject[] m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12;

    public int SelectedModel = 0;

    public void Start()
    {
        SelectedModel = PlayerPrefs.GetInt("SelectModel", 0);

        // Deactivate all models initially
        DeactivateAllModels();

        // Activate the saved model
        ActivateModel(SelectedModel);
    }

    private void DeactivateAllModels()
    {
        DeactivateGameObjects(m1);
        DeactivateGameObjects(m2);
        DeactivateGameObjects(m3);
        DeactivateGameObjects(m4);
        DeactivateGameObjects(m5);
        DeactivateGameObjects(m6);
        DeactivateGameObjects(m7);
        DeactivateGameObjects(m8);
        DeactivateGameObjects(m9);
        DeactivateGameObjects(m10);
        DeactivateGameObjects(m11);
        DeactivateGameObjects(m12);
    }

    private void DeactivateGameObjects(GameObject[] gameObjects)
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(false);
        }
    }

    private void ActivateGameObjects(GameObject[] gameObjects)
    {
        foreach (GameObject obj in gameObjects)
        {
            obj.SetActive(true);
        }
    }

    public void Active_m1()
    {
        SelectedModel = 1;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m1);
    }

    public void Active_m2()
    {
        SelectedModel = 2;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m2);
    }
    public void Active_m3()
    {
        SelectedModel = 3;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m3);
    }
    public void Active_m4()
    {
        SelectedModel = 4;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m4);
    }
    public void Active_m5()
    {
        SelectedModel = 5;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m5);
    }

    public void Active_m6()
    {
        SelectedModel = 6;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m6);
    }
    public void Active_m7()
    {
        SelectedModel = 7;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m7);
    }
    public void Active_m8()
    {
        SelectedModel = 8;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m8);
    }
    public void Active_m9()
    {
        SelectedModel = 9;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m9);
    }
    public void Active_m10()
    {
        SelectedModel = 10;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m10);
    }
    public void Active_m11()
    {
        SelectedModel = 11;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m11);
    }
    public void Active_m12()
    {
        SelectedModel = 12;
        PlayerPrefs.SetInt("SelectModel", SelectedModel);
        PlayerPrefs.Save();

        DeactivateAllModels();
        ActivateGameObjects(m12);
    }

    private void ActivateModel(int modelIndex)
    {
        switch (modelIndex)
        {
            case 1: ActivateGameObjects(m1); break;
            case 2: ActivateGameObjects(m2); break;
            case 3: ActivateGameObjects(m3); break;
            case 4: ActivateGameObjects(m4); break;
            case 5: ActivateGameObjects(m5); break;
            case 6: ActivateGameObjects(m6); break;
            case 7: ActivateGameObjects(m7); break;
            case 8: ActivateGameObjects(m8); break;
            case 9: ActivateGameObjects(m9); break;
            case 10: ActivateGameObjects(m10); break;
            case 11: ActivateGameObjects(m11); break;
            case 12: ActivateGameObjects(m12); break;
            default: break;
        }
    }
}
