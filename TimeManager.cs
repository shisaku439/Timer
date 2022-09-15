using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


public class TimeManager
{
    private static TimeManager tManager = null;
    [SerializeField]
    private float timer;
    private DateTime startTime;
    private TimeSpan timeSpan;
    private bool stopFlag=true;

    public static TimeManager GetInstance()
    {
        return tManager ?? (tManager =new TimeManager());
    }


    //�o�ߎ��Ԃ̎擾
    public static float GetTime()
    {
        return GetInstance()._GetTime();
    }

    private float _GetTime()
    {
        if (stopFlag == true) return timer;
        return GetInstance().timer += GetInstance().GetSpan();
    }

    //�O�񂩂�̌o�ߎ��Ԏ擾
    private float GetSpan()
    {
        float span = 0;
        timeSpan = DateTime.Now - startTime;
        span= (float)timeSpan.TotalSeconds;
        startTime = DateTime.Now;
        return span;
    }

    //�^�C�}�[�J�n
    public static void StartTimer()
    {
        GetInstance()._StartTimer();           
    }
    private void _StartTimer()
    {
        startTime = DateTime.Now;
        stopFlag = false;
    }

    //�ꎞ��~
    public static void StopTimer()
    {
        GetInstance()._StopTime();
    }
    private void _StopTime()
    {
        timer += GetSpan();
        stopFlag = true;
    }

    //���Z�b�g
    public static void ResetTimer()
    {
        GetInstance()._StopTime();
        GetInstance().timer = 0;
    }


}

//[CustomEditor(typeof(TimeManager))]
//public class TimeManagerEditor : Editor 
//{
//    public override void OnInspectorGUI()
//    {
//        base.OnInspectorGUI();
//        if (GUILayout.Button("StartTime"))
//        {
//            TimeManager.StartTimer();
//        }
//        if (GUILayout.Button("StopTime"))
//        {
//            TimeManager.StopTimer();
//        }
//        if (GUILayout.Button("ResetTime"))
//        {
//            TimeManager.ResetTimer();
//        }
//    }
//}

