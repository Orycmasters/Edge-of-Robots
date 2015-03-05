using UnityEngine;
using System.Collections;

public static class BancoDeDados {

	public static void SalvarDados(string meuNome, string idade){

		string mn = meuNome;
		string i = idade;

		PlayerPrefs.SetString ("nome", mn);
		PlayerPrefs.SetString ("idade", i);
		Debug.Log (mn + ", seus dados foram salvos.");
	}

}
