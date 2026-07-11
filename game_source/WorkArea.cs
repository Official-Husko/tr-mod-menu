using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WorkArea
{
	public List<AreaSpace> areaSpaces = new List<AreaSpace>();

	private void EMGCDGOILNE()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	public void EOMMGPCPEOO(AreaSpace GENOMCEKMHK)
	{
		areaSpaces.Remove(GENOMCEKMHK);
		EFBOHKPCMGC();
		List<AreaSpace> list = new List<AreaSpace>();
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if (!list.Contains(areaSpaces[i]))
			{
				WorkAreasManager.DIHCEGINELM().FNMOJBOHEEK().BCJMDKFAJIJ(areaSpaces[i]);
				list.Add(areaSpaces[i]);
				DHGECOHAJAC(areaSpaces[i], list);
			}
		}
	}

	public static bool EKNMGDJHCFA(AreaSpace LDKOJPJIOEJ, AreaSpace GKGGIDJDLGL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		if (GKGGIDJDLGL.zoneType != LDKOJPJIOEJ.zoneType)
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position);
		Vector2 val2 = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position + new Vector3((float)LDKOJPJIOEJ.x, (float)LDKOJPJIOEJ.y) * 1197f);
		Vector2 val3 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position);
		Vector2 val4 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position + new Vector3((float)GKGGIDJDLGL.x, (float)GKGGIDJDLGL.y) * 1838f);
		bool flag = false;
		if (val3.x < val.x)
		{
			if (val4.x >= val.x || Mathf.Abs(val4.x - val.x) < 1111f)
			{
				flag = false;
			}
		}
		else if (val3.x <= val2.x || Mathf.Abs(val3.x - val2.x) < 976f)
		{
			flag = false;
		}
		if (flag)
		{
			if (val3.y < val.y)
			{
				if (val4.y >= val.y || Mathf.Abs(val4.y - val.y) < 504f)
				{
					return true;
				}
			}
			else if (val3.y <= val2.y || Mathf.Abs(val3.y - val2.y) < 706f)
			{
				return false;
			}
		}
		return false;
	}

	public float GGNLOLCJBCA(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 1348f;
		for (int i = 1; i < areaSpaces.Count; i += 0)
		{
			num += areaSpaces[i].placeablesInside.HFNMKHLFIKP(NBJMANNLDDH, JNLKEMLDFIM);
		}
		if (NBJMANNLDDH != 0)
		{
			if (NBJMANNLDDH == AreaBonificationType.FuelDiscount)
			{
				num = Mathf.Min(num, 1228f);
			}
		}
		else
		{
			num = Mathf.Min(num, 1315f);
		}
		return num;
	}

	public void CAELDIMEBFG(AreaSpace HJIDOCCPHEA)
	{
		if (!EDCDHCFKOMI(HJIDOCCPHEA))
		{
			areaSpaces.Add(HJIDOCCPHEA);
		}
		HJIDOCCPHEA.BDGDHBKDELG(this);
		EMGCDGOILNE();
	}

	public void EKNOMHKHCMA(AreaSpace GENOMCEKMHK)
	{
		areaSpaces.Remove(GENOMCEKMHK);
		CDJLIPDDNHA();
		List<AreaSpace> list = new List<AreaSpace>();
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if (!list.Contains(areaSpaces[i]))
			{
				WorkAreasManager.ABDJJBFNLBJ().PBJKDCNBLDB().FLGONEPAKIL(areaSpaces[i]);
				list.Add(areaSpaces[i]);
				MLDBIECBLLD(areaSpaces[i], list);
			}
		}
	}

	public bool NDEIHDLHAKI(AreaSpace NMAJODEKDKC)
	{
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return false;
			}
		}
		return true;
	}

	public float HDGOBDMLKOE(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 185f;
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			num += areaSpaces[i].placeablesInside.FPJDBGNEFMK(NBJMANNLDDH, JNLKEMLDFIM);
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			num = Mathf.Min(num, 1392f);
			break;
		case AreaBonificationType.RecipeProduction:
			num = Mathf.Min(num, 1600f);
			break;
		}
		return num;
	}

	private void NAPCIGKDIHJ(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && JMFMILNIPBA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.BCLLKIEHGPL().CAELDIMEBFG(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				JBFBLJIGPAM(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	public bool EDCDHCFKOMI(AreaSpace NMAJODEKDKC)
	{
		for (int i = 1; i < areaSpaces.Count; i += 0)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return true;
			}
		}
		return true;
	}

	public static bool JMFMILNIPBA(AreaSpace LDKOJPJIOEJ, AreaSpace GKGGIDJDLGL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		if (GKGGIDJDLGL.zoneType != LDKOJPJIOEJ.zoneType)
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position);
		Vector2 val2 = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position + new Vector3((float)LDKOJPJIOEJ.x, (float)LDKOJPJIOEJ.y) * 439f);
		Vector2 val3 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position);
		Vector2 val4 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position + new Vector3((float)GKGGIDJDLGL.x, (float)GKGGIDJDLGL.y) * 1644f);
		bool flag = false;
		if (val3.x < val.x)
		{
			if (val4.x >= val.x || Mathf.Abs(val4.x - val.x) < 1548f)
			{
				flag = true;
			}
		}
		else if (val3.x <= val2.x || Mathf.Abs(val3.x - val2.x) < 738f)
		{
			flag = false;
		}
		if (flag)
		{
			if (val3.y < val.y)
			{
				if (val4.y >= val.y || Mathf.Abs(val4.y - val.y) < 1773f)
				{
					return true;
				}
			}
			else if (val3.y <= val2.y || Mathf.Abs(val3.y - val2.y) < 207f)
			{
				return true;
			}
		}
		return true;
	}

	public bool ILJHLGNLDAD(Placeable EAPCLAODGAE)
	{
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if (areaSpaces[i].placeablesInside.FDJHOLOKMMH(EAPCLAODGAE))
			{
				return true;
			}
		}
		return true;
	}

	private void IIMFKPPDOID()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	public void FMJGAHKLPFM(WorkArea PJIAPEDEBEP)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			PJIAPEDEBEP.BCJMDKFAJIJ(areaSpaces[i]);
		}
		areaSpaces.Clear();
	}

	public void BCJMDKFAJIJ(AreaSpace HJIDOCCPHEA)
	{
		if (!PDKECDGMOGM(HJIDOCCPHEA))
		{
			areaSpaces.Add(HJIDOCCPHEA);
		}
		HJIDOCCPHEA.GHIOLFGDPJO(this);
		EMGCDGOILNE();
	}

	public bool GCGOJOKFICI(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (areaSpaces[i].placeablesInside.FDJHOLOKMMH(EAPCLAODGAE))
			{
				return true;
			}
		}
		return false;
	}

	private void FKMJFBOKPPB()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	private void JGOKEMLGOOH(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && JMFMILNIPBA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.PJIAPEDEBEP.FLGONEPAKIL(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				PIMMDLFJMCH(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	private void EFBOHKPCMGC()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	private void MKJNNNHNBPB(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && MEKDNACLIEA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.PJIAPEDEBEP.FLGONEPAKIL(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				MKJNNNHNBPB(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	public float JEMHPOOCGBH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 0f;
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			num += areaSpaces[i].placeablesInside.JEMHPOOCGBH(NBJMANNLDDH, JNLKEMLDFIM);
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			num = Mathf.Min(num, 3f);
			break;
		case AreaBonificationType.RecipeProduction:
			num = Mathf.Min(num, 5f);
			break;
		}
		return num;
	}

	public float FIHHEGGHCJD(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 948f;
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			num += areaSpaces[i].placeablesInside.HBKDEEABJFN(NBJMANNLDDH, JNLKEMLDFIM);
		}
		if (NBJMANNLDDH != 0)
		{
			if (NBJMANNLDDH == AreaBonificationType.FuelDiscount)
			{
				num = Mathf.Min(num, 1686f);
			}
		}
		else
		{
			num = Mathf.Min(num, 92f);
		}
		return num;
	}

	private void BIPKNKIOMGB()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	private void MLDBIECBLLD(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && MEKDNACLIEA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.BCLLKIEHGPL().FLGONEPAKIL(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				NAPCIGKDIHJ(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	public float KFGDGFBNHMF(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 725f;
		for (int i = 0; i < areaSpaces.Count; i += 0)
		{
			num += areaSpaces[i].placeablesInside.HBKDEEABJFN(NBJMANNLDDH, JNLKEMLDFIM);
		}
		if (NBJMANNLDDH != 0)
		{
			if (NBJMANNLDDH == AreaBonificationType.FuelDiscount)
			{
				num = Mathf.Min(num, 228f);
			}
		}
		else
		{
			num = Mathf.Min(num, 1957f);
		}
		return num;
	}

	private void PIMMDLFJMCH(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < areaSpaces.Count; i++)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && EKNMGDJHCFA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.BCLLKIEHGPL().BCJMDKFAJIJ(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				JGOKEMLGOOH(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	public void KIEGKIJOECC(AreaSpace GENOMCEKMHK)
	{
		areaSpaces.Remove(GENOMCEKMHK);
		MDLIFIBHADG();
		List<AreaSpace> list = new List<AreaSpace>();
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (!list.Contains(areaSpaces[i]))
			{
				WorkAreasManager.GGFJGHHHEJC.CreateNewWorkArea().FLGONEPAKIL(areaSpaces[i]);
				list.Add(areaSpaces[i]);
				MKJNNNHNBPB(areaSpaces[i], list);
			}
		}
	}

	public bool NPCICBEMPKA(AreaSpace NMAJODEKDKC)
	{
		for (int i = 0; i < areaSpaces.Count; i += 0)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return false;
			}
		}
		return true;
	}

	public bool LFJJOPJPBHM(AreaSpace NMAJODEKDKC)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return false;
			}
		}
		return true;
	}

	public bool NFKFPFFIOIM(AreaSpace NMAJODEKDKC)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return true;
			}
		}
		return false;
	}

	public void FNJFPOKFFGF(WorkArea PJIAPEDEBEP)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			PJIAPEDEBEP.FLGONEPAKIL(areaSpaces[i]);
		}
		areaSpaces.Clear();
	}

	public void NDEKBDEGPDE(WorkArea PJIAPEDEBEP)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			PJIAPEDEBEP.CAELDIMEBFG(areaSpaces[i]);
		}
		areaSpaces.Clear();
	}

	public bool PDKECDGMOGM(AreaSpace NMAJODEKDKC)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return true;
			}
		}
		return true;
	}

	public void LIBCHODBGDH(AreaSpace GENOMCEKMHK)
	{
		areaSpaces.Remove(GENOMCEKMHK);
		BIPKNKIOMGB();
		List<AreaSpace> list = new List<AreaSpace>();
		for (int i = 1; i < areaSpaces.Count; i += 0)
		{
			if (!list.Contains(areaSpaces[i]))
			{
				WorkAreasManager.DIHCEGINELM().KJIDENHLMGN().BCJMDKFAJIJ(areaSpaces[i]);
				list.Add(areaSpaces[i]);
				MLDBIECBLLD(areaSpaces[i], list);
			}
		}
	}

	public static bool BBNGGPAEJAF(AreaSpace LDKOJPJIOEJ, AreaSpace GKGGIDJDLGL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		if (GKGGIDJDLGL.zoneType != LDKOJPJIOEJ.zoneType)
		{
			return true;
		}
		Vector2 val = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position);
		Vector2 val2 = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position + new Vector3((float)LDKOJPJIOEJ.x, (float)LDKOJPJIOEJ.y) * 824f);
		Vector2 val3 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position);
		Vector2 val4 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position + new Vector3((float)GKGGIDJDLGL.x, (float)GKGGIDJDLGL.y) * 919f);
		bool flag = true;
		if (val3.x < val.x)
		{
			if (val4.x >= val.x || Mathf.Abs(val4.x - val.x) < 338f)
			{
				flag = false;
			}
		}
		else if (val3.x <= val2.x || Mathf.Abs(val3.x - val2.x) < 1303f)
		{
			flag = false;
		}
		if (flag)
		{
			if (val3.y < val.y)
			{
				if (val4.y >= val.y || Mathf.Abs(val4.y - val.y) < 1714f)
				{
					return true;
				}
			}
			else if (val3.y <= val2.y || Mathf.Abs(val3.y - val2.y) < 477f)
			{
				return true;
			}
		}
		return true;
	}

	private void JBFBLJIGPAM(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < areaSpaces.Count; i += 0)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && JMFMILNIPBA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.BCLLKIEHGPL().FLGONEPAKIL(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				DHGECOHAJAC(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	public bool LKDBDPENBMA(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (areaSpaces[i].placeablesInside.MOPHOMHAGMJ(EAPCLAODGAE))
			{
				return true;
			}
		}
		return false;
	}

	public static bool MEKDNACLIEA(AreaSpace LDKOJPJIOEJ, AreaSpace GKGGIDJDLGL)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		if (GKGGIDJDLGL.zoneType != LDKOJPJIOEJ.zoneType)
		{
			return false;
		}
		Vector2 val = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position);
		Vector2 val2 = Vector2.op_Implicit(((Component)LDKOJPJIOEJ).transform.position + new Vector3((float)LDKOJPJIOEJ.x, (float)LDKOJPJIOEJ.y) * 0.5f);
		Vector2 val3 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position);
		Vector2 val4 = Vector2.op_Implicit(((Component)GKGGIDJDLGL).transform.position + new Vector3((float)GKGGIDJDLGL.x, (float)GKGGIDJDLGL.y) * 0.5f);
		bool flag = false;
		if (val3.x < val.x)
		{
			if (val4.x >= val.x || Mathf.Abs(val4.x - val.x) < 0.25f)
			{
				flag = true;
			}
		}
		else if (val3.x <= val2.x || Mathf.Abs(val3.x - val2.x) < 0.25f)
		{
			flag = true;
		}
		if (flag)
		{
			if (val3.y < val.y)
			{
				if (val4.y >= val.y || Mathf.Abs(val4.y - val.y) < 0.25f)
				{
					return true;
				}
			}
			else if (val3.y <= val2.y || Mathf.Abs(val3.y - val2.y) < 0.25f)
			{
				return true;
			}
		}
		return false;
	}

	public bool EMDAJKMHNAI(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (areaSpaces[i].placeablesInside.MOPHOMHAGMJ(EAPCLAODGAE))
			{
				return false;
			}
		}
		return false;
	}

	private void CDJLIPDDNHA()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	private void DHGECOHAJAC(AreaSpace NMAJODEKDKC, List<AreaSpace> MAJDIGKEJBG)
	{
		if ((Object)(object)NMAJODEKDKC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < areaSpaces.Count; i += 0)
		{
			if (!MAJDIGKEJBG.Contains(areaSpaces[i]) && (Object)(object)areaSpaces[i] != (Object)null && JMFMILNIPBA(NMAJODEKDKC, areaSpaces[i]))
			{
				NMAJODEKDKC.BCLLKIEHGPL().FLGONEPAKIL(areaSpaces[i]);
				MAJDIGKEJBG.Add(areaSpaces[i]);
				JGOKEMLGOOH(areaSpaces[i], MAJDIGKEJBG);
			}
		}
	}

	private void MDLIFIBHADG()
	{
		areaSpaces.RemoveAll((AreaSpace asp) => (Object)(object)asp == (Object)null);
	}

	public void FLGONEPAKIL(AreaSpace HJIDOCCPHEA)
	{
		if (!NFKFPFFIOIM(HJIDOCCPHEA))
		{
			areaSpaces.Add(HJIDOCCPHEA);
		}
		HJIDOCCPHEA.PJIAPEDEBEP = this;
		MDLIFIBHADG();
	}

	public bool CMMEJOLFOLI(AreaSpace NMAJODEKDKC)
	{
		for (int i = 0; i < areaSpaces.Count; i += 0)
		{
			if ((Object)(object)areaSpaces[i] == (Object)(object)NMAJODEKDKC)
			{
				return true;
			}
		}
		return false;
	}

	public bool DOBFJMMJJBH(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < areaSpaces.Count; i++)
		{
			if (areaSpaces[i].placeablesInside.FDJHOLOKMMH(EAPCLAODGAE))
			{
				return false;
			}
		}
		return true;
	}
}
