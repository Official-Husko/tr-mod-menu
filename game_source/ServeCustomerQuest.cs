using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Quest/Serve Item Type")]
public class ServeCustomerQuest : RequiredItemQuest
{
	private void NFGAJDCIBIB(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		CMOICCAACMA(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void IPDLFOAFPIJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		PDIKODBNCDE(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void PMHDNCHBOGE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		MIKBGGPLPMN(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void AEKLKOEFPNP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		AIOHOCHIEHH(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void HFKACHODLKD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		GIBFAFFAGNA(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void FKBNFPPGKMF(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		CMOICCAACMA(JIIGOACEIKL, DNLMCHDOMOK);
	}

	public override void OEICMCIGNKO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AAJCMJJLIAD));
	}

	private void HPKFGBBOFAF(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		PDIKODBNCDE(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void EJGFAGPNLDG(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		OPAKABJOKGK(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void EAHIKIDEEMP(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		OJOJHIEDCON(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void AAJCMJJLIAD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		AIOHOCHIEHH(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void PADGONCJMDE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		CMOICCAACMA(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void CJLMNOBIDEJ(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		PDIKODBNCDE(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void MFOKODBPLOE(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		AIOHOCHIEHH(JIIGOACEIKL, DNLMCHDOMOK);
	}

	private void CBHJMALOJAD(int JIIGOACEIKL, ItemInstance DNLMCHDOMOK)
	{
		GIBFAFFAGNA(JIIGOACEIKL, DNLMCHDOMOK);
	}

	public override void MHOGPMHEAFN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AAJCMJJLIAD));
		MFHHJFEJAMF();
	}
}
