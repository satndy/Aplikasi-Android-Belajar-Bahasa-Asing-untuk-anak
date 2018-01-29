using UnityEngine;
using UnityEngine.UI;  
using System.Collections;
using UnityEngine.SceneManagement;

public class inc : MonoBehaviour {

	public GameObject benar;
	public GameObject salah;
	public Text tampil;
	public Text poin;
	public GameObject GameOver;
	public GameObject Menang;
	public int Gold = 5;
	public int Goldperclick = 1;
	public int Pinter = 5;
	public int Pinterclick = 1;
	public int syaratMenang = 0;
	public int syaratKalah = 0;
	// Use this for initialization

	 

	public void NoPress()
	{
		benar.SetActive(false);
		salah.SetActive (false);
	}

	public void stupid()
	{
		
		salah.SetActive (true);
	}

	public void smart()
	{
		benar.SetActive(true);
	}


	public void clicked() {
		salah.SetActive (true);
		Gold -= Goldperclick;
		tampil.text = "Kesempatan= " + Gold;
		salah.SetActive (true);
		if (Gold == syaratKalah) {
			GameOver.SetActive (true);
			Invoke( "ChangeLevel", 2.0f );


		}
	}

	public void pener() {
		benar.SetActive (true);
		Pinter += Pinterclick;
		poin.text = "Poin= " + Pinter;
		benar.SetActive (true);
		if (Pinter == syaratMenang) {
			Menang.SetActive (true);
			Invoke( "ChangeLevel", 3.0f );


		}
	}
		
	void ChangeLevel()
	{
		SceneManager.LoadScene ("main_menu");
	}
}
