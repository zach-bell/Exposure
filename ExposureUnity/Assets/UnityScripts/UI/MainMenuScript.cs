using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

	public void ButtonClickPlay() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void ButtonClickOptions() {

	}

//		options Menu Methods

	public void ButtonClickBack() {

	}

	public void AdjustDifficulty(int difficulty) {

	}


}
