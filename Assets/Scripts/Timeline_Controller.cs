using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_Controller : MonoBehaviour
{
    public PlayableDirector cameraControl;
    // Start is called before the first frame update
    void Start()
    {
        PlayAnimCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimCamera()
    {
        cameraControl.Play();
    }
}
