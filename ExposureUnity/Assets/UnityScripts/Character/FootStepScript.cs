using UnityEngine;

public class FootStepScript : MonoBehaviour {

	private CharacterController controller;
	private AudioManager audioManager;

	private float currentTime = 0;
	public bool playedSound = false;

	[SerializeField]
	private float speed = 2f;
	[SerializeField]
	private float timeBetweenSteps = 0.65f;

	void Start () {
		controller = GetComponent<CharacterController>();
		audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
	}
	
	void Update () {
		if (playedSound)
			currentTime += Time.deltaTime;
		if (currentTime >= timeBetweenSteps) {
			playedSound = false;
			currentTime = 0;
		}
		if ((controller.isGrounded && controller.velocity.magnitude > speed) && !playedSound) {
			PlayRandomGrassSound();
			playedSound = true;
		}
	}

	private void PlayRandomGrassSound() {
		int ran = (int) (Random.Range(1, 18));
		switch(ran) {
		case 1:
			audioManager.Play("stepGrassClean1");
			break;
		case 2:
			audioManager.Play("stepGrassClean2");
			break;
		case 3:
			audioManager.Play("stepGrassClean3");
			break;
		case 4:
			audioManager.Play("stepGrassClean4");
			break;
		case 5:
			audioManager.Play("stepGrassClean5");
			break;
		case 6:
			audioManager.Play("stepGrassClean6");
			break;
		case 7:
			audioManager.Play("stepGrassCrunch1");
			break;
		case 8:
			audioManager.Play("stepGrassCrunch2");
			break;
		case 9:
			audioManager.Play("stepGrassCrunch3");
			break;
		case 10:
			audioManager.Play("stepGrassCrunch4");
			break;
		case 11:
			audioManager.Play("stepGrassCrunch5");
			break;
		case 12:
			audioManager.Play("stepGrassCrunch6");
			break;
		case 13:
			audioManager.Play("stepGrassQuiet1");
			break;
		case 14:
			audioManager.Play("stepGrassQuiet2");
			break;
		case 15:
			audioManager.Play("stepGrassQuiet3");
			break;
		case 16:
			audioManager.Play("stepGrassQuiet4");
			break;
		case 17:
			audioManager.Play("stepGrassQuiet5");
			break;
		case 18:
			audioManager.Play("stepGrassQuiet6");
			break;
		}
	}
}
