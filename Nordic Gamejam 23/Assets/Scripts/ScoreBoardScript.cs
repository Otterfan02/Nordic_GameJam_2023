using System.Collections;
using System.Collections.Generic;
using Coherence;
using Coherence.Toolkit;
using UnityEngine;
using TMPro;

public class ScoreBoardScript : MonoBehaviour
{
    public CoherenceMonoBridge bridge;
    public IEnumerable<CoherenceClientConnection> clientList;
    public ArrayList nameList;
    public ArrayList scoreList;
    public TMP_Text scoreBoardText;
    // Start is called before the first frame update
    void Start()
    {
        
        bridge.ClientConnections.OnSynced += ClientConnections_OnSynced;
    }

    private void ClientConnections_OnSynced(CoherenceClientConnectionManager obj = null)
    {
        //Debug.Log("Test");
        nameList = new ArrayList();
        scoreList = new ArrayList();
        clientList = bridge.ClientConnections.GetAll();
        foreach (var clientConection in clientList)
        {

            nameList.Add((clientConection.GameObject.GetComponent<Client>().clientName));
            scoreList.Add(clientConection.GameObject.GetComponent<Client>().clientScore);
            //Debug.Log(scoreList[0]);
        }
    }
    private void Update()
    {
        try
        {
            scoreBoardText.text = null;
            int i = 0;
            foreach (var user in nameList)
            {
                scoreBoardText.text += nameList[i] + " " + Mathf.Round((float)scoreList[i]) + "\n";
                i++;

            }
        }
        catch
        {
            return;
        }
    }


    public void reBuildList()
    {
        ClientConnections_OnSynced();


    }
}
