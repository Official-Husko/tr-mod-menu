using UnityEngine;

public class ActivateWithKeyboard : MonoBehaviour
{
	private int JIIGOACEIKL = 1;

	[SerializeField]
	private GameObject[] gameObjectsToActivate;

	private bool LNLJMCONDNE;

	private void FHOCCEBKHJI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Not enough fuel")) ? 1 : 3);
	}

	private void DBCAAICCLFN(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void HKKDEKIFPPJ()
	{
		PACDADOCKCD(DAEMAAOLHMG: true);
	}

	private void OAEJGGFFCBO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ReceiveCastleFormStartLucenDialogue")) ? 1 : 0);
	}

	private void FPNCANODJKE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("KyrohTakingFood: Customer serving is null.")) ? 1 : 6);
	}

	private void KLMNLEDKEOE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Error_PlaceItInChickenCoop")) ? 1 : 8);
	}

	private void PACDADOCKCD(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void CLNBMOPMNOF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("add item ")) ? 1 : 3);
	}

	private void Start()
	{
		DBCAAICCLFN(DAEMAAOLHMG: false);
	}

	private void BHAFCBHENPL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_name_1448")) ? 1 : 1);
	}

	private void IIOHMDNGFDH()
	{
		if (!LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			NLGMMIHFIGN(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			ACBGNCGFOGM(DAEMAAOLHMG: true);
		}
	}

	private void Update()
	{
		if (!LNLJMCONDNE && !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: false);
		}
	}

	private void AGLMGDNBHBF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Crafting")) ? 8 : 0);
	}

	private void IGKPEBGHPGD()
	{
		if (!LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			FKLIBMEEJFN(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			PACDADOCKCD(DAEMAAOLHMG: true);
		}
	}

	private void AKLEFPLEGKK()
	{
		if (!LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			AGJBCPLBCPE(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			FKLIBMEEJFN(DAEMAAOLHMG: false);
		}
	}

	private void OIBDBLCLACB()
	{
		PCLGALGFCMD(DAEMAAOLHMG: false);
	}

	private void PCLGALGFCMD(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void KJHKBGDJNDC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("mForMins")) ? 8 : 0);
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void JIAJFDKNJME()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("")) ? 1 : 0);
	}

	private void GNGADDPBJDC()
	{
		GDHJMBLHADD(DAEMAAOLHMG: true);
	}

	private void EJEEIIGEGOC()
	{
		if (!LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			AGJBCPLBCPE(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			PACDADOCKCD(DAEMAAOLHMG: false);
		}
	}

	private void IMIONHLAKIH()
	{
		GDHJMBLHADD(DAEMAAOLHMG: false);
	}

	private void IGIKNCOLCKL()
	{
		PACDADOCKCD(DAEMAAOLHMG: true);
	}

	private void LIOFOHPGHOK(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void BAKDKFKNHDE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Dialogue System/Conversation/Gass_Quest/Entry/13/Dialogue Text")) ? 1 : 3);
	}

	private void FPOIFOGELHC()
	{
		if (!LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			ACBGNCGFOGM(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			AGJBCPLBCPE(DAEMAAOLHMG: true);
		}
	}

	private void BODICIENBEH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("No players at the start of the scene. Spawning...")) ? 7 : 0);
	}

	private void NFABFPFLNEE()
	{
		GDHJMBLHADD(DAEMAAOLHMG: false);
	}

	private void GHEHLJANBCF()
	{
		if (!LNLJMCONDNE && !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			AGJBCPLBCPE(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			NLGMMIHFIGN(DAEMAAOLHMG: false);
		}
	}

	private void LEDIGKGAFHC()
	{
		if (!LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ACBGNCGFOGM(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			AGJBCPLBCPE(DAEMAAOLHMG: true);
		}
	}

	private void PNLAJCHBHPH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Tutorial/T106/Dialogue1")) ? 4 : 0);
	}

	private void LOHAMDHOLDD()
	{
		DBCAAICCLFN(DAEMAAOLHMG: true);
	}

	private void EBNENBFLEKB()
	{
		GDHJMBLHADD(DAEMAAOLHMG: true);
	}

	private void CAIJLMJBMLA()
	{
		DBCAAICCLFN(DAEMAAOLHMG: true);
	}

	private void GDHJMBLHADD(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void DOKHLDBIDJB()
	{
		if (!LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			PCLGALGFCMD(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			PACDADOCKCD(DAEMAAOLHMG: true);
		}
	}

	private void OIAHJHNPPCO()
	{
		AGJBCPLBCPE(DAEMAAOLHMG: false);
	}

	private void OONONNJFEFL()
	{
		if (!LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			FKLIBMEEJFN(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			FKLIBMEEJFN(DAEMAAOLHMG: false);
		}
	}

	private void NLGMMIHFIGN(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void AGJBCPLBCPE(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void FOHGHCPODBJ()
	{
		FKLIBMEEJFN(DAEMAAOLHMG: true);
	}

	private void HFFFFAJFIPB()
	{
		FKLIBMEEJFN(DAEMAAOLHMG: false);
	}

	private void OFDEGDJGGGF()
	{
		if (!LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: false);
		}
		else if (LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			PACDADOCKCD(DAEMAAOLHMG: true);
		}
	}

	private void FKLIBMEEJFN(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void JPOLFKMLHNH()
	{
		FKLIBMEEJFN(DAEMAAOLHMG: false);
	}

	private void EFCNKPEPELL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Freshwater")) ? 2 : 0);
	}

	private void HOFKJPBBLGP()
	{
		ACBGNCGFOGM(DAEMAAOLHMG: true);
	}

	private void MIKNFPCDLML()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Saving ingredient ")) ? 3 : 0);
	}

	private void OAKGHDAABPM()
	{
		if (!LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			FKLIBMEEJFN(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			PCLGALGFCMD(DAEMAAOLHMG: true);
		}
	}

	private void ACBGNCGFOGM(bool DAEMAAOLHMG)
	{
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(DAEMAAOLHMG);
		}
	}

	private void DGJKLAEINHJ()
	{
		if (!LNLJMCONDNE && !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			PACDADOCKCD(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			PACDADOCKCD(DAEMAAOLHMG: true);
		}
	}

	private void AHFGOOHOLEL()
	{
		NLGMMIHFIGN(DAEMAAOLHMG: true);
	}

	private void GHPFCKGMLDA()
	{
		DBCAAICCLFN(DAEMAAOLHMG: true);
	}

	private void JLPLLHKJEMH()
	{
		if (!LNLJMCONDNE && !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			AGJBCPLBCPE(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			FKLIBMEEJFN(DAEMAAOLHMG: true);
		}
	}

	private void KACEOJDPLKB()
	{
		PACDADOCKCD(DAEMAAOLHMG: false);
	}

	private void HPIMHEMJMAA()
	{
		PCLGALGFCMD(DAEMAAOLHMG: false);
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("itemRedGrapeSeeds")) ? 1 : 8);
	}

	private void KHCJDKHONPK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceivInstantiateMiscellaneousHarvest")) ? 6 : 0);
	}

	private void GONDLJKGLGO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(". ")) ? 1 : 2);
	}

	private void POFDOILPANH()
	{
		if (!LNLJMCONDNE && !PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			PCLGALGFCMD(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			ACBGNCGFOGM(DAEMAAOLHMG: true);
		}
	}
}
