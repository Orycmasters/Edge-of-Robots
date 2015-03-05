using UnityEngine;
using System.Collections;

public class UserInterface : MonoBehaviour {

	public string meuNome;
	public string idade;

	// Use this for initialization
	void OnGUI () {

		meuNome = GUI.TextField (new Rect (Screen.width / 2 - 50, Screen.height / 2, 100, 20), meuNome);
		idade = GUI.TextField (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 20, 100, 20), idade);

		bool salvarJogo = GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 20), "Salvar");
		bool carregarJogo = GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 70, 100, 20), "Carregar");
		bool deletarJogo = GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 2 + 90, 100, 20), "Deletar");
	}

}
