﻿/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
	[SerializeField] AudioClip _audioClip;
	[SerializeField] [Range(0.0f, 1.0f)] float _volume = 1;
	AudioSource _audioSource;

	void Awake ()
	{
		_audioSource = gameObject.AddComponent<AudioSource> ();
		if (_audioClip != null)
			_audioSource.clip = _audioClip;
		_audioSource.playOnAwake = false;
		_audioSource.volume = _volume;
		GetComponent<Button> ().onClick.AddListener (() => _audioSource.Play ());
	}
}