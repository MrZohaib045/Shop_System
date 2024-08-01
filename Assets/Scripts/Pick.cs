using UnityEngine;

public class Pick : MonoBehaviour
{
    Color tileColor;
    void Start()
    {
        tileColor = GetComponent<MeshRenderer>().material.color; // Simplified to use GetComponent directly
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Checking the tag directly on the Collider parameter
        {
            Debug.Log("Hello");
            // Assuming you want to destroy the tile object if the player's color matches
            Renderer playerRenderer = other.GetComponent<Renderer>();
            if (playerRenderer != null && playerRenderer.material.color == tileColor)
            {
                //print("You are Destroying me");
                Destroy(gameObject);
            }
        }
    }
}
