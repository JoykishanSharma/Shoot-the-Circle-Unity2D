﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int PinCount;
	public Text text;
	void Start()
    {
        PinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PinCount.ToString();
    }
}
