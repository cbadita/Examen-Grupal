using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    public GameObject interfaceObject;
    public GameObject bouncingObject;

    public bool interfaceVisible;
    private float timeWithoutInteraction = 0f;

    private List<IGameObjectObserver> observers = new List<IGameObjectObserver>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ShowInterface();
    }

    private void Update()
    {
        if (!interfaceVisible)
        {
            timeWithoutInteraction += Time.deltaTime;
            if (timeWithoutInteraction >= 5f)
            {
                bouncingObject.SetActive(true);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!interfaceVisible)
            {
                ShowInterface();
            }
            else
            {
                timeWithoutInteraction = 0f;
            }
        }
    }

    public void AddObserver(IGameObjectObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IGameObjectObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.OnNotify();
        }
    }

    private void ShowInterface()
    {
        interfaceVisible = true;
        interfaceObject.SetActive(true);
        bouncingObject.SetActive(false);
    }

    public void HideInterface()
    {
        interfaceVisible = false;
        interfaceObject.SetActive(false);
    }
}
