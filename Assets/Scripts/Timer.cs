using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int Time = 30;
    [SerializeField] 
    private Text _timerText;
    [SerializeField] 
    private Defit _defit;

    public void StartTimer()
    {
        _timerText.text = Time.ToString();
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while (Time > 0)
        {    
            yield return new WaitForSeconds(1);
            Time--;
            _timerText.text = Time.ToString();
        }
        _defit.Lose();
    }
}
