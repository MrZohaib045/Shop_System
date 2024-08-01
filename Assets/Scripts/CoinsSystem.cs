using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsSystem : MonoBehaviour
{
    public int coins = 0;
    public Text coin_text;

    public const string CoinKey = "Coins"; // Key to identify the stored coin value

    private void Start()
    {
        LoadCoins();
    }

    public void LoadCoins()
    {
        // Load the stored number of coins when the script starts
        coins = PlayerPrefs.GetInt(CoinKey, coins);
        coin_text.text = coins.ToString();
    }

    public void SaveCoins()
    {
        // Save the current coin value
        PlayerPrefs.SetInt(CoinKey, coins);
        PlayerPrefs.Save(); // Make sure to save changes
    }
}
