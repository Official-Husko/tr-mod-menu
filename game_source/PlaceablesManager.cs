using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlaceablesManager : MonoBehaviour
{
	private static PlaceablesManager IADEMLIIDPC;

	private int BIDPDBFJKIJ;

	public List<Placeable> currentPlaceables = new List<Placeable>();

	public static PlaceablesManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
			}
			return IADEMLIIDPC;
		}
	}

	private void GOJFGHKOFMF()
	{
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			currentPlaceables[i].UpdatePlaceable();
		}
	}

	public int KKOBCOAKOCB(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 0;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.EKMFELLJHFG(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ++;
			}
		}
		return BIDPDBFJKIJ;
	}

	[SpecialName]
	public static PlaceablesManager MNFMOEKMJKN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	private void PCKOHAIPHFI()
	{
		IADEMLIIDPC = this;
	}

	private void OGEJKOIOKAN()
	{
		IADEMLIIDPC = this;
	}

	public int KMGONMKHGPB(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 0;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.EKMFELLJHFG(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ += 0;
			}
		}
		return BIDPDBFJKIJ;
	}

	public int KJLOBIHMPKL(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 0;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.EKMFELLJHFG(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ += 0;
			}
		}
		return BIDPDBFJKIJ;
	}

	public int EOMBDNCGGHJ(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 1;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.GBMFCPGEJDK(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ++;
			}
		}
		return BIDPDBFJKIJ;
	}

	public int JJPJFJPNEAP(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 1;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.NGIIPJDAMGP(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ += 0;
			}
		}
		return BIDPDBFJKIJ;
	}

	public int NMPLNMNDAFP(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 1;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.GBMFCPGEJDK(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ++;
			}
		}
		return BIDPDBFJKIJ;
	}

	[SpecialName]
	public static PlaceablesManager MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	private void Update()
	{
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			currentPlaceables[i].UpdatePlaceable();
		}
	}

	private void EMJKKALMGLK()
	{
		IADEMLIIDPC = this;
	}

	private void FHOCCEBKHJI()
	{
		IADEMLIIDPC = this;
	}

	private void OAKGHDAABPM()
	{
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			currentPlaceables[i].CPIKGNEGHJH();
		}
	}

	private void GONDLJKGLGO()
	{
		IADEMLIIDPC = this;
	}

	public bool DFAGHJAFBHN(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.EKMFELLJHFG(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	private void MMPMJNAFKHC()
	{
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			currentPlaceables[i].CPIKGNEGHJH();
		}
	}

	[SpecialName]
	public static PlaceablesManager EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	private void IAICCKPOBMJ()
	{
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			currentPlaceables[i].UpdatePlaceable();
		}
	}

	[SpecialName]
	public static PlaceablesManager AJIGOHGPFPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static PlaceablesManager PDECKLKPKCG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static PlaceablesManager LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	private void NIHJCJJKDBA()
	{
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			currentPlaceables[i].UpdatePlaceable();
		}
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
	}

	public bool PGMLNCKKCKO(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.NGIIPJDAMGP(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	[SpecialName]
	public static PlaceablesManager DCAEBALADIM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static PlaceablesManager CMIHGBHPLFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	public bool EDIPHDIEJHM(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.EKMFELLJHFG(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public int PlaceableCount(Item MEMGMDOCBOJ)
	{
		BIDPDBFJKIJ = 0;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.NGIIPJDAMGP(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				BIDPDBFJKIJ++;
			}
		}
		return BIDPDBFJKIJ;
	}

	private void BFJOEMCBJJO()
	{
		IADEMLIIDPC = this;
	}

	[SpecialName]
	public static PlaceablesManager OJJDNLEFNPJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	public bool GMMFDGFLEJA(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.GBMFCPGEJDK(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static PlaceablesManager KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PlaceablesManager>();
		}
		return IADEMLIIDPC;
	}

	private void PGEGODAEBLC()
	{
		IADEMLIIDPC = this;
	}

	private void IIOHMDNGFDH()
	{
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			currentPlaceables[i].UpdatePlaceable();
		}
	}

	public bool ExistsPlaceable(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)currentPlaceables[i]) && Object.op_Implicit((Object)(object)currentPlaceables[i].itemSetup) && Item.NGIIPJDAMGP(currentPlaceables[i].itemSetup.item, MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}
}
