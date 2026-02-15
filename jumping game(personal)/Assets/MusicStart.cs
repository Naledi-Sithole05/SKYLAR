using UnityEngine;

public class StartMusic : MonoBehaviour
{
    [SerializeField] private AudioClip music;

    void Start()
    {
        MusicManager.Instance.Play(music);
    }
}
