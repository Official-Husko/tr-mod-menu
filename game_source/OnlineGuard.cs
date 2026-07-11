using Photon.Pun;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public class OnlineGuard : OnlineBaseCharacter
{
	private void OJNJOJKNBPE()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = false;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = true;
		}
	}

	private void ENEDNDEEPHJ()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = true;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = true;
		}
	}

	private void Start()
	{
		JKLCEMHACDF();
	}

	protected override void MKFDEDDJMBG()
	{
		PPHIMGHODKK = "Guard";
	}

	private void LANGHIOBJIH()
	{
		OJNJOJKNBPE();
	}

	private void GHPFCKGMLDA()
	{
		LPGHPDEJAMA();
	}

	private void KOBBANBDAMN()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = false;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = true;
		}
	}

	private void LPGHPDEJAMA()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = false;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = true;
		}
	}

	private void BDJKNKIOPIJ()
	{
		JKLCEMHACDF();
	}

	private void JKLCEMHACDF()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = false;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = false;
		}
	}

	private void PLHEHGHFCJI()
	{
		ENEDNDEEPHJ();
	}

	private void GBBAIOAHJND()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = true;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = false;
		}
	}

	private void HCEDMLJNOBL()
	{
		NDNIEDJBCFP();
	}

	private void NDNIEDJBCFP()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			((Behaviour)((Component)this).GetComponent<GuardNPC>()).enabled = true;
			((Behaviour)((Component)this).GetComponentInChildren<NPCAnimation>()).enabled = true;
		}
	}

	private void OLDDEAJMHNI()
	{
		NDNIEDJBCFP();
	}
}
