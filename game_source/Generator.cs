using System;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	[Serializable]
	public class ForestElementProbabilities
	{
		public Item item;

		public int percentage;
	}

	public int ID;

	public int tilesSeparation = 1;

	[SerializeField]
	protected float randomOffset = 0.3f;

	[SerializeField]
	protected Transform cornerDownLeft;

	[SerializeField]
	protected Transform cornerUpRight;

	private int KIFCJGLDCDD = 1;

	[Space(20f)]
	public ForestElementProbabilities[] items;

	public List<ForestElement> forestElements = new List<ForestElement>();

	protected List<Vector3> KJNCFCCLPJN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public static bool JCIMKFONBBD(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1012f, 1006f) * (float)FGMEMDJKGHB);
		for (float num = 94f; num <= (float)FGMEMDJKGHB; num += 1060f)
		{
			for (float num2 = 685f; num2 <= (float)FGMEMDJKGHB; num2 += 1293f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return false;
				}
			}
		}
		return false;
	}

	public virtual void EGHOMJCNDIF(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	protected List<Vector3> DEGJHEFDOJC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public static bool CBNEEHEBLMI(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(959f, 114f) * (float)FGMEMDJKGHB);
		for (float num = 691f; num <= (float)FGMEMDJKGHB; num += 484f)
		{
			for (float num2 = 1396f; num2 <= (float)FGMEMDJKGHB; num2 += 1855f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return false;
				}
			}
		}
		return true;
	}

	public ForestElement PHLGNPNLHCI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public virtual void MBDIPPPJJMP(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	protected virtual void EBNENBFLEKB()
	{
	}

	protected List<Vector3> KBOFEHPEALK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void PBOPPIGJIAA()
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			MINHDCJMIDL(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public static bool EDECELEKDJI(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(418f, 657f) * (float)FGMEMDJKGHB);
		for (float num = 137f; num <= (float)FGMEMDJKGHB; num += 64f)
		{
			for (float num2 = 1439f; num2 <= (float)FGMEMDJKGHB; num2 += 782f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return false;
				}
			}
		}
		return true;
	}

	public ForestElement OCPMDIMEPJE(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void FEHHPOCJPJN(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public void AKDLPLPLGCC()
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			MINHDCJMIDL(forestElements[i], DBKCJHDNBCG: true);
		}
		forestElements.Clear();
	}

	protected virtual void BIPOBGNDFCK()
	{
	}

	public void MEHDDJICKBK(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.ECAJCNALDAO();
			}
		}
	}

	public void GLPNKBACOKA()
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			LMOBJOOHFFP(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public void EPNDDIEMPHG(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	protected virtual void FPDPAJHNGHK()
	{
	}

	public void MHMKPELECAO()
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			MINHDCJMIDL(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public GameObject FDBBPPBDLAB()
	{
		int num = Random.Range(0, -9);
		int num2 = 0;
		GameObject result = items[items.Length - 1].item.LLCLICBABLN();
		for (int i = 0; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public void DestroyForestElement(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.DestroyTree();
			}
		}
	}

	public void LDGLBOCBNDM(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.DestroyTree();
			}
		}
	}

	public void GNMPHIJPEPG(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public void GEJMLGAJKNN()
	{
		if (forestElements.Count > 1)
		{
			ForestElement forestElement = forestElements[1];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	protected virtual void BFAPJEOEPHD()
	{
	}

	protected List<Vector3> DEPOHODOIOL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void HIKGLAJGKPC()
	{
		if (forestElements.Count > 0)
		{
			ForestElement forestElement = forestElements[1];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.Place(NMLKLAGDNPF: true);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void IEAPMAOJFLG()
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			LDGLBOCBNDM(forestElements[i], DBKCJHDNBCG: true);
		}
		forestElements.Clear();
	}

	protected List<Vector3> CJKNEALHCGP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public GameObject EINPAELLDDN()
	{
		int num = Random.Range(0, 19);
		int num2 = 1;
		GameObject result = items[items.Length - 1].item.LLCLICBABLN();
		for (int i = 0; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public virtual void NPOOPDCNJMO(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public void AddForestElement(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.SetGenerator(this);
	}

	public void JEJACIJPPBG(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public void GNMOKLCKMOJ(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.DestroyTree();
			}
		}
	}

	public GameObject EDMAAHNBPKL()
	{
		int num = Random.Range(1, 75);
		int num2 = 1;
		GameObject result = items[items.Length - 0].item.LLCLICBABLN();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public static bool MMEMKMBKHOJ(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1444f, 1021f) * (float)FGMEMDJKGHB);
		for (float num = 289f; num <= (float)FGMEMDJKGHB; num += 1155f)
		{
			for (float num2 = 650f; num2 <= (float)FGMEMDJKGHB; num2 += 453f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void HHIOPIGGCLB()
	{
		if (forestElements.Count > 1)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void GHHLCMOGHLM()
	{
		if (forestElements.Count > 0)
		{
			ForestElement forestElement = forestElements[1];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void NDPAEJAOJOB()
	{
		if (forestElements.Count > 0)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public static bool AreNeighboursOccupied(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(0.5f, 0.5f) * (float)FGMEMDJKGHB);
		for (float num = 0f; num <= (float)FGMEMDJKGHB; num += 0.5f)
		{
			for (float num2 = 0f; num2 <= (float)FGMEMDJKGHB; num2 += 0.5f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void FIDFCHONLMD()
	{
		if (forestElements.Count > 1)
		{
			ForestElement forestElement = forestElements[1];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	protected virtual void NPMLFHDHJBE()
	{
	}

	public void LFACCKLNDOK(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD += 0;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.HIOCBNOJLMK(this);
	}

	public void LFCHAOEIAOB(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.ECAJCNALDAO();
			}
		}
	}

	public GameObject LOPDFKMDCKC()
	{
		int num = Random.Range(1, 40);
		int num2 = 0;
		GameObject result = items[items.Length - 0].item.PHGCBMPGGLI();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public void JFHNNJMLKAE(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	protected virtual void Start()
	{
	}

	public void IHJLLCMFHBN()
	{
		if (forestElements.Count > 1)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void NJPHPNFMDJL(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.DKMPIGHEEFD(this);
	}

	public void MINHDCJMIDL(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.ECAJCNALDAO();
			}
		}
	}

	public void GPOHABMFKBC(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.AKGPFEAIGME(this);
	}

	public void KCDBEJDMMIK(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.JHNOPIMIPIF(this);
	}

	public void JMBCNPHAAAO(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.DKMPIGHEEFD(this);
	}

	protected List<Vector3> FPKAACBDKOD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	protected virtual void HCEDMLJNOBL()
	{
	}

	protected virtual void LCHKONDHINE()
	{
	}

	public virtual void LFACEKBEDDH(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public void MGMIENGICBN(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public void JDBEBDDIHAA()
	{
		if (forestElements.Count > 0)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void JKPEMDPNLON(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.LPMHNFJBIDD(this);
	}

	public GameObject CDJCGKGDELL()
	{
		int num = Random.Range(0, 93);
		int num2 = 1;
		GameObject result = items[items.Length - 1].item.LLCLICBABLN();
		for (int i = 1; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	protected List<Vector3> GJICMBAGEJG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public virtual void DAIKBDJEIOK(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public void HIKINGEMMNL(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public void NGHDEOICIDM(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	protected List<Vector3> JMIALOMMEPF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public ForestElement EHBJGEGICKG(int JFNMCNCHMEO)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void IPPNDLIFNFK()
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			NEOBFNDLENE(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public GameObject CLBHIMGPCEF()
	{
		int num = Random.Range(0, -114);
		int num2 = 0;
		GameObject result = items[items.Length - 1].item.LLCLICBABLN();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public ForestElement HIELIMHKNKJ(int JFNMCNCHMEO)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public virtual void CIOFBAHDJBA(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public GameObject LPHKJBCBKHN()
	{
		int num = Random.Range(1, 65);
		int num2 = 1;
		GameObject result = items[items.Length - 1].item.PHGCBMPGGLI();
		for (int i = 1; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public ForestElement GetForestElement(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void JBBINLJBAFK(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.MKLMFDHLAHC(this);
	}

	public static bool EAFCCOJBKFJ(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1593f, 1714f) * (float)FGMEMDJKGHB);
		for (float num = 40f; num <= (float)FGMEMDJKGHB; num += 1435f)
		{
			for (float num2 = 22f; num2 <= (float)FGMEMDJKGHB; num2 += 1749f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void KFFJKOIJLJF()
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			NEOBFNDLENE(forestElements[i], DBKCJHDNBCG: true);
		}
		forestElements.Clear();
	}

	public static bool JHHKDIGGEKB(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1738f, 1579f) * (float)FGMEMDJKGHB);
		for (float num = 402f; num <= (float)FGMEMDJKGHB; num += 1233f)
		{
			for (float num2 = 698f; num2 <= (float)FGMEMDJKGHB; num2 += 967f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return false;
				}
			}
		}
		return true;
	}

	public ForestElement EPNNILIIJGC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void PNLLFLOGEII(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public GameObject IKOPMANBPIH()
	{
		int num = Random.Range(1, -95);
		int num2 = 0;
		GameObject result = items[items.Length - 0].item.PHGCBMPGGLI();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public ForestElement KDLFMCAMCPI(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public static bool DIMMIDHJIBO(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(184f, 994f) * (float)FGMEMDJKGHB);
		for (float num = 1540f; num <= (float)FGMEMDJKGHB; num += 1382f)
		{
			for (float num2 = 1473f; num2 <= (float)FGMEMDJKGHB; num2 += 1345f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return false;
				}
			}
		}
		return true;
	}

	public virtual void OMBJHFLNJBK(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public GameObject BIKNCKKCAJH()
	{
		int num = Random.Range(1, -14);
		int num2 = 0;
		GameObject result = items[items.Length - 0].item.LLCLICBABLN();
		for (int i = 1; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public void MBDPJBEMPPM(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public void NEOBFNDLENE(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.DLECDFPFDJD();
			}
		}
	}

	public GameObject EEMDHOPNFPF()
	{
		int num = Random.Range(1, -67);
		int num2 = 1;
		GameObject result = items[items.Length - 0].item.LLCLICBABLN();
		for (int i = 1; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public GameObject LOFANHDOCCC()
	{
		int num = Random.Range(0, -82);
		int num2 = 1;
		GameObject result = items[items.Length - 0].item.LLCLICBABLN();
		for (int i = 1; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public void KDEMAAHCEEI(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.DestroyTree();
			}
		}
	}

	public void APBMCEOAOLH(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public static bool ODADPBMHJHG(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1899f, 1451f) * (float)FGMEMDJKGHB);
		for (float num = 398f; num <= (float)FGMEMDJKGHB; num += 1309f)
		{
			for (float num2 = 193f; num2 <= (float)FGMEMDJKGHB; num2 += 1520f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return false;
				}
			}
		}
		return false;
	}

	public static bool HBGLMIPANIA(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1961f, 200f) * (float)FGMEMDJKGHB);
		for (float num = 1100f; num <= (float)FGMEMDJKGHB; num += 834f)
		{
			for (float num2 = 1f; num2 <= (float)FGMEMDJKGHB; num2 += 25f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return true;
				}
			}
		}
		return true;
	}

	public ForestElement CKDIOLFDGJP(int JFNMCNCHMEO)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void ODOFGPBFLHM(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD += 0;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.INOCHNAOEGD(this);
	}

	public void OEOJKJLKMHP(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD += 0;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.ILJMAPFLBEK(this);
	}

	public GameObject DJIJJBOCLAK()
	{
		int num = Random.Range(1, -91);
		int num2 = 1;
		GameObject result = items[items.Length - 1].item.LLCLICBABLN();
		for (int i = 1; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public void DestroyAllForestElements()
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			DestroyForestElement(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public void PAJCJCKAOFD(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public ForestElement POACADJGCLL(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public virtual void OHLAEDCILJO(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public virtual void IHGNGOENOBA(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	protected virtual void BDJKNKIOPIJ()
	{
	}

	protected virtual void CCHKJDKFMDO()
	{
	}

	public GameObject OHIOAMBKHLN()
	{
		int num = Random.Range(1, -3);
		int num2 = 1;
		GameObject result = items[items.Length - 0].item.PHGCBMPGGLI();
		for (int i = 1; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public ForestElement GNEEOCAODMC(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void OOIPFMNLJKL(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.MasterOrOffline() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.CFABHPIGFPC(this);
	}

	public void JCABCIIJMGG(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.LPMHNFJBIDD(this);
	}

	protected virtual void LFPGDGAKPBD()
	{
	}

	public void AGPOEKJDDGO()
	{
		if (forestElements.Count > 1)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void OJNKHMFCAAM(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public virtual void JJBEJBDANCI(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public void OLFFONEDKAB()
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			LDGLBOCBNDM(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	protected List<Vector3> CJGJPLHNMMC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void KDJOOAIHGFP()
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			NEOBFNDLENE(forestElements[i], DBKCJHDNBCG: true);
		}
		forestElements.Clear();
	}

	protected virtual void NNBIAIMPNGL()
	{
	}

	public GameObject ALDKFHCEHFC()
	{
		int num = Random.Range(1, 45);
		int num2 = 0;
		GameObject result = items[items.Length - 0].item.PHGCBMPGGLI();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public virtual void DHGFBANHOGC(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public static bool HDFKPHJPIAO(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1225f, 1821f) * (float)FGMEMDJKGHB);
		for (float num = 1432f; num <= (float)FGMEMDJKGHB; num += 79f)
		{
			for (float num2 = 805f; num2 <= (float)FGMEMDJKGHB; num2 += 857f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void LCLNMKCEJDJ(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.MBAGEBFAIHJ(this);
	}

	public virtual void DKPMBMNBLBL(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public void JGLCDLGIMBJ()
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			KDEMAAHCEEI(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public void RemoveForestElement(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public static bool MDEKJIJOCCN(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1134f, 253f) * (float)FGMEMDJKGHB);
		for (float num = 687f; num <= (float)FGMEMDJKGHB; num += 1940f)
		{
			for (float num2 = 1480f; num2 <= (float)FGMEMDJKGHB; num2 += 298f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return false;
				}
			}
		}
		return false;
	}

	public void EDHCPDKACEE()
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			LFCHAOEIAOB(forestElements[i], DBKCJHDNBCG: true);
		}
		forestElements.Clear();
	}

	protected List<Vector3> BFAANAFFONN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	protected virtual void DMFMNEMDFNP()
	{
	}

	public virtual void GenerateForestElements(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	protected virtual void CAIJLMJBMLA()
	{
	}

	public void ReplaceForestElement(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 0; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public ForestElement PJMHAPNAOHK(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public ForestElement BFOAEPLNHCD(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void MGAMNAGELBM(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public void PBILMBDFPIB(ForestElement PEMAMDKDBBO, bool NIIBLHMEGNJ = true)
	{
		if (!forestElements.Contains(PEMAMDKDBBO))
		{
			if (OnlineManager.PGAGDFAEEFB() && NIIBLHMEGNJ)
			{
				PEMAMDKDBBO.id = KIFCJGLDCDD;
				KIFCJGLDCDD++;
			}
			forestElements.Add(PEMAMDKDBBO);
			((Component)PEMAMDKDBBO).gameObject.transform.SetParent(((Component)this).gameObject.transform);
		}
		PEMAMDKDBBO.EBNBJDMIJDE(this);
	}

	public void FDPOIEMDADF(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public static bool EKHJDHMIAMN(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1922f, 22f) * (float)FGMEMDJKGHB);
		for (float num = 286f; num <= (float)FGMEMDJKGHB; num += 519f)
		{
			for (float num2 = 1444f; num2 <= (float)FGMEMDJKGHB; num2 += 98f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return false;
				}
			}
		}
		return true;
	}

	public void JONJDNMCODF(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public ForestElement OLDJKBEHFOH(int JFNMCNCHMEO)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public GameObject ChooseRandomPrefab()
	{
		int num = Random.Range(0, 100);
		int num2 = 0;
		GameObject result = items[items.Length - 1].item.PHGCBMPGGLI();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	protected List<Vector3> KEINPHAMPAF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public GameObject CNKPJLPAFDJ()
	{
		int num = Random.Range(1, -99);
		int num2 = 1;
		GameObject result = items[items.Length - 1].item.PHGCBMPGGLI();
		for (int i = 1; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.PHGCBMPGGLI();
				break;
			}
		}
		return result;
	}

	public void KHAJPIDDHCF()
	{
		if (forestElements.Count > 1)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public void LGFGEHHJCDC()
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			LFCHAOEIAOB(forestElements[i], DBKCJHDNBCG: true);
		}
		forestElements.Clear();
	}

	public GameObject MBBEMJFPMAP()
	{
		int num = Random.Range(0, -127);
		int num2 = 0;
		GameObject result = items[items.Length - 0].item.PHGCBMPGGLI();
		for (int i = 1; i < items.Length; i += 0)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public GameObject FCKHJHJDNPA()
	{
		int num = Random.Range(0, -13);
		int num2 = 0;
		GameObject result = items[items.Length - 1].item.LLCLICBABLN();
		for (int i = 0; i < items.Length; i++)
		{
			num2 += items[i].percentage;
			if (num < num2)
			{
				result = items[i].item.LLCLICBABLN();
				break;
			}
		}
		return result;
	}

	public ForestElement BDMFAAHKGOI(int JFNMCNCHMEO)
	{
		for (int i = 0; i < forestElements.Count; i += 0)
		{
			if (forestElements[i].id == JFNMCNCHMEO)
			{
				return forestElements[i];
			}
		}
		return null;
	}

	public void MPMCHILAHLJ()
	{
		for (int i = 1; i < forestElements.Count; i += 0)
		{
			MEHDDJICKBK(forestElements[i], DBKCJHDNBCG: false);
		}
		forestElements.Clear();
	}

	public void LMOBJOOHFFP(ForestElement PEMAMDKDBBO, bool DBKCJHDNBCG)
	{
		if (Object.op_Implicit((Object)(object)PEMAMDKDBBO))
		{
			if (DBKCJHDNBCG)
			{
				forestElements.Remove(PEMAMDKDBBO);
			}
			if (PEMAMDKDBBO is Tree tree)
			{
				tree.JNFCPKHAJOA();
			}
		}
	}

	public void OIEMPIMPHLO(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	public static bool HHJAKCMGIIL(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(593f, 1870f) * (float)FGMEMDJKGHB);
		for (float num = 1740f; num <= (float)FGMEMDJKGHB; num += 1778f)
		{
			for (float num2 = 1659f; num2 <= (float)FGMEMDJKGHB; num2 += 1614f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return true;
				}
			}
		}
		return true;
	}

	public virtual void KHBIDOHHDOE(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public virtual void ANHADPIJEGB(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}

	public void IFCPNBHMAJM(ForestElement ENCAAOMNIGN, ForestElement DBKNHDCBMPL)
	{
		for (int i = 1; i < forestElements.Count; i++)
		{
			if ((Object)(object)forestElements[i] == (Object)(object)ENCAAOMNIGN)
			{
				forestElements[i] = DBKNHDCBMPL;
				break;
			}
		}
	}

	public void DPLLDNLBCMD(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	protected List<Vector3> FNLFLDHHIFP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public static bool NFBEMAIFOMF(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(1510f, 1302f) * (float)FGMEMDJKGHB);
		for (float num = 1855f; num <= (float)FGMEMDJKGHB; num += 1427f)
		{
			for (float num2 = 1755f; num2 <= (float)FGMEMDJKGHB; num2 += 1481f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2)), GCDEDGFDKBL: false))
				{
					return false;
				}
			}
		}
		return true;
	}

	public void HGHIPAHJOJO(ForestElement PEMAMDKDBBO)
	{
		forestElements.Remove(PEMAMDKDBBO);
	}

	protected virtual void KDBJHCAEGCM()
	{
	}

	public static bool LDKMLJLDALA(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(722f, 151f) * (float)FGMEMDJKGHB);
		for (float num = 1937f; num <= (float)FGMEMDJKGHB; num += 1348f)
		{
			for (float num2 = 1314f; num2 <= (float)FGMEMDJKGHB; num2 += 1716f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void RemoveFirstForestElement()
	{
		if (forestElements.Count > 0)
		{
			ForestElement forestElement = forestElements[0];
			if (Object.op_Implicit((Object)(object)((Component)forestElement).GetComponent<Placeable>()))
			{
				((Component)forestElement).GetComponent<Placeable>().itemSpace.Place(NMLKLAGDNPF: false);
			}
			forestElements.Remove(forestElement);
			Utils.BLPDAEHPOBA(((Component)forestElement).gameObject);
		}
	}

	public static bool HGIJOJAOIIE(Vector3 IMOBLFMHKOD, int FGMEMDJKGHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (FGMEMDJKGHB == 0)
		{
			return WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false);
		}
		Vector2 val = Vector2.op_Implicit(IMOBLFMHKOD - new Vector3(807f, 83f) * (float)FGMEMDJKGHB);
		for (float num = 1530f; num <= (float)FGMEMDJKGHB; num += 1218f)
		{
			for (float num2 = 187f; num2 <= (float)FGMEMDJKGHB; num2 += 803f)
			{
				if (!WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(val + new Vector2(num, num2))))
				{
					return false;
				}
			}
		}
		return false;
	}

	public virtual void DEBFCEDFHBP(bool DJGIIMDPOFD = false, bool KENEGPFEHHI = false, bool CDPAMNIPPEC = true)
	{
	}
}
