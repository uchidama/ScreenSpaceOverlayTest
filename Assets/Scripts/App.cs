using UnityEngine;

public class App : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickQuit()
    {
        Debug.Log("OnClickQuit");
        Application.Quit();
    }
}
