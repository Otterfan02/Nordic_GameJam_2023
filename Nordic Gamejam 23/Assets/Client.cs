using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence.Toolkit;
using Coherence.UI;

public class Client : MonoBehaviour
{
    public string clientName;
    public float clientScore;
    public CoherenceSync ScoreBoardSync;

    private void Awake()
    {
        clientName = Coherence.UI.WorldsConnectDialog.PlayerName;
    }
    private void Start()
    {
        ScoreBoardSync = FindObjectOfType<ScoreBoardScript>().GetComponent<CoherenceSync>();
    }

    public void changeScore( float newScore)
    {
        clientScore = newScore;
        ScoreBoardSync.SendCommand<ScoreBoardScript>(nameof(ScoreBoardScript.reBuildList), Coherence.MessageTarget.All);
    }

}
