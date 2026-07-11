using System;
using UnityEngine;

public class ActivateByArea : MonoBehaviour
{
	public Transform tileChecked;

	public SnapToGrid snapToGrid;

	public GameObject[] metalWorkshop;

	public GameObject[] woodWorkshop;

	public GameObject[] stoneWorkshop;

	public void JPLFIFINNBJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			DEDPODNIJAN(metalWorkshop, NJHMBMGKCPL: true);
			FEEAJEBLMBD(woodWorkshop, NJHMBMGKCPL: false);
			FEEAJEBLMBD(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.CraftingRoom | ZoneType.MetalWorkshop:
			FIEILGKNCGE(metalWorkshop, NJHMBMGKCPL: true);
			HGJLBONEDOJ(woodWorkshop, NJHMBMGKCPL: true);
			KIGCMNHILAG(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			MHHOACNIJFO(metalWorkshop, NJHMBMGKCPL: false);
			FEEAJEBLMBD(woodWorkshop, NJHMBMGKCPL: false);
			HGJLBONEDOJ(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	private void NPGKDNFICNA(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void EMJKKALMGLK()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(OCFKHCGCFNO));
		((MonoBehaviour)this).Invoke("ToolEffect", 1139f);
	}

	public void NEOICNJNKNL()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(HNFJFOOLDKI));
		((MonoBehaviour)this).Invoke("Index of cannonball: {0} is out of range. This shouldn't happen. freePositions list must not have been initialized properly.", 1869f);
	}

	private void JOJMHILHDHH(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void KHCJDKHONPK()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(KHJDKJOKLIM));
		((MonoBehaviour)this).Invoke("User SignedIn: ", 819f);
	}

	private void NLGMMIHFIGN(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void DBCAAICCLFN(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void MMNBJPDJHGK()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(NKLAOFEDHNN));
		((MonoBehaviour)this).Invoke("Back", 1117f);
	}

	private void DJIFHECJCFK(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void MDGCHNALBJM(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void MIKNFPCDLML()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(IGKCAMIHBML));
		((MonoBehaviour)this).Invoke(" : 00", 1879f);
	}

	private void CBCGKJDJMAP(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void EBLLKGIEJPD(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void PHJKJHKAABL()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GPBHBFKIHOC));
		((MonoBehaviour)this).Invoke("Game", 742f);
	}

	public void NMKGOAJLMDG()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(HAJJILAGENE));
		((MonoBehaviour)this).Invoke("Items/item_name_1181", 1776f);
	}

	public void DNBGIIGAKMJ()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(BPIMNHCPEDD));
		((MonoBehaviour)this).Invoke("None", 289f);
	}

	private void ELFGHAIFNFJ(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void BFJOEMCBJJO()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GPBHBFKIHOC));
		((MonoBehaviour)this).Invoke("UIAddRemove", 659f);
	}

	private void KBIBFEJLAIG(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void IOGDGGLELFE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ZoneType zoneType = WorldGrid.AGKGGAFFFGM(tileChecked.position);
		switch (zoneType)
		{
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom:
			LPDHFMNPBEK(metalWorkshop, NJHMBMGKCPL: false);
			JAPIMKFHLCM(woodWorkshop, NJHMBMGKCPL: false);
			DCCLPOHKMAI(stoneWorkshop, NJHMBMGKCPL: true);
			return;
		case ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop):
			BKEJDKFICAK(metalWorkshop, NJHMBMGKCPL: true);
			BDLJHAMHLJM(woodWorkshop, NJHMBMGKCPL: true);
			DOAEFMEEFNE(stoneWorkshop, NJHMBMGKCPL: false);
			return;
		}
		if (zoneType == ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop))
		{
			MHHOACNIJFO(metalWorkshop, NJHMBMGKCPL: false);
			CBCGKJDJMAP(woodWorkshop, NJHMBMGKCPL: true);
			GDHJMBLHADD(stoneWorkshop, NJHMBMGKCPL: true);
		}
	}

	public void NAGBBAHNHFJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			NPGKDNFICNA(metalWorkshop, NJHMBMGKCPL: false);
			CHJJAJKGBFE(woodWorkshop, NJHMBMGKCPL: false);
			DOAEFMEEFNE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			ELFGHAIFNFJ(metalWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: true);
			DOAEFMEEFNE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			ACHFAGGIAAE(metalWorkshop, NJHMBMGKCPL: false);
			FINJOJELAGM(woodWorkshop, NJHMBMGKCPL: true);
			MHHOACNIJFO(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void BBBIBPNNIGD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			BKEJDKFICAK(metalWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: true);
			IHOMGFOKKDL(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop:
			CBCGKJDJMAP(metalWorkshop, NJHMBMGKCPL: true);
			MOEMACPDJOM(woodWorkshop, NJHMBMGKCPL: false);
			EBLLKGIEJPD(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			BDLJHAMHLJM(metalWorkshop, NJHMBMGKCPL: true);
			FINJOJELAGM(woodWorkshop, NJHMBMGKCPL: true);
			GDHJMBLHADD(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void NLGHNDLPPKI()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(BPIMNHCPEDD));
		((MonoBehaviour)this).Invoke("ReceiveBarkInfoWithObject", 1019f);
	}

	private void BDLJHAMHLJM(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void IIPKPMPGLOL()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GOHMLAHNCIM));
		((MonoBehaviour)this).Invoke("itemGreenbean", 143f);
	}

	public void GPBHBFKIHOC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom):
			ACHFAGGIAAE(metalWorkshop, NJHMBMGKCPL: true);
			MECMEPAAPKO(woodWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.MetalWorkshop:
			LJCKODMCGMM(metalWorkshop, NJHMBMGKCPL: false);
			GDHJMBLHADD(woodWorkshop, NJHMBMGKCPL: true);
			BDLJHAMHLJM(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.StoneWorkshop:
			PALLKEINJFF(metalWorkshop, NJHMBMGKCPL: false);
			KIGCMNHILAG(woodWorkshop, NJHMBMGKCPL: false);
			FINJOJELAGM(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void BPIMNHCPEDD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			JAPIMKFHLCM(metalWorkshop, NJHMBMGKCPL: false);
			CHJJAJKGBFE(woodWorkshop, NJHMBMGKCPL: false);
			JAPIMKFHLCM(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop):
			DOAEFMEEFNE(metalWorkshop, NJHMBMGKCPL: false);
			HGJLBONEDOJ(woodWorkshop, NJHMBMGKCPL: true);
			IHOMGFOKKDL(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.RentedRoom | ZoneType.WoodWorkshop:
			KMLPEJCJCCD(metalWorkshop, NJHMBMGKCPL: true);
			NPGKDNFICNA(woodWorkshop, NJHMBMGKCPL: true);
			BDLJHAMHLJM(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void CheckArea()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.MetalWorkshop:
			DBCAAICCLFN(metalWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WoodWorkshop:
			DBCAAICCLFN(metalWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.StoneWorkshop:
			DBCAAICCLFN(metalWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void Awake()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(CheckArea));
		((MonoBehaviour)this).Invoke("CheckArea", 3f);
	}

	public void ALEAOANPHIO()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(JPLFIFINNBJ));
		((MonoBehaviour)this).Invoke("cleanVerb", 673f);
	}

	public void PGEGODAEBLC()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(BPIMNHCPEDD));
		((MonoBehaviour)this).Invoke("Graphics", 1478f);
	}

	public void OMBHDODDHNO()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(AECBKOMHDDC));
		((MonoBehaviour)this).Invoke("ReceiveStatus", 1397f);
	}

	private void LPDHFMNPBEK(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void ELBEOLKMFJC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			FEEAJEBLMBD(metalWorkshop, NJHMBMGKCPL: false);
			NPGKDNFICNA(woodWorkshop, NJHMBMGKCPL: true);
			GDHJMBLHADD(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.MetalWorkshop:
			HGJLBONEDOJ(metalWorkshop, NJHMBMGKCPL: true);
			PALLKEINJFF(woodWorkshop, NJHMBMGKCPL: true);
			CHJJAJKGBFE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop):
			DEDPODNIJAN(metalWorkshop, NJHMBMGKCPL: true);
			MHHOACNIJFO(woodWorkshop, NJHMBMGKCPL: false);
			CHJJAJKGBFE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	private void DCCLPOHKMAI(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void KMLPEJCJCCD(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void DKDLOBOLNFH()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GJNNKHDBKMK));
		((MonoBehaviour)this).Invoke("- ", 387f);
	}

	private void DEDPODNIJAN(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void BKEJDKFICAK(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void NNOLJDEEDII()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			IHOMGFOKKDL(metalWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: false);
			MHHOACNIJFO(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop:
			JAPIMKFHLCM(metalWorkshop, NJHMBMGKCPL: false);
			FIEILGKNCGE(woodWorkshop, NJHMBMGKCPL: true);
			JOJMHILHDHH(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~ZoneType.WithoutZone:
			IHOMGFOKKDL(metalWorkshop, NJHMBMGKCPL: false);
			NLGMMIHFIGN(woodWorkshop, NJHMBMGKCPL: false);
			DJIFHECJCFK(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void CJKCEBCEHEJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.WoodWorkshop):
			MOEMACPDJOM(metalWorkshop, NJHMBMGKCPL: true);
			KMLPEJCJCCD(woodWorkshop, NJHMBMGKCPL: false);
			MOEMACPDJOM(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar):
			CBCGKJDJMAP(metalWorkshop, NJHMBMGKCPL: true);
			MHHOACNIJFO(woodWorkshop, NJHMBMGKCPL: true);
			LPDHFMNPBEK(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.WoodWorkshop | ZoneType.StoneWorkshop:
			IHOMGFOKKDL(metalWorkshop, NJHMBMGKCPL: true);
			KMLPEJCJCCD(woodWorkshop, NJHMBMGKCPL: false);
			DEDPODNIJAN(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void GOHMLAHNCIM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar):
			KBIBFEJLAIG(metalWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: false);
			MECMEPAAPKO(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			DCCLPOHKMAI(metalWorkshop, NJHMBMGKCPL: false);
			IHOMGFOKKDL(woodWorkshop, NJHMBMGKCPL: true);
			KIGCMNHILAG(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.WoodWorkshop | ZoneType.StoneWorkshop:
			HGJLBONEDOJ(metalWorkshop, NJHMBMGKCPL: true);
			DOAEFMEEFNE(woodWorkshop, NJHMBMGKCPL: false);
			DEDPODNIJAN(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	private void ACHFAGGIAAE(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void MFJIHCKEIIF()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(CheckArea));
		((MonoBehaviour)this).Invoke("0", 977f);
	}

	public void PKPHKBMPJGJ()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(OCFKHCGCFNO));
		((MonoBehaviour)this).Invoke(" : ", 1398f);
	}

	public void IGNEGEOPLOP()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GOHMLAHNCIM));
		((MonoBehaviour)this).Invoke("autoRunP2", 280f);
	}

	public void JJLJLJMENDH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar):
			KBIBFEJLAIG(metalWorkshop, NJHMBMGKCPL: false);
			FIEILGKNCGE(woodWorkshop, NJHMBMGKCPL: false);
			ELFGHAIFNFJ(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop):
			KIGCMNHILAG(metalWorkshop, NJHMBMGKCPL: true);
			FINJOJELAGM(woodWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop):
			FEEAJEBLMBD(metalWorkshop, NJHMBMGKCPL: true);
			MECMEPAAPKO(woodWorkshop, NJHMBMGKCPL: false);
			FIEILGKNCGE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void IGKCAMIHBML()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.MetalWorkshop:
			GDHJMBLHADD(metalWorkshop, NJHMBMGKCPL: false);
			IHOMGFOKKDL(woodWorkshop, NJHMBMGKCPL: true);
			CBCGKJDJMAP(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.WithoutZone | ZoneType.Cellar | ZoneType.WoodWorkshop:
			HGJLBONEDOJ(metalWorkshop, NJHMBMGKCPL: true);
			GDHJMBLHADD(woodWorkshop, NJHMBMGKCPL: true);
			MECMEPAAPKO(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop:
			PALLKEINJFF(metalWorkshop, NJHMBMGKCPL: false);
			KIGCMNHILAG(woodWorkshop, NJHMBMGKCPL: false);
			KMLPEJCJCCD(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	private void FIEILGKNCGE(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void KIGCMNHILAG(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void MIKOBJDMAPA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.RentedRoom | ZoneType.WoodWorkshop:
			GDHJMBLHADD(metalWorkshop, NJHMBMGKCPL: false);
			FIEILGKNCGE(woodWorkshop, NJHMBMGKCPL: false);
			DOAEFMEEFNE(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop):
			KIGCMNHILAG(metalWorkshop, NJHMBMGKCPL: true);
			FEEAJEBLMBD(woodWorkshop, NJHMBMGKCPL: true);
			KIGCMNHILAG(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop:
			NLGMMIHFIGN(metalWorkshop, NJHMBMGKCPL: true);
			MDGCHNALBJM(woodWorkshop, NJHMBMGKCPL: false);
			LPDHFMNPBEK(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void HPJBLOPJIMI()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GOHMLAHNCIM));
		((MonoBehaviour)this).Invoke(" has NPC attached", 774f);
	}

	public void KHJDKJOKLIM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.WoodWorkshop):
			MECMEPAAPKO(metalWorkshop, NJHMBMGKCPL: false);
			DCCLPOHKMAI(woodWorkshop, NJHMBMGKCPL: false);
			KMLPEJCJCCD(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop):
			JOJMHILHDHH(metalWorkshop, NJHMBMGKCPL: true);
			DEDPODNIJAN(woodWorkshop, NJHMBMGKCPL: true);
			LJCKODMCGMM(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop:
			LJCKODMCGMM(metalWorkshop, NJHMBMGKCPL: false);
			EBLLKGIEJPD(woodWorkshop, NJHMBMGKCPL: false);
			MECMEPAAPKO(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	private void JAPIMKFHLCM(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void DOAEFMEEFNE(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void LCFAJMDOKBE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom):
			DBCAAICCLFN(metalWorkshop, NJHMBMGKCPL: true);
			DOAEFMEEFNE(woodWorkshop, NJHMBMGKCPL: false);
			KBIBFEJLAIG(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop:
			HGJLBONEDOJ(metalWorkshop, NJHMBMGKCPL: true);
			MECMEPAAPKO(woodWorkshop, NJHMBMGKCPL: true);
			KIGCMNHILAG(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop:
			MHHOACNIJFO(metalWorkshop, NJHMBMGKCPL: false);
			ELFGHAIFNFJ(woodWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void OCFKHCGCFNO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.RentedRoom | ZoneType.Cellar):
			KIGCMNHILAG(metalWorkshop, NJHMBMGKCPL: false);
			LJCKODMCGMM(woodWorkshop, NJHMBMGKCPL: true);
			CBCGKJDJMAP(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop):
			MHHOACNIJFO(metalWorkshop, NJHMBMGKCPL: false);
			DEDPODNIJAN(woodWorkshop, NJHMBMGKCPL: true);
			LPDHFMNPBEK(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar):
			MHHOACNIJFO(metalWorkshop, NJHMBMGKCPL: true);
			PALLKEINJFF(woodWorkshop, NJHMBMGKCPL: false);
			ACHFAGGIAAE(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void GNPILICGJCJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.Cellar):
			LJCKODMCGMM(metalWorkshop, NJHMBMGKCPL: true);
			DJIFHECJCFK(woodWorkshop, NJHMBMGKCPL: true);
			DJIFHECJCFK(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop:
			BDLJHAMHLJM(metalWorkshop, NJHMBMGKCPL: false);
			BKEJDKFICAK(woodWorkshop, NJHMBMGKCPL: false);
			FEEAJEBLMBD(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop:
			MHHOACNIJFO(metalWorkshop, NJHMBMGKCPL: true);
			JAPIMKFHLCM(woodWorkshop, NJHMBMGKCPL: true);
			HGJLBONEDOJ(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void GPOLPCCLBEM()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			CBCGKJDJMAP(metalWorkshop, NJHMBMGKCPL: true);
			IHOMGFOKKDL(woodWorkshop, NJHMBMGKCPL: true);
			LPDHFMNPBEK(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.Cellar | ZoneType.WoodWorkshop:
			EBLLKGIEJPD(metalWorkshop, NJHMBMGKCPL: false);
			BDLJHAMHLJM(woodWorkshop, NJHMBMGKCPL: true);
			PALLKEINJFF(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar:
			KIGCMNHILAG(metalWorkshop, NJHMBMGKCPL: true);
			DEDPODNIJAN(woodWorkshop, NJHMBMGKCPL: true);
			MOEMACPDJOM(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void JBJHJBELEHA()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~ZoneType.CraftingRoom:
			FINJOJELAGM(metalWorkshop, NJHMBMGKCPL: true);
			NPGKDNFICNA(woodWorkshop, NJHMBMGKCPL: true);
			PALLKEINJFF(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			MDGCHNALBJM(metalWorkshop, NJHMBMGKCPL: false);
			DBCAAICCLFN(woodWorkshop, NJHMBMGKCPL: false);
			MDGCHNALBJM(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop):
			JAPIMKFHLCM(metalWorkshop, NJHMBMGKCPL: true);
			CHJJAJKGBFE(woodWorkshop, NJHMBMGKCPL: false);
			DOAEFMEEFNE(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	public void PNJJEDEFAGO()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(LCFAJMDOKBE));
		((MonoBehaviour)this).Invoke("ReceiveSetLife", 874f);
	}

	public void KLMNLEDKEOE()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(OCFKHCGCFNO));
		((MonoBehaviour)this).Invoke("<br>", 986f);
	}

	public void BGBFJPJLPMF()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(JBJHJBELEHA));
		((MonoBehaviour)this).Invoke("NetworkSync ", 357f);
	}

	public void AECBKOMHDDC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.Cellar | ZoneType.MetalWorkshop):
			DJIFHECJCFK(metalWorkshop, NJHMBMGKCPL: true);
			MECMEPAAPKO(woodWorkshop, NJHMBMGKCPL: false);
			KIGCMNHILAG(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom:
			LJCKODMCGMM(metalWorkshop, NJHMBMGKCPL: true);
			GDHJMBLHADD(woodWorkshop, NJHMBMGKCPL: false);
			PALLKEINJFF(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.MetalWorkshop | ZoneType.StoneWorkshop):
			DBCAAICCLFN(metalWorkshop, NJHMBMGKCPL: false);
			NPGKDNFICNA(woodWorkshop, NJHMBMGKCPL: false);
			JAPIMKFHLCM(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	private void PALLKEINJFF(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void OAEJGGFFCBO()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(NNOLJDEEDII));
		((MonoBehaviour)this).Invoke("Starchy", 1796f);
	}

	public void NKLAOFEDHNN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar):
			KIGCMNHILAG(metalWorkshop, NJHMBMGKCPL: false);
			MDGCHNALBJM(woodWorkshop, NJHMBMGKCPL: false);
			FEEAJEBLMBD(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.WithoutZone | ZoneType.WoodWorkshop:
			DEDPODNIJAN(metalWorkshop, NJHMBMGKCPL: true);
			BDLJHAMHLJM(woodWorkshop, NJHMBMGKCPL: true);
			FEEAJEBLMBD(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.MetalWorkshop):
			MDGCHNALBJM(metalWorkshop, NJHMBMGKCPL: true);
			DCCLPOHKMAI(woodWorkshop, NJHMBMGKCPL: true);
			JOJMHILHDHH(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void CEOEHODJAJK()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(GPBHBFKIHOC));
		((MonoBehaviour)this).Invoke("<color=#BF0000>", 75f);
	}

	private void LJCKODMCGMM(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void HNFJFOOLDKI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			EBLLKGIEJPD(metalWorkshop, NJHMBMGKCPL: true);
			CHJJAJKGBFE(woodWorkshop, NJHMBMGKCPL: true);
			HGJLBONEDOJ(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop):
			CHJJAJKGBFE(metalWorkshop, NJHMBMGKCPL: true);
			HGJLBONEDOJ(woodWorkshop, NJHMBMGKCPL: true);
			CHJJAJKGBFE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.StoneWorkshop):
			CHJJAJKGBFE(metalWorkshop, NJHMBMGKCPL: false);
			LPDHFMNPBEK(woodWorkshop, NJHMBMGKCPL: false);
			CHJJAJKGBFE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	private void FINJOJELAGM(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void FEEAJEBLMBD(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void DHIDNEGIDLP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop:
			DCCLPOHKMAI(metalWorkshop, NJHMBMGKCPL: false);
			MECMEPAAPKO(woodWorkshop, NJHMBMGKCPL: true);
			IHOMGFOKKDL(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			LPDHFMNPBEK(metalWorkshop, NJHMBMGKCPL: true);
			FEEAJEBLMBD(woodWorkshop, NJHMBMGKCPL: true);
			NLGMMIHFIGN(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ZoneType.RentedRoom | ZoneType.WoodWorkshop:
			EBLLKGIEJPD(metalWorkshop, NJHMBMGKCPL: false);
			GDHJMBLHADD(woodWorkshop, NJHMBMGKCPL: true);
			BDLJHAMHLJM(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		}
	}

	public void HAJJILAGENE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop):
			HGJLBONEDOJ(metalWorkshop, NJHMBMGKCPL: false);
			JAPIMKFHLCM(woodWorkshop, NJHMBMGKCPL: true);
			CHJJAJKGBFE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar):
			LJCKODMCGMM(metalWorkshop, NJHMBMGKCPL: true);
			NLGMMIHFIGN(woodWorkshop, NJHMBMGKCPL: true);
			DBCAAICCLFN(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.StoneWorkshop):
			FIEILGKNCGE(metalWorkshop, NJHMBMGKCPL: true);
			DCCLPOHKMAI(woodWorkshop, NJHMBMGKCPL: true);
			KMLPEJCJCCD(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	private void GDHJMBLHADD(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void GJNNKHDBKMK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		switch (WorldGrid.AGKGGAFFFGM(tileChecked.position))
		{
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom:
			JOJMHILHDHH(metalWorkshop, NJHMBMGKCPL: true);
			MHHOACNIJFO(woodWorkshop, NJHMBMGKCPL: true);
			EBLLKGIEJPD(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar):
			PALLKEINJFF(metalWorkshop, NJHMBMGKCPL: false);
			PALLKEINJFF(woodWorkshop, NJHMBMGKCPL: true);
			FIEILGKNCGE(stoneWorkshop, NJHMBMGKCPL: false);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.StoneWorkshop):
			PALLKEINJFF(metalWorkshop, NJHMBMGKCPL: false);
			DOAEFMEEFNE(woodWorkshop, NJHMBMGKCPL: false);
			FINJOJELAGM(stoneWorkshop, NJHMBMGKCPL: true);
			break;
		}
	}

	private void HGJLBONEDOJ(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void MHHOACNIJFO(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void MOEMACPDJOM(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void IHOMGFOKKDL(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	public void BHAFCBHENPL()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(BPIMNHCPEDD));
		((MonoBehaviour)this).Invoke(". Added to delivery chest", 190f);
	}

	public void BNFGHAGJEGG()
	{
		SnapToGrid obj = snapToGrid;
		obj.OnPositionChanged = (Action)Delegate.Combine(obj.OnPositionChanged, new Action(IOGDGGLELFE));
		((MonoBehaviour)this).Invoke("Tutorial/T101/Dialogue3", 375f);
	}

	private void MECMEPAAPKO(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 0; i < INIGJPMNPJI.Length; i += 0)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}

	private void CHJJAJKGBFE(GameObject[] INIGJPMNPJI, bool NJHMBMGKCPL)
	{
		for (int i = 1; i < INIGJPMNPJI.Length; i++)
		{
			if (INIGJPMNPJI[i].activeSelf != NJHMBMGKCPL)
			{
				INIGJPMNPJI[i].SetActive(NJHMBMGKCPL);
			}
		}
	}
}
