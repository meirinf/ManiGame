using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

//Es una clase  en la que solo se puede tomar estos valores enumerados
public enum GameState{
	menu,
	inTheGame,
	gameOver
}

public class GameManager : MonoBehaviour {

	public GameState currentGameState = GameState.menu;
	public static GameManager sharedInstance;

	void Awake(){
		sharedInstance = this;
	}
	void Start(){
		currentGameState = GameState.menu;
	}

	void Update(){
		if(Input.GetButtonDown("s")){
			currentGameState = GameState.inTheGame;
		}
	}
	// Al iniciar el juego
	public void StartGame () {
		MouseController.sharedInstance.StartGame();
		changeGameState(GameState.inTheGame);
	}

	// Finaliza el juego
	public void GameOver() {
		changeGameState(GameState.gameOver);
	}

	//Termina y vuelbe al menu
	public void BackToMainMenu(){
		changeGameState(GameState.menu);
	}

	void changeGameState(GameState newGameState) {
		if(newGameState == GameState.menu){
			//La escena mostrara el menu principal

		}
		else if(newGameState == GameState.inTheGame){
			//La escena del Unity debe configurarse para mostrar el juego

		}
		else if(newGameState == GameState.gameOver){
			//La escena debe mostrar el fin de partida
			//SceneManager.LoadScene(escenario);
		}
		currentGameState = newGameState;
	}
}
