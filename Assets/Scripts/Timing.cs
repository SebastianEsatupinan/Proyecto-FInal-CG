using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{
    public TextMeshProUGUI timerMinutos;
    public TextMeshProUGUI timerSegundo;
    public TextMeshProUGUI timerMilisegundos;

    private float starTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    public float StarTime { get => starTime; set => starTime = value; }
    public float StopTime { get => stopTime; set => stopTime = value; }
    public float TimerTime { get => timerTime; set => timerTime = value; }
    public bool IsRunning { get => isRunning; set => isRunning = value; }

    // Implementaci�n del patr�n Singleton
    private static Timing _instance;
    public static Timing Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Timing>();
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("Timing");
                    _instance = singletonObject.AddComponent<Timing>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        // Asegura que este objeto persista entre escenas
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        TimerStart();
    }

    // Update is called once per frame
    void Update()
    {
        timerTime = stopTime = (Time.time - starTime);
        int minutosInt = (int)timerTime / 60;
        int segundosInt = (int)timerTime % 60;
        int milisegundosInt = (int)(Mathf.Floor((timerTime - (segundosInt + minutosInt * 60)) * 100));

        if (IsRunning)
        {
            timerMinutos.text = (minutosInt < 10) ? "0" + minutosInt : minutosInt.ToString();
            timerSegundo.text = (segundosInt < 10) ? "0" + segundosInt : segundosInt.ToString();
            timerMilisegundos.text = (milisegundosInt < 10) ? "0" + milisegundosInt : milisegundosInt.ToString();

        }

    }

    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        IsRunning = false;
        timerMinutos.text = timerSegundo.text = timerMilisegundos.text = "00";
    }

    public void TimerStart()
    {
        if (!IsRunning)
        {
            print("START");
            IsRunning = true;
            starTime = Time.time;
        }
    }

    public void TimerStop()
    {
        if (IsRunning)
        {
            print("STOP");
            IsRunning = false;
            stopTime = timerTime;
            Debug.Log(stopTime.ToString());
        }
    }



}
