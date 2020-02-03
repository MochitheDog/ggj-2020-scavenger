using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public void Play(string name, int number) {
		Debug.Log("Play");

		if (name == "player") {
			AudioSource[] playerSources = this.transform.Find("aPlayerManager").GetComponents<AudioSource>();
			if (playerSources != null) {
				// Debug.Log("Playing: " + number);
				if(number > playerSources.Length) {
					Debug.Log("Error: number to play > number of sources");
				}
				if (!playerSources[number].isPlaying) {
						playerSources[number].volume = Random.Range(0.4f, 0.6f);
						playerSources[number].pitch = Random.Range(0.8f, 1.1f);
						playerSources[number].Play();
				} else {
					//IF it's already playing, fade away the sound
					fade("player", number, 0.35f);
					//StartCoroutine(FadeAudioSource.StartFade(playerSources[number], 0.35f, 0));
					//playerSources[number].Stop();
				}

			} else {
				// Debug.Log("playerSources = null!");
			}
		}

		if (name == "level") {
			Debug.Log("level");
			AudioSource[] levelSources = this.transform.Find("aLevelManager").GetComponents<AudioSource>();
			if (levelSources != null) {
				// Debug.Log("Playing: " + number);
				if(number > levelSources.Length) {
					Debug.Log("Error: number to play > number of sources");
				}
				if (!levelSources[number].isPlaying) {
					if (number == 0) {
						levelSources[number].volume = Random.Range(0.4f, 0.6f);
						levelSources[number].pitch = Random.Range(0.8f, 1.1f);
						levelSources[number].Play();
					} else {
						levelSources[number].Play();
					}
				} else {
					//IF it's already playing, fade away the sound
					fade("level", number, 0.35f);
					//StartCoroutine(FadeAudioSource.StartFade(playerSources[number], 0.35f, 0));
					//playerSources[number].Stop();
				}

			} else {
				// Debug.Log("playerSources = null!");
			}
		}

		if (name == "ambient") {
			AudioSource[] ambientSources = this.transform.Find("aAmbientManager").GetComponents<AudioSource>();
			if (ambientSources != null) {
				if (number > ambientSources.Length) {
					Debug.Log("Error: number to play > number of sources");
				}
				if (!ambientSources[number].isPlaying) {
					// Debug.Log("Playing ambient " + number);
					ambientSources[number].volume = 1f;
					ambientSources[number].Play();
					//ambientSources[number].loop = true;
				} else {
					//IF it's already playing, fade away the sound
					fade("ambient", number, 1.0f);
					//StartCoroutine(FadeAudioSource.StartFade(ambientSources[number], 0.35f, 0));
					//ambientSources[number].loop = false;
					//ambientSources[number].Stop();
				}
			} else {
				// Debug.Log("ambientSources = null!");
			}
		}

	}


	//
	// public void playWheel2() {
	// 	if (!source2.isPlaying) {
	// 		source2.pitch = trainSpeed*0.55f;
	// 		source2.volume = trainSpeed*0.75f;
	// 		//set maximum values on the pitch and volume
	// 		if (source2.pitch >= 1.4f) {
	// 			source2.pitch = 1.4f;
	// 		}
	// 		if (source2.pitch <= 0.6f) {
	// 			source2.pitch = 0.6f;
	// 		}
	//
	// 		// if (source2.volume <= 0.5f) {
	// 		// 	source2.volume = 0.5f;
	// 		// }
	//
	// 		source2.Play();
	// 	}
	// }

	// public void playWheel1(float inputVolume) {
	// 	if (!source1.isPlaying) {
	// 		source1.pitch = trainSpeed*0.55f;
	// 		source1.volume = inputVolume;
	// 		//set maximum values on the pitch and volume
	// 		if (source1.pitch >= 1.4f) {
	// 			source1.pitch = 1.4f;
	// 		}
	// 		if (source1.pitch <= 0.6f) {
	// 			source1.pitch = 0.6f;
	// 		}
	//
	// 		// if (source1.volume <= 0.5f) {
	// 		// 	source1.volume = 0.5f;
	// 		// }
	//
	// 		source1.Play();
	// 	}
	// }



	public void fade(string name, int number, float durationToFade){

		if (name == "pressure") {
			AudioSource[] pressureSources = this.transform.Find("aPressureManager").GetComponents<AudioSource>();
			StartCoroutine(FadeAudioSource.StartFade(pressureSources[number], durationToFade, 0));
		} else if (name == "train") {
			AudioSource[] trainSources = this.transform.Find("aTrainManager").GetComponents<AudioSource>();
			StartCoroutine(FadeAudioSource.StartFade(trainSources[number], durationToFade, 0));
		} else if (name == "ambient") {
			AudioSource[] ambientSources = this.transform.Find("aAmbientManager").GetComponents<AudioSource>();
			StartCoroutine(FadeAudioSource.StartFade(ambientSources[number], durationToFade, 0));
		} else if (name == "player") {
			AudioSource[] playerSources = this.transform.Find("aPlayerManager").GetComponents<AudioSource>();
			StartCoroutine(FadeAudioSource.StartFade(playerSources[number], durationToFade, 0));
		} else {
			// Debug.Log("Something happened in fade() of AudioManager2");
		}

	}


	void Awake() {


	}

	// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


		}

}
