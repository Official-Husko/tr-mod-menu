using System;
using UnityEngine;

public class MineHelmetInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[SerializeField]
	private CharacterSprite[] helmetSprites;

	[SerializeField]
	private string equipHelmet = "WearHelmet";

	[SerializeField]
	private string unEquipHelmet = "RemoveHelmet";

	private int[] NLBLCNOPLJB = new int[5];

	public void NKGNABOCPDG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(ResetHair));
		}
	}

	public void HPOMPFNHGHN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(ResetHair));
		}
	}

	public bool BGAFGOLFDGI(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool JAELLHFFLKO(int JIIGOACEIKL)
	{
		if (!BOMCNGALNEN(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return false;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.EOFFJNELMLD())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.BFCMMCJMEHI(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return true;
	}

	public void OJIEDIAAOLN(int JIIGOACEIKL)
	{
	}

	public void CJGDFDJMAAA(int JIIGOACEIKL)
	{
	}

	public void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(ResetHair));
	}

	public bool KCBDEECFIKO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HJKJLDNBFLP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FNCFDPBNCBL(int JIIGOACEIKL)
	{
		return false;
	}

	public void MHENLAGHFOD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NFCHOMHHGAM));
		}
	}

	public bool CIOGGHDFDCP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void DENOGCNHPCJ()
	{
		for (int i = 1; i < 8; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null))
			{
				CharacterCreator characterCreator = player.characterCreator;
				if (characterCreator.humanInfo.NMDOONKEOGG())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void JHGDBLMEFMP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(GPDGODFJDKL));
	}

	public void DCBLHLOFPMK(int JIIGOACEIKL)
	{
	}

	public bool ODAPLEDBOEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OACAPFIFIOC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.EOFFJNELMLD())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return false;
	}

	public bool AIBNDPCOHHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOHOJFCHMEC(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.AECDCAEDBBL())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return true;
	}

	public void HFHKBOCPBJN(int JIIGOACEIKL)
	{
	}

	public void EDBOBLNOBLP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(CELMLKFNGPB));
		}
	}

	public bool JOCDOHFACJH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool BLGIKKBBFKF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (GFKDNEJHNNI(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.MNIHEOCAHJL())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return true;
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public void IJOHPJPPHHG(int JIIGOACEIKL)
	{
	}

	public bool IAOKCOEGDBF(int JIIGOACEIKL)
	{
		if (!BANJNCOOACM(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.JOLDFJLHDFC())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.BFCMMCJMEHI(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return true;
	}

	public void IAEPFFMCKOH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(DENOGCNHPCJ));
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CGBBGIFMMDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		if (!CLFHGIFAMME(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.MOPAGFAAADL())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.BFCMMCJMEHI(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL] += 0;
		}
		return false;
	}

	public bool PBPIJOAIGII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MJEHNKDKBBF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KEPKNBFJPOO(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.MOPAGFAAADL())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return true;
	}

	public void OBLCKPMAADM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(CELMLKFNGPB));
		}
	}

	public void ACOAGLHGJFL(int JIIGOACEIKL)
	{
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void GJJPNFHFBFP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(GAOCDCIKAPB));
	}

	public void LDKNMDBCKFJ(int JIIGOACEIKL)
	{
	}

	public void FPJFFEOAJPM(int JIIGOACEIKL)
	{
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	public void GGCCMCLILLH(int JIIGOACEIKL)
	{
	}

	public void JDDBBAEIIHP(int JIIGOACEIKL)
	{
	}

	public bool NOHOJFCHMEC(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void HLNEGJCBPOA(int JIIGOACEIKL)
	{
	}

	public void NFCHOMHHGAM()
	{
		for (int i = 0; i < 6; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null))
			{
				CharacterCreator characterCreator = player.characterCreator;
				if (characterCreator.humanInfo.MNIHEOCAHJL())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void HPLHMNAIEMF(int JIIGOACEIKL)
	{
	}

	public void FIECAFNFCDM(int JIIGOACEIKL)
	{
	}

	public bool LJHHANBIACF(int JIIGOACEIKL)
	{
		return false;
	}

	public void HKFGIKEBNJN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(DENOGCNHPCJ));
		}
	}

	public bool DLLJLOJELKK(int JIIGOACEIKL)
	{
		if (!NOHOJFCHMEC(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.MNIHEOCAHJL())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.KFHEGANJGMG(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return false;
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOHOJFCHMEC(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.MNIHEOCAHJL())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return true;
	}

	public void ELEFOPHJICI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(CELMLKFNGPB));
		}
	}

	public void KGHAMBEDHKD(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return false;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.EOFFJNELMLD())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.MineEnter(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return true;
	}

	public bool BOMCNGALNEN(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void KNGEADIBMPM(int JIIGOACEIKL)
	{
	}

	public void KBIFFDFOLGF()
	{
		for (int i = 0; i < 3; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null))
			{
				CharacterCreator characterCreator = playerController.characterCreator;
				if (characterCreator.humanInfo.AECDCAEDBBL())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void ResetHair()
	{
		for (int i = 1; i < 5; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null))
			{
				CharacterCreator characterCreator = player.characterCreator;
				if (characterCreator.humanInfo.EOFFJNELMLD())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void NMNPLOIIIGD(int JIIGOACEIKL)
	{
	}

	public bool OPEOJMLFPMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (GFKDNEJHNNI(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.LIBPOJPKLHD())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(equipHelmet));
			}
			return false;
		}
		return false;
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public bool BBFPHALCPHA(int JIIGOACEIKL)
	{
		return false;
	}

	public void EPHDHKDCNOD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(GPDGODFJDKL));
		}
	}

	public bool JMLPFPAFPGE(int JIIGOACEIKL)
	{
		if (!GDOPOFNFLEB(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.EOFFJNELMLD())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.KFHEGANJGMG(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return false;
	}

	public bool FEEGKDKHJOE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void IFOGDEJAFKA(int JIIGOACEIKL)
	{
	}

	public bool JCCHKBELDFJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
	}

	public bool FBFGOFLDOHL(int JIIGOACEIKL)
	{
		if (!BOMCNGALNEN(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.EOFFJNELMLD())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.BFCMMCJMEHI(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return true;
	}

	public bool KKCJMNJFELB(int JIIGOACEIKL)
	{
		return false;
	}

	public void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ResetHair));
		}
	}

	public bool GKCBFBDBNON(int JIIGOACEIKL)
	{
		return false;
	}

	public void NHMFHPJBOON()
	{
		for (int i = 1; i < 7; i += 0)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null))
			{
				CharacterCreator characterCreator = playerController.characterCreator;
				if (characterCreator.humanInfo.MNIHEOCAHJL())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void GPDGODFJDKL()
	{
		for (int i = 1; i < 8; i++)
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(i);
			if (!((Object)(object)playerController == (Object)null))
			{
				CharacterCreator characterCreator = playerController.characterCreator;
				if (characterCreator.humanInfo.JOLDFJLHDFC())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void CDOOEGGKFBB(int JIIGOACEIKL)
	{
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CLFHGIFAMME(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.MNIHEOCAHJL())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(equipHelmet));
			}
			return false;
		}
		return true;
	}

	public bool FJLIPEHAJOF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NHPMOOAKEFF(int JIIGOACEIKL)
	{
		if (!CLFHGIFAMME(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return false;
		}
		CharacterCreator characterCreator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.MOPAGFAAADL())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.BFCMMCJMEHI(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return false;
	}

	public bool DDKLIFBPKBF(int JIIGOACEIKL)
	{
		return true;
	}

	public void HACPCOIPNDD(int JIIGOACEIKL)
	{
	}

	public void GJKMPLHIDFC(int JIIGOACEIKL)
	{
	}

	public void LINJNPGDLGA(int JIIGOACEIKL)
	{
	}

	public void GBAKNAINDJM()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(KBIFFDFOLGF));
	}

	public bool EOJCOMAHIFB(int JIIGOACEIKL)
	{
		if (!NOHOJFCHMEC(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.EOFFJNELMLD())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.KFHEGANJGMG(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL] += 0;
		}
		return true;
	}

	public bool AAGOLOPJOHJ(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return true;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.JOLDFJLHDFC())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.MineEnter(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL] += 0;
		}
		return false;
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void BOHBDMHDIDC(int JIIGOACEIKL)
	{
	}

	public bool APFAKKDDFIK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool GGLKCAFNFOB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KMKLMJOHLGC(int JIIGOACEIKL)
	{
		if (!CLFHGIFAMME(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return false;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.MNIHEOCAHJL())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.BFCMMCJMEHI(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL] += 0;
		}
		return false;
	}

	public void CEDDOKBCHAI(int JIIGOACEIKL)
	{
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void MEFFGGKAALB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NHMFHPJBOON));
	}

	public bool HAOPENBNBFF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (GFKDNEJHNNI(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.AAPHDKCPJNH())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return false;
	}

	public bool DAKHAHICKMO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HNBIEOPGBNB(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void KJJAGKNOFIG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(GAOCDCIKAPB));
		}
	}

	public void NEIBJLCMDGK(int JIIGOACEIKL)
	{
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void JPJDFHEANJH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(GPDGODFJDKL));
		}
	}

	public bool CLFHGIFAMME(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool OKACGFMHMEH(int JIIGOACEIKL)
	{
		return false;
	}

	public bool FMDIGCNHBAP(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		if (!KEPKNBFJPOO(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return false;
		}
		CharacterCreator characterCreator = PlayerController.GetPlayer(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.AAPHDKCPJNH())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.KFHEGANJGMG(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return false;
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		return true;
	}

	public void GAOCDCIKAPB()
	{
		for (int i = 1; i < 3; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null))
			{
				CharacterCreator characterCreator = player.characterCreator;
				if (characterCreator.humanInfo.EOFFJNELMLD())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void OKEIHMKAFEP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(NFCHOMHHGAM));
		}
	}

	public void CELMLKFNGPB()
	{
		for (int i = 1; i < 8; i++)
		{
			PlayerController player = PlayerController.GetPlayer(i);
			if (!((Object)(object)player == (Object)null))
			{
				CharacterCreator characterCreator = player.characterCreator;
				if (characterCreator.humanInfo.LIBPOJPKLHD())
				{
					characterCreator.MineExit();
				}
			}
		}
	}

	public void PGANCIOMODE(int JIIGOACEIKL)
	{
	}

	public bool LCDFJODPNGJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void OCIHCODJBGC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(ResetHair));
	}

	public void NDEDLJMAKBJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(GPDGODFJDKL));
		}
	}

	public bool ICOEHINGKFF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool FAJKNOLOCBC(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.EOFFJNELMLD())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return false;
	}

	public void CACPOGPOKOJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(CELMLKFNGPB));
		}
	}

	public bool KEPKNBFJPOO(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool ALMMEPANOOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void CICBEIMDOGJ(int JIIGOACEIKL)
	{
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KEPKNBFJPOO(JIIGOACEIKL))
		{
			if (PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.AAPHDKCPJNH())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(equipHelmet));
			}
			return false;
		}
		return false;
	}

	public bool OAPMCNNLHJO(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool GIDIDGMFLAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HNBIEOPGBNB(JIIGOACEIKL))
		{
			if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.MOPAGFAAADL())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(unEquipHelmet));
			}
			else
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(equipHelmet));
			}
			return true;
		}
		return false;
	}

	public void NEJHEEBHJGL(int JIIGOACEIKL)
	{
	}

	public void ECHMKEAGFFO()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(DENOGCNHPCJ));
		}
	}

	public bool FNJHKKPGJFC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ADJHOLOIGJE()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(DENOGCNHPCJ));
		}
	}

	public bool EAOHDAKIJCK(int JIIGOACEIKL)
	{
		if (!GDOPOFNFLEB(JIIGOACEIKL) || helmetSprites.Length == 0)
		{
			return false;
		}
		CharacterCreator characterCreator = PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator;
		if (characterCreator.humanInfo.LIBPOJPKLHD())
		{
			characterCreator.MineExit();
		}
		else
		{
			int num = NLBLCNOPLJB[JIIGOACEIKL] % helmetSprites.Length;
			characterCreator.KFHEGANJGMG(helmetSprites[num]);
			NLBLCNOPLJB[JIIGOACEIKL]++;
		}
		return true;
	}

	public void EAMLHICIOMO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(KBIFFDFOLGF));
		}
	}

	public bool DHGKDOGEJPF(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}
}
