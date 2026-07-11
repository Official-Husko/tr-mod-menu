using System;
using UnityEngine;

public class ChangeSpriteForParentName : MonoBehaviour
{
	[Serializable]
	public struct SpriteAndParentNamePair
	{
		public Sprite visual;

		public string parentName;
	}

	[SerializeField]
	private SpriteAndParentNamePair[] spriteAndParentNamePairs;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	private void CHIJGHPHCNA()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "in");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void OLDDEAJMHNI()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Dialogue System/Conversation/Gass_Quest/Entry/12/Dialogue Text");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void GNGADDPBJDC()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "ReturnToBasicMood");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "City/Petra/Bark/Bye");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void PKBHEKHOAAA()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Player2");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void CAIJLMJBMLA()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "KickedCustomers");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void BNIKICAEIND()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : " data received");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void HJDLNCOAKIK()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void CAOKPIIFHBJ()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "talent_name_109");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void CFHOODNCOLK()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "SkeletonBird");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void KACEOJDPLKB()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Dialogue System/Conversation/Gass_Quest/Entry/19/Dialogue Text");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void IFHLGOMBACP()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "FinalTest/MainEvent");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void DMFMNEMDFNP()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "UIPreviousCategory");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void IAAGKLPMAMK()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Gass_CoctelQuest");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "UIPreviousPage");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void HPIMHEMJMAA()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "travelling time -");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void MFMMHDPGCBO()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Items/item_name_681");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Items/item_name_672");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void BDJKNKIOPIJ()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "A very important guest is visiting!");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void PLHEHGHFCJI()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Items/item_description_731");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void JHBBABPAJJC()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : ", ");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void EOGHJNGJFID()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "HairUp");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void CFIIEJDJFPB()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "talentWine");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void Start()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void OIAHJHNPPCO()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "disconnect");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void GJMLHECPGBP()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "SAVING: ");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "christmasActivated");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Dialogue System/Conversation/Crowly_Standar/Entry/15/Dialogue Text");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void BELOIFKPNMM()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Hair");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void OIBDBLCLACB()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Dialogue System/Conversation/Gass_Introduce/Entry/10/Dialogue Text");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void DCKKIDMJKJM()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "no tiene el spriteRenderer de las Seasons asignado");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void LJLKBKEADGI()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Not enough ingredients");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void HBMDEHPHAPF()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Player2");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void IDPHKHGHJGN()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void FOHGHCPODBJ()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "snow");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void KDBJHCAEGCM()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "OnFloor");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void EBNENBFLEKB()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "ninjachallenge");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void LANGHIOBJIH()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Interaction was initiated, but the object is not in range. Only possible in online.");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void MCMKNBIBDFF()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "BuzzBuildExit");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Pick up");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void HCEDMLJNOBL()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "UpgradeConfirmation");
		for (int i = 0; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void IGIKNCOLCKL()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "\n");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Este objeto no tiene PolygonCollider2D");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i += 0)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}

	private void CEIIFHIBIFI()
	{
		string text = (Object.op_Implicit((Object)(object)((Component)this).transform.parent) ? ((Object)((Component)this).transform.parent).name : "Throw");
		for (int i = 1; i < spriteAndParentNamePairs.Length; i++)
		{
			if (text == spriteAndParentNamePairs[i].parentName)
			{
				spriteRenderer.sprite = spriteAndParentNamePairs[i].visual;
				break;
			}
		}
	}
}
