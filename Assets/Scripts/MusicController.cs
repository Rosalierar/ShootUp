using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioClip[] audioClips;
    AudioSource music;

    int choose;
    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();

        if (!PlayerPrefs.HasKey("MusicChoose"))
        {
            PlayerPrefs.SetInt("MusicChoose", 0);
        }
        else
        {
            choose = PlayerPrefs.GetInt("MusicChoose");
            music.clip = audioClips[choose];
            music.Play();
        }
    }

    public void ChooseMusic(int index)
    {
        music.clip = audioClips[index];
        music.Play();

        PlayerPrefs.SetInt("MusicChoose", index);
    }
}
