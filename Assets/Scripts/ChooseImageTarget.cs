/*
* Copyright (c) ZeroSlide
* http://zeroslide.com/
*/

using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class ChooseImageTarget : MonoBehaviour, ITrackableEventHandler {

    private TrackableBehaviour mTrackableBehaviour;
    public GameObject _focusPane;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
        	_focusPane.SetActive(false);
        	Time.timeScale = 1;
        }
        else
        {
        	_focusPane.SetActive(true);
        	Time.timeScale = 0;
        }
    }
}