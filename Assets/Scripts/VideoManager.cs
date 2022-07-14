using UnityEngine.Video;
using UnityEngine;

/// <summary>
/// 视频管理器
/// </summary>
public class VideoManager : MonoBehaviour
{
    /// <summary>开场CG </summary>
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
                    //出现角色档案界面
                    l2.GetChild(0).gameObject.SetActive(true);
                    l2.GetChild(1).gameObject.SetActive(true);


                }
            }
        }
    }
    /// <summary>
    /// 点击开始游戏，播放开场CG
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
