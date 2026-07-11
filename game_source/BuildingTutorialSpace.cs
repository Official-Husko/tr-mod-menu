using System;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTutorialSpace : MonoBehaviour
{
	[Serializable]
	public class InstantiateGameObjects
	{
		public Item item;

		public Transform transform;
	}

	public int id;

	public InstantiateGameObjects[] instantiateGO;

	private BuildingPopUp.Objective[] NDNOEEDFNFH;

	private int IFHGNJNDJPH;

	private List<bool> COCGNJFCLMC;

	private Transform DCGBADKLANM;

	private bool PCGNHMPADGE;

	private bool ACHOCPKILII;

	private float KHEBKHFHMDB;

	private List<Placeable> KCJIMDFEBBL;

	private void JIOLNLPAIHP()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 1; i < instantiateGO.Length; i++)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.LLCLICBABLN(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.MDFENOKNBEG();
			if (instantiateGO[i].item.IMCJPECAAPC(DAINLFIMLIH: false) == 73)
			{
				component.rotatable = false;
			}
		}
	}

	private void IEPJAFLDBJJ()
	{
		GGFCLPPDNKN(ENCANKDGBOH: true);
		LJCOEGDNJPN();
	}

	public void FNMLHIJPPEG()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void FGKIFGDINOF()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 1; i < instantiateGO.Length; i += 0)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.LLCLICBABLN(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.MDFENOKNBEG();
			if (instantiateGO[i].item.JPNFKDMFKMC() == -70)
			{
				component.rotatable = false;
			}
		}
	}

	public void BGLCNECIJFK()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void AJOAKOCODOC()
	{
		KAPJEJOLMPL(ENCANKDGBOH: false);
		JIOLNLPAIHP();
	}

	private void PKLDCIJGHMH()
	{
		EJPMKDIAJDB(ENCANKDGBOH: false);
		CEAMCEANGMB();
	}

	public void EGCKIBNBDJF()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void BHCMPDDOHEF(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				PCGNHMPADGE = false;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 1; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j++)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	private void KOLOOGLOKBA(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(92f, 1933f)))
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void OHGHOPMMNLC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1021f, 598f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(625f, 1289f, 261f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
		else
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
	}

	public void IIGGPCIEDMF()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void EELBGHJGCLI(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(292f, 1883f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(1600f, 1746f, 1559f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
				return;
			}
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = true;
		}
		else
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
	}

	private void ACJELGJHJPM(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void DLIKLMNCIAC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == (ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void AFEKMPEAJJH(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			for (int j = 0; j < ((Component)this).transform.GetChild(i).childCount; j++)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void JCKEHNFJJIG(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	public void ActivateSpace()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void ADKEPCIBMFG(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void KJJOKJLCAFE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	public void NJDPPOLMCPH()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void OKAPGNGLOHO()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.CONNPMNKIIO(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.HADFBBLFBML(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.FDABNCPKGFK();
	}

	private void OnEnable()
	{
		FKDMPFKPLJN(ENCANKDGBOH: true);
		JJILJFILLFA();
	}

	private void DOHLOJOIHFO()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.KONPAFKGDPP(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.HADFBBLFBML(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.BHEAFPDDOCA();
	}

	private void JOOJOACPJJN(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	public void OGGOAHLHMFG()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void FKDMPFKPLJN(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			for (int j = 0; j < ((Component)this).transform.GetChild(i).childCount; j++)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void EJPMKDIAJDB(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			for (int j = 1; j < ((Component)this).transform.GetChild(i).childCount; j++)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void CEDIMHKHAGA(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void APEIDBEOLFH(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 0; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.CIGFGKKCPCK() == MNBNGGHHMBB)
			{
				PCGNHMPADGE = false;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 1; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j++)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	private void EPOICHFMJLK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1869f, 1013f)))
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void INGGDMNFMCO()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-87) || NDNOEEDFNFH[i].goal == BuildingTutorialGoals.AssignWall || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)89 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-38))
			{
				PCGNHMPADGE = true;
			}
			else
			{
				PCGNHMPADGE = false;
			}
			ACHOCPKILII = false;
			for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
			{
				for (int k = 1; k < ((Component)this).transform.GetChild(j).childCount; k++)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.MoveWASD:
						ACHOCPKILII = false;
						AADDAIBDLNK(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AddFloor:
						ACHOCPKILII = true;
						LONMLCBHKFC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChangeTavernFloor:
						ACHOCPKILII = false;
						JCIIHCCELLE(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ApplyCraftingZone:
						ACHOCPKILII = true;
						DCGOGCCDJNP(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignWall:
						ACHOCPKILII = false;
						FFNANDGGEJE(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignFloor:
						ACHOCPKILII = false;
						EELBGHJGCLI(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChooseRoomName:
						ACHOCPKILII = false;
						BOPLJDJCIIL(DCGBADKLANM, -157);
						break;
					case BuildingTutorialGoals.ActivateBuildMode:
						ACHOCPKILII = false;
						APEIDBEOLFH(DCGBADKLANM, -40);
						break;
					case BuildingTutorialGoals.PlaceBed:
						ACHOCPKILII = true;
						FAIOHCNFLNC(DCGBADKLANM, -183);
						break;
					case BuildingTutorialGoals.PlaceTable:
						ACHOCPKILII = true;
						HJPAMIIFEKM(DCGBADKLANM, 24);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.GoalCompleted(i);
			}
		}
	}

	private void IGGNHKNKDNJ(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void FAKNILODPNH()
	{
		EJPMKDIAJDB(ENCANKDGBOH: true);
	}

	private void MBCDGFCEPFI(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void DGMPPGLEFPE(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	private void GFMLEGIABEP()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 0; i < instantiateGO.Length; i += 0)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.LLCLICBABLN(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.SetUpCreatedPlaceable();
			if (instantiateGO[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -142)
			{
				component.rotatable = true;
			}
		}
	}

	private void ECFBPBGLMIG()
	{
		GGFCLPPDNKN(ENCANKDGBOH: true);
		GEPMLIFAPEO();
	}

	private void FAIOHCNFLNC(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				PCGNHMPADGE = true;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 0; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j++)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == MNBNGGHHMBB)
				{
					PCGNHMPADGE = false;
					break;
				}
			}
		}
	}

	private void NPDFCPEOFPD()
	{
		KAPJEJOLMPL(ENCANKDGBOH: true);
		JJILJFILLFA();
	}

	private void DOKHLDBIDJB()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 1; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)59 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-45) || NDNOEEDFNFH[i].goal == BuildingTutorialGoals.AcceptChanges || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)94)
			{
				PCGNHMPADGE = false;
			}
			else
			{
				PCGNHMPADGE = true;
			}
			ACHOCPKILII = true;
			for (int j = 1; j < ((Component)this).transform.childCount; j++)
			{
				for (int k = 0; k < ((Component)this).transform.GetChild(j).childCount; k++)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = false;
						IGGNHKNKDNJ(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ActivateBuildMode:
						ACHOCPKILII = false;
						LONMLCBHKFC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceBed:
						ACHOCPKILII = false;
						KOCJENAPLJI(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceTable:
						ACHOCPKILII = false;
						BPEMJOEGFLH(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						KOLOOGLOKBA(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = true;
						DIAAAMGLFGC(DCGBADKLANM);
						break;
					case (BuildingTutorialGoals)17:
						ACHOCPKILII = false;
						GIPDCOLLCBC(DCGBADKLANM, 146);
						break;
					case (BuildingTutorialGoals)18:
						ACHOCPKILII = false;
						MMJAFGOEDMO(DCGBADKLANM, 184);
						break;
					case (BuildingTutorialGoals)19:
						ACHOCPKILII = false;
						LGPLEMFHGFC(DCGBADKLANM, 144);
						break;
					case (BuildingTutorialGoals)20:
						ACHOCPKILII = false;
						PGLBJJKMANN(DCGBADKLANM, 52);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.EHIPLFHMLFC(i);
			}
		}
	}

	private void PLMDPONDIBK(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			for (int j = 0; j < ((Component)this).transform.GetChild(i).childCount; j += 0)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void AEFLKFANPIJ(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	private void GFFNHFDABBH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(663f, 811f)))
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void JHGAMPPHLOE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void PCIHIIAGJIH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void MEDIGODLCBN()
	{
		DGDKFOBOOAL(ENCANKDGBOH: true);
		LJCOEGDNJPN();
	}

	private void EPCALLOKMAM(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			for (int j = 1; j < ((Component)this).transform.GetChild(i).childCount; j += 0)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	public void KBNOLEIHFGL()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void FOFACCKMDDG()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void DOKBODADDAF(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.RentedRoom)
		{
			DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void DFDCOIOPAEM(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	private void MFFPMOGCHFC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.CraftingRoom)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void PKLBKJPCCDM()
	{
		EJPMKDIAJDB(ENCANKDGBOH: false);
		ENLHGHHAEBJ();
	}

	public void AKPIMJJKKCI()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void CBAICOOHOAK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void KAEOBLJOBEL(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	public void IGCCBCEKJCD()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void BHLHCOALABE()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 1; i < NDNOEEDFNFH.Length; i++)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)55 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-47) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-36) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-32))
			{
				PCGNHMPADGE = false;
			}
			else
			{
				PCGNHMPADGE = false;
			}
			ACHOCPKILII = true;
			for (int j = 1; j < ((Component)this).transform.childCount; j++)
			{
				for (int k = 0; k < ((Component)this).transform.GetChild(j).childCount; k += 0)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.AssignWall:
						ACHOCPKILII = true;
						CCFIOIJNOOL(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateDoor:
						ACHOCPKILII = true;
						NGGPGFHNHBK(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = true;
						JCKEHNFJJIG(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChooseRoomName:
						ACHOCPKILII = false;
						ADKEPCIBMFG(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ActivateBuildMode:
						ACHOCPKILII = false;
						KIGENKBKPDO(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceBed:
						ACHOCPKILII = true;
						DIAAAMGLFGC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = false;
						POLLKEIFPGK(DCGBADKLANM, 198);
						break;
					case BuildingTutorialGoals.AcceptChanges:
						ACHOCPKILII = false;
						MMJAFGOEDMO(DCGBADKLANM, 76);
						break;
					case (BuildingTutorialGoals)16:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, 65);
						break;
					case (BuildingTutorialGoals)17:
						ACHOCPKILII = true;
						MMJAFGOEDMO(DCGBADKLANM, 0);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.GoalCompleted(i);
			}
		}
	}

	private void COJHGDLKGAD(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1947f, 1460f)))
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void CCFIOIJNOOL(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void ENLHGHHAEBJ()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 1; i < instantiateGO.Length; i += 0)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.LLCLICBABLN(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.MDFENOKNBEG();
			if (instantiateGO[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -30)
			{
				component.rotatable = true;
			}
		}
	}

	private void KOCJENAPLJI(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void JJILJFILLFA()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 0; i < instantiateGO.Length; i++)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.PHGCBMPGGLI(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.SetUpCreatedPlaceable();
			if (instantiateGO[i].item.JDJGFAACPFC() == 1131)
			{
				component.rotatable = false;
			}
		}
	}

	private void PGLBJJKMANN(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i += 0)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.CIGFGKKCPCK() == MNBNGGHHMBB)
			{
				PCGNHMPADGE = true;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 0; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j++)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	private void POLLKEIFPGK(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				PCGNHMPADGE = false;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 1; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j += 0)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.CIGFGKKCPCK() == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	public void HDOKCBMEHCL()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void DGFDIBNEBLK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(0f, 0.5f)))
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void KJOJLHCDFPP()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.OKLGHDFPLED(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.CONNPMNKIIO(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.BHEAFPDDOCA();
	}

	private void LONMLCBHKFC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.None)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void HJPAMIIFEKM(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 0; i < KCJIMDFEBBL.Count; i += 0)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				PCGNHMPADGE = false;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 0; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j += 0)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.JGHNDJBCFAJ() == MNBNGGHHMBB)
				{
					PCGNHMPADGE = false;
					break;
				}
			}
		}
	}

	private void BKAPOBBAMKH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.CraftingRoom)
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	public void ECHKHCOLJNC()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void OANLKKENLIH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1663f, 735f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(383f, 677f, 1691f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = true;
		}
		else
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = true;
		}
	}

	private void AADDAIBDLNK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void HOFKJPBBLGP()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.OKLGHDFPLED(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.HADFBBLFBML(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.GetCompletedGoals();
	}

	private void NGGPGFHNHBK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.RentedRoom)
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void KJFPNFMOHEK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void HIGNMDKDBOP(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void JPOLFKMLHNH()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.GetPopUp(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.GetPopUp(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.FDABNCPKGFK();
	}

	private void OnDisable()
	{
		FKDMPFKPLJN(ENCANKDGBOH: false);
	}

	private void EGGNIKNEDOI(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void ACNFICFEICK(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	private void GBILMMMOAPO(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void BNDDDHFLEAE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(293f, 1735f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(175f, 1593f, 595f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: true);
				return;
			}
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
		else
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
	}

	private void KIGENKBKPDO(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(78f, 18f)))
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void IJIMJNCKLAC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void CHIJGHPHCNA()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.KONPAFKGDPP(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.KONPAFKGDPP(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.BHEAFPDDOCA();
	}

	private void CCPCFKMJECM(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.CraftingRoom)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void FNDEHFNFEKB(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1999f, 989f)))
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void AIFOBFHCHGK()
	{
		GGFCLPPDNKN(ENCANKDGBOH: true);
	}

	private void GEPMLIFAPEO()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 1; i < instantiateGO.Length; i++)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.LLCLICBABLN(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.MDFENOKNBEG();
			if (instantiateGO[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -95)
			{
				component.rotatable = true;
			}
		}
	}

	private void CDFCDNOMKEC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1792f, 1168f)))
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void ACJOJMCPDFM(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(564f, 1730f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(1832f, 891f, 902f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
		else
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
	}

	private void DDOHCBEAEJH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void DGDKFOBOOAL(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			for (int j = 1; j < ((Component)this).transform.GetChild(i).childCount; j += 0)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void OECNKINLDDE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(768f, 1451f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(276f, 600f, 1207f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
				return;
			}
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
		else
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
	}

	private void DCGOGCCDJNP(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	public void OPFFJLFLKID()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void MMJAFGOEDMO(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i += 0)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				PCGNHMPADGE = false;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 1; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j += 0)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.IMCJPECAAPC() == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	private void GGFCLPPDNKN(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			for (int j = 1; j < ((Component)this).transform.GetChild(i).childCount; j += 0)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void CNLHNNBMDNN(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1855f, 252f)))
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void DIAAAMGLFGC(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1929f, 1853f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(264f, 501f, 1180f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
		else
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
	}

	private void GCHMNMKCOFG()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)21 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-126) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)103 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)81)
			{
				PCGNHMPADGE = true;
			}
			else
			{
				PCGNHMPADGE = false;
			}
			ACHOCPKILII = false;
			for (int j = 1; j < ((Component)this).transform.childCount; j++)
			{
				for (int k = 1; k < ((Component)this).transform.GetChild(j).childCount; k += 0)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = false;
						JBHDACJFPCD(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ActivateBuildMode:
						ACHOCPKILII = true;
						DLIKLMNCIAC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceBed:
						ACHOCPKILII = true;
						AJBHMPFOLLB(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceTable:
						ACHOCPKILII = true;
						PCIHIIAGJIH(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						MEMPGJDDOOL(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = false;
						OANLKKENLIH(DCGBADKLANM);
						break;
					case (BuildingTutorialGoals)17:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, -115);
						break;
					case (BuildingTutorialGoals)18:
						ACHOCPKILII = false;
						BHCMPDDOHEF(DCGBADKLANM, -24);
						break;
					case (BuildingTutorialGoals)19:
						ACHOCPKILII = true;
						BHCMPDDOHEF(DCGBADKLANM, -20);
						break;
					case (BuildingTutorialGoals)20:
						ACHOCPKILII = true;
						MMJAFGOEDMO(DCGBADKLANM, -13);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.EHIPLFHMLFC(i);
			}
		}
	}

	private void KAPJEJOLMPL(bool ENCANKDGBOH)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			for (int j = 1; j < ((Component)this).transform.GetChild(i).childCount; j += 0)
			{
				if (ENCANKDGBOH)
				{
					EditorGrid.CEDBHKIPBOB(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
				else
				{
					EditorGrid.AJACKDNIDPA(((Component)this).transform.GetChild(i).GetChild(j).position);
				}
			}
		}
	}

	private void NLHKLOPMKNP(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.CraftingRoom)
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void EALDAIOEBMN(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void BFKCHCLJIPL()
	{
		AFEKMPEAJJH(ENCANKDGBOH: false);
		JJILJFILLFA();
	}

	private void OILHJENGGEL()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.OKLGHDFPLED(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.HADFBBLFBML(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.BHEAFPDDOCA();
	}

	private void NCOMGPCNMAL(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void GIPDCOLLCBC(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				PCGNHMPADGE = true;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 0; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j += 0)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.CIGFGKKCPCK() == MNBNGGHHMBB)
				{
					PCGNHMPADGE = false;
					break;
				}
			}
		}
	}

	private void BOPLJDJCIIL(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 1; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.JDJGFAACPFC() == MNBNGGHHMBB)
			{
				PCGNHMPADGE = true;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 0; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j++)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.CIGFGKKCPCK() == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	private void Update()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i++)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == BuildingTutorialGoals.PlaceBed || NDNOEEDFNFH[i].goal == BuildingTutorialGoals.PlaceTable || NDNOEEDFNFH[i].goal == BuildingTutorialGoals.PlaceChair || NDNOEEDFNFH[i].goal == BuildingTutorialGoals.PlaceLight)
			{
				PCGNHMPADGE = false;
			}
			else
			{
				PCGNHMPADGE = true;
			}
			ACHOCPKILII = false;
			for (int j = 0; j < ((Component)this).transform.childCount; j++)
			{
				for (int k = 0; k < ((Component)this).transform.GetChild(j).childCount; k++)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.AddFloor:
						ACHOCPKILII = true;
						CCFIOIJNOOL(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ApplyCraftingZone:
						ACHOCPKILII = true;
						CCPCFKMJECM(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignWall:
						ACHOCPKILII = true;
						KDNMNKANJLG(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignFloor:
						ACHOCPKILII = true;
						ALPEAANOOLO(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateDoor:
						ACHOCPKILII = true;
						DGFDIBNEBLK(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = true;
						IFGNIGGOBFE(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceBed:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, 635);
						break;
					case BuildingTutorialGoals.PlaceTable:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, 1131);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, 660);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, 605);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.GoalCompleted(i);
			}
		}
	}

	private void ILLJPPHHJMH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void OMLHIAADEHE()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-128) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-19) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)55 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)47)
			{
				PCGNHMPADGE = false;
			}
			else
			{
				PCGNHMPADGE = false;
			}
			ACHOCPKILII = true;
			for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
			{
				for (int k = 1; k < ((Component)this).transform.GetChild(j).childCount; k++)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.ChangeTavernFloor:
						ACHOCPKILII = true;
						JBHDACJFPCD(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignWall:
						ACHOCPKILII = true;
						LONMLCBHKFC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignFloor:
						ACHOCPKILII = true;
						PNNNBLCMALA(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateDoor:
						ACHOCPKILII = false;
						GBILMMMOAPO(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = true;
						FNDEHFNFEKB(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChooseRoomName:
						ACHOCPKILII = true;
						DIAAAMGLFGC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceTable:
						ACHOCPKILII = false;
						GIPDCOLLCBC(DCGBADKLANM, 184);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						PGLBJJKMANN(DCGBADKLANM, -59);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = false;
						MMJAFGOEDMO(DCGBADKLANM, 170);
						break;
					case BuildingTutorialGoals.AcceptChanges:
						ACHOCPKILII = false;
						APEIDBEOLFH(DCGBADKLANM, -32);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.EHIPLFHMLFC(i);
			}
		}
	}

	private void ALPEAANOOLO(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void FFNANDGGEJE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(684f, 497f)))
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void FCGJBDGOHPN()
	{
		FKDMPFKPLJN(ENCANKDGBOH: true);
	}

	public void PGMBJIMBDLA()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void BPEMJOEGFLH(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EIHIPOEOBCO(DCGBADKLANM.position, null) == IFHGNJNDJPH)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void PMJAHOEMHOJ(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	private void AMFDOBCMMHK()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 0; i < instantiateGO.Length; i++)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.PHGCBMPGGLI(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.MDFENOKNBEG();
			if (instantiateGO[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == -175)
			{
				component.rotatable = false;
			}
		}
	}

	private void IFBAFAKGDKB(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1896f, 1348f)))
		{
			NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void MDNAJDAJBDK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void JCIIHCCELLE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	public void LPMLAFCBOEB()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void NBDAECMGMBK(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	private void HKFGIKEBNJN()
	{
		AFEKMPEAJJH(ENCANKDGBOH: false);
	}

	private void AJBHMPFOLLB(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void JBHDACJFPCD(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.EJCEAEPNJCA(DCGBADKLANM.position) && EditorGrid.AJGOLEOFPOL(DCGBADKLANM.position) == EditorAction.None)
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		ACNFICFEICK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void ONOAGANPECB()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 1; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-56) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-29) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)17 || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)112)
			{
				PCGNHMPADGE = false;
			}
			else
			{
				PCGNHMPADGE = false;
			}
			ACHOCPKILII = true;
			for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
			{
				for (int k = 1; k < ((Component)this).transform.GetChild(j).childCount; k += 0)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.ApplyCraftingZone:
						ACHOCPKILII = true;
						CEDIMHKHAGA(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignFloor:
						ACHOCPKILII = true;
						CCPCFKMJECM(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateDoor:
						ACHOCPKILII = false;
						JOOJOACPJJN(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = false;
						CBAICOOHOAK(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChooseRoomName:
						ACHOCPKILII = false;
						DGFDIBNEBLK(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ActivateBuildMode:
						ACHOCPKILII = false;
						GGLJGDHLFOK(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						HJPAMIIFEKM(DCGBADKLANM, -90);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = false;
						BHCMPDDOHEF(DCGBADKLANM, -69);
						break;
					case BuildingTutorialGoals.AcceptChanges:
						ACHOCPKILII = true;
						PGLBJJKMANN(DCGBADKLANM, 163);
						break;
					case (BuildingTutorialGoals)16:
						ACHOCPKILII = false;
						MMJAFGOEDMO(DCGBADKLANM, 24);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.EHIPLFHMLFC(i);
			}
		}
	}

	private void GOJHCINMAJD()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 1; i < NDNOEEDFNFH.Length; i += 0)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-113) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-91) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-85) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-124))
			{
				PCGNHMPADGE = false;
			}
			else
			{
				PCGNHMPADGE = true;
			}
			ACHOCPKILII = false;
			for (int j = 0; j < ((Component)this).transform.childCount; j++)
			{
				for (int k = 0; k < ((Component)this).transform.GetChild(j).childCount; k += 0)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.ChangeTavernFloor:
						ACHOCPKILII = true;
						ACJELGJHJPM(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignWall:
						ACHOCPKILII = false;
						MFFPMOGCHFC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignFloor:
						ACHOCPKILII = true;
						PNNNBLCMALA(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateDoor:
						ACHOCPKILII = true;
						ADKEPCIBMFG(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = true;
						FNDEHFNFEKB(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChooseRoomName:
						ACHOCPKILII = true;
						OHGHOPMMNLC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceTable:
						ACHOCPKILII = false;
						BOPLJDJCIIL(DCGBADKLANM, -28);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						APEIDBEOLFH(DCGBADKLANM, -105);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = false;
						GIPDCOLLCBC(DCGBADKLANM, 17);
						break;
					case BuildingTutorialGoals.AcceptChanges:
						ACHOCPKILII = true;
						FAIOHCNFLNC(DCGBADKLANM, 13);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.GoalCompleted(i);
			}
		}
	}

	private void EHKMHKPKHDE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1923f, 755f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(844f, 318f, 1526f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
		else
		{
			AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
	}

	private void DHCIDFJBFAD()
	{
		KAPJEJOLMPL(ENCANKDGBOH: true);
	}

	private void CPEEDJMOHMO()
	{
		EPCALLOKMAM(ENCANKDGBOH: false);
	}

	private void MHCHENKFGJG(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void LGPLEMFHGFC(Transform DCGBADKLANM, int MNBNGGHHMBB)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KCJIMDFEBBL = WorldGrid.OPLHBJGKKAD(DCGBADKLANM.position);
		if (KCJIMDFEBBL == null)
		{
			return;
		}
		for (int i = 0; i < KCJIMDFEBBL.Count; i++)
		{
			if (KCJIMDFEBBL[i].itemSetup.item.JDJGFAACPFC() == MNBNGGHHMBB)
			{
				PCGNHMPADGE = true;
				break;
			}
			if (!((Object)(object)KCJIMDFEBBL[i].placeableSurface != (Object)null))
			{
				continue;
			}
			for (int j = 0; j < KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface.Count; j++)
			{
				if (!KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].FHEMHCEAICB && KCJIMDFEBBL[i].placeableSurface.placeablesOnSurface[j].itemSetup.item.JDJGFAACPFC() == MNBNGGHHMBB)
				{
					PCGNHMPADGE = true;
					break;
				}
			}
		}
	}

	private void PIEPPDFIOHN(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(298f, 1694f)))
		{
			KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = true;
	}

	private void Start()
	{
		NDNOEEDFNFH = BuildingTutorialDBAccessor.GetPopUp(id).objectives;
		IFHGNJNDJPH = BuildingTutorialDBAccessor.GetPopUp(id).goalDecoId;
		COCGNJFCLMC = BuildingTutorialManager.GetCompletedGoals();
	}

	private void LJCOEGDNJPN()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 1; i < instantiateGO.Length; i++)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.PHGCBMPGGLI(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.SetUpCreatedPlaceable();
			if (instantiateGO[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == 101)
			{
				component.rotatable = false;
			}
		}
	}

	private void CEAMCEANGMB()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (instantiateGO == null)
		{
			return;
		}
		for (int i = 1; i < instantiateGO.Length; i += 0)
		{
			Placeable component = Object.Instantiate<GameObject>(instantiateGO[i].item.PHGCBMPGGLI(), instantiateGO[i].transform.position, Quaternion.identity).GetComponent<Placeable>();
			component.MDFENOKNBEG();
			if (instantiateGO[i].item.CIGFGKKCPCK() == -131)
			{
				component.rotatable = false;
			}
		}
	}

	private void GFPIEOPHABO()
	{
		DGDKFOBOOAL(ENCANKDGBOH: false);
	}

	private void MEMPGJDDOOL(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1199f, 443f)))
		{
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void LGCACPHEHIE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(24f, 704f)))
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		NBDAECMGMBK(DCGBADKLANM, DAEMAAOLHMG: false);
		PCGNHMPADGE = false;
	}

	private void JMMBKMOBAFB()
	{
		EPCALLOKMAM(ENCANKDGBOH: true);
	}

	private void FOHCEDHJOEF()
	{
		if (NDNOEEDFNFH == null || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		for (int i = 0; i < NDNOEEDFNFH.Length; i++)
		{
			if (COCGNJFCLMC[i])
			{
				continue;
			}
			if (NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-17) || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-31) || NDNOEEDFNFH[i].goal == BuildingTutorialGoals.AssignWall || NDNOEEDFNFH[i].goal == (BuildingTutorialGoals)(-42))
			{
				PCGNHMPADGE = true;
			}
			else
			{
				PCGNHMPADGE = true;
			}
			ACHOCPKILII = false;
			for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
			{
				for (int k = 0; k < ((Component)this).transform.GetChild(j).childCount; k += 0)
				{
					DCGBADKLANM = ((Component)this).transform.GetChild(j).GetChild(k);
					switch (NDNOEEDFNFH[i].goal)
					{
					case BuildingTutorialGoals.ApplyCraftingZone:
						ACHOCPKILII = false;
						HIGNMDKDBOP(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.AssignFloor:
						ACHOCPKILII = true;
						DLIKLMNCIAC(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateDoor:
						ACHOCPKILII = false;
						AJBHMPFOLLB(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.CreateRentedRoomDoor:
						ACHOCPKILII = true;
						GBILMMMOAPO(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ChooseRoomName:
						ACHOCPKILII = false;
						IFBAFAKGDKB(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.ActivateBuildMode:
						ACHOCPKILII = false;
						EHKMHKPKHDE(DCGBADKLANM);
						break;
					case BuildingTutorialGoals.PlaceChair:
						ACHOCPKILII = true;
						PGLBJJKMANN(DCGBADKLANM, 184);
						break;
					case BuildingTutorialGoals.PlaceLight:
						ACHOCPKILII = true;
						GIPDCOLLCBC(DCGBADKLANM, -148);
						break;
					case BuildingTutorialGoals.AcceptChanges:
						ACHOCPKILII = true;
						HJPAMIIFEKM(DCGBADKLANM, 2);
						break;
					case (BuildingTutorialGoals)16:
						ACHOCPKILII = true;
						LGPLEMFHGFC(DCGBADKLANM, -195);
						break;
					}
				}
			}
			if (ACHOCPKILII && PCGNHMPADGE)
			{
				BuildingTutorialManager.EHIPLFHMLFC(i);
			}
		}
	}

	private void IFGNIGGOBFE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(0f, 0.5f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(0f, 0.5f, 0f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
		else
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = false;
		}
	}

	public void DeactivateSpace()
	{
		if (((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void KACNHLGNOGC(Transform DCGBADKLANM, bool DAEMAAOLHMG)
	{
		if (((Component)DCGBADKLANM).gameObject.activeSelf != DAEMAAOLHMG)
		{
			((Component)DCGBADKLANM).gameObject.SetActive(DAEMAAOLHMG);
		}
	}

	public void AFBOJAENBHI()
	{
		if (!((Component)this).gameObject.activeSelf)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void NIKCHFBHICE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(1345f, 384f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(1952f, 381f, 1937f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				AEFLKFANPIJ(DCGBADKLANM, DAEMAAOLHMG: false);
				return;
			}
			DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = true;
		}
		else
		{
			DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = true;
		}
	}

	private void GGLJGDHLFOK(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position) || WorldGrid.LBKKDAMMKIE(DCGBADKLANM.position + new Vector3(303f, 405f)))
		{
			Door door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position);
			if ((Object)(object)door == (Object)null)
			{
				door = WorldGrid.IPNJBJEMDKF(DCGBADKLANM.position + new Vector3(1991f, 1086f, 1311f));
			}
			if (Object.op_Implicit((Object)(object)door) && door is RentedRoomDoor)
			{
				PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
				return;
			}
			PMJAHOEMHOJ(DCGBADKLANM, DAEMAAOLHMG: true);
			PCGNHMPADGE = true;
		}
		else
		{
			DGMPPGLEFPE(DCGBADKLANM, DAEMAAOLHMG: false);
			PCGNHMPADGE = false;
		}
	}

	private void PNNNBLCMALA(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		KACNHLGNOGC(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = true;
	}

	private void KDNMNKANJLG(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.KHJJCAGIJAP(DCGBADKLANM.position, out KHEBKHFHMDB) && WorldGrid.IKCDANOHPJE(new Vector3(DCGBADKLANM.position.x, KHEBKHFHMDB)) == IFHGNJNDJPH)
		{
			DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: false);
			return;
		}
		DFDCOIOPAEM(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}

	private void JMJMAONPPOE(Transform DCGBADKLANM)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.AGKGGAFFFGM(DCGBADKLANM.position) == ZoneType.RentedRoom)
		{
			KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
			return;
		}
		KAEOBLJOBEL(DCGBADKLANM, DAEMAAOLHMG: true);
		PCGNHMPADGE = false;
	}
}
