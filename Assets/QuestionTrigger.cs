using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;
using System;

public class QuestionTrigger : MonoBehaviour
{
    public AudioClip introductionClip;
    public AudioClip conclusionClip;

    public AudioClip[] questionClips;
    public AudioClip[] modestPraiseClips;
    public AudioClip[] inflatedPraiseClips;

    private int currentQuestionIndex = 0;
    private List<AudioClip> usedModestPraises = new List<AudioClip>();
    private List<AudioClip> usedInflatedPraises = new List<AudioClip>();

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Handling questions
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Assign different keys for each question
        {
            PlayAudioClip(introductionClip);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlayAudioClip(questionClips[0]); // Play question 1 audio clip
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PlayAudioClip(questionClips[1]); // Play question 2 audio clip
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            PlayAudioClip(questionClips[2]); // Play question 3 audio clip
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            PlayAudioClip(conclusionClip);
        }

        // Praises
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayRandomAudioClip(modestPraiseClips, usedModestPraises);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            PlayRandomAudioClip(inflatedPraiseClips, usedInflatedPraises);
        }
    }

    void PlayAudioClip(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    void PlayRandomAudioClip(AudioClip[] clips, List<AudioClip> usedClips)
    {
        if (clips.Length > 0)
        {
            /*AudioClip selectedClip = GetUniqueClip(clips, usedClips);
            if (selectedClip != null)
            {
                PlayAudioClip(selectedClip);
                usedClips.Add(selectedClip);
            }
            else
            {
                Debug.Log("No more unique audio clips available for this mode.");
            }*/
            //Debug.Log("Test");
        }
        else
        {
            //Debug.Log("No audio clips available for this mode.");
        }
    }
    /*
    void GetUniqueClip(AudioClip[] clips, List<AudioClip> usedClips)
    {
        List<AudioClip> availableClips = new List<AudioClip>();

        foreach (var clip in clips)
        {
            if (!usedClips.Contains(clip))
            {
                availableClips.Add(clip);
            }
        }

        if (availableClips.Count > 0)
        {
            int randomIndex = Random.Range(0, availableClips.Count);
            return availableClips[randomIndex];
        }
        else
        {
            return null;
        }
    }
    */

}
