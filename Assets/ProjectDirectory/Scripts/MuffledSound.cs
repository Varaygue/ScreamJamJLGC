using UnityEngine;
using UnityEngine.Audio;

public class MuffledSound : MonoBehaviour
{
    public AudioSource audioSource;
    public FirstPersonController script;

    void Update()
    {
        // Check if the "isHiding" flag is set to true
        if (script.isHiding==true)
        {
            // Adjust the pitch parameter of the Audio Mixer
            audioSource.pitch = 0.75f;
        }
        else
        {
            // Reset the pitch parameter to its default value
            audioSource.pitch = 1f;
        }
    }
}
