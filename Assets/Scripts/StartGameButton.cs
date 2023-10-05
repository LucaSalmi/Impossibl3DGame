using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartGameButton : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(1,1,1);
    }

    public void HoverStart()
    {
        transform.localScale = Vector3.one * 1.1f;
    }
    
    public void HoverEnd()
    {
        transform.localScale = Vector3.one;
    }

    public void StartClick()
    {
        var mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.grey;
        mr.material.SetColor("_EmissionColor", Color.green);
    }
    public void EndClick()
    {
        var mr = GetComponent<MeshRenderer>();
        mr.material.color = Color.white;
        mr.material.SetColor("_EmissionColor", Color.red);
        
    }

    public void Click()
    {
        SceneManager.LoadScene(0);
    }
}