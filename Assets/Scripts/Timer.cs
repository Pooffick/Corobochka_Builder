using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int time = 30;
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject defit;

    public void StartTimer()
    {
        timerText.text = time.ToString();
        StartCoroutine(_Timer());
    }
    IEnumerator _Timer()
    {
        while (time > 0)
        {    
            yield return new WaitForSeconds(1);
            time--;
            timerText.text = time.ToString();
        }
        defit.GetComponent<Defit>().lose = true;
        defit.GetComponent<Defit>().image.SetActive(true);
    }

}
