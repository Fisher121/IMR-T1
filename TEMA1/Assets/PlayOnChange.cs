using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnChange : MonoBehaviour
{

	public AudioClip appearClip;
	public AudioClip disappearClip;
	private AudioSource source;
    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
	
	public void Initialize()
	{
		source.enabled=true;
	}

	public void PlayOnAppear()
	{
		source.clip = appearClip;
		source.Play();
	}

	public void PlayOnDisappear()
	{
		source.clip = disappearClip;
		source.Play();
	}

}
