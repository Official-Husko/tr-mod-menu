using System;
using UnityEngine;

public class ActivateWithGamepad : MonoBehaviour
{
	public Action<bool> OnGamepadToggle;

	public UIWindow uiWindowPlayerNum;

	private int JIIGOACEIKL;

	[SerializeField]
	private GameObject[] gameObjectsToActivate;

	[SerializeField]
	private GameObject[] keyToActivate;

	[SerializeField]
	private GamepadSprite[] gamepadSpritesPlayerNumUpdated;

	private bool LNLJMCONDNE;

	private void PCGKODCDHFD(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void LHFOFAMDKEO()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			HEHNBHGELOI(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			DJIFHECJCFK(DAEMAAOLHMG: true);
			BAGJLLNCBMO(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			BAGJLLNCBMO(DAEMAAOLHMG: false);
			PCGKODCDHFD(DAEMAAOLHMG: false);
		}
	}

	private void OLDDEAJMHNI()
	{
		FIEILGKNCGE(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceiveDisableNPC")) ? 8 : 0);
	}

	private void BNIKICAEIND()
	{
		DJIFHECJCFK(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_description_1068")) ? 8 : 0);
	}

	private void MNFJELNEGPG()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			CBGALBBCOKD(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: true);
			BFBEAEGJCLK(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			BFBEAEGJCLK(DAEMAAOLHMG: false);
			PKHMKDBFLIA(DAEMAAOLHMG: true);
		}
	}

	private void DCKKIDMJKJM()
	{
		DJIFHECJCFK(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("\n")) ? 1 : 7);
	}

	private void CGBPGLLIJGF(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void EJMAJFGPGEC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			ALMHAIIKEJO(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			CKENLLMEEKP(DAEMAAOLHMG: false);
			EDNCHOOBECE(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			LEAANBANEAP(DAEMAAOLHMG: false);
			DBCAAICCLFN(DAEMAAOLHMG: false);
		}
	}

	private void ABMLHGAEAFC(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void CAOKPIIFHBJ()
	{
		FIEILGKNCGE(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Coming soon!")) ? 3 : 0);
	}

	private void PKHMKDBFLIA(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void ICFKCFHKNGD(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void HCKBMOKECOA()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			IILOHAPCONB(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			PKHMKDBFLIA(DAEMAAOLHMG: true);
			EDNCHOOBECE(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			GDHNHECIIFN(DAEMAAOLHMG: false);
			FEBNKOBGMIA(DAEMAAOLHMG: true);
		}
	}

	private void CKENLLMEEKP(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void FGGPGOEAEKK()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			ALMHAIIKEJO(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			EJDILMMPDPL(DAEMAAOLHMG: false);
			ABMLHGAEAFC(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			KJOLAJJMPEP(DAEMAAOLHMG: false);
			ACHFAGGIAAE(DAEMAAOLHMG: true);
		}
	}

	private void AJAGBLDFEAD(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i++)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].SetPlayerNum(JIIGOACEIKL);
			}
		}
	}

	private void PBFGFECPPPO()
	{
		FEBNKOBGMIA(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("")) ? 2 : 0);
	}

	private void LFNENELHOGJ()
	{
		JOBMMBLLPGI(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("/Cheats.txt")) ? 6 : 0);
	}

	private void BCFCONOFGPP(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void EBFJOAEJPGE()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			EJOINNMMNIE(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			EJDILMMPDPL(DAEMAAOLHMG: true);
			MBCFGGHFFGB(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			PLGEOLHLKJE(DAEMAAOLHMG: false);
			ICIDLEPBJAC(DAEMAAOLHMG: true);
		}
	}

	private void MBCFGGHFFGB(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void BEGLOAKAICN()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			PHIIICDKPND(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			JOBMMBLLPGI(DAEMAAOLHMG: true);
			AOMPOEMMGGO(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			LLBKGPLACLA(DAEMAAOLHMG: false);
			DMDPNFBKKOD(DAEMAAOLHMG: true);
		}
	}

	private void ODNGBEOKEFK()
	{
		EJDILMMPDPL(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("\n")) ? 1 : 1);
	}

	private void EPEIMPCCHEP(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void GOKBDDFNDFH()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			IILOHAPCONB(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			JOBMMBLLPGI(DAEMAAOLHMG: true);
			LPANHGCNPNF(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			AOMPOEMMGGO(DAEMAAOLHMG: false);
			ICFKCFHKNGD(DAEMAAOLHMG: true);
		}
	}

	private void DBKCPJIKFFC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			MFCNELLMJOP(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: true);
			GDHNHECIIFN(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			MBCFGGHFFGB(DAEMAAOLHMG: false);
			MOEMACPDJOM(DAEMAAOLHMG: true);
		}
	}

	private void PHIIICDKPND(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].PPBGKAMFOKD(JIIGOACEIKL);
			}
		}
	}

	private void GJNLEKHAHDA(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void HCJGCDOEJEM(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void EMCGGCHDJDF(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void IABEJCPMJOF()
	{
		DMDPNFBKKOD(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Day")) ? 4 : 0);
	}

	private void IDPHKHGHJGN()
	{
		PKHMKDBFLIA(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" with id ")) ? 1 : 5);
	}

	private void EDNCHOOBECE(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void LLBKGPLACLA(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void ALMHAIIKEJO(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i++)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].PPBGKAMFOKD(JIIGOACEIKL);
			}
		}
	}

	private void FKLIBMEEJFN(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void OJHFFPBHKEH(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].AOIJBOIBGMJ(JIIGOACEIKL);
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		DBCAAICCLFN(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_description_1180")) ? 1 : 7);
	}

	private void DBCAAICCLFN(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void DLNOLBHCIGC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			HEHNBHGELOI(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			DJIFHECJCFK(DAEMAAOLHMG: true);
			KJOLAJJMPEP(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			EEGFFKMIFFB(DAEMAAOLHMG: true);
			EJDILMMPDPL(DAEMAAOLHMG: true);
		}
	}

	private void MNFMLJJBKNC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			NGNDEJEOCHP(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			FEBNKOBGMIA(DAEMAAOLHMG: false);
			KJOLAJJMPEP(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			EPEIMPCCHEP(DAEMAAOLHMG: false);
			JOBMMBLLPGI(DAEMAAOLHMG: true);
		}
	}

	private void LJLKBKEADGI()
	{
		CKENLLMEEKP(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("new save")) ? 1 : 4);
	}

	private void PEIFJDIGKOC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			OJHFFPBHKEH(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			CKENLLMEEKP(DAEMAAOLHMG: false);
			EEGFFKMIFFB(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			MNCEEIGEPJE(DAEMAAOLHMG: true);
			ICIDLEPBJAC(DAEMAAOLHMG: false);
		}
	}

	private void FOHGHCPODBJ()
	{
		FEBNKOBGMIA(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Dialogue System/Conversation/Crowly_Introduce/Entry/26/Dialogue Text")) ? 1 : 8);
	}

	private void HNEGFBCKIIJ()
	{
		ICFKCFHKNGD(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("mForMins")) ? 1 : 8);
	}

	private void GCHMNMKCOFG()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			HEHNBHGELOI(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			DJIFHECJCFK(DAEMAAOLHMG: false);
			GJNLEKHAHDA(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			LPANHGCNPNF(DAEMAAOLHMG: true);
			MOEMACPDJOM(DAEMAAOLHMG: false);
		}
	}

	private void GBFPCABGAII()
	{
		DJIFHECJCFK(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("</color>")) ? 1 : 2);
	}

	private void NELBHAMPBPL()
	{
		PKHMKDBFLIA(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" ")) ? 1 : 6);
	}

	private void DGJKLAEINHJ()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			HEHNBHGELOI(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			PKHMKDBFLIA(DAEMAAOLHMG: false);
			AOMPOEMMGGO(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			AOMPOEMMGGO(DAEMAAOLHMG: true);
			EJDILMMPDPL(DAEMAAOLHMG: true);
		}
	}

	private void IILOHAPCONB(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i++)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].AOIJBOIBGMJ(JIIGOACEIKL);
			}
		}
	}

	private void JLCFNPBBKEK()
	{
		PCGKODCDHFD(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Jump")) ? 1 : 7);
	}

	private void KFBOPABEJNL()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			PHIIICDKPND(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ACHFAGGIAAE(DAEMAAOLHMG: false);
			OGEPMAFCAAC(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			GDHNHECIIFN(DAEMAAOLHMG: true);
			DJIFHECJCFK(DAEMAAOLHMG: false);
		}
	}

	private void EEGFFKMIFFB(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void LEAANBANEAP(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void BHKNJOEBCKA()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			IILOHAPCONB(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			FEBNKOBGMIA(DAEMAAOLHMG: false);
			MBCFGGHFFGB(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			CGBPGLLIJGF(DAEMAAOLHMG: true);
			DJIFHECJCFK(DAEMAAOLHMG: false);
		}
	}

	private void Start()
	{
		DBCAAICCLFN(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void INKOKIGFJBG()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			ICKCALDDILF(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			PKHMKDBFLIA(DAEMAAOLHMG: false);
			LEAANBANEAP(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			MBCFGGHFFGB(DAEMAAOLHMG: true);
			ICFKCFHKNGD(DAEMAAOLHMG: true);
		}
	}

	private void ICKCALDDILF(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].NIALEPAOIKF(JIIGOACEIKL);
			}
		}
	}

	private void LPANHGCNPNF(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void FKPNIHJGFBJ()
	{
		PKHMKDBFLIA(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("NPCWalkTo is null in NPCRoutine. Make sure the routine ")) ? 3 : 0);
	}

	private void NNBIAIMPNGL()
	{
		PCGKODCDHFD(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Bird materials empty ")) ? 5 : 0);
	}

	private void AOMPOEMMGGO(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void NEPDNLPCCON()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			OJHFFPBHKEH(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			FIEILGKNCGE(DAEMAAOLHMG: true);
			KJOLAJJMPEP(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			GDHNHECIIFN(DAEMAAOLHMG: true);
			CKENLLMEEKP(DAEMAAOLHMG: false);
		}
	}

	private void PLGEOLHLKJE(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		DJIFHECJCFK(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" : 00")) ? 1 : 3);
	}

	private void DJIFHECJCFK(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void ELHCBGCEJDH()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			PICBODIALHG(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			FIEILGKNCGE(DAEMAAOLHMG: true);
			CGBPGLLIJGF(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			MMDCJALLKEI(DAEMAAOLHMG: true);
			MOEMACPDJOM(DAEMAAOLHMG: false);
		}
	}

	private void FEBNKOBGMIA(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void HOFKJPBBLGP()
	{
		FKLIBMEEJFN(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ChristmasEvent")) ? 1 : 4);
	}

	private void CMLLBIDFNEB()
	{
		JOBMMBLLPGI(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Not enough fuel")) ? 1 : 1);
	}

	private void IAPCILMGCMD(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].SetPlayerNum(JIIGOACEIKL);
			}
		}
	}

	private void BFBEAEGJCLK(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void HEHNBHGELOI(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i++)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].PPBGKAMFOKD(JIIGOACEIKL);
			}
		}
	}

	private void ODKGLIDMCNP()
	{
		ICIDLEPBJAC(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("1")) ? 7 : 0);
	}

	private void BIILFPDIADC()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			EJOINNMMNIE(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			MOEMACPDJOM(DAEMAAOLHMG: false);
			AOMPOEMMGGO(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			BAGJLLNCBMO(DAEMAAOLHMG: false);
			ACHFAGGIAAE(DAEMAAOLHMG: true);
		}
	}

	private void KJOLAJJMPEP(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void BAGJLLNCBMO(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void OGEPMAFCAAC(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void MNCEEIGEPJE(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void HEHNBONKMGJ()
	{
		DMDPNFBKKOD(DAEMAAOLHMG: true);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_description_615")) ? 1 : 0);
	}

	private void KEGALMPPEAC(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].NIALEPAOIKF(JIIGOACEIKL);
			}
		}
	}

	private void BDMEBLBLPIA()
	{
		FKLIBMEEJFN(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("tavernVisionActive")) ? 2 : 0);
	}

	private void EJOINNMMNIE(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].AOIJBOIBGMJ(JIIGOACEIKL);
			}
		}
	}

	private void MFCNELLMJOP(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].NIALEPAOIKF(JIIGOACEIKL);
			}
		}
	}

	private void KOCJCGBDPIF(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].PPBGKAMFOKD(JIIGOACEIKL);
			}
		}
	}

	private void EEKOJEKPIMP()
	{
		PCGKODCDHFD(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Miners/Mine/Clive/Talk")) ? 8 : 0);
	}

	private void NKDFMFFDGKC()
	{
		MOEMACPDJOM(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("\n")) ? 1 : 5);
	}

	private void GDHNHECIIFN(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void EAIBGLJONPC(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void PICBODIALHG(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].NIALEPAOIKF(JIIGOACEIKL);
			}
		}
	}

	private void MOEMACPDJOM(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void DMDPNFBKKOD(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void NGNDEJEOCHP(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 0; i < gamepadSpritesPlayerNumUpdated.Length; i += 0)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].NIALEPAOIKF(JIIGOACEIKL);
			}
		}
	}

	private void GGAIIIMAEKN(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 1; i < keyToActivate.Length; i++)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}

	private void BHLHCOALABE()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			MFCNELLMJOP(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ICIDLEPBJAC(DAEMAAOLHMG: true);
			LLBKGPLACLA(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			MBCFGGHFFGB(DAEMAAOLHMG: false);
			PCGKODCDHFD(DAEMAAOLHMG: false);
		}
	}

	private void OIBDBLCLACB()
	{
		FKLIBMEEJFN(DAEMAAOLHMG: false);
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(": [")) ? 1 : 7);
	}

	private void Update()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			AJAGBLDFEAD(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: true);
			GJNLEKHAHDA(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			GJNLEKHAHDA(DAEMAAOLHMG: true);
			DBCAAICCLFN(DAEMAAOLHMG: false);
		}
	}

	private void ACHFAGGIAAE(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void CBGALBBCOKD(int JIIGOACEIKL)
	{
		if (gamepadSpritesPlayerNumUpdated == null)
		{
			return;
		}
		for (int i = 1; i < gamepadSpritesPlayerNumUpdated.Length; i++)
		{
			if ((Object)(object)gamepadSpritesPlayerNumUpdated[i] != (Object)null)
			{
				gamepadSpritesPlayerNumUpdated[i].AOIJBOIBGMJ(JIIGOACEIKL);
			}
		}
	}

	private void EJDILMMPDPL(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void EMCCGDFOPEH()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			OJHFFPBHKEH(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			MOEMACPDJOM(DAEMAAOLHMG: false);
			ABMLHGAEAFC(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			LLBKGPLACLA(DAEMAAOLHMG: true);
			CKENLLMEEKP(DAEMAAOLHMG: true);
		}
	}

	private void ICIDLEPBJAC(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void LMEJFGKCHEF()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			AJAGBLDFEAD(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			FIEILGKNCGE(DAEMAAOLHMG: false);
			EDNCHOOBECE(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			ABMLHGAEAFC(DAEMAAOLHMG: true);
			CKENLLMEEKP(DAEMAAOLHMG: true);
		}
	}

	private void POFDOILPANH()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			EJOINNMMNIE(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ICFKCFHKNGD(DAEMAAOLHMG: true);
			EAIBGLJONPC(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			BFBEAEGJCLK(DAEMAAOLHMG: true);
			FIEILGKNCGE(DAEMAAOLHMG: true);
		}
	}

	private void DEEIEACLPEF()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			HEHNBHGELOI(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			PKHMKDBFLIA(DAEMAAOLHMG: true);
			LLBKGPLACLA(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			GJNLEKHAHDA(DAEMAAOLHMG: true);
			FIEILGKNCGE(DAEMAAOLHMG: true);
		}
	}

	private void JOBMMBLLPGI(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void FIEILGKNCGE(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		if (gameObjectsToActivate == null)
		{
			return;
		}
		for (int i = 1; i < gameObjectsToActivate.Length; i++)
		{
			if ((Object)(object)gameObjectsToActivate[i] != (Object)null)
			{
				gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
		OnGamepadToggle?.Invoke(DAEMAAOLHMG);
	}

	private void PMPLNGEAAII()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			IILOHAPCONB(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 0;
		}
		if (!LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ICFKCFHKNGD(DAEMAAOLHMG: false);
			BAGJLLNCBMO(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			BFBEAEGJCLK(DAEMAAOLHMG: false);
			FKLIBMEEJFN(DAEMAAOLHMG: false);
		}
	}

	private void PJLKGOACDEN()
	{
		if ((Object)(object)uiWindowPlayerNum != (Object)null)
		{
			JIIGOACEIKL = uiWindowPlayerNum.JIIGOACEIKL;
			KOCJCGBDPIF(JIIGOACEIKL);
		}
		else
		{
			JIIGOACEIKL = 1;
		}
		if (!LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			ICIDLEPBJAC(DAEMAAOLHMG: true);
			GGAIIIMAEKN(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			LPANHGCNPNF(DAEMAAOLHMG: false);
			DJIFHECJCFK(DAEMAAOLHMG: false);
		}
	}

	private void MMDCJALLKEI(bool DAEMAAOLHMG)
	{
		if (keyToActivate == null)
		{
			return;
		}
		for (int i = 0; i < keyToActivate.Length; i += 0)
		{
			if ((Object)(object)keyToActivate[i] != (Object)null)
			{
				keyToActivate[i].SetActive(DAEMAAOLHMG);
			}
		}
	}
}
