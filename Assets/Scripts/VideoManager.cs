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
    public Transform l2;
    public Transform l3;
   
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
                    //���ֽ�ɫ��������
                    l2.GetChild(0).gameObject.SetActive(true);
                    l2.GetChild(1).gameObject.SetActive(true);


                }
            }
        }
    }
    /// <summary>
    /// �����ʼ��Ϸ�����ſ���CG
    /// </summary>
    public void StartCGPlay()
    {
        videoPlayer.Play();
        audioSource.Stop();
    }

    public void L2Back()
    {
        l2.GetChild(0).gameObject.SetActive(false);
        l2.GetChild(1).gameObject.SetActive(false);
    }
    public void L2Next()
    {
        l2.GetChild(0).gameObject.SetActive(false);
        l2.GetChild(1).gameObject.SetActive(false);
        l3.GetChild(0).gameObject.SetActive(true);
        l3.GetChild(1).gameObject.SetActive(true);
    }
    public void L3Back()
    {
        l2.GetChild(0).gameObject.SetActive(true);
        l2.GetChild(1).gameObject.SetActive(true);
        l3.GetChild(0).gameObject.SetActive(false);
        l3.GetChild(1).gameObject.SetActive(false);
    }
    

}
