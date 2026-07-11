using System.Runtime.CompilerServices;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelectUI : MonoBehaviour
{
	[SerializeField]
	private GameLanguage language;

	public GameLanguage LHEMLBGALAL
	{
		get
		{
			return language;
		}
		set
		{
			language = value;
			OOKHODGBACJ();
		}
	}

	[SpecialName]
	public void FBKEMEONPAK(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		HNMJJAFILNC();
	}

	[SpecialName]
	public GameLanguage HMJHLGLNODP()
	{
		return language;
	}

	[SpecialName]
	public void ACPDHBJGBBJ(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		EACDNLPEGJF();
	}

	[SpecialName]
	public GameLanguage NDJMPFNMANN()
	{
		return language;
	}

	[SpecialName]
	public GameLanguage DKBDJDPCFOK()
	{
		return language;
	}

	[SpecialName]
	public void KLCAMIOJAJL(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		PFCCAOOJAKC();
	}

	public void GPFMONEHIPO()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.CMIBBDJLMBM = LHEMLBGALAL;
		if (Application.isEditor)
		{
			Debug.Log((object)("Rummage" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.NJNFHEPLEHL().KKCIALNAGCA(MJHBHDAEDLF: false);
	}

	public void PPDDNKJBBHE()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.BALLKBAGCDD(LHEMLBGALAL);
		if (Application.isEditor)
		{
			Debug.Log((object)("Looking up current user name..." + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.OJJDNLEFNPJ().JBHEIMCIFLN(MJHBHDAEDLF: false);
	}

	[SpecialName]
	public void ONDDNGJJDOG(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		FIPFINKFIAM();
	}

	private void OOKHODGBACJ()
	{
		if ((Object)(object)LHEMLBGALAL != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = LHEMLBGALAL.flag;
			}
			((Object)((Component)this).gameObject).name = LHEMLBGALAL.name;
		}
	}

	public void DPANHFBLECI()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.BALLKBAGCDD(LHEMLBGALAL);
		if (Application.isEditor)
		{
			Debug.Log((object)("" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.NJNFHEPLEHL().ToggleAllFlags(MJHBHDAEDLF: false);
	}

	public void SelectClicked()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.CMIBBDJLMBM = LHEMLBGALAL;
		if (Application.isEditor)
		{
			Debug.Log((object)("New language: " + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.GGFJGHHHEJC.ToggleAllFlags(MJHBHDAEDLF: false);
	}

	private void KEIKDIJKMGL()
	{
		if ((Object)(object)JHBJAGHJKLP() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = JHBJAGHJKLP().flag;
			}
			((Object)((Component)this).gameObject).name = PMBKLINFGLO().name;
		}
	}

	public void HMAPKONAALA()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.CMIBBDJLMBM = NNLOKPKGFFO();
		if (Application.isEditor)
		{
			Debug.Log((object)("Received upgrade tool RPC for toolID: " + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.IBEGPMLJIOJ().JBHEIMCIFLN(MJHBHDAEDLF: true);
	}

	[SpecialName]
	public void GKGMPHNNEMB(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		HNMJJAFILNC();
	}

	[SpecialName]
	public GameLanguage PMBKLINFGLO()
	{
		return language;
	}

	public void OMEANKHIBNP()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.HGPLKIMBMED(NDJMPFNMANN());
		if (Application.isEditor)
		{
			Debug.Log((object)("Items/item_description_1089" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.OAPOJCODNCO().EEPKAMCIJPF(MJHBHDAEDLF: false);
	}

	private void BJFELKDKINO()
	{
		if ((Object)(object)NNLOKPKGFFO() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = HMJHLGLNODP().flag;
			}
			((Object)((Component)this).gameObject).name = BICJMAHENOO().name;
		}
	}

	[SpecialName]
	public void CHPHAGFFGON(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		AOGIOEJOKOI();
	}

	private void PFCCAOOJAKC()
	{
		if ((Object)(object)NNLOKPKGFFO() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = DGPJKJKFCJC().flag;
			}
			((Object)((Component)this).gameObject).name = PMBKLINFGLO().name;
		}
	}

	private void JOFFJANOIEE()
	{
		if ((Object)(object)HMJHLGLNODP() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = LHEMLBGALAL.flag;
			}
			((Object)((Component)this).gameObject).name = BICJMAHENOO().name;
		}
	}

	public void LOAEDEBFFPN()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.BALLKBAGCDD(PKEEHNJLEAI());
		if (Application.isEditor)
		{
			Debug.Log((object)("itemGreenPepperSeeds" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.LFPEPJBNCBF().BJLBOJCHLAN(MJHBHDAEDLF: false);
	}

	private void FIPFINKFIAM()
	{
		if ((Object)(object)BICJMAHENOO() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = NDJMPFNMANN().flag;
			}
			((Object)((Component)this).gameObject).name = BICJMAHENOO().name;
		}
	}

	public void FKPDOGMLDPL()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.HDEODLBJLHM(PKEEHNJLEAI());
		if (Application.isEditor)
		{
			Debug.Log((object)("/ExtraSettings.sd" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.HLMGBEGEAPC().MCNAIPDCDML(MJHBHDAEDLF: true);
	}

	public void HEGCJJNHBKI()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.BALLKBAGCDD(LHEMLBGALAL);
		if (Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/Rowdy/Entry/2/Dialogue Text" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.LFPEPJBNCBF().GBHNJCDNAOJ(MJHBHDAEDLF: true);
	}

	[SpecialName]
	public void NPOLHDIOLGA(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		BJFELKDKINO();
	}

	[SpecialName]
	public void OFGFJMPLKDF(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		JOFFJANOIEE();
	}

	private void EACDNLPEGJF()
	{
		if ((Object)(object)LHEMLBGALAL != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = NDJMPFNMANN().flag;
			}
			((Object)((Component)this).gameObject).name = JHBJAGHJKLP().name;
		}
	}

	[SpecialName]
	public GameLanguage PKEEHNJLEAI()
	{
		return language;
	}

	[SpecialName]
	public GameLanguage DGPJKJKFCJC()
	{
		return language;
	}

	[SpecialName]
	public GameLanguage BICJMAHENOO()
	{
		return language;
	}

	private void PFBNMDACFDD()
	{
		if ((Object)(object)JHBJAGHJKLP() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = BICJMAHENOO().flag;
			}
			((Object)((Component)this).gameObject).name = PKEEHNJLEAI().name;
		}
	}

	private void MBNHGMGELAD()
	{
		if ((Object)(object)DGPJKJKFCJC() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = BICJMAHENOO().flag;
			}
			((Object)((Component)this).gameObject).name = PKEEHNJLEAI().name;
		}
	}

	private void AOGIOEJOKOI()
	{
		if ((Object)(object)PKEEHNJLEAI() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = PKEEHNJLEAI().flag;
			}
			((Object)((Component)this).gameObject).name = LHEMLBGALAL.name;
		}
	}

	public void DOJKNMIMLCH()
	{
		LocalizationManager.CurrentLanguage = language.name;
		LocalisationSystem.CMIBBDJLMBM = NDJMPFNMANN();
		if (Application.isEditor)
		{
			Debug.Log((object)("BirdInteract" + LocalizationManager.CurrentLanguage));
		}
		LocalisationSystemUI.DICHPHEOINO().MPEJELCCANA(MJHBHDAEDLF: false);
	}

	[SpecialName]
	public void NONKDOCJBGA(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		NPOHJHIAABC();
	}

	[SpecialName]
	public void EPDFGKDDEKM(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		PFBNMDACFDD();
	}

	[SpecialName]
	public GameLanguage NNLOKPKGFFO()
	{
		return language;
	}

	private void HNMJJAFILNC()
	{
		if ((Object)(object)DKBDJDPCFOK() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = JHBJAGHJKLP().flag;
			}
			((Object)((Component)this).gameObject).name = LHEMLBGALAL.name;
		}
	}

	[SpecialName]
	public void KCMPLGFOHDK(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		HNMJJAFILNC();
	}

	[SpecialName]
	public void GHLGNIHPHAF(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		FIPFINKFIAM();
	}

	[SpecialName]
	public GameLanguage JHBJAGHJKLP()
	{
		return language;
	}

	private void NPOHJHIAABC()
	{
		if ((Object)(object)HMJHLGLNODP() != (Object)null)
		{
			Image component = ((Component)this).GetComponent<Image>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.sprite = DGPJKJKFCJC().flag;
			}
			((Object)((Component)this).gameObject).name = DGPJKJKFCJC().name;
		}
	}

	[SpecialName]
	public void HCCJLAKPCIN(GameLanguage AODONKKHPBP)
	{
		language = AODONKKHPBP;
		MBNHGMGELAD();
	}
}
