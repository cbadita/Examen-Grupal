using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClickButton : MonoBehaviour
{
    protected int clickCounter;

    public abstract void OnClick();

    public void IncreaseCounter()
    {
        clickCounter++;
        Debug.Log("Click Count:" + clickCounter);
    }
}

