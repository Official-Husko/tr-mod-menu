using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
	public static SlotManager instance;

	private List<Slot> PCJEDMJEKEF = new List<Slot>();

	public static void IEPFDLFFJOB(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"ReceiveUpdateBentoOnTray");
		}
	}

	private void LNPDALMANFB()
	{
		AIFIBNNAMEC();
	}

	public static void NGKHKCNNKBA(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	public static void MLCLEEJHIKF(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	public static void EAOPCMDJNDA(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"AddQuest2");
		}
	}

	public static void AddSlot(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"NO SLOT MANAGER!");
		}
	}

	public void PCDEFINBAHC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void DBBIAKMKJIP()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void FHOCCEBKHJI()
	{
		MJOGICLJAHC();
	}

	public static void JJBKIALKECP(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"Player");
		}
	}

	public void MJOGICLJAHC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void MFGANCCJFJK()
	{
		CPGKEDLBPGM();
	}

	public static void OAOEKONDOAB(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"Open");
		}
	}

	private void JDAMCMODANB()
	{
		OGDHDBBBCKE();
	}

	public static void NPEMBJFAENC(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"Scene");
		}
	}

	public static void RemoveSlot(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	public static void MFOEGLBHALK(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"Ground");
		}
	}

	private void JIAJFDKNJME()
	{
		EOADCHLNLPK();
	}

	private void CABBIPOHEFM()
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 1; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FJMBKLHJIKO())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].FKCFFOHOMOB(AODONKKHPBP: true);
			}
		}
	}

	public static void JHLJMEDLLJP(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"Could not get value of statistic ");
		}
	}

	private void HINGECEDJAP()
	{
		PPICAMAGNME();
	}

	public void OJBBMIGKHCG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void LBKPBFMEDLE(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	private void MBMFDJHDNCI()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FINGJCFAILB())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].FKCFFOHOMOB(AODONKKHPBP: false);
			}
		}
	}

	private void KHCJDKHONPK()
	{
		ENPJHFLIALN();
	}

	private void EBJPPNBLGOC()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FINGJCFAILB())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].FKCFFOHOMOB(AODONKKHPBP: false);
			}
		}
	}

	private void AAEAAEBBFKG()
	{
		OJBBMIGKHCG();
	}

	public void IJBBCBKBNAN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void AIFIBNNAMEC()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void CPGKEDLBPGM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void AJMEFFOGPPE()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].IDAEFBPMBCN())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].AJOGNKDJNAD(AODONKKHPBP: false);
			}
		}
	}

	private void IIPKPMPGLOL()
	{
		JEMFMIHMAOI();
	}

	public void JEMFMIHMAOI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void JPPCPMOMDON()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].JJCCONBGLBC())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].isDirty = true;
			}
		}
	}

	private void BHAFCBHENPL()
	{
		PLIFJBMCANA();
	}

	private void IIKAAAHEFMP()
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FINGJCFAILB())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].FKCFFOHOMOB(AODONKKHPBP: true);
			}
		}
	}

	public void ENPJHFLIALN()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void DKFGDMNBAAK()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].JJCCONBGLBC())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].FBAFIONMKBG(AODONKKHPBP: true);
			}
		}
	}

	private void KPHPCKJBLBH()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FINGJCFAILB())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].AJOGNKDJNAD(AODONKKHPBP: true);
			}
		}
	}

	public void LIIIBHPMFKK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void BMJFCKCIIAC(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	public void PEKDBJOHHIK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void PPICAMAGNME()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void CIECDFPIOPF(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_Standar/Entry/10/Dialogue Text");
		}
	}

	private void EMJKKALMGLK()
	{
		OJBBMIGKHCG();
	}

	private void Awake()
	{
		Initialize();
	}

	public static void MCGALHEKMBE(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	public static void PEOEEFBDEOJ(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Add(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"");
		}
	}

	private void HPJBLOPJIMI()
	{
		OJBBMIGKHCG();
	}

	public static void BHKAEJKMKLC(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	private void HNNFBDAMMCK()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FINGJCFAILB())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].AJOGNKDJNAD(AODONKKHPBP: true);
			}
		}
	}

	private void OMBHDODDHNO()
	{
		MJOGICLJAHC();
	}

	private void DADPOICMNPI()
	{
		OJBBMIGKHCG();
	}

	public void PLIFJBMCANA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void OGDHDBBBCKE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void KDHLJKMKFMG()
	{
		EOADCHLNLPK();
	}

	public void Initialize()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public void DNNGLPLEEMJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	private void LJCOPHJMDEL()
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].FINGJCFAILB())
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].isDirty = true;
			}
		}
	}

	public void EOADCHLNLPK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			instance = this;
		}
	}

	public static void NLMOEDNDDAO(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	private void LateUpdate()
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			if (PCJEDMJEKEF[num] == null)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else if (PCJEDMJEKEF[num].isDirty)
			{
				PCJEDMJEKEF[num].OnDirtied();
				PCJEDMJEKEF[num].isDirty = false;
			}
		}
	}

	public static void HBBDJNKDOHD(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}

	public static void JDNBCANHEEA(Slot AHEHNLOLJLL)
	{
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.PCJEDMJEKEF.Remove(AHEHNLOLJLL);
		}
	}
}
