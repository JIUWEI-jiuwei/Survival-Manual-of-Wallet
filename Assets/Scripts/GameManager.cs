using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    public int currSuccessNum;
    public GameObject[] allIncidentPrefabs;

    /// <summary>Îå¸öµ¯´° </summary>
    public GameObject[] windows;

    public void TriggerIncident()
    {
        SceneChanger.Instance.SceneTransition("incidentScene");
    }
}