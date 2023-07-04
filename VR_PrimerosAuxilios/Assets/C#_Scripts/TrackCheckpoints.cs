using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TrackCheckpoints : MonoBehaviour
{
    public event EventHandler OnPlayerCorrectCheckpoint;
    public event EventHandler OnPlayerWrongCheckpoint;


    private List<CheckpointSingle> checkpointSingleList;
    private int nextCheckpointSnigleIndex;
    private void Awake()
    {

        Transform checkpointsTransform = transform.Find("Checkpoints");
        checkpointSingleList = new List<CheckpointSingle>();

        foreach ( Transform checkponitSingleTransform in checkpointsTransform)
        {
            Debug.Log(checkponitSingleTransform);
            CheckpointSingle checkpointSingle = checkponitSingleTransform.GetComponent<CheckpointSingle>();
            
            
            checkpointSingle.SetTrckCheckpoints(this);
            
            checkpointSingleList.Add(checkpointSingle);
        }

        nextCheckpointSnigleIndex = 0;
    }

    public void PlayerTroughCheckpoint(CheckpointSingle checkpointSingle)
    {
        if (checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSnigleIndex)
        {
            //CorrectCheckpoint
            Debug.Log("correctCheckpoint");
            nextCheckpointSnigleIndex++;
            OnPlayerCorrectCheckpoint?.Invoke(this, EventArgs.Empty);
        }
        else
        {
            Debug.Log("WrongCheckpoint");
            //WrongCheckpoint
            OnPlayerWrongCheckpoint?.Invoke(this, EventArgs.Empty);
        }

       
    }
}
