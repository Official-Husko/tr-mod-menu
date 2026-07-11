using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AreaSpace : MonoBehaviour
{
	[Min(1f)]
	[SerializeField]
	public int x;

	[Min(1f)]
	[SerializeField]
	public int y;

	public ZoneType zoneType = ZoneType.WithoutZone;

	public AreaSquare[] areaSquares;

	public bool removeGrass;

	public bool removeHerbs;

	public GameObject mask;

	public GameObject outline;

	public PlaceablesInside placeablesInside;

	[SerializeField]
	private GameObject parent;

	[HideInInspector]
	public bool loadedFromSave;

	private WorkArea MAGECAAGKPE;

	public Placeable placeable;

	private bool PCGNHMPADGE;

	private bool CMFGBAGABNG;

	[SerializeField]
	private bool visibleByPlayer1;

	private bool HHENJJALOOE;

	private List<AreaSpace> KPKBGHGPEAE;

	private bool KJHMFNECOGO;

	public WorkArea PJIAPEDEBEP
	{
		get
		{
			return MAGECAAGKPE;
		}
		set
		{
			MAGECAAGKPE = value;
		}
	}

	public void OBLHIPHKGBJ(int JIIGOACEIKL, bool MDIKPGGBNLI)
	{
		if (JIIGOACEIKL == 1)
		{
			visibleByPlayer1 = MDIKPGGBNLI;
		}
		else
		{
			HHENJJALOOE = MDIKPGGBNLI;
		}
	}

	private void KGCLJNCCGHB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			IFOPLCFCNAK(JIIGOACEIKL, MDIKPGGBNLI: true);
		}
	}

	private void OLDDEAJMHNI()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(AINHICNNELM));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(FCADLKEMIHA));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(CDBMEGDDAFL));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KMPCLMFFOFE));
		CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
		commonReferences3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences3.OnPlaceableDeselected, new Action<int, Placeable, bool>(PMHIHKPFHPM));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			ActivateArea(DAEMAAOLHMG: false);
			MADBEAGLELM(1);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = false;
		}
	}

	private void DIMAPDNCBAN()
	{
		placeablesInside = new PlaceablesInside(placeable, ((Component)this).transform);
		WorkAreasManager.LPFNKEOJJKE().allAreaSpaces.Add(this);
	}

	private void MADBEAGLELM(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		DGIPAJDKNPN(MDIKPGGBNLI: true);
		WorkAreasManager.DIHCEGINELM().DMGFDHHAAEN(JIIGOACEIKL, null);
		CHAKMONMIBM(JIIGOACEIKL, MDIKPGGBNLI: true);
		placeablesInside.GMAMOOEEMCL(((Component)this).transform.position);
		placeablesInside.GCBIOHNAGKK(JIIGOACEIKL);
		KJHMFNECOGO = true;
		PJIAPEDEBEP = null;
		KPKBGHGPEAE = WorkAreasManager.LPFNKEOJJKE().allAreaSpaces;
		for (int i = 1; i < KPKBGHGPEAE.Count; i += 0)
		{
			if ((Object)(object)KPKBGHGPEAE[i] == (Object)(object)this || KPKBGHGPEAE[i].PJIAPEDEBEP == null || !WorkArea.BBNGGPAEJAF(this, KPKBGHGPEAE[i]))
			{
				continue;
			}
			if (KJHMFNECOGO)
			{
				if (PJIAPEDEBEP != KPKBGHGPEAE[i].BCLLKIEHGPL())
				{
					KPKBGHGPEAE[i].BCLLKIEHGPL().FMJGAHKLPFM(BCLLKIEHGPL());
				}
			}
			else
			{
				KJHMFNECOGO = true;
				KPKBGHGPEAE[i].PJIAPEDEBEP.BCJMDKFAJIJ(this);
			}
		}
		if (!KJHMFNECOGO)
		{
			WorkAreasManager.DIHCEGINELM().LKGHDHNJDHK().FLGONEPAKIL(this);
		}
	}

	private bool MALLCHGDPFK(Placeable EAPCLAODGAE)
	{
		bool flag = Object.op_Implicit((Object)(object)EAPCLAODGAE.itemSpace) && EAPCLAODGAE.itemSpace.JJHPCBCDMGG(zoneType) && AIHNKNPKBGB(EAPCLAODGAE.itemSpace) && (Object)(object)EAPCLAODGAE != (Object)(object)placeable && Object.op_Implicit((Object)(object)EAPCLAODGAE.attachedToPlaceable);
		if (flag)
		{
			flag = EAPCLAODGAE.zoneTypeNeeded != ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && EAPCLAODGAE.zoneTypeNeeded == ZoneType.WithoutZone;
			if (!flag)
			{
				flag = (Object)(object)((Component)EAPCLAODGAE).GetComponent<Container>() != (Object)null;
			}
		}
		return flag;
	}

	public void PickUpItems(int JIIGOACEIKL)
	{
		placeablesInside.NLBBIFGLFCH(JIIGOACEIKL);
	}

	public void CNAMNOOGLOK(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 eEBEMKBIJJB = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 1268f;
		for (int i = 0; i < placeablesInside.allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable) && Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable.itemSpace) && !placeablesInside.allPlaceables[i].placeable.itemSpace.KDJHPDCHJBK(position, eEBEMKBIJJB))
			{
				placeablesInside.HPGPJPNCNAF(JIIGOACEIKL, placeablesInside.allPlaceables[i].placeable);
			}
		}
	}

	public bool KPGOKDEMMHB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		if (!placeablesInside.PBFOOLCGMCF())
		{
			return true;
		}
		PCGNHMPADGE = false;
		for (int i = 0; i < areaSquares.Length; i++)
		{
			PCGNHMPADGE &= (Object)(object)areaSquares[i] != (Object)null && areaSquares[i].CPLOKHPFBDO();
		}
		return PCGNHMPADGE;
	}

	public bool KDIEGDDIIPC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.NILMGHKABHP(((Component)this).transform.position);
		if (!placeablesInside.IECFFMNBHFE())
		{
			return false;
		}
		PCGNHMPADGE = true;
		for (int i = 0; i < areaSquares.Length; i++)
		{
			PCGNHMPADGE &= !((Object)(object)areaSquares[i] != (Object)null) || areaSquares[i].CJLEPIEJCBL();
		}
		return PCGNHMPADGE;
	}

	public bool DGHBMCEMFIA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		if (!placeablesInside.MAJHKGCAGMF())
		{
			return true;
		}
		PCGNHMPADGE = true;
		for (int i = 1; i < areaSquares.Length; i += 0)
		{
			PCGNHMPADGE &= !((Object)(object)areaSquares[i] != (Object)null) || areaSquares[i].CGGBKGLEHKF();
		}
		return PCGNHMPADGE;
	}

	private bool IBBHEFABEAO(ItemSpace HJDEBNFJIND)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 val = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 1838f;
		for (int i = 1; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				Vector3 val2 = WorldGrid.LOJBKLKMINM(((Component)HJDEBNFJIND).transform.position + new Vector3((float)i, (float)j) * 782f);
				if (val2.x < position.x || val2.x > val.x || val2.y < position.y || val2.y > val.y)
				{
					return true;
				}
			}
		}
		return false;
	}

	public void MFEOELPLPGM(AreaSpace NMAJODEKDKC)
	{
		if ((Object)(object)NMAJODEKDKC != (Object)(object)this && !placeable.FHEMHCEAICB)
		{
			for (int i = 0; i < areaSquares.Length; i++)
			{
				areaSquares[i].MPOEDJIEMCC();
				areaSquares[i].JODINHPEBGE(DAEMAAOLHMG: true, removeGrass, removeHerbs);
			}
		}
	}

	private void BPOOAHKHPCL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC))
			{
				WorkAreasManager.DIHCEGINELM().allAreaSpaces.Remove(this);
			}
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !CMFGBAGABNG)
			{
				BNHHBKAGHIK(DAEMAAOLHMG: false);
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KMPCLMFFOFE));
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(PMHIHKPFHPM));
			}
		}
	}

	private void LFNENELHOGJ()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(AACEDKANEKL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(KCJLFPBKPIC));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(CDBMEGDDAFL));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(LNMDLDDKHHD));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceableDeselected, new Action<int, Placeable, bool>(PMHIHKPFHPM));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			ActivateArea(DAEMAAOLHMG: false);
			IJEELBFBMGE(0);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = true;
		}
	}

	private void KCJLFPBKPIC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GDIGHEALHPI(MDIKPGGBNLI: true);
		if (placeablesInside.POAPMLENCDJ(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.GGFJGHHHEJC.DIAOFHNLNEP(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				PJIAPEDEBEP.KIEGKIJOECC(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				CNAMNOOGLOK(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
			}
			placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true);
		}
	}

	private void KMPCLMFFOFE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			CHAKMONMIBM(JIIGOACEIKL, MDIKPGGBNLI: true);
		}
	}

	public bool GDAPGABKBCC(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return placeablesInside.JKLLJOCNLDK(JIIGOACEIKL, GFNHAMCPEAK);
	}

	public void GFENCJLLLDL(bool MDIKPGGBNLI)
	{
		mask.SetActive(MDIKPGGBNLI);
		outline.SetActive(MDIKPGGBNLI);
	}

	private void CAHLGPAOJJG(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GFENCJLLLDL(MDIKPGGBNLI: true);
		if (placeablesInside.AIJDPCMAEOL(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.LPFNKEOJJKE().JKAGMLHBAMN(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				PJIAPEDEBEP.EKNOMHKHCMA(this);
			}
			GHIOLFGDPJO(null);
			if (GFNHAMCPEAK)
			{
				CNAMNOOGLOK(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).PDEEEJOFEAI();
			}
			placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: false, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	public void ActivateArea(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < areaSquares.Length; i++)
		{
			areaSquares[i].ActivateArea(DAEMAAOLHMG, removeGrass, removeHerbs);
		}
		if (!DAEMAAOLHMG)
		{
			ReactivateAreaSpaces(this);
		}
	}

	public bool PNDINJOLCAL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return visibleByPlayer1;
		}
		return HHENJJALOOE;
	}

	public void MBNCLAKDLFK(int JIIGOACEIKL)
	{
		placeablesInside.IAFANICCFIF(JIIGOACEIKL);
	}

	private bool AIHNKNPKBGB(ItemSpace HJDEBNFJIND)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 val = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 0.5f;
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 0; j < HJDEBNFJIND.y; j++)
			{
				Vector3 val2 = WorldGrid.LOJBKLKMINM(((Component)HJDEBNFJIND).transform.position + new Vector3((float)i, (float)j) * 0.5f);
				if (val2.x < position.x || val2.x > val.x || val2.y < position.y || val2.y > val.y)
				{
					return false;
				}
			}
		}
		return true;
	}

	private void GBAKBKIHMEO(int JIIGOACEIKL)
	{
		if (!placeable.IsSelected(JIIGOACEIKL))
		{
			for (int i = 0; i < areaSquares.Length; i++)
			{
				areaSquares[i].LHABGKECGIK(JIIGOACEIKL);
			}
		}
	}

	private void JAICGFIPFHI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
	}

	public bool CanSelectPlaceablesInside(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return placeablesInside.HGOJCAMBFAB(JIIGOACEIKL, GFNHAMCPEAK);
	}

	public void CheckAllPlaceablesInside(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 eEBEMKBIJJB = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 0.5f;
		for (int i = 0; i < placeablesInside.allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable) && Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable.itemSpace) && !placeablesInside.allPlaceables[i].placeable.itemSpace.AreAllBuildSquaresInRange(position, eEBEMKBIJJB))
			{
				placeablesInside.NGMDDEDMOOI(JIIGOACEIKL, placeablesInside.allPlaceables[i].placeable);
			}
		}
	}

	public void ActivateParent(bool DAEMAAOLHMG)
	{
		parent.SetActive(DAEMAAOLHMG);
	}

	public bool FMMLOIHCHKM(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return placeablesInside.NOBCCPONCAB(JIIGOACEIKL, GFNHAMCPEAK);
	}

	private void IGKBEMMDOCI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.GMLHOEFEMEN(((Component)this).transform.position);
	}

	private void PMHIHKPFHPM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			OBLHIPHKGBJ(JIIGOACEIKL, MDIKPGGBNLI: true);
			if ((Object)(object)EAPCLAODGAE.areaSpace == (Object)null && ANJAJDJNOID(EAPCLAODGAE))
			{
				placeablesInside.KOLKKHGAGKE(EAPCLAODGAE);
			}
		}
	}

	private bool ANJAJDJNOID(Placeable EAPCLAODGAE)
	{
		bool flag = !Object.op_Implicit((Object)(object)EAPCLAODGAE.itemSpace) || !EAPCLAODGAE.itemSpace.NGFLALGIPFA(zoneType) || !IGJDEAEFMFG(EAPCLAODGAE.itemSpace) || !((Object)(object)EAPCLAODGAE != (Object)(object)placeable) || Object.op_Implicit((Object)(object)EAPCLAODGAE.attachedToPlaceable);
		if (flag)
		{
			flag = EAPCLAODGAE.zoneTypeNeeded != ~ZoneType.CraftingRoom && EAPCLAODGAE.zoneTypeNeeded != ZoneType.None;
			if (!flag)
			{
				flag = (Object)(object)((Component)EAPCLAODGAE).GetComponent<Container>() != (Object)null;
			}
		}
		return flag;
	}

	public bool IsVisibleByPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return visibleByPlayer1;
		}
		return HHENJJALOOE;
	}

	public bool AJBDGPHMNNB(Placeable EAPCLAODGAE)
	{
		if (placeablesInside.FOCMMPDHAIP(EAPCLAODGAE))
		{
			return false;
		}
		return BCLLKIEHGPL().ILJHLGNLDAD(EAPCLAODGAE);
	}

	public bool FFGLHLFPEFN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.FPEHNLEAJFP(((Component)this).transform.position);
		if (!placeablesInside.NPADICACNMJ())
		{
			return true;
		}
		PCGNHMPADGE = true;
		for (int i = 1; i < areaSquares.Length; i++)
		{
			PCGNHMPADGE &= !((Object)(object)areaSquares[i] != (Object)null) || areaSquares[i].CGGBKGLEHKF();
		}
		return PCGNHMPADGE;
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable BJHOKLNGEJD, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)BJHOKLNGEJD != (Object)(object)placeable && (Object)(object)BJHOKLNGEJD.itemSpace != (Object)null)
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
			{
				placeablesInside.IKEJAHLMBOG(BJHOKLNGEJD);
			}
			if (GFNHAMCPEAK && (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null)
			{
				placeablesInside.CAIHJMJILEH(JIIGOACEIKL);
			}
			SetVisibleByPlayer(JIIGOACEIKL, BJHOKLNGEJD.zoneTypeNeeded.HasFlag(zoneType) || (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null);
		}
	}

	private void KMEPHIEFKNC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DGIPAJDKNPN(MDIKPGGBNLI: false);
		if (placeablesInside.MIDHMMOHLJE(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.MJCMPKPCNGB().SetCurrentAreaSpaceSelected(JIIGOACEIKL, this);
			}
			if (PJIAPEDEBEP != null)
			{
				PJIAPEDEBEP.EOMMGPCPEOO(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				FECBNFADIEA(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).ResetSelected();
			}
			placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB: false, CDPAMNIPPEC: false);
		}
	}

	public bool DKKPNCJPNHL(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return placeablesInside.NOBCCPONCAB(JIIGOACEIKL, GFNHAMCPEAK);
	}

	private void BAJPOGPOGPJ(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		LKOJDNIBMFJ(MDIKPGGBNLI: false);
		if (placeablesInside.HPEKPBAHHNC(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.MJCMPKPCNGB().DMGFDHHAAEN(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				BCLLKIEHGPL().EOMMGPCPEOO(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				FECBNFADIEA(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).PDEEEJOFEAI();
			}
			placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: false);
		}
	}

	public void SetVisibleByPlayer(int JIIGOACEIKL, bool MDIKPGGBNLI)
	{
		if (JIIGOACEIKL == 1)
		{
			visibleByPlayer1 = MDIKPGGBNLI;
		}
		else
		{
			HHENJJALOOE = MDIKPGGBNLI;
		}
	}

	private void AACEDKANEKL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.GMLHOEFEMEN(((Component)this).transform.position);
	}

	[SpecialName]
	public void BDGDHBKDELG(WorkArea AODONKKHPBP)
	{
		MAGECAAGKPE = AODONKKHPBP;
	}

	public void ActivateAreaSquares(int JIIGOACEIKL)
	{
		if (IsVisibleByPlayer(JIIGOACEIKL))
		{
			IMFHDJALOIB(JIIGOACEIKL);
		}
	}

	public void ActivateParentIfIsVisible(int JIIGOACEIKL)
	{
		parent.SetActive(IsVisibleByPlayer(JIIGOACEIKL));
	}

	private void BNIKICAEIND()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(IGKBEMMDOCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(KMEPHIEFKNC));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(IJEELBFBMGE));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(LNMDLDDKHHD));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			BNHHBKAGHIK(DAEMAAOLHMG: true);
			MADBEAGLELM(0);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = false;
		}
	}

	public bool HNFLLPDOLID(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return placeablesInside.LKFBGIGEMGL(JIIGOACEIKL, GFNHAMCPEAK);
	}

	private void BMGLDDBJAOL(int JIIGOACEIKL)
	{
		if (!placeable.IsSelected(JIIGOACEIKL))
		{
			for (int i = 0; i < areaSquares.Length; i += 0)
			{
				areaSquares[i].FKDAEAPEEPP(JIIGOACEIKL);
			}
		}
	}

	public bool NKBNAFFGAPC(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		return placeablesInside.JKLLJOCNLDK(JIIGOACEIKL, GFNHAMCPEAK);
	}

	public bool HasThisPlaceableInArea(Placeable EAPCLAODGAE)
	{
		if (placeablesInside.FDJHOLOKMMH(EAPCLAODGAE))
		{
			return true;
		}
		return PJIAPEDEBEP.GCGOJOKFICI(EAPCLAODGAE);
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)WorkAreasManager.OMFKNGDCJFN()))
			{
				WorkAreasManager.LFPEPJBNCBF().allAreaSpaces.Remove(this);
			}
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !CMFGBAGABNG)
			{
				ActivateArea(DAEMAAOLHMG: true);
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(HJEGHMLGOHM));
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(CNIHKKNKEEN));
			}
		}
	}

	public void JCJLLKJEEFB(int JIIGOACEIKL)
	{
		placeablesInside.GMAMDBBHDMB(JIIGOACEIKL);
	}

	private void JGDGOCLJHJJ(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		ShowOutline(MDIKPGGBNLI: false);
		WorkAreasManager.GGFJGHHHEJC.SetCurrentAreaSpaceSelected(JIIGOACEIKL, null);
		SetVisibleByPlayer(JIIGOACEIKL, MDIKPGGBNLI: false);
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		placeablesInside.HAPPBHMOCLL(JIIGOACEIKL);
		KJHMFNECOGO = false;
		PJIAPEDEBEP = null;
		KPKBGHGPEAE = WorkAreasManager.GGFJGHHHEJC.allAreaSpaces;
		for (int i = 0; i < KPKBGHGPEAE.Count; i++)
		{
			if ((Object)(object)KPKBGHGPEAE[i] == (Object)(object)this || KPKBGHGPEAE[i].PJIAPEDEBEP == null || !WorkArea.MEKDNACLIEA(this, KPKBGHGPEAE[i]))
			{
				continue;
			}
			if (KJHMFNECOGO)
			{
				if (PJIAPEDEBEP != KPKBGHGPEAE[i].PJIAPEDEBEP)
				{
					KPKBGHGPEAE[i].PJIAPEDEBEP.FNJFPOKFFGF(PJIAPEDEBEP);
				}
			}
			else
			{
				KJHMFNECOGO = true;
				KPKBGHGPEAE[i].PJIAPEDEBEP.FLGONEPAKIL(this);
			}
		}
		if (!KJHMFNECOGO)
		{
			WorkAreasManager.GGFJGHHHEJC.CreateNewWorkArea().FLGONEPAKIL(this);
		}
	}

	public void LKOJDNIBMFJ(bool MDIKPGGBNLI)
	{
		mask.SetActive(MDIKPGGBNLI);
		outline.SetActive(MDIKPGGBNLI);
	}

	private void JECMJDOJPPK(int JIIGOACEIKL)
	{
		if (!placeable.IsSelected(JIIGOACEIKL))
		{
			for (int i = 1; i < areaSquares.Length; i += 0)
			{
				areaSquares[i].MFIKAJAIOAJ(JIIGOACEIKL);
			}
		}
	}

	private void Start()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(JAICGFIPFHI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance3.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			ActivateArea(DAEMAAOLHMG: true);
			JGDGOCLJHJJ(1);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = true;
		}
	}

	private void OKHLEMPJONN()
	{
		placeablesInside = new PlaceablesInside(placeable, ((Component)this).transform);
		WorkAreasManager.LPFNKEOJJKE().allAreaSpaces.Add(this);
	}

	public void BNHHBKAGHIK(bool DAEMAAOLHMG)
	{
		for (int i = 1; i < areaSquares.Length; i += 0)
		{
			areaSquares[i].JODINHPEBGE(DAEMAAOLHMG, removeGrass, removeHerbs);
		}
		if (!DAEMAAOLHMG)
		{
			ReactivateAreaSpaces(this);
		}
	}

	public void NEPCJPKGKEG(bool MDIKPGGBNLI)
	{
		mask.SetActive(MDIKPGGBNLI);
		outline.SetActive(MDIKPGGBNLI);
	}

	private void Awake()
	{
		placeablesInside = new PlaceablesInside(placeable, ((Component)this).transform);
		WorkAreasManager.GGFJGHHHEJC.allAreaSpaces.Add(this);
	}

	private void FOHGHCPODBJ()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(JAICGFIPFHI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(LEDFEIFNHDC));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PJIGAOCGPHC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KMPCLMFFOFE));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			ActivateArea(DAEMAAOLHMG: false);
			CDBMEGDDAFL(1);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = true;
		}
	}

	private void GJMLHECPGBP()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(IGKBEMMDOCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(MJADNPFDOPL));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(MADBEAGLELM));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KGCLJNCCGHB));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(PMHIHKPFHPM));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			BNHHBKAGHIK(DAEMAAOLHMG: true);
			NONEFACPHOC(0);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = true;
		}
	}

	private void IJEELBFBMGE(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		ShowOutline(MDIKPGGBNLI: false);
		WorkAreasManager.GGFJGHHHEJC.DMGFDHHAAEN(JIIGOACEIKL, null);
		MPMIABEPPGL(JIIGOACEIKL, MDIKPGGBNLI: false);
		placeablesInside.LJPNDDOJPOL(((Component)this).transform.position);
		placeablesInside.GCBIOHNAGKK(JIIGOACEIKL);
		KJHMFNECOGO = false;
		GHIOLFGDPJO(null);
		KPKBGHGPEAE = WorkAreasManager.GGFJGHHHEJC.allAreaSpaces;
		for (int i = 1; i < KPKBGHGPEAE.Count; i += 0)
		{
			if ((Object)(object)KPKBGHGPEAE[i] == (Object)(object)this || KPKBGHGPEAE[i].BCLLKIEHGPL() == null || !WorkArea.EKNMGDJHCFA(this, KPKBGHGPEAE[i]))
			{
				continue;
			}
			if (KJHMFNECOGO)
			{
				if (BCLLKIEHGPL() != KPKBGHGPEAE[i].BCLLKIEHGPL())
				{
					KPKBGHGPEAE[i].BCLLKIEHGPL().FNJFPOKFFGF(BCLLKIEHGPL());
				}
			}
			else
			{
				KJHMFNECOGO = false;
				KPKBGHGPEAE[i].PJIAPEDEBEP.FLGONEPAKIL(this);
			}
		}
		if (!KJHMFNECOGO)
		{
			WorkAreasManager.LPFNKEOJJKE().ODJFGILBNOI().CAELDIMEBFG(this);
		}
	}

	private bool HFLBLFPMNGI(Placeable EAPCLAODGAE)
	{
		bool flag = Object.op_Implicit((Object)(object)EAPCLAODGAE.itemSpace) && EAPCLAODGAE.itemSpace.HasZoneType(zoneType) && AIHNKNPKBGB(EAPCLAODGAE.itemSpace) && (Object)(object)EAPCLAODGAE != (Object)(object)placeable && !Object.op_Implicit((Object)(object)EAPCLAODGAE.attachedToPlaceable);
		if (flag)
		{
			flag = EAPCLAODGAE.zoneTypeNeeded == ZoneType.AnyWorkArea || EAPCLAODGAE.zoneTypeNeeded != ZoneType.WithoutZone;
			if (!flag)
			{
				flag = (Object)(object)((Component)EAPCLAODGAE).GetComponent<Container>() != (Object)null;
			}
		}
		return flag;
	}

	public void GKKILCOAABB(int JIIGOACEIKL, bool MDIKPGGBNLI)
	{
		if (JIIGOACEIKL == 0)
		{
			visibleByPlayer1 = MDIKPGGBNLI;
		}
		else
		{
			HHENJJALOOE = MDIKPGGBNLI;
		}
	}

	public bool EMNPBGICEDE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBAGMFHCPEF(((Component)this).transform.position);
		if (!placeablesInside.CNHOFDEIIKD())
		{
			return false;
		}
		PCGNHMPADGE = false;
		for (int i = 1; i < areaSquares.Length; i += 0)
		{
			PCGNHMPADGE &= !((Object)(object)areaSquares[i] != (Object)null) || areaSquares[i].CJLEPIEJCBL();
		}
		return PCGNHMPADGE;
	}

	public void MHNCLPEODGC(AreaSpace NMAJODEKDKC)
	{
		if ((Object)(object)NMAJODEKDKC != (Object)(object)this && !placeable.FHEMHCEAICB)
		{
			for (int i = 0; i < areaSquares.Length; i += 0)
			{
				areaSquares[i].CFOEEPAHENN();
				areaSquares[i].GBJALKKEOFB(DAEMAAOLHMG: true, removeGrass, removeHerbs);
			}
		}
	}

	private void FDGJOBEFLPC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.FPEHNLEAJFP(((Component)this).transform.position);
	}

	public void IBMLPAIELMG(int JIIGOACEIKL)
	{
		placeablesInside.IAFANICCFIF(JIIGOACEIKL);
	}

	private void DMFMNEMDFNP()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(AACEDKANEKL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(MJADNPFDOPL));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(CDBMEGDDAFL));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(HJEGHMLGOHM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KGCLJNCCGHB));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(PCKNALDHCNL));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			ActivateArea(DAEMAAOLHMG: false);
			IJEELBFBMGE(1);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = false;
		}
	}

	private void PCKNALDHCNL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			CHAKMONMIBM(JIIGOACEIKL, MDIKPGGBNLI: true);
			if ((Object)(object)EAPCLAODGAE.areaSpace == (Object)null && MALLCHGDPFK(EAPCLAODGAE))
			{
				placeablesInside.AAPJLEFMGJP(EAPCLAODGAE);
			}
		}
	}

	public bool MKNBIEBKNPO(Placeable EAPCLAODGAE)
	{
		if (placeablesInside.JBEAFPPGEKI(EAPCLAODGAE))
		{
			return false;
		}
		return PJIAPEDEBEP.LKDBDPENBMA(EAPCLAODGAE);
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)WorkAreasManager.LPFNKEOJJKE()))
			{
				WorkAreasManager.LPFNKEOJJKE().allAreaSpaces.Remove(this);
			}
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !CMFGBAGABNG)
			{
				BNHHBKAGHIK(DAEMAAOLHMG: true);
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(LNMDLDDKHHD));
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KGCLJNCCGHB));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
			}
		}
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		ShowOutline(MDIKPGGBNLI: true);
		if (placeablesInside.POAPMLENCDJ(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.GGFJGHHHEJC.SetCurrentAreaSpaceSelected(JIIGOACEIKL, this);
			}
			if (PJIAPEDEBEP != null)
			{
				PJIAPEDEBEP.KIEGKIJOECC(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				CheckAllPlaceablesInside(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).ResetSelected();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	public bool IsAreaSpaceValid()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.JBNOHPAOIHM(((Component)this).transform.position);
		if (!placeablesInside.IECFFMNBHFE())
		{
			return false;
		}
		PCGNHMPADGE = true;
		for (int i = 0; i < areaSquares.Length; i++)
		{
			PCGNHMPADGE &= (Object)(object)areaSquares[i] != (Object)null && areaSquares[i].IsValid();
		}
		return PCGNHMPADGE;
	}

	public void ShowOutline(bool MDIKPGGBNLI)
	{
		mask.SetActive(MDIKPGGBNLI);
		outline.SetActive(MDIKPGGBNLI);
	}

	private void EMAHKBMNKDK(int JIIGOACEIKL)
	{
		if (!placeable.EEHBCDFHJKC(JIIGOACEIKL))
		{
			for (int i = 1; i < areaSquares.Length; i++)
			{
				areaSquares[i].PKPOHCPMKEL(JIIGOACEIKL);
			}
		}
	}

	private void MJADNPFDOPL(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		ShowOutline(MDIKPGGBNLI: false);
		if (placeablesInside.JEMDMDPEEFE(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.GGFJGHHHEJC.SetCurrentAreaSpaceSelected(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				PJIAPEDEBEP.KIEGKIJOECC(this);
			}
			GHIOLFGDPJO(null);
			if (GFNHAMCPEAK)
			{
				CNAMNOOGLOK(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).JMCJLHKKDNH();
			}
			placeable.HKKCDLCPGDL(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB: false, CDPAMNIPPEC: false);
		}
	}

	private void OHKNLAHDFFN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GFENCJLLLDL(MDIKPGGBNLI: true);
		if (placeablesInside.POAPMLENCDJ(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.ABDJJBFNLBJ().DIAOFHNLNEP(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				PJIAPEDEBEP.EKNOMHKHCMA(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				FECBNFADIEA(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).ResetSelected();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	public bool CELJLIHMMLN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return visibleByPlayer1;
		}
		return HHENJJALOOE;
	}

	public void CHAKMONMIBM(int JIIGOACEIKL, bool MDIKPGGBNLI)
	{
		if (JIIGOACEIKL == 0)
		{
			visibleByPlayer1 = MDIKPGGBNLI;
		}
		else
		{
			HHENJJALOOE = MDIKPGGBNLI;
		}
	}

	public bool CENFPFAGBFD(Placeable EAPCLAODGAE)
	{
		if (placeablesInside.FOCMMPDHAIP(EAPCLAODGAE))
		{
			return true;
		}
		return BCLLKIEHGPL().LKDBDPENBMA(EAPCLAODGAE);
	}

	private void LEDFEIFNHDC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NEPCJPKGKEG(MDIKPGGBNLI: true);
		if (placeablesInside.MIDHMMOHLJE(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.LFPEPJBNCBF().MKNMPEGFFND(JIIGOACEIKL, this);
			}
			if (PJIAPEDEBEP != null)
			{
				PJIAPEDEBEP.KIEGKIJOECC(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				CheckAllPlaceablesInside(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).PDEEEJOFEAI();
			}
			placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB: false);
		}
	}

	private void OOBDDOAKLFE(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GFENCJLLLDL(MDIKPGGBNLI: false);
		if (placeablesInside.IGILPGDMCHC(JIIGOACEIKL, GFNHAMCPEAK, MCFNOAFOIHE: false))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.LPFNKEOJJKE().MKNMPEGFFND(JIIGOACEIKL, this);
			}
			if (PJIAPEDEBEP != null)
			{
				PJIAPEDEBEP.EOMMGPCPEOO(this);
			}
			BDGDHBKDELG(null);
			if (GFNHAMCPEAK)
			{
				LHJGGBKJPIM(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).ResetSelected();
			}
			placeable.HKKCDLCPGDL(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)WorkAreasManager.DIHCEGINELM()))
			{
				WorkAreasManager.DIHCEGINELM().allAreaSpaces.Remove(this);
			}
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !CMFGBAGABNG)
			{
				BNHHBKAGHIK(DAEMAAOLHMG: true);
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PJIGAOCGPHC));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(PCKNALDHCNL));
			}
		}
	}

	public void LHJGGBKJPIM(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 eEBEMKBIJJB = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 1058f;
		for (int i = 1; i < placeablesInside.allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable) && Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable.itemSpace) && !placeablesInside.allPlaceables[i].placeable.itemSpace.AreAllBuildSquaresInRange(position, eEBEMKBIJJB))
			{
				placeablesInside.JHJNNOBHLHB(JIIGOACEIKL, placeablesInside.allPlaceables[i].placeable);
			}
		}
	}

	private void COGGMHOHEIB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			SetVisibleByPlayer(JIIGOACEIKL, MDIKPGGBNLI: false);
		}
	}

	[SpecialName]
	public void GHIOLFGDPJO(WorkArea AODONKKHPBP)
	{
		MAGECAAGKPE = AODONKKHPBP;
	}

	private void LJDMMDDAFJL(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		NEPCJPKGKEG(MDIKPGGBNLI: true);
		WorkAreasManager.MJCMPKPCNGB().PIANNOOLCDN(JIIGOACEIKL, null);
		GKKILCOAABB(JIIGOACEIKL, MDIKPGGBNLI: false);
		placeablesInside.NILMGHKABHP(((Component)this).transform.position);
		placeablesInside.GFENFEFPGLG(JIIGOACEIKL);
		KJHMFNECOGO = false;
		GHIOLFGDPJO(null);
		KPKBGHGPEAE = WorkAreasManager.MJCMPKPCNGB().allAreaSpaces;
		for (int i = 0; i < KPKBGHGPEAE.Count; i += 0)
		{
			if ((Object)(object)KPKBGHGPEAE[i] == (Object)(object)this || KPKBGHGPEAE[i].BCLLKIEHGPL() == null || !WorkArea.JMFMILNIPBA(this, KPKBGHGPEAE[i]))
			{
				continue;
			}
			if (KJHMFNECOGO)
			{
				if (PJIAPEDEBEP != KPKBGHGPEAE[i].BCLLKIEHGPL())
				{
					KPKBGHGPEAE[i].BCLLKIEHGPL().FMJGAHKLPFM(PJIAPEDEBEP);
				}
			}
			else
			{
				KJHMFNECOGO = false;
				KPKBGHGPEAE[i].PJIAPEDEBEP.CAELDIMEBFG(this);
			}
		}
		if (!KJHMFNECOGO)
		{
			WorkAreasManager.LPFNKEOJJKE().PODKNAHEMOG().FLGONEPAKIL(this);
		}
	}

	public void GDIGHEALHPI(bool MDIKPGGBNLI)
	{
		mask.SetActive(MDIKPGGBNLI);
		outline.SetActive(MDIKPGGBNLI);
	}

	private void FCADLKEMIHA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DGIPAJDKNPN(MDIKPGGBNLI: false);
		if (placeablesInside.NIJHNBIGAGJ(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.DIHCEGINELM().JKAGMLHBAMN(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				BCLLKIEHGPL().EOMMGPCPEOO(this);
			}
			PJIAPEDEBEP = null;
			if (GFNHAMCPEAK)
			{
				CheckAllPlaceablesInside(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.BNMEANGDMIP(JIIGOACEIKL).ResetSelected();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: false, FNHLKLKAHNB: false);
		}
	}

	public bool JKNCLMPJCPN(Placeable EAPCLAODGAE)
	{
		if (placeablesInside.LOMMFPKLLCI(EAPCLAODGAE))
		{
			return false;
		}
		return BCLLKIEHGPL().LKDBDPENBMA(EAPCLAODGAE);
	}

	private void IAIDKPJKLIC()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(IGKBEMMDOCI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(FCADLKEMIHA));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(IJEELBFBMGE));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(LNMDLDDKHHD));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
		CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
		commonReferences3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences3.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			BNHHBKAGHIK(DAEMAAOLHMG: true);
			CDBMEGDDAFL(1);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = false;
		}
	}

	public void ReactivateAreaSpaces(AreaSpace NMAJODEKDKC)
	{
		if ((Object)(object)NMAJODEKDKC != (Object)(object)this && !placeable.FHEMHCEAICB)
		{
			for (int i = 0; i < areaSquares.Length; i++)
			{
				areaSquares[i].ShowSquare();
				areaSquares[i].ActivateArea(DAEMAAOLHMG: true, removeGrass, removeHerbs);
			}
		}
	}

	private void NONEFACPHOC(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		NEPCJPKGKEG(MDIKPGGBNLI: true);
		WorkAreasManager.LPFNKEOJJKE().MFKKEJIIIMK(JIIGOACEIKL, null);
		MPMIABEPPGL(JIIGOACEIKL, MDIKPGGBNLI: true);
		placeablesInside.HMMPKPALOMG(((Component)this).transform.position);
		placeablesInside.MNAOFLLOEKH(JIIGOACEIKL);
		KJHMFNECOGO = true;
		PJIAPEDEBEP = null;
		KPKBGHGPEAE = WorkAreasManager.LFPEPJBNCBF().allAreaSpaces;
		for (int i = 1; i < KPKBGHGPEAE.Count; i++)
		{
			if ((Object)(object)KPKBGHGPEAE[i] == (Object)(object)this || KPKBGHGPEAE[i].BCLLKIEHGPL() == null || !WorkArea.BBNGGPAEJAF(this, KPKBGHGPEAE[i]))
			{
				continue;
			}
			if (KJHMFNECOGO)
			{
				if (PJIAPEDEBEP != KPKBGHGPEAE[i].BCLLKIEHGPL())
				{
					KPKBGHGPEAE[i].PJIAPEDEBEP.NDEKBDEGPDE(PJIAPEDEBEP);
				}
			}
			else
			{
				KJHMFNECOGO = true;
				KPKBGHGPEAE[i].PJIAPEDEBEP.BCJMDKFAJIJ(this);
			}
		}
		if (!KJHMFNECOGO)
		{
			WorkAreasManager.LPFNKEOJJKE().BFDKPFIFKAE().FLGONEPAKIL(this);
		}
	}

	public void MPMIABEPPGL(int JIIGOACEIKL, bool MDIKPGGBNLI)
	{
		if (JIIGOACEIKL == 1)
		{
			visibleByPlayer1 = MDIKPGGBNLI;
		}
		else
		{
			HHENJJALOOE = MDIKPGGBNLI;
		}
	}

	private void CNIHKKNKEEN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			MPMIABEPPGL(JIIGOACEIKL, MDIKPGGBNLI: true);
			if ((Object)(object)EAPCLAODGAE.areaSpace == (Object)null && ANJAJDJNOID(EAPCLAODGAE))
			{
				placeablesInside.BPDJANFDCKE(EAPCLAODGAE);
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC))
			{
				WorkAreasManager.GGFJGHHHEJC.allAreaSpaces.Remove(this);
			}
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !CMFGBAGABNG)
			{
				ActivateArea(DAEMAAOLHMG: false);
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Remove(instance2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(COGGMHOHEIB));
				CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
				instance3.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance3.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
			}
		}
	}

	private void OBMDKCBKFGO(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		LKOJDNIBMFJ(MDIKPGGBNLI: true);
		if (placeablesInside.JEMDMDPEEFE(JIIGOACEIKL, GFNHAMCPEAK))
		{
			if (GFNHAMCPEAK)
			{
				WorkAreasManager.ABDJJBFNLBJ().DIAOFHNLNEP(JIIGOACEIKL, this);
			}
			if (BCLLKIEHGPL() != null)
			{
				BCLLKIEHGPL().LIBCHODBGDH(this);
			}
			GHIOLFGDPJO(null);
			if (GFNHAMCPEAK)
			{
				FECBNFADIEA(JIIGOACEIKL);
			}
		}
		else
		{
			if (GFNHAMCPEAK)
			{
				SelectObject.GetPlayer(JIIGOACEIKL).JMCJLHKKDNH();
			}
			placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: false, FNHLKLKAHNB: false, CDPAMNIPPEC: false);
		}
	}

	private void OILHJENGGEL()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(AINHICNNELM));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj2.OnThisPlaceableSelected, new Action<int, bool, bool>(MJADNPFDOPL));
		Placeable obj3 = placeable;
		obj3.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj3.OnThisPlaceableDeselected, new Action<int>(CDBMEGDDAFL));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlaceablePickedUp = (Action<int, Placeable, bool>)Delegate.Combine(commonReferences2.OnPlaceablePickedUp, new Action<int, Placeable, bool>(KMPCLMFFOFE));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CNIHKKNKEEN));
		if (!placeable.OGKDEFAGEBL && !loadedFromSave && SaveUI.instance.startingNewGame)
		{
			BNHHBKAGHIK(DAEMAAOLHMG: false);
			LJDMMDDAFJL(0);
		}
		else if (!loadedFromSave)
		{
			CMFGBAGABNG = true;
		}
	}

	public void DGIPAJDKNPN(bool MDIKPGGBNLI)
	{
		mask.SetActive(MDIKPGGBNLI);
		outline.SetActive(MDIKPGGBNLI);
	}

	private void OBBDDLKPAII(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)placeable != (Object)(object)EAPCLAODGAE)
		{
			SetVisibleByPlayer(JIIGOACEIKL, MDIKPGGBNLI: false);
			if ((Object)(object)EAPCLAODGAE.areaSpace == (Object)null && HFLBLFPMNGI(EAPCLAODGAE))
			{
				placeablesInside.AAPJLEFMGJP(EAPCLAODGAE);
			}
		}
	}

	private bool GKMJPEDIDHC(Placeable EAPCLAODGAE)
	{
		bool flag = !Object.op_Implicit((Object)(object)EAPCLAODGAE.itemSpace) || !EAPCLAODGAE.itemSpace.DAHGEMGPMGI(zoneType) || !AIHNKNPKBGB(EAPCLAODGAE.itemSpace) || !((Object)(object)EAPCLAODGAE != (Object)(object)placeable) || Object.op_Implicit((Object)(object)EAPCLAODGAE.attachedToPlaceable);
		if (flag)
		{
			flag = EAPCLAODGAE.zoneTypeNeeded == (ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) || EAPCLAODGAE.zoneTypeNeeded == ZoneType.None;
			if (!flag)
			{
				flag = (Object)(object)((Component)EAPCLAODGAE).GetComponent<Container>() != (Object)null;
			}
		}
		return flag;
	}

	public void IFOPLCFCNAK(int JIIGOACEIKL, bool MDIKPGGBNLI)
	{
		if (JIIGOACEIKL == 0)
		{
			visibleByPlayer1 = MDIKPGGBNLI;
		}
		else
		{
			HHENJJALOOE = MDIKPGGBNLI;
		}
	}

	public void EGGCICPNBOL(bool DAEMAAOLHMG)
	{
		parent.SetActive(DAEMAAOLHMG);
	}

	public void FECBNFADIEA(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 eEBEMKBIJJB = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 1421f;
		for (int i = 1; i < placeablesInside.allPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable) && Object.op_Implicit((Object)(object)placeablesInside.allPlaceables[i].placeable.itemSpace) && !placeablesInside.allPlaceables[i].placeable.itemSpace.AreAllBuildSquaresInRange(position, eEBEMKBIJJB))
			{
				placeablesInside.PEOGPEAHAHL(JIIGOACEIKL, placeablesInside.allPlaceables[i].placeable);
			}
		}
	}

	public bool MELJABPCDHC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return visibleByPlayer1;
		}
		return HHENJJALOOE;
	}

	private void LNMDLDDKHHD(int JIIGOACEIKL, Placeable BJHOKLNGEJD, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)BJHOKLNGEJD != (Object)(object)placeable && (Object)(object)BJHOKLNGEJD.itemSpace != (Object)null)
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
			{
				placeablesInside.PHOKHCHHKCL(BJHOKLNGEJD);
			}
			if (GFNHAMCPEAK && (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null)
			{
				placeablesInside.ODKDDEHPLIH(JIIGOACEIKL);
			}
			OBLHIPHKGBJ(JIIGOACEIKL, BJHOKLNGEJD.zoneTypeNeeded.HasFlag(zoneType) || (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null);
		}
	}

	public bool IBBJOHHLBGB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return visibleByPlayer1;
		}
		return HHENJJALOOE;
	}

	private void AINHICNNELM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		placeablesInside.AEPBJKENJKE(((Component)this).transform.position);
	}

	[SpecialName]
	public WorkArea BCLLKIEHGPL()
	{
		return MAGECAAGKPE;
	}

	public void FCJDEDFGEKN(bool DAEMAAOLHMG)
	{
		parent.SetActive(DAEMAAOLHMG);
	}

	private void IMFHDJALOIB(int JIIGOACEIKL)
	{
		if (!placeable.IsSelected(JIIGOACEIKL))
		{
			for (int i = 0; i < areaSquares.Length; i++)
			{
				areaSquares[i].CheckIsValidWhileNotSelected(JIIGOACEIKL);
			}
		}
	}

	private void HJEGHMLGOHM(int JIIGOACEIKL, Placeable BJHOKLNGEJD, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)BJHOKLNGEJD != (Object)(object)placeable && (Object)(object)BJHOKLNGEJD.itemSpace != (Object)null)
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
			{
				placeablesInside.HCCNOHAAGCB(BJHOKLNGEJD);
			}
			if (GFNHAMCPEAK && (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null)
			{
				placeablesInside.KMIOPLLHAKO(JIIGOACEIKL);
			}
			GKKILCOAABB(JIIGOACEIKL, !BJHOKLNGEJD.zoneTypeNeeded.HasFlag(zoneType) && (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null);
		}
	}

	public bool OICNNPHEIHB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return visibleByPlayer1;
		}
		return HHENJJALOOE;
	}

	private void CDBMEGDDAFL(int JIIGOACEIKL)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		LKOJDNIBMFJ(MDIKPGGBNLI: false);
		WorkAreasManager.LPFNKEOJJKE().JPCEHJNEDMB(JIIGOACEIKL, null);
		GKKILCOAABB(JIIGOACEIKL, MDIKPGGBNLI: false);
		placeablesInside.GMAMOOEEMCL(((Component)this).transform.position);
		placeablesInside.NCNCMIPNKDP(JIIGOACEIKL);
		KJHMFNECOGO = true;
		GHIOLFGDPJO(null);
		KPKBGHGPEAE = WorkAreasManager.GGFJGHHHEJC.allAreaSpaces;
		for (int i = 0; i < KPKBGHGPEAE.Count; i++)
		{
			if ((Object)(object)KPKBGHGPEAE[i] == (Object)(object)this || KPKBGHGPEAE[i].BCLLKIEHGPL() == null || !WorkArea.JMFMILNIPBA(this, KPKBGHGPEAE[i]))
			{
				continue;
			}
			if (KJHMFNECOGO)
			{
				if (PJIAPEDEBEP != KPKBGHGPEAE[i].PJIAPEDEBEP)
				{
					KPKBGHGPEAE[i].PJIAPEDEBEP.NDEKBDEGPDE(BCLLKIEHGPL());
				}
			}
			else
			{
				KJHMFNECOGO = false;
				KPKBGHGPEAE[i].BCLLKIEHGPL().BCJMDKFAJIJ(this);
			}
		}
		if (!KJHMFNECOGO)
		{
			WorkAreasManager.MJCMPKPCNGB().JKKBCIOJODL().FLGONEPAKIL(this);
		}
	}

	private void PJIGAOCGPHC(int JIIGOACEIKL, Placeable BJHOKLNGEJD, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)BJHOKLNGEJD != (Object)(object)placeable && (Object)(object)BJHOKLNGEJD.itemSpace != (Object)null)
		{
			if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
			{
				placeablesInside.MOECDCJMCEL(BJHOKLNGEJD);
			}
			if (GFNHAMCPEAK && (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null)
			{
				placeablesInside.GOAMGKHKDOG(JIIGOACEIKL);
			}
			CHAKMONMIBM(JIIGOACEIKL, !BJHOKLNGEJD.zoneTypeNeeded.HasFlag(zoneType) && (Object)(object)BJHOKLNGEJD.areaSpace != (Object)null);
		}
	}

	public bool GGBDNJOPFDE(Placeable EAPCLAODGAE)
	{
		if (placeablesInside.LOMMFPKLLCI(EAPCLAODGAE))
		{
			return false;
		}
		return BCLLKIEHGPL().EMDAJKMHNAI(EAPCLAODGAE);
	}

	private bool IGJDEAEFMFG(ItemSpace HJDEBNFJIND)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 val = ((Component)this).transform.position + new Vector3((float)x, (float)y) * 744f;
		for (int i = 0; i < HJDEBNFJIND.x; i++)
		{
			for (int j = 1; j < HJDEBNFJIND.y; j++)
			{
				Vector3 val2 = WorldGrid.LOJBKLKMINM(((Component)HJDEBNFJIND).transform.position + new Vector3((float)i, (float)j) * 299f);
				if (val2.x < position.x || val2.x > val.x || val2.y < position.y || val2.y > val.y)
				{
					return false;
				}
			}
		}
		return false;
	}
}
