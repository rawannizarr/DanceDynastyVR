using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadArenaScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGardenScene()
    {
        SceneManager.LoadScene(1);

    }

    public void LoadIndoorScene()
    {
        SceneManager.LoadScene(2);

    }


}

