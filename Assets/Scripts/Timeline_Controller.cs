using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_Controller : MonoBehaviour
{
    public PlayableDirector cameraControl;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        cameraControl.stopped += OnPlayableDirectorStopped;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimCamera();
        }
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (cameraControl == aDirector)
        {
            Debug.Log("PlayableDirector named " + aDirector.name + " is now stopped.");
            player.SetActive(true);
        }
            
            
    }

    public void PlayAnimCamera()
    {
        cameraControl.Play();
    }
    void OnDisable()
    {
        cameraControl.stopped -= OnPlayableDirectorStopped;
    }
}
