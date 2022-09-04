﻿using UnityEngine;

[CreateAssetMenu]
public class ParamsSO : ScriptableObject
{
    [Header("Time limit")]
    [Range(30, 60)]
    public int TimeLimit;

    //Singleton

    public const string PATH = "ParamsSO";
    private static ParamsSO _entity;

    public static ParamsSO Entity
    {
        get
        {
            if (_entity == null)
            {
                _entity = Resources.Load<ParamsSO>(PATH);

                if (_entity == null)
                {
                    Debug.LogError(PATH + " not found");
                }
            }
            return _entity;
        }
    }
}