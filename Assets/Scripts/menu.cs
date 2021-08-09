using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    [SerializeField] private GameObject obuchenie;
    [SerializeField] private GameObject _Timer;
    private void Start()
    {
        _Timer = GameObject.Find("loseColider");
    }
    public void StartGameEz()
    {
        Destroy(obuchenie);
        _Timer.GetComponent<Timer>().time = 1800;
        _Timer.GetComponent<Timer>().StartTimer();
    }
public void StartGameMid()
    {
        Destroy(obuchenie);
        _Timer.GetComponent<Timer>().time = 60;
        _Timer.GetComponent<Timer>().StartTimer();
    }
public void StartGameHard()
    {
        Destroy(obuchenie);
        _Timer.GetComponent<Timer>().time = 20;
        _Timer.GetComponent<Timer>().StartTimer();
    }
}
