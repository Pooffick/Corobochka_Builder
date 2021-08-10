using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] 
    private GameObject _obuchenie;
    private GameObject _timer;
    
    private void Start()
    {
        _timer = GameObject.Find("loseColider");
    }
    
    public void StartGameEz()
    {
        Destroy(_obuchenie);
        _timer.GetComponent<Timer>().time = 1800;
        _timer.GetComponent<Timer>().StartTimer();
    }
    
    public void StartGameMid()
    {
        Destroy(_obuchenie);
        _timer.GetComponent<Timer>().time = 60;
        _timer.GetComponent<Timer>().StartTimer();
    }
    
    public void StartGameHard()
    {
        Destroy(_obuchenie);
        _timer.GetComponent<Timer>().time = 20;
        _timer.GetComponent<Timer>().StartTimer();
    }
}
