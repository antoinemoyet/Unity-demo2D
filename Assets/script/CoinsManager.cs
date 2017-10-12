using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour {

	public static int Coins;
	public int CoinsToAdd;

	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		Coins = PlayerPrefs.GetInt ("Coins", Coins);
	}
	
	// Update is called once per frame
	void Update () {
		if (Coins < 0)
			Coins = 0;
		text.text = "" + Coins;
	}

	public static void AddCoins (int CoinsToAdd)
	{
		Coins += CoinsToAdd;
		PlayerPrefs.SetInt ("Coins", Coins);
		if (Coins == null)
			Coins = 0;
	}
	public static void Reset ()
	{
		Coins = 0;
	}
}