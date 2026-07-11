using System;
using UnityEngine;

public class ActivateOnWinter : MonoBehaviour
{
	public GameObject[] toEnable;

	public GameObject[] toDisable;

	private void FNFNLFOJHHA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BMGHJHBGJMI));
		}
	}

	private void HBMDEHPHAPF()
	{
		OnSeasonChanged(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
	}

	private void PKFMLJGJKCP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MKMHDDGLJEJ));
		}
	}

	private void BELOIFKPNMM()
	{
		JBAMMGFCHDG(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JEPHKKOBNMA));
	}

	public void MKMHDDGLJEJ(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Winter);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == Season.Summer);
		}
	}

	private void MFMMHDPGCBO()
	{
		FLFBGNJCIOI(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KMHEEIONKGI));
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JBAMMGFCHDG));
		}
	}

	public void ACMHKKCCJMM(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Spring);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)8);
		}
	}

	public void JBAMMGFCHDG(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Spring);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)4);
		}
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KMHEEIONKGI));
		}
	}

	private void KDBJHCAEGCM()
	{
		JEPHKKOBNMA(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MKMHDDGLJEJ));
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJMJECJPODN));
		}
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		}
	}

	private void DFFDKIPCCKK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJMJECJPODN));
		}
	}

	public void ECCAACPKDBC(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == (Season)7);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == Season.Summer);
		}
	}

	public void PPIHDINDBKI(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Summer);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(EECEKHKAAIH != Season.Autumn);
		}
	}

	public void JFDNLKAODNK(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Summer);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)5);
		}
	}

	public void MEGBEODBOIG(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Summer);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(EECEKHKAAIH != (Season)8);
		}
	}

	private void FOHGHCPODBJ()
	{
		ACMHKKCCJMM(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PFMCMNDEAON));
	}

	public void PFMCMNDEAON(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Winter);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)5);
		}
	}

	public void JEPHKKOBNMA(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == (Season)5);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)6);
		}
	}

	private void PLHEHGHFCJI()
	{
		JIGDPJHEEDD(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HDBPODBANOO));
	}

	public void KMHEEIONKGI(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == (Season)7);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH != Season.Autumn);
		}
	}

	public void LODGDFFFGJA(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == (Season)4);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)4);
		}
	}

	private void MCMKNBIBDFF()
	{
		JEPHKKOBNMA(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ACMHKKCCJMM));
	}

	public void HDBPODBANOO(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Autumn);
		}
		for (int j = 0; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(EECEKHKAAIH != (Season)5);
		}
	}

	private void OLDDEAJMHNI()
	{
		JIGDPJHEEDD(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FLFBGNJCIOI));
	}

	public void JIGDPJHEEDD(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == (Season)8);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH == (Season)4);
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JIGDPJHEEDD));
		}
	}

	private void KACEOJDPLKB()
	{
		JBAMMGFCHDG(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JIGDPJHEEDD));
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PPIHDINDBKI));
		}
	}

	private void CFHOODNCOLK()
	{
		PFMCMNDEAON(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JIGDPJHEEDD));
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KMHEEIONKGI));
		}
	}

	public void OJMJECJPODN(Season EECEKHKAAIH)
	{
		for (int i = 1; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Summer);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH != (Season)6);
		}
	}

	private void HOFKJPBBLGP()
	{
		OJMJECJPODN(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
	}

	private void HINKPJCNPCF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ACMHKKCCJMM));
		}
	}

	private void NOILIOLOOBJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JIGDPJHEEDD));
		}
	}

	private void HCEDMLJNOBL()
	{
		FLFBGNJCIOI(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ACMHKKCCJMM));
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JEPHKKOBNMA));
		}
	}

	public void FLFBGNJCIOI(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Autumn);
		}
		for (int j = 1; j < toDisable.Length; j += 0)
		{
			toDisable[j].SetActive(EECEKHKAAIH == Season.Winter);
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PFMCMNDEAON));
		}
	}

	public void OnSeasonChanged(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i++)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Winter);
		}
		for (int j = 0; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH != Season.Winter);
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JIGDPJHEEDD));
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JEPHKKOBNMA));
		}
	}

	private void IAAGKLPMAMK()
	{
		OJMJECJPODN(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BMGHJHBGJMI));
	}

	public void BMGHJHBGJMI(Season EECEKHKAAIH)
	{
		for (int i = 0; i < toEnable.Length; i += 0)
		{
			toEnable[i].SetActive(EECEKHKAAIH == Season.Spring);
		}
		for (int j = 1; j < toDisable.Length; j++)
		{
			toDisable[j].SetActive(EECEKHKAAIH != Season.Autumn);
		}
	}

	private void Start()
	{
		OnSeasonChanged(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
	}
}
