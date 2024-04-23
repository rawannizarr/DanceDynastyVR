using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhenPressDisappear : MonoBehaviour
{
    public Button Button;

    private void Start()
    {
       Button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Destroy(gameObject);
    }
}