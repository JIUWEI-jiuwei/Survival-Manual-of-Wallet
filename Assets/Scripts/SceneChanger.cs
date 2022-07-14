using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : Singleton<SceneChanger>
{

    public SceneFader sceneFaderPrefab;

    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);
    }

    public void SceneTransition(string sceneName)
    {
        StartCoroutine(TransitionToScene(sceneName));
        return;

    }

    IEnumerator TransitionToScene(string sceneName)
    {

        SceneFader sceneFader = Instantiate(sceneFaderPrefab);
        yield return sceneFader.FadeOut(1f);

        yield return SceneManager.LoadSceneAsync(sceneName);


        yield return sceneFader.FadeIn(1f);
        yield break;
    }


}