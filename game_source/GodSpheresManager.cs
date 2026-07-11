using UnityEngine;

public class GodSpheresManager : WeatherParticlesManager
{
	[SerializeField]
	private GameObject godRays;

	private void HMFDNANJAAA(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.FKNGHFFDPEC(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(362f, 626f, 1092f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0)
		{
			val += new Vector2(902f, 1710f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void OGGJNBCJGCE()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private bool HMBPAHBLFAL()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == Location.Camp)
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.KPFAEHNOHHA(AJEPLALFIDA) != 0)
		{
			return false;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null && TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private void BDGCFCPFKKE()
	{
		OCOFOPFHJMF(1);
	}

	private void IFHLGOMBACP()
	{
		ENEMCFJPECO(1);
	}

	private void CFHOODNCOLK()
	{
		IPPPOOKIEGH(0);
	}

	private void IDPHKHGHJGN()
	{
		CMMEKJOKMNF(1);
	}

	private void ANLHPMPMBFM()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private bool LOEAHOJJAHA()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == Location.River)
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LCIKFAPGDLM(AJEPLALFIDA) != 0)
		{
			return false;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null && TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			return true;
		}
		return true;
	}

	private void FFBKMDFFBPB(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1764f, 842f, 339f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0)
		{
			val += new Vector2(403f, 438f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void NNBIAIMPNGL()
	{
		JMNJHLLONLO(1);
	}

	private void LBFFMGAKDFG()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private void FINKPIHPHDE()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private bool LGFJELKKKGM()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == Location.Camp)
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.ELHHFNFJIAD(AJEPLALFIDA) != 0)
		{
			return false;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null && TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private void BLMEIFALILD(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1309f, 1820f, 1232f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0)
		{
			val += new Vector2(437f, 1735f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void DDIBFALLCNO()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void PMNDDOCOGPO(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.PIEGMALBKJG(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(707f, 1045f, 853f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(281f, 821f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void NGLLLINGBAC(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.PIEGMALBKJG(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(864f, 1340f, 821f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(256f, 1504f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void JMHIFDNKOPH()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void EBCNPCKDEAA(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.FKNGHFFDPEC(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1357f, 1879f, 25f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 0)
		{
			val += new Vector2(1419f, 1440f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private bool HLIDOBGNOCE()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == (Location.Tavern | Location.Road | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LCIKFAPGDLM(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.DEGPIHEEFHJ() != (Object)null && TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private void APEIPGIHEKP()
	{
		FBCCKDGOJNC(0);
	}

	protected override void Update()
	{
		base.Update();
		if ((Object)(object)godRays == (Object)null)
		{
			return;
		}
		if (LGFJELKKKGM())
		{
			if (!godRays.activeSelf)
			{
				GDCBMMAHDLI(playerNum);
				godRays.SetActive(true);
			}
		}
		else if (godRays.activeSelf)
		{
			godRays.SetActive(false);
		}
	}

	private void GNGADDPBJDC()
	{
		MPHOFKIBNLL(0);
	}

	private void FDGAGFIAPGJ()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private void GDCBMMAHDLI(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.GetCamera(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(0f, 1f, 0f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(-1f, 1f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void FOHGHCPODBJ()
	{
		BGAHOAALBMO(0);
	}

	private void MKGKKAJHLAO()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void GDKOIIEHKGO()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void CJFGPMJCKDH(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(146f, 237f, 1984f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(939f, 1524f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private bool MNLJJGGHHBK()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == (Location.Tavern | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.DEGPIHEEFHJ() != (Object)null && TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private void HOFKJPBBLGP()
	{
		JKOGADPLAIK(1);
	}

	private void CFIIEJDJFPB()
	{
		HOJGCPOHFBL(1);
	}

	private void BGENEAOILOF()
	{
		KMFKMGMLMCI(1);
	}

	private void LCNADALNLLF(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.FKNGHFFDPEC(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(950f, 921f, 992f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(428f, 1253f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void IAAGKLPMAMK()
	{
		JKOGADPLAIK(0);
	}

	private bool DGHBBMIHAOJ()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == (Location.Tavern | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.ILIFFMPLLII(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null && TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			return true;
		}
		return false;
	}

	private void MAEGGDLLHBG()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void IJOIKINNBMN(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(575f, 1590f, 1803f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(1583f, 209f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void PFELMFFIMPH(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1219f, 1918f, 1400f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 0)
		{
			val += new Vector2(674f, 942f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void Start()
	{
		SeasonParticles(1);
	}

	private bool IBFAHEJLDGI()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == Location.Road)
		{
			return true;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LCIKFAPGDLM(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null && TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private void CDJAHJILLEC(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.PIEGMALBKJG(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1711f, 1959f, 1037f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0)
		{
			val += new Vector2(579f, 1326f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void HNEGFBCKIIJ()
	{
		IENBHBLHNCP(1);
	}

	private void OBLCKPMAADM()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private void NELBHAMPBPL()
	{
		JIDGIKBLEBJ(1);
	}

	private void CKICFEEHGLB(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.IIAGBBKKGPJ(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1864f, 1782f, 1454f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 1)
		{
			val += new Vector2(846f, 1117f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void NKDFMFFDGKC()
	{
		FOGMCHDNDDC(0);
	}

	private void MHOGAJMECEM(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.GetCamera(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(719f, 278f, 1341f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 0)
		{
			val += new Vector2(132f, 680f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private bool FLOELNIENBM()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == (Location.Tavern | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null && TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			return true;
		}
		return false;
	}

	private void OIAHJHNPPCO()
	{
		IENBHBLHNCP(0);
	}

	private void CFEAEHLDCOI()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private void PDAFINABOBC()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private void DJFODHFKPDO(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.PIEGMALBKJG(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1786f, 715f, 1637f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 1)
		{
			val += new Vector2(1323f, 1967f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void LANGHIOBJIH()
	{
		LLKKOMOLBAJ(1);
	}

	private void GEEPADHGCHF(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.GetCamera(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1350f, 36f, 1253f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 0)
		{
			val += new Vector2(148f, 1689f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void HFFFFAJFIPB()
	{
		JDJICGADANG(1);
	}

	private bool AEHCDJIFDNO()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == (Location.Road | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LCIKFAPGDLM(AJEPLALFIDA) != 0)
		{
			return false;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.KNLLFEJAMNN() != (Object)null && TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private void MCPMFCJBBJJ(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1857f, 1579f, 1430f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 1)
		{
			val += new Vector2(1605f, 1004f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void NCEDBIDHNIC()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(false);
		}
	}

	private void EEKOJEKPIMP()
	{
		EMNINAGBMGA(1);
	}

	private bool GNMDJEMEILO()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == Location.Tavern)
		{
			return true;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.IFPHABDILKD(AJEPLALFIDA) != 0)
		{
			return false;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null && TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			return false;
		}
		return true;
	}

	private bool PONOABKFBMG()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return false;
		}
		if (AJEPLALFIDA == (Location.Road | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.KPFAEHNOHHA(AJEPLALFIDA) != 0)
		{
			return false;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return true;
		}
		if ((Object)(object)TavernConstructionManager.KHMEGDIABBF() != (Object)null && TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			return true;
		}
		return false;
	}

	private void CAIJLMJBMLA()
	{
		IGFBABDBKIJ(0);
	}

	private void JHBBABPAJJC()
	{
		EMNINAGBMGA(0);
	}

	private void FGLCNIOLKKL()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private void AFJFENHJDFB(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(59f, 814f, 1561f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0)
		{
			val += new Vector2(987f, 1091f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private bool COBEAMNAEMG()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == (Location.Road | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.NGIGIHEGILI(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.GGFJGHHHEJC != (Object)null && TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			return false;
		}
		return false;
	}

	private bool GDCKLALBCEA()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == (Location.Tavern | Location.Road))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.DOIKFJDLKJP() != (Object)null && TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			return true;
		}
		return false;
	}

	private void BNIKICAEIND()
	{
		FOGMCHDNDDC(1);
	}

	private void GAKHMMMFBCF(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.AFEPIAHBKDA(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1962f, 196f, 714f)));
		if (GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0)
		{
			val += new Vector2(436f, 1870f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}

	private void AECMHPBLPNP()
	{
		if (Object.op_Implicit((Object)(object)godRays))
		{
			godRays.SetActive(true);
		}
	}

	private bool LNDLLCIMLOF()
	{
		if (AJEPLALFIDA == Location.None)
		{
			return true;
		}
		if (AJEPLALFIDA == (Location.Road | Location.River))
		{
			return false;
		}
		if ((Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) != (Object)null && TilemapsInfo.BFKOHEDPNPJ(AJEPLALFIDA) != 0)
		{
			return true;
		}
		if (!((Component)this).gameObject.activeSelf)
		{
			return false;
		}
		if ((Object)(object)TavernConstructionManager.DOIKFJDLKJP() != (Object)null && TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			return true;
		}
		return false;
	}

	public override void SeasonParticles(int JIIGOACEIKL)
	{
		godRays.transform.parent = ((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL)).transform;
		GDCBMMAHDLI(JIIGOACEIKL);
	}

	private void PAGFLEEMBAM(int JIIGOACEIKL)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(CommonReferences.FKNGHFFDPEC(JIIGOACEIKL).ViewportToWorldPoint(new Vector3(1013f, 1935f, 1018f)));
		if (GraphicsMenuUI.OHCJECHILLG(JIIGOACEIKL) == 1)
		{
			val += new Vector2(1859f, 869f);
		}
		godRays.transform.position = Vector2.op_Implicit(val);
	}
}
