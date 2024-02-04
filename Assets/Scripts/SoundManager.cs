using UnityEngine;

namespace KID
{
    [DefaultExecutionOrder(0)]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;
        private AudioSource aud;
        private void Awake()
        {
          instance = this;
          aud = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
            aud.PlayOneShot(sound);

    }

    
}