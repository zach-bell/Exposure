using UnityEngine.Audio;
using UnityEngine;

public class SoundEmitter1 : MonoBehaviour {

	[SerializeField]
	private AudioManager audioManager;
	[SerializeField]
	private AudioMixer audioMixer;
	[SerializeField]
	private AudioMixerSnapshot mute;
	[SerializeField]
	private AudioMixerSnapshot unmute;
	[SerializeField]
	private Transform targetToFollow;
	[SerializeField]
	private Vector3 offset = new Vector3(0, 2, 0);

	private AudioMixerSnapshot[] snapshots = new AudioMixerSnapshot[2];
	private float[] weights = {0, 1};

	void Start () {
		snapshots[0] = mute;
		snapshots[1] = unmute;

		if (audioManager == null)
			audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
		audioManager.Play("heavyBreathing");
		audioManager.Play("hit1");
		audioManager.Play("machineDistant");
		audioMixer.TransitionToSnapshots(snapshots, weights, 2);
		if (targetToFollow == null)
			targetToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}

	public void PlayStartingSounds() {
		audioManager.Play("alert1");
		audioManager.Play("machineStart");
		audioManager.Play("heavyBreathing");
		audioManager.Play("machineClacking");
	}

	public void FadeOut() {
		snapshots[0] = unmute;
		snapshots[1] = mute;
		audioMixer.TransitionToSnapshots(snapshots, weights, 3);
	}
}
