using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] 
    private GameObject _obuchenie;
    private Timer _timer;
    
    private void Start()
    {
        _timer = GameObject.Find("loseColider").GetComponent<Timer>();
    }
    
    public void StartGameEz()
    {
        Destroy(_obuchenie);
        _timer.StartTimer(1800);
    }
    
    public void StartGameMid()
    {
        Destroy(_obuchenie);
        _timer.StartTimer(60);
    }
    
    public void StartGameHard()
    {
        Destroy(_obuchenie);
        _timer.StartTimer(20);
    }
}
