using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButton : ClickButton, IGameObjectObserver
{
    private void Start()
    {
        GameController.Instance.AddObserver(this);
    }

    private void OnDestroy()
    {
        GameController.Instance.RemoveObserver(this);
    }

    public override void OnClick()
    {
        IncreaseCounter();

        SceneManager.LoadScene("Credits");
    }

    public void OnNotify()
    {
        IncreaseCounter();
    }
}
