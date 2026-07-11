using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTavernUI : UIWindow
{
	private static UpgradeTavernUI IADEMLIIDPC;

	public Button firstGamepadButton;

	public RepLock repLock;

	[SerializeField]
	private GameObject listParent;

	[SerializeField]
	private UpgradeRoomElementUI[] upgradeRoomElements;

	[SerializeField]
	private UpgradeRoomLockedUI prefabUpgradeRoomLocked;

	private List<UpgradeRoomLockedUI> IHMDFLDJOBC;

	private int LDNFCLNDNNA;

	public static UpgradeTavernUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
			}
			return IADEMLIIDPC;
		}
	}

	private void PMOGLENNPEN()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].EAMHFGBBELN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].LIDLKHPKLNK();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LOEPFAHGDIA(upgradeRoomElements[i].JOHADBAAFND());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void MPLLDNNCJFI()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].HasReputationLevel())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].UpdateElement();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].UpdateElement(upgradeRoomElements[i].GetCurrentReputationReward());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void EHEOAKJDLCE()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].BHHJOCGKPFI())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].LCDNOJEDJKN();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].OGLAJAKDIPG(upgradeRoomElements[i].ANJAAONHLEO());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI LANAINBEMCM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI AJIGOHGPFPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void BMCCDAKOAIJ()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].MKNHFDLDAMP())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].BPLKCCNBPFH();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].BCPLGIJLLAD(upgradeRoomElements[i].NNPKBEJDLJL());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void FNLLJNBJPFP()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].PMCCKIEOMKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].PKHFJAIBCDI();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].BCPLGIJLLAD(upgradeRoomElements[i].JOHADBAAFND());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void BFNPMJOHHNJ()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BEMNCDGLNDB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].PNILDPCIBBL();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].BCPLGIJLLAD(upgradeRoomElements[i].NNPKBEJDLJL());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI ABDJJBFNLBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		Utils.JEAHJILAIAP(0f);
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && !((Component)repLock).gameObject.activeSelf)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstGamepadButton);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	[SpecialName]
	public static UpgradeTavernUI OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI OFLELHKKNKC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void BBEINCCFDDP()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].JJALEIAELNF())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].UpdateElement();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].MCIBPHCHFAB(upgradeRoomElements[i].LOJKCGANDBG());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI JCMKNNOEONP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI OOKBNHMMFON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void CKFMIODNBJE()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].EGMBBBGIAIJ())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].UpdateElement();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].MNMPLAIEAPN(upgradeRoomElements[i].IPIJKHDMDKM());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI OPILDPFDFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI MIGKKKELOJO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void DJONFAGFLEO()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].MKNHFDLDAMP())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].HGGNFBDKFEK();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].LOFNIECDBAF(upgradeRoomElements[i].JOCBBJCOBCH());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI DFJGHOHPPEL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void BDFAJENGLBH()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].HAHIKABNEGL())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].NPPFHJLGCBE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].LOFNIECDBAF(upgradeRoomElements[i].FGBEIEOHKGA());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void PNILDPCIBBL()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].EAMHFGBBELN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].LCDNOJEDJKN();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LMFDGABDAKM(upgradeRoomElements[i].GHHPONDHDDK());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI MNFMOEKMJKN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void KJPBMKOJGJA()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].INEPEDHGPLI())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].LMFDGABDAKM();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LOEPFAHGDIA(upgradeRoomElements[i].MCNPKNKNHIL());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void HIINHOKKCPB()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].ILBCEFEBNBN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].LMFDGABDAKM();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].OGLAJAKDIPG(upgradeRoomElements[i].NNPKBEJDLJL());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void LLMLEOHOEMD()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].GOEPJLMDBAL())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].NPPFHJLGCBE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].LMFDGABDAKM(upgradeRoomElements[i].BAIKKHFJBHL());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void LMFDGABDAKM()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BEMNCDGLNDB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].BBEINCCFDDP();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].JFHCPBJONGE(upgradeRoomElements[i].BAIKKHFJBHL());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI CMIHGBHPLFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI NEFIEJALANL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void HGGNFBDKFEK()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].INEPEDHGPLI())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].LCDNOJEDJKN();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].JFHCPBJONGE(upgradeRoomElements[i].JIHDOIDOONA());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void DCGHBLCMAMB()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].EOILPEPACDE())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].UpdateElement();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LOEPFAHGDIA(upgradeRoomElements[i].JLFOCHAKDJG());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void EOILJFHHMMD()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].BPLKCCNBPFH();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].BCPLGIJLLAD(upgradeRoomElements[i].JLFOCHAKDJG());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI KNOKBLFFNLM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void DMBFENEEKAJ()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].PMCCKIEOMKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].OOKANHIBNDE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].BCPLGIJLLAD(upgradeRoomElements[i].GHHPONDHDDK());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void ELNMBDIHHDK()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].EGMBBBGIAIJ())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].UpdateElement();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].MCIBPHCHFAB(upgradeRoomElements[i].BAIKKHFJBHL());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void LOEPFAHGDIA()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].INEPEDHGPLI())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].LIDLKHPKLNK();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].OOKANHIBNDE(upgradeRoomElements[i].GNMPFNLOBGD());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI FOPGLLMEEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI LADDMEMMJFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void NDMDBECHDCL()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].MKNHFDLDAMP())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].NPPFHJLGCBE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].MCIBPHCHFAB(upgradeRoomElements[i].JFJJPGAOFJD());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI OAPOJCODNCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI DGCNCEDIFOF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			MPLLDNNCJFI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void ACIDMLDNHCG()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].ADLGEPGGOEJ())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].PKHFJAIBCDI();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].EIJFGACDMNK(upgradeRoomElements[i].HOPEOPFJKKH());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI EAGMIHGJKNB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void HPADHAFDDMH()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].EOILPEPACDE())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].OOKANHIBNDE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].UpdateElement(upgradeRoomElements[i].GetCurrentReputationReward());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI NGIMIHFFNMH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void AOEIHMNLJAC()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].BEMNCDGLNDB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].GCMOKLLFBNF();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].OGLAJAKDIPG(upgradeRoomElements[i].CPJGABDELKJ());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void CBJHJNKAEJO()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].EOILPEPACDE())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].NPPFHJLGCBE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].MNMPLAIEAPN(upgradeRoomElements[i].JOHADBAAFND());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI LFPEPJBNCBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI LPFNKEOJJKE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI HLMGBEGEAPC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI ACPHFLBLJAA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void DFHHDDKIJED()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].EGMBBBGIAIJ())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].PNILDPCIBBL();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].UpdateElement(upgradeRoomElements[i].CPKGJKGNDCE());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void AIMDCFPDOMA()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].HGGNFBDKFEK();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].JFHCPBJONGE(upgradeRoomElements[i].FGBEIEOHKGA());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI PFHFIJDDOME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void BAKGAHONABL()
	{
		LDNFCLNDNNA = 0;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].GCMOKLLFBNF();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LOFNIECDBAF(upgradeRoomElements[i].ANJAAONHLEO());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void LCOBLJEIADI()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].GCMOKLLFBNF();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].PMOGLENNPEN(upgradeRoomElements[i].FGBEIEOHKGA());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void HLGGNHMPEIG()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].HEPNFGADEIN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].GCMOKLLFBNF();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LMFDGABDAKM(upgradeRoomElements[i].JLFOCHAKDJG());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
			IHMDFLDJOBC = new List<UpgradeRoomLockedUI>();
		}
	}

	[SpecialName]
	public static UpgradeTavernUI KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI BADFKMEJOKE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void LGCDBBBGKGO()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].EAMHFGBBELN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].PKHFJAIBCDI();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].EHEOAKJDLCE(upgradeRoomElements[i].FGBEIEOHKGA());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void LJPLMGOPIDD()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].LIDLKHPKLNK();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].JFHCPBJONGE(upgradeRoomElements[i].ALCDFAFMDOG());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void GBHDIMEBKEA()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].JJALEIAELNF())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].HGGNFBDKFEK();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].LMFDGABDAKM(upgradeRoomElements[i].CPKGJKGNDCE());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI EJHDHCNILDH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void POECGCOHIFD()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].OOPCCIAKMCE())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].CIPNBDCLGEJ();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].BCPLGIJLLAD(upgradeRoomElements[i].FINFDMOEIMP());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI MOJDNGDNCCO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void CNEHLDJMNKH()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].BHHJOCGKPFI())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].BBEINCCFDDP();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].MCIBPHCHFAB(upgradeRoomElements[i].NNPKBEJDLJL());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void JFHCPBJONGE()
	{
		LDNFCLNDNNA = 1;
		for (int i = 1; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].HasReputationLevel())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].OOKANHIBNDE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].OOKANHIBNDE(upgradeRoomElements[i].JIHDOIDOONA());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI ABHIDHPMLLD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void LGFHMKPCIMC()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].EGMBBBGIAIJ())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].NPPFHJLGCBE();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].UpdateElement(upgradeRoomElements[i].HOPEOPFJKKH());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void LOFNIECDBAF()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].ILBCEFEBNBN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].UpdateElement();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].EIJFGACDMNK(upgradeRoomElements[i].ALCDFAFMDOG());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	private void EBLINHCCCCF()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].PABPIGGOEMO();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(false);
			IHMDFLDJOBC[LDNFCLNDNNA].UpdateElement(upgradeRoomElements[i].GHHPONDHDDK());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void PKHFJAIBCDI()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].HAHIKABNEGL())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].CIPNBDCLGEJ();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].MCIBPHCHFAB(upgradeRoomElements[i].FGBEIEOHKGA());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public static UpgradeTavernUI MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI KGPJPILAHDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI OLHBLKIAFOM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static UpgradeTavernUI AFFGPMFKEFH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<UpgradeTavernUI>();
		}
		return IADEMLIIDPC;
	}

	private void FONMOPCKDFA()
	{
		LDNFCLNDNNA = 1;
		for (int i = 0; i < upgradeRoomElements.Length; i += 0)
		{
			if (upgradeRoomElements[i].BPELFFDOPKB())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(true);
				upgradeRoomElements[i].LMFDGABDAKM();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].LOFNIECDBAF(upgradeRoomElements[i].LOJKCGANDBG());
			LDNFCLNDNNA += 0;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j += 0)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(true);
		}
	}

	private void GBAGEBECINO()
	{
		LDNFCLNDNNA = 0;
		for (int i = 0; i < upgradeRoomElements.Length; i++)
		{
			if (upgradeRoomElements[i].HEPNFGADEIN())
			{
				((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
				upgradeRoomElements[i].GCMOKLLFBNF();
				continue;
			}
			((Component)upgradeRoomElements[i]).gameObject.SetActive(false);
			if (LDNFCLNDNNA >= IHMDFLDJOBC.Count)
			{
				IHMDFLDJOBC.Add(Object.Instantiate<UpgradeRoomLockedUI>(prefabUpgradeRoomLocked, listParent.transform));
			}
			((Component)IHMDFLDJOBC[LDNFCLNDNNA]).gameObject.SetActive(true);
			IHMDFLDJOBC[LDNFCLNDNNA].OGLAJAKDIPG(upgradeRoomElements[i].ALCDFAFMDOG());
			LDNFCLNDNNA++;
		}
		for (int j = LDNFCLNDNNA; j < IHMDFLDJOBC.Count; j++)
		{
			((Component)IHMDFLDJOBC[j]).gameObject.SetActive(false);
		}
	}
}
