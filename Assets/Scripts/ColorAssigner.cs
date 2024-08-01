using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAssigner : MonoBehaviour
{
    public GameObject[] players; // Reference to the player GameObject array

    void Start()
    {
        AssignColorToCubes();
    }
    void AssignColorToCubes()
    {
        // Check the number of players
        foreach (GameObject currentPlayer in players)
        {
            MeshRenderer playerColor = currentPlayer.GetComponent<MeshRenderer>();
            Color player_color = playerColor.material.color;
            for (int j = 0; j < transform.childCount; j++)
            {
                int k = Random.Range(0, transform.childCount);
                MeshRenderer m1 = transform.GetChild(k).transform.GetComponent<MeshRenderer>();
                m1.material.color = player_color;
                //m1.enabled = true;
                //transform.GetChild(k).GetComponent<ParticleSystem>().startColor = temp.color;
                //transform.GetChild(k).parent = null;
            }
        }
    }
}
