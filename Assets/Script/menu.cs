using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	// Use this for initialization
	public void mulai () {

		SceneManager.LoadScene ("belajar_menu");

	}

	public void home () {

		SceneManager.LoadScene ("main_menu");

	}
	public void kuis () {

		SceneManager.LoadScene ("pilih_kuis");

	}

	public void kendaraan () {

		SceneManager.LoadScene ("kendaraan");

	}
	public void buah () {

		SceneManager.LoadScene ("alpukat");

	}

	public void angka () {

		SceneManager.LoadScene ("0");

	}

	public void tubuh () {

		SceneManager.LoadScene ("hidung");

	}

	public void warna () {

		SceneManager.LoadScene ("abu");

	}

	public void hewan () {

		SceneManager.LoadScene ("anjing");

	}

	public void mudah () {

		SceneManager.LoadScene ("01");

	}
	public void sedang () {

		SceneManager.LoadScene ("sedang");

	}
	public void sulit () {

		SceneManager.LoadScene ("sulit");

	}

	// Update is called once per frame
	public void keluar () {
		Application.Quit ();
	}
	

}
