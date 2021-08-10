using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private int _time = 30;
    [SerializeField] 
    private Text _timerText;
    [SerializeField] 
    private Defit _defit;

    public void AddTime(uint time)
    {
        _time += time;
    }

    public void StartTimer(int time)
    {
        _time = time;
        _timerText.text = _time.ToString();
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (_time > 0)
        {    
            yield return new WaitForSeconds(1);
            _time--;
            _timerText.text = _time.ToString();
        }
        _defit.Lose();
    }
}
