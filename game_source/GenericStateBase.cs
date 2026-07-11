using UnityEngine;

public class GenericStateBase : GenericState, IStateFunctions
{
	protected GenericStateMachine AGCLAOMNOGI;

	public virtual int PJCJDHLNOHN()
	{
		return -1;
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		if (GDHCBGCIIKG)
		{
			Debug.Log((object)(((object)this).ToString() + " UpdateState()."));
		}
	}

	public virtual string GIEGKNMCIGC()
	{
		return "CalculateTriggerInstensity() returns ";
	}

	public virtual string ECGCLKBHBAK()
	{
		return "%";
	}

	public virtual int NAENMNNCHIO()
	{
		return -1;
	}

	public virtual string JOAKMGEFHDB()
	{
		return "Fly";
	}

	public virtual int OGBJBHAINOC()
	{
		return -1;
	}

	public virtual string JFKAMOFJFDK()
	{
		return ":</color> ";
	}

	public virtual int HMJEJFAHEKJ()
	{
		return -1;
	}

	public virtual string GAIOFKDEGCJ()
	{
		return "Items/item_name_616";
	}

	public virtual string CALAIMKFHJC()
	{
		return "Game";
	}

	public virtual int MHOMONJLOBL()
	{
		return -1;
	}

	public virtual int EAHCHMKILCL()
	{
		return -1;
	}

	public virtual string OBBIDEAEDFJ()
	{
		return "Open";
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		if (GDHCBGCIIKG)
		{
			Debug.Log((object)(((object)this).ToString() + " ExitState()."));
		}
	}

	public virtual string INMDBAJNIEB()
	{
		return "Was master: {0}";
	}

	public virtual string IDFCMGAEOFJ()
	{
		return "Invalid symbol index {0}";
	}

	public virtual string IMNFFPEGEGB()
	{
		return "Dialogue System/Conversation/BirdPositiveComments/Entry/10/Dialogue Text";
	}

	public virtual string AFDJJELOCEP()
	{
		return "Tutorial/T102/Dialogue1";
	}

	public virtual string FAILMFNGBCC()
	{
		return "BarnTutorialDone";
	}

	public virtual string AFDAEJMMDJF()
	{
		return "ReceiveLastOrder";
	}

	public virtual string GAHAOPGEBDA()
	{
		return "Placed item has no item setup component: ";
	}

	public virtual int HJGAONPJHFL()
	{
		return -1;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		if (GDHCBGCIIKG)
		{
			Debug.Log((object)(((object)this).ToString() + " EnterState()."));
		}
	}

	public virtual int LCLNMMCICJG()
	{
		return -1;
	}

	public virtual int PCAHAEIHBBB()
	{
		return -1;
	}

	public virtual string OKGMNDPAPGM()
	{
		return ">";
	}

	public virtual string POKHIFBFHBF()
	{
		return "Items/item_description_672";
	}

	public virtual string AAKNOPLCBLK()
	{
		return "";
	}

	public virtual string GLBFDLBEKOM()
	{
		return "HarvestableEveryXDays";
	}

	public virtual int PNPNDEOAHAI()
	{
		return -1;
	}

	public virtual int PBDDMJKOLJC()
	{
		return -1;
	}

	public virtual int IAEKIGLIHCO()
	{
		return -1;
	}

	public virtual string JIAOIHPAENF()
	{
		return "Items/item_name_1047";
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		if (GDHCBGCIIKG)
		{
			Debug.Log((object)(((object)this).ToString() + " FixedState()."));
		}
	}

	public virtual string NMMJCGNIKMK()
	{
		return "00";
	}

	public virtual string BBBPPJMIGMF()
	{
		return "Crafter not attached on OnlineCrafter of placeable ";
	}

	public virtual int HOEECPHFHAD()
	{
		return -1;
	}

	public virtual string MGMMAAMIAFB()
	{
		return "Direction";
	}

	public virtual int EDEOOIFHKDO()
	{
		return -1;
	}

	public virtual int MKFCKADLFPM()
	{
		return -1;
	}

	public virtual string IPGPAIKIDKK()
	{
		return "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/11/Dialogue Text";
	}

	public virtual string GetStateName()
	{
		return "GENERIC STATE - NAME UNDEFINED";
	}

	public virtual int GetStateEnumID()
	{
		return -1;
	}

	public virtual string PDPIDMLDFKM()
	{
		return "Items/item_description_1141";
	}

	public virtual string ABEKCEGCNNB()
	{
		return "Running";
	}

	public virtual int OIKHJFNDAKE()
	{
		return -1;
	}

	public virtual string LCDFOFIPIBA()
	{
		return "Items/item_description_675";
	}

	public virtual string AIIDOGMHJFL()
	{
		return "Items/item_name_1031";
	}

	public virtual string CFGCHBBFKJC()
	{
		return ")";
	}

	public override void InitializeState(GenericStateMachine ELKILIBAAKF, bool GDHCBGCIIKG = false)
	{
		if (GDHCBGCIIKG)
		{
			Debug.Log((object)(((object)this).ToString() + " InitializedState()."));
			if (base.GGJFEPEOLJA)
			{
				Debug.LogWarning((object)(((object)this).ToString() + " is trying to initialize more than once."));
			}
			else
			{
				Debug.Log((object)(((object)this).ToString() + "First initialization."));
			}
		}
		base.GGJFEPEOLJA = true;
	}

	public virtual int KFICKCHHNKA()
	{
		return -1;
	}
}
