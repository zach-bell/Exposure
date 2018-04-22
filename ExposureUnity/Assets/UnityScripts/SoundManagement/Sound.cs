using UnityEngine.Audio;
using UnityEngine;

namespace Exposure.Sound {
	[System.Serializable]
	public class Sound {

		public string name;

		public AudioClip clip;

		[Range(0, 1)]
		public float volume = 0.8f;
		[Range(0.1f, 3)]
		public float pitch = 1f;
		public bool loop = false;

		[Range(0.0f, 1.0f)]
		public float spatialBlend = 0f;

		public AudioMixerGroup mixerGroup;

		[HideInInspector]
		public AudioSource source;
	}
}
