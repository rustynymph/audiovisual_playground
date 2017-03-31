using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkSyncSequencer : NetworkBehaviour {

	[SyncVar]
	public bool seq1;
	[SyncVar]
	public bool seq2;
	[SyncVar]
	public bool seq3;
	[SyncVar]
	public bool seq4;
	[SyncVar]
	public bool seq5;
	[SyncVar]
	public bool seq6;
	[SyncVar]
	public bool seq7;
	[SyncVar]
	public bool seq8;

	void Update(){
		Sequencer sequencer = gameObject.GetComponent<Sequencer>();
		seq1 = sequencer.sequence[0];
		seq2 = sequencer.sequence[1];
		seq3 = sequencer.sequence[2];
		seq4 = sequencer.sequence[3];
		seq5 = sequencer.sequence[4];
		seq6 = sequencer.sequence[5];
		seq7 = sequencer.sequence[6];
		seq8 = sequencer.sequence[7];
		Debug.Log("0: " + seq1);
	}

}