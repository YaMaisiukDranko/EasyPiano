using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource AudioNotes;

    [Header("Массив нот")]
    [SerializeField] private AudioClip[] Notes = new AudioClip[7];

    // Start is called before the first frame update
    void Start()
    {
        AudioNotes = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlaySound(int numberNotes)
    {
        AudioNotes.PlayOneShot(Notes[numberNotes]);
    }
}
