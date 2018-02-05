using UnityEngine.Audio;
using UnityEngine;

namespace Exposure.Sound {
	[System.Serializable]
	public class Sound {

		public string name;

		public AudioClip clip;

		[Range(0, 1)]
		public float volume;
		[Range(0.1f, 3)]
		public float pitch;

		[HideInInspector]
		public AudioSource source;
	}
}
