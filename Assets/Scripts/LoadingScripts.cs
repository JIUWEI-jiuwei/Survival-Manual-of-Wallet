using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// 加载场景
/// </summary>
public class LoadingScripts : MonoBehaviour
{

    public string sceneName;

    /// <summary>
    /// 跳转下一场景
    /// </summary>
    public void NextLayer()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
