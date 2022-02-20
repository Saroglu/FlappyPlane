using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    Text _text;
    private float _timer;

    void Awake()
    {
        _text = GetComponent<Text>();
    }

    void Start()
    {
        //text'e yazi atma islemi
        _text.text = "timer";
    }

    //bu islem update icinde olmali
    void Update()
    {
        _timer += Time.deltaTime;
        int seconds = Mathf.FloorToInt(_timer);
        _text.text = seconds.ToString("0000");
    }
}
