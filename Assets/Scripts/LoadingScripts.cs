using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// ���س���
/// </summary>
public class LoadingScripts : MonoBehaviour
{

    public string sceneName;

    /// <summary>
    /// ��ת��һ����
    /// </summary>
    public void NextLayer()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
