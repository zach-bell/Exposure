using UnityEngine.SceneManagement;
using UnityEngine;

public class Sequencer : MonoBehaviour {

// Intro scene
	[Header("Intro Scene stuff")]
	[SerializeField]
	private bool introScene = false;
	[SerializeField]
	private GameObject introLight;
	[SerializeField]
	private float waitTill = 5f;
	[SerializeField]
	private GameObject floor;

// intro level
	[Header("Intro to Level stuff")]
	[SerializeField]
	private bool introLevel = false;
	[SerializeField]
	private GameObject TrapDoor1;
	[SerializeField]
	private GameObject TrapDoor2;
	[SerializeField]
	private GameObject floor2;
	[SerializeField]
	private GameObject dayTime;
	[SerializeField]
	private float waitTillSeconds = 5f;
	[SerializeField]
	private Color ambientColor;

// Gloabal vars shared
	[Header("Global Variables needed for both")]
	[SerializeField]
	private GameObject soundEmitter;
	[SerializeField]
	private AudioManager am;

	private bool ended = false;
	private float currentTime = 0, currentTime2 = 0;
	private bool oneTime = true, oneTime2 = true;

	void LateUpdate () {
		currentTime += Time.deltaTime;

		if (introScene) {
			if (currentTime > waitTill) {
				if (oneTime) {
					introLight.GetComponent<Light>().enabled = true;
					soundEmitter.GetComponent<SoundEmitter1>().PlayStartingSounds();
					floor.GetComponent<Animator>().enabled = true;
					oneTime = false;
				}
			}
			if (ended) {
				currentTime2 += Time.deltaTime;
				if (currentTime2 > 3) {
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
				}
			}
		}
		if (introLevel) {
			if (oneTime) {
				am.Play("tonalFX15");
				oneTime = false;
			}
			if (currentTime > waitTillSeconds) {
				if (oneTime2) {
					RenderSettings.ambientLight = ambientColor;
					RenderSettings.ambientIntensity = 1;
					TrapDoor1.GetComponent<Animator>().enabled = true;
					TrapDoor2.GetComponent<Animator>().enabled = true;
					floor2.GetComponent<Animator>().enabled = true;
					dayTime.SetActive(true);
					am.Play("BirdsLong");
					am.Play("WindQuiet");
					oneTime2 = false;
				}
			}
		}
	}
	public void EndAnim() {
		am.StopAll();
		introLight.GetComponent<Light>().enabled = false;
		am.Play("hit2");
		am.Play("hit1");
		ended = true;
		soundEmitter.GetComponent<SoundEmitter1>().FadeOut();
	}
}
