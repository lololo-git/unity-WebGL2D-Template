﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    private void Start()
    {
        // Play sound..
    }

    public void OnStartButton()
    {
        SceneManager.LoadScene("Game");
    }
}