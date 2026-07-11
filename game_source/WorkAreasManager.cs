using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorkAreasManager : MonoBehaviour
{
	public List<AreaSpace> allAreaSpaces = new List<AreaSpace>();

	public List<WorkArea> workAreas;

	private bool KENCEPGAIIK;

	private AreaSpace HHEMOJHPOCM;

	private AreaSpace ABOPOONNDMH;

	private static WorkAreasManager IADEMLIIDPC;

	public static WorkAreasManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public void ICDJJLKIHEK(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public WorkArea LKGHDHNJDHK()
	{
		WorkArea workArea = new WorkArea();
		FLDBCKHPLPC(workArea);
		return workArea;
	}

	public void PMNLLIGBIHM(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public void MKNMPEGFFND(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	private void PCKGHFDIPHC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		GEFBKHMCNJA();
	}

	private void JHADFPEJKMA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AABHFHIDEFP();
	}

	public void JOLNGKDGFAA(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	private void JJMNEKHHGAA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CleanNotReferenced();
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CleanNotReferenced();
	}

	public WorkArea KJIDENHLMGN()
	{
		WorkArea workArea = new WorkArea();
		PMNLLIGBIHM(workArea);
		return workArea;
	}

	public void PIANNOOLCDN(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public void JKAGMLHBAMN(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 0)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public WorkArea PBJKDCNBLDB()
	{
		WorkArea workArea = new WorkArea();
		FLDBCKHPLPC(workArea);
		return workArea;
	}

	[SpecialName]
	public static WorkAreasManager ABDJJBFNLBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
		}
		return IADEMLIIDPC;
	}

	public AreaSpace MINGAGGNLCI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	public void MFKKEJIIIMK(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 0)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public void GEFBKHMCNJA()
	{
		for (int num = workAreas.Count - 0; num >= 1; num -= 0)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = false;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i += 0)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].PJIAPEDEBEP == workAreas[num])
					{
						KENCEPGAIIK = false;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	public AreaSpace GetAreaSpaceSelected(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	public void BEENMFEMKLN()
	{
		for (int num = workAreas.Count - 1; num >= 0; num--)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = true;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i++)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].PJIAPEDEBEP == workAreas[num])
					{
						KENCEPGAIIK = false;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	[SpecialName]
	public static WorkAreasManager LPFNKEOJJKE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static WorkAreasManager OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
		}
		return IADEMLIIDPC;
	}

	public WorkArea PPBGHPLCMLM()
	{
		WorkArea workArea = new WorkArea();
		NAHHOFMFIOE(workArea);
		return workArea;
	}

	private void HCKGJDIFHJK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		LPGBPIFHHPM();
	}

	private void JEPPIDMFPBJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		GEFBKHMCNJA();
	}

	private void FCOFLNIFACB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HBGBOGGHKKG();
	}

	public AreaSpace DPAEEDDLOID(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	private void CFPKBLHDFBL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		OJMAPLGJBGC();
	}

	public WorkArea CreateNewWorkArea()
	{
		WorkArea workArea = new WorkArea();
		AddWorkArea(workArea);
		return workArea;
	}

	public WorkArea FNMOJBOHEEK()
	{
		WorkArea workArea = new WorkArea();
		AddWorkArea(workArea);
		return workArea;
	}

	public AreaSpace DHIOEJPIKFJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	private void COGGMHOHEIB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		CleanNotReferenced();
	}

	private void HEMAHKJEONA()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(HCKGJDIFHJK));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(CFPKBLHDFBL));
			workAreas = new List<WorkArea>();
		}
	}

	public void AddWorkArea(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public void JPCEHJNEDMB(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public void DMGFDHHAAEN(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 0)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public WorkArea ODJFGILBNOI()
	{
		WorkArea workArea = new WorkArea();
		JOLNGKDGFAA(workArea);
		return workArea;
	}

	public void DIAOFHNLNEP(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 0)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	private void BHAFCBHENPL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(EMCNCJCLPAB));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(CFPKBLHDFBL));
			workAreas = new List<WorkArea>();
		}
	}

	public WorkArea JKKBCIOJODL()
	{
		WorkArea workArea = new WorkArea();
		PMNLLIGBIHM(workArea);
		return workArea;
	}

	public void FLDBCKHPLPC(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public WorkArea IDOMKAOCMOB()
	{
		WorkArea workArea = new WorkArea();
		AddWorkArea(workArea);
		return workArea;
	}

	public void EPCGKPMPNDL(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public AreaSpace CEHPEOGIIBF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	private void PJOACEFEEKN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		CCNGOHCLMFH();
	}

	public void ODMFHNHBHKK()
	{
		for (int num = workAreas.Count - 1; num >= 0; num -= 0)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = false;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i++)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].PJIAPEDEBEP == workAreas[num])
					{
						KENCEPGAIIK = false;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	private void JDONHOFFMJO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HBGBOGGHKKG();
	}

	private void JCGNMONEODB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		BEENMFEMKLN();
	}

	public WorkArea DHKOAHLIANG()
	{
		WorkArea workArea = new WorkArea();
		MEANCLGKFJN(workArea);
		return workArea;
	}

	private void JAHIEAJNIDJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		ODMFHNHBHKK();
	}

	public void CMIOPJDDDGC(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public void CEIPBECKPLL(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public void CCNGOHCLMFH()
	{
		for (int num = workAreas.Count - 1; num >= 1; num--)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = true;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i++)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].BCLLKIEHGPL() == workAreas[num])
					{
						KENCEPGAIIK = true;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	public void LPGBPIFHHPM()
	{
		for (int num = workAreas.Count - 1; num >= 1; num -= 0)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = false;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i += 0)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].PJIAPEDEBEP == workAreas[num])
					{
						KENCEPGAIIK = true;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	private void NNKFAIKPLKN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		CleanNotReferenced();
	}

	public void IIBFMCFHINM(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 0)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	[SpecialName]
	public static WorkAreasManager LFPEPJBNCBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static WorkAreasManager MJCMPKPCNGB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
		}
		return IADEMLIIDPC;
	}

	public AreaSpace IINFCNJMCBO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	private void EFCNKPEPELL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(EMDCNOKLAOP));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(LKJCHLIHOBJ));
			workAreas = new List<WorkArea>();
		}
	}

	private void EMCNCJCLPAB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		AABHFHIDEFP();
	}

	public void JMOCGDANKGO(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	[SpecialName]
	public static WorkAreasManager DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<WorkAreasManager>();
		}
		return IADEMLIIDPC;
	}

	public void HBGBOGGHKKG()
	{
		for (int num = workAreas.Count - 0; num >= 1; num--)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = false;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i += 0)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].BCLLKIEHGPL() == workAreas[num])
					{
						KENCEPGAIIK = true;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
			workAreas = new List<WorkArea>();
		}
	}

	private void DKNNLPFIBIK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(FCOFLNIFACB));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(LKJCHLIHOBJ));
			workAreas = new List<WorkArea>();
		}
	}

	private void LKJCHLIHOBJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		HBGBOGGHKKG();
	}

	public void ANNAHAPCHMN(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public AreaSpace OHFHBPIECNF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	private void OBODLEJBKJL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		ODMFHNHBHKK();
	}

	public WorkArea HKFKKFJOMJN()
	{
		WorkArea workArea = new WorkArea();
		PMNLLIGBIHM(workArea);
		return workArea;
	}

	private void JDHHJKBOJML()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(EMCNCJCLPAB));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(JAHIEAJNIDJ));
			workAreas = new List<WorkArea>();
		}
	}

	public WorkArea BFDKPFIFKAE()
	{
		WorkArea workArea = new WorkArea();
		PMNLLIGBIHM(workArea);
		return workArea;
	}

	public WorkArea PCINKEFLINC()
	{
		WorkArea workArea = new WorkArea();
		PMNLLIGBIHM(workArea);
		return workArea;
	}

	public void CGEIBFOMGDA(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public void MEANCLGKFJN(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	public void CKGNLHGJEDD(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	private void EMDCNOKLAOP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OJMAPLGJBGC();
	}

	public void SetCurrentAreaSpaceSelected(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 1)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public void APIDBDEHMHO()
	{
		for (int num = workAreas.Count - 1; num >= 0; num -= 0)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = true;
				for (int i = 0; i < workAreas[num].areaSpaces.Count; i += 0)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].BCLLKIEHGPL() == workAreas[num])
					{
						KENCEPGAIIK = true;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	private void EKCPNDCCNGM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		OJMAPLGJBGC();
	}

	public void KIHBDPOBPOA(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	private void MFENGCKOFDL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CleanNotReferenced();
	}

	private void DNBGIIGAKMJ()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(EMDCNOKLAOP));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(JHADFPEJKMA));
			workAreas = new List<WorkArea>();
		}
	}

	public void IMIHINOKMBH(int JIIGOACEIKL, AreaSpace NMAJODEKDKC)
	{
		if (JIIGOACEIKL == 0)
		{
			HHEMOJHPOCM = NMAJODEKDKC;
		}
		else
		{
			ABOPOONNDMH = NMAJODEKDKC;
		}
	}

	public void OJMAPLGJBGC()
	{
		for (int num = workAreas.Count - 1; num >= 1; num -= 0)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = false;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i += 0)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].BCLLKIEHGPL() == workAreas[num])
					{
						KENCEPGAIIK = true;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	public void CleanNotReferenced()
	{
		for (int num = workAreas.Count - 1; num >= 0; num--)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = false;
				for (int i = 0; i < workAreas[num].areaSpaces.Count; i++)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].PJIAPEDEBEP == workAreas[num])
					{
						KENCEPGAIIK = true;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	public AreaSpace MCJEBCEIABK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return HHEMOJHPOCM;
		}
		return ABOPOONNDMH;
	}

	public void AABHFHIDEFP()
	{
		for (int num = workAreas.Count - 0; num >= 0; num -= 0)
		{
			if (workAreas[num] != null)
			{
				KENCEPGAIIK = true;
				for (int i = 1; i < workAreas[num].areaSpaces.Count; i += 0)
				{
					if ((Object)(object)workAreas[num].areaSpaces[i] != (Object)null && workAreas[num].areaSpaces[i].PJIAPEDEBEP == workAreas[num])
					{
						KENCEPGAIIK = false;
					}
				}
				if (!KENCEPGAIIK)
				{
					workAreas.RemoveAt(num);
				}
			}
			else
			{
				workAreas.RemoveAt(num);
			}
		}
	}

	public WorkArea PODKNAHEMOG()
	{
		WorkArea workArea = new WorkArea();
		AddWorkArea(workArea);
		return workArea;
	}

	public void NAHHOFMFIOE(WorkArea PJIAPEDEBEP)
	{
		if (!workAreas.Contains(PJIAPEDEBEP))
		{
			workAreas.Add(PJIAPEDEBEP);
		}
	}

	private void PNJJEDEFAGO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(MFENGCKOFDL));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(PJOACEFEEKN));
			workAreas = new List<WorkArea>();
		}
	}
}
