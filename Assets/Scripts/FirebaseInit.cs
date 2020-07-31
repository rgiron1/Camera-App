using Firebase;
using Firebase.Analytics;
using Firebase.Storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FirebaseInit : MonoBehaviour
{

    public UnityEvent onFirebaseInitialized = new UnityEvent();
    // Start is called before the first frame update
    private async void Start()
    {
        var dependencyStatus = await FirebaseApp.CheckAndFixDependenciesAsync();
        if (dependencyStatus == DependencyStatus.Available)
        {
            onFirebaseInitialized.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
