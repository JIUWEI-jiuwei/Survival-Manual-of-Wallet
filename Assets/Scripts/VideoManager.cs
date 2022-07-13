using UnityEngine.Video;
using UnityEngine;

/// <summary>
/// ��Ƶ������
/// </summary>
public class VideoManager : MonoBehaviour
{
    /// <summary>����CG </summary>
    public VideoPlayer videoPlayer;
    /// <summary>BGM</summary>
    public AudioSource audioSource;

    /// <summary>
    /// ���ſ���CG
    /// </summary>
    public void StartCGPlay()
    {
        videoPlayer.Play();
        audioSource.Stop();
    }
    private void Update()
    {
        if (videoPlayer != null)
        {
            if (videoPlayer.isPlaying && videoPlayer.clip.name == "startCG")
            {
                if ((int)videoPlayer.frame >= (int)videoPlayer.frameCount - 3)
                {
                    videoPlayer.Stop();
                    audioSource.Play();
                }
            }
        }
    }
}
