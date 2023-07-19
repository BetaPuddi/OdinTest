using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParty : Party
{
    private void OnValidate()
    {
        SetParty();
    }
    public void SetParty()
    {
        partyMembers.Clear();
        for (int i = 0; i < this.transform.childCount; i++)
        {
            partyMembers.Add(this.transform.GetChild(i).GetComponent<Player>());
        }
    }
}
