using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConstructionFloors : MonoBehaviour
{
	public Action<TavernFloor> OnFloorChanged = delegate
	{
	};

	public GameObject content;

	[SerializeField]
	private Image[] backgrounds;

	[SerializeField]
	private Button[] buttons;

	[SerializeField]
	private TextMeshProUGUI floorTextMesh;

	[SerializeField]
	private CameraController cameraController;

	public Transform originalParent;

	private Transform OFBKCHILNIP;

	private float CMGDCLIIONE;

	private TavernFloor LKOFIKKFNMC = TavernFloor.FirstFloor;

	private TavernFloor MLGAAIFPNHD = TavernFloor.FirstFloor;

	private static ConstructionFloors IADEMLIIDPC;

	public TavernFloor ODFBDBLCFOM => LKOFIKKFNMC;

	public static ConstructionFloors GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
			}
			return IADEMLIIDPC;
		}
	}

	private void GFPIEOPHABO()
	{
		if (TavernConstructionUI.PGKBDDJMEEK())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	public void OBCLNPFNAHN(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(1234f);
			AGBMOOCJFNE(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.DPPPPNIDLOK(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	[SpecialName]
	public TavernFloor EJKJLPAFFOI()
	{
		return LKOFIKKFNMC;
	}

	[SpecialName]
	public static ConstructionFloors DCAEBALADIM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	private void HEOAIGHOLLD()
	{
		if (TavernConstructionUI.NIHAGDNNENF())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	[SpecialName]
	public static ConstructionFloors MNFMOEKMJKN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	public Image MKOIMPBENPP()
	{
		return ((Component)this).GetComponent<Image>();
	}

	public void NLNLGDEAFOO(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.KGJOKHEBLOJ())
		{
			HCIDINIPLJO(0, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.Cellar));
			ODFONEGPHKE(0, BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag((TavernFloor)8));
			IFPHGDMHNHN(4, BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag(TavernFloor.Cellar | TavernFloor.SecondFloor));
		}
		else
		{
			ODFONEGPHKE(1, NCLCPJJOGKN: false);
			BBFEFEPCHKE(1, NCLCPJJOGKN: false);
			NJFNGKKAOMM(3, NCLCPJJOGKN: true);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.None:
			((Behaviour)backgrounds[1]).enabled = false;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.FAOPFMBMMJJ().cellarPos;
			break;
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().firstFloorPos;
			break;
		case TavernFloor.Cellar | TavernFloor.FirstFloor:
			((Behaviour)backgrounds[7]).enabled = false;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	[SpecialName]
	public static ConstructionFloors DFJGHOHPPEL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	public void NHLLIJACJEI(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			ODFONEGPHKE(0, BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag(TavernFloor.None));
			ODFONEGPHKE(1, BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag(TavernFloor.FirstFloor));
			OJKFPCPGMIN(6, BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag((TavernFloor)8));
		}
		else
		{
			OJKFPCPGMIN(0, NCLCPJJOGKN: true);
			GOLHJOEJGJO(0, NCLCPJJOGKN: false);
			ODFONEGPHKE(4, NCLCPJJOGKN: true);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[0]).enabled = false;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.CKDKHMPHENE().cellarPos;
			break;
		case TavernFloor.FirstFloor:
			((Behaviour)backgrounds[1]).enabled = false;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.CFAMKBHIGLO().firstFloorPos;
			break;
		case TavernFloor.SecondFloor:
			((Behaviour)backgrounds[0]).enabled = false;
			((TMP_Text)floorTextMesh).text = 0.ToString();
			OFBKCHILNIP = SceneReferences.CKDKHMPHENE().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	public void OHPJCAFGGGI(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).FLCGEKBIMIK = 1030f;
			NIJBDBOAMEL(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.DPPPPNIDLOK(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	[SpecialName]
	public TavernFloor LKIILEMCPHH()
	{
		return LKOFIKKFNMC;
	}

	private void KDHLJKMKFMG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public TavernFloor CIOOGFMBBAO()
	{
		return LKOFIKKFNMC;
	}

	public void CNDNFJMKJDL(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).FLCGEKBIMIK = 1397f;
			UpdateFloor(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.DKAICNMJIJH(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	[SpecialName]
	public TavernFloor CPNOFHJLENN()
	{
		return LKOFIKKFNMC;
	}

	private void BBFEFEPCHKE(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = false;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	[SpecialName]
	public static ConstructionFloors JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	private void NBMJJFNKJBA()
	{
		if (TavernConstructionUI.KOKDBLGCOPJ())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	public Image PPIBFACPKBF()
	{
		return ((Component)this).GetComponent<Image>();
	}

	[SpecialName]
	public static ConstructionFloors JCMKNNOEONP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	public void BHDOPOEKDPP(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(1215f);
			PFMPGJGANKO(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.MJNAGHKCDEI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	public void IGNENLODDII(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.KGJOKHEBLOJ() || BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(606f);
			NIJBDBOAMEL(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.MJNAGHKCDEI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public TavernFloor JIBIAOMIGHP()
	{
		return LKOFIKKFNMC;
	}

	private void JIAJFDKNJME()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public TavernFloor DAONIMMHCFB()
	{
		return LKOFIKKFNMC;
	}

	public void EMGIBIHICOO(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.KGJOKHEBLOJ() || BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(1593f);
			NLNLGDEAFOO(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.PNLDBADHHMI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	private void ODBKBMCMFNB()
	{
		if (TavernConstructionUI.BHKOPGENIFB())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void OGNIDHAIABM()
	{
		if (!TavernConstructionUI.FIAGBFIKDFA() || !PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && !((Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Items/item_description_607", 411f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				BHDOPOEKDPP(6);
				break;
			case TavernFloor.Cellar | TavernFloor.FirstFloor:
				EMGIBIHICOO(6);
				break;
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Intensity: ", 629f))
			{
				return;
			}
			TavernFloor lKOFIKKFNMC = LKOFIKKFNMC;
			if (lKOFIKKFNMC != TavernFloor.SecondFloor)
			{
				if (lKOFIKKFNMC == TavernFloor.SecondFloor)
				{
					OHPJCAFGGGI(8);
				}
			}
			else
			{
				KAGELMPBJDO(1);
			}
		}
	}

	[SpecialName]
	public TavernFloor BBNJPPNBCFC()
	{
		return LKOFIKKFNMC;
	}

	[SpecialName]
	public TavernFloor OMHGKGLLOAA()
	{
		return LKOFIKKFNMC;
	}

	private void OnDisable()
	{
		if (TavernConstructionUI.IsWindowOpen())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	public Image OJKIJLFOCKK()
	{
		return ((Component)this).GetComponent<Image>();
	}

	private void DIEKBCKJMPH()
	{
		if (TavernConstructionUI.KOKDBLGCOPJ())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void GOLHJOEJGJO(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = false;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	private void IFPHGDMHNHN(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = false;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	public Image FEDCOJCLBJC()
	{
		return ((Component)this).GetComponent<Image>();
	}

	private void MAEGGDLLHBG()
	{
		if (TavernConstructionUI.FIAGBFIKDFA())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	public void IIJGGHLKCNC(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.PABJKGJJHFG())
		{
			HCIDINIPLJO(1, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.None));
			IFPHGDMHNHN(0, BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag((TavernFloor)8));
			BBFEFEPCHKE(2, BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag(TavernFloor.SecondFloor));
		}
		else
		{
			ODFONEGPHKE(0, NCLCPJJOGKN: false);
			HCIDINIPLJO(1, NCLCPJJOGKN: false);
			OJKFPCPGMIN(6, NCLCPJJOGKN: false);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.CKDKHMPHENE().cellarPos;
			break;
		case TavernFloor.FirstFloor:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = 0.ToString();
			OFBKCHILNIP = SceneReferences.FAOPFMBMMJJ().firstFloorPos;
			break;
		case TavernFloor.SecondFloor:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.CFAMKBHIGLO().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	[SpecialName]
	public TavernFloor EINPMJDHBNA()
	{
		return LKOFIKKFNMC;
	}

	[SpecialName]
	public TavernFloor EHDOGFFODIF()
	{
		return LKOFIKKFNMC;
	}

	private void MEAFJDDNAJB()
	{
		if (!TavernConstructionUI.LBBDNPAGCDE() || !PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.NPANPNIDKDG(ConstructionUI.current.JIIGOACEIKL).IDPGEBNGDJD() && !((Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, " seconds.", 840f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.None:
				EMGIBIHICOO(6);
				break;
			case TavernFloor.FirstFloor | TavernFloor.SecondFloor:
				CABBEPJAHFA(8);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "+", 1545f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.SecondFloor:
				IGNENLODDII(0);
				break;
			case TavernFloor.AllTavernFloors:
				OBCLNPFNAHN(5);
				break;
			}
		}
	}

	[SpecialName]
	public static ConstructionFloors OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	private void BHLHCOALABE()
	{
		if (!TavernConstructionUI.NIHAGDNNENF() || !PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.OCJGHINCLJM(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && !((Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Room Index: {0}, Selected Room: {1}", 607f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				OBCLNPFNAHN(0);
				break;
			case TavernFloor.None:
				OBCLNPFNAHN(4);
				break;
			}
		}
		else
		{
			if (!Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "[^0-9]", 358f))
			{
				return;
			}
			TavernFloor lKOFIKKFNMC = LKOFIKKFNMC;
			if (lKOFIKKFNMC != (TavernFloor.Cellar | TavernFloor.FirstFloor))
			{
				if (lKOFIKKFNMC == (TavernFloor.Cellar | TavernFloor.FirstFloor))
				{
					PGKHMNKFPMK(7);
				}
			}
			else
			{
				KAGELMPBJDO(0);
			}
		}
	}

	public void PGKHMNKFPMK(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.PABJKGJJHFG() || BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(150f);
			UpdateFloor(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.MJNAGHKCDEI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	public void SetFloor(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).FLCGEKBIMIK = 1f;
			UpdateFloor(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.SetCursorPositionFromWorld(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	[SpecialName]
	public TavernFloor PPDODCMKOKF()
	{
		return LKOFIKKFNMC;
	}

	private void HFJJFGDKKOF(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	private void FCGJBDGOHPN()
	{
		if (TavernConstructionUI.IsWindowOpen())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void EAMLHICIOMO()
	{
		if (TavernConstructionUI.FIAGBFIKDFA())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void HCIDINIPLJO(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	public void JMDGKCCKPKK(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(1854f);
			PFMPGJGANKO(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.SetCursorPositionFromWorld(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	private void JMDOCHBJGKG()
	{
		if (!TavernConstructionUI.IsWindowOpen() || !PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.IECFJGHAIDO(ConstructionUI.current.JIIGOACEIKL).DFNMDDHOIJI() && !((Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, " // Replaced for ", 1828f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				BHDOPOEKDPP(2);
				break;
			case TavernFloor.None:
				PGKHMNKFPMK(7);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "descOldDoormat", 1606f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				SetFloor(1);
				break;
			case TavernFloor.FirstFloor | TavernFloor.SecondFloor:
				OBCLNPFNAHN(6);
				break;
			}
		}
	}

	private void FPOIFOGELHC()
	{
		if (!TavernConstructionUI.LBBDNPAGCDE() || !PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.IECFJGHAIDO(ConstructionUI.current.JIIGOACEIKL).GABNNLJOMHI() && !((Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "MineFloor", 1661f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				HEAOCPMDJJE(1);
				break;
			case TavernFloor.Cellar | TavernFloor.FirstFloor:
				KAGELMPBJDO(3);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "LE_11", 1129f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.None:
				KAGELMPBJDO(1);
				break;
			case TavernFloor.Cellar | TavernFloor.FirstFloor:
				EMGIBIHICOO(8);
				break;
			}
		}
	}

	private void PDAFINABOBC()
	{
		if (TavernConstructionUI.OJBKLPONLAH())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void KLHIMJFCHPD()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void HEAOCPMDJJE(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).FLCGEKBIMIK = 350f;
			PFMPGJGANKO(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.DKAICNMJIJH(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	public void NACJFKEKJMP(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.KGJOKHEBLOJ() || BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).BCLDAIFAFKP(1434f);
			PFMPGJGANKO(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.MJNAGHKCDEI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	public void PFMPGJGANKO(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.PABJKGJJHFG())
		{
			OJKFPCPGMIN(0, BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag(TavernFloor.None));
			BBFEFEPCHKE(1, BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag(TavernFloor.FirstFloor));
			HCIDINIPLJO(7, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.None));
		}
		else
		{
			NJFNGKKAOMM(0, NCLCPJJOGKN: false);
			OJKFPCPGMIN(1, NCLCPJJOGKN: false);
			NJFNGKKAOMM(4, NCLCPJJOGKN: true);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().cellarPos;
			break;
		case TavernFloor.FirstFloor:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.CFAMKBHIGLO().firstFloorPos;
			break;
		case TavernFloor.SecondFloor:
			((Behaviour)backgrounds[7]).enabled = false;
			((TMP_Text)floorTextMesh).text = 0.ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	private void ELHCBGCEJDH()
	{
		if (!TavernConstructionUI.NIHAGDNNENF() || !PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.EKLMFMKPEBB(ConstructionUI.current.JIIGOACEIKL).MDOKKKHKKKE() && !((Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Generating new trends ", 1592f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				KAGELMPBJDO(6);
				break;
			case TavernFloor.AllTavernFloors:
				KAGELMPBJDO(6);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "No se encontró una entrada con ID {0} en la conversación '{1}'.", 224f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.AllTavernFloors:
				PKFNJGLAJNC(1);
				break;
			case TavernFloor.FirstFloor:
				CABBEPJAHFA(2);
				break;
			}
		}
	}

	public void MDKBIIHIOON(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).FLCGEKBIMIK = 1615f;
			AGBMOOCJFNE(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.AACNDMPICFG(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	public void NIJBDBOAMEL(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.PABJKGJJHFG())
		{
			HCIDINIPLJO(0, BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag(TavernFloor.None));
			GOLHJOEJGJO(0, BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag(TavernFloor.None));
			HFJJFGDKKOF(2, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.FirstFloor | TavernFloor.SecondFloor));
		}
		else
		{
			OJKFPCPGMIN(0, NCLCPJJOGKN: false);
			GOLHJOEJGJO(0, NCLCPJJOGKN: true);
			BBFEFEPCHKE(8, NCLCPJJOGKN: false);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[0]).enabled = false;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.CFAMKBHIGLO().cellarPos;
			break;
		case TavernFloor.FirstFloor:
			((Behaviour)backgrounds[1]).enabled = false;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.FAOPFMBMMJJ().firstFloorPos;
			break;
		case TavernFloor.SecondFloor:
			((Behaviour)backgrounds[6]).enabled = false;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.CKDKHMPHENE().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	public void DMPJJBIEKPA(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.PABJKGJJHFG() || BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).FLCGEKBIMIK = 1608f;
			NLNLGDEAFOO(AJONCPPJIBP: false);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.GEGOEAMGDEE(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	private void DNAMDIHOOKN()
	{
		if (TavernConstructionUI.KOKDBLGCOPJ())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void HINGECEDJAP()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void ODFONEGPHKE(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = false;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = false;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	[SpecialName]
	public TavernFloor CPOCGMOJCEL()
	{
		return LKOFIKKFNMC;
	}

	private void EBPAMIHFCBG()
	{
		if (TavernConstructionUI.PGKBDDJMEEK())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	public void KAGELMPBJDO(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.KGJOKHEBLOJ() || BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).ALICKGBCJOE(1896f);
			NHLLIJACJEI(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.PNLDBADHHMI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	[SpecialName]
	public TavernFloor MEIHKHCALIP()
	{
		return LKOFIKKFNMC;
	}

	private void CKCHKHNBBFG()
	{
		if (!TavernConstructionUI.KOKDBLGCOPJ() || !PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.FIHGMLABOBB(ConstructionUI.current.JIIGOACEIKL).DBAEGBDEPFK() && !((Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Care", 1582f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.None:
				MDKBIIHIOON(7);
				break;
			case TavernFloor.Cellar:
				OBCLNPFNAHN(8);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Customise Character", 1591f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar | TavernFloor.SecondFloor:
				EMGIBIHICOO(0);
				break;
			case TavernFloor.SecondFloor:
				PKFNJGLAJNC(3);
				break;
			}
		}
	}

	private void CEOEHODJAJK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void AGBMOOCJFNE(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			NJFNGKKAOMM(1, BuildingTutorialManager.GMANLOEOFDB().floorsAvailable.HasFlag(TavernFloor.Cellar));
			BBFEFEPCHKE(0, BuildingTutorialManager.MAPABOKDNEC().floorsAvailable.HasFlag(TavernFloor.FirstFloor));
			NJFNGKKAOMM(7, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.Cellar | TavernFloor.FirstFloor));
		}
		else
		{
			BBFEFEPCHKE(0, NCLCPJJOGKN: true);
			GOLHJOEJGJO(0, NCLCPJJOGKN: true);
			OJKFPCPGMIN(2, NCLCPJJOGKN: true);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[1]).enabled = false;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.CKDKHMPHENE().cellarPos;
			break;
		case TavernFloor.FirstFloor:
			((Behaviour)backgrounds[1]).enabled = false;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.FAOPFMBMMJJ().firstFloorPos;
			break;
		case TavernFloor.SecondFloor:
			((Behaviour)backgrounds[5]).enabled = false;
			((TMP_Text)floorTextMesh).text = 0.ToString();
			OFBKCHILNIP = SceneReferences.CFAMKBHIGLO().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	public Image OMDOKPODMEB()
	{
		return ((Component)this).GetComponent<Image>();
	}

	[SpecialName]
	public static ConstructionFloors DOIKFJDLKJP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionFloors>();
		}
		return IADEMLIIDPC;
	}

	public Image GetOutlineImage()
	{
		return ((Component)this).GetComponent<Image>();
	}

	private void HIPNEFOEJPL()
	{
		if (!TavernConstructionUI.BHKOPGENIFB() || !PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.NPANPNIDKDG(ConstructionUI.current.JIIGOACEIKL).MDOKKKHKKKE() && !((Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Error_CloseMenus", 1969f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				SetFloor(7);
				break;
			case (TavernFloor)8:
				IGNENLODDII(5);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Comfort", 943f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.None:
				CNDNFJMKJDL(0);
				break;
			case (TavernFloor)8:
				EMGIBIHICOO(1);
				break;
			}
		}
	}

	private void JAKILILIBIM()
	{
		if (TavernConstructionUI.FIAGBFIKDFA())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	public void UpdateFloor(bool AJONCPPJIBP)
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		if (BuildingTutorialManager.IKNOJDMCFOK)
		{
			BBFEFEPCHKE(0, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.Cellar));
			BBFEFEPCHKE(1, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.FirstFloor));
			BBFEFEPCHKE(2, BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag(TavernFloor.SecondFloor));
		}
		else
		{
			BBFEFEPCHKE(0, NCLCPJJOGKN: true);
			BBFEFEPCHKE(1, NCLCPJJOGKN: true);
			BBFEFEPCHKE(2, NCLCPJJOGKN: true);
		}
		switch (LKOFIKKFNMC)
		{
		case TavernFloor.Cellar:
			((Behaviour)backgrounds[0]).enabled = true;
			((TMP_Text)floorTextMesh).text = (-1).ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().cellarPos;
			break;
		case TavernFloor.FirstFloor:
			((Behaviour)backgrounds[1]).enabled = true;
			((TMP_Text)floorTextMesh).text = 0.ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().firstFloorPos;
			break;
		case TavernFloor.SecondFloor:
			((Behaviour)backgrounds[2]).enabled = true;
			((TMP_Text)floorTextMesh).text = 1.ToString();
			OFBKCHILNIP = SceneReferences.GetSceneReferences().secondFloorPos;
			break;
		}
		if (AJONCPPJIBP && (Object)(object)cameraController != (Object)null && (Object)(object)((Component)cameraController).transform != (Object)null && (Object)(object)OFBKCHILNIP != (Object)null && (Object)(object)((Component)OFBKCHILNIP).transform != (Object)null)
		{
			((Component)cameraController).transform.position = OFBKCHILNIP.position;
		}
	}

	private void NJFNGKKAOMM(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	public void PKFNJGLAJNC(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.IKNOJDMCFOK || BuildingTutorialManager.CPJBNDOMLGL.floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).ALICKGBCJOE(1935f);
			UpdateFloor(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.MJNAGHKCDEI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	private void OJKFPCPGMIN(int MOFKEDGAOEE, bool NCLCPJJOGKN)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		((Selectable)buttons[MOFKEDGAOEE]).interactable = NCLCPJJOGKN;
		if (NCLCPJJOGKN)
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = false;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.white;
		}
		else
		{
			((Behaviour)backgrounds[MOFKEDGAOEE]).enabled = true;
			((Graphic)backgrounds[MOFKEDGAOEE]).color = Color.black;
		}
	}

	public void CABBEPJAHFA(int GJMIPIKKAAI)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!BuildingTutorialManager.KGJOKHEBLOJ() || BuildingTutorialManager.AEDLFNJPABE().floorsAvailable.HasFlag((TavernFloor)GJMIPIKKAAI))
		{
			LKOFIKKFNMC = (TavernFloor)GJMIPIKKAAI;
			CursorManager.CMDGPJEIIJI(ConstructionUI.current.JIIGOACEIKL).ALICKGBCJOE(1129f);
			UpdateFloor(AJONCPPJIBP: true);
			OnFloorChanged(LKOFIKKFNMC);
			CursorManager.MJNAGHKCDEI(ConstructionUI.current.JIIGOACEIKL, ((Component)cameraController).transform.position);
		}
	}

	private void Update()
	{
		if (!TavernConstructionUI.IsWindowOpen() || !PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH && !((Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Up"))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				SetFloor(2);
				break;
			case TavernFloor.FirstFloor:
				SetFloor(4);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Down"))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.FirstFloor:
				SetFloor(1);
				break;
			case TavernFloor.SecondFloor:
				SetFloor(2);
				break;
			}
		}
	}

	private void CHDGJHNBNEJ()
	{
		if (TavernConstructionUI.PGKBDDJMEEK())
		{
			MLGAAIFPNHD = LKOFIKKFNMC;
		}
	}

	private void KFDMANOLOAB()
	{
		if (!TavernConstructionUI.NIHAGDNNENF() || !PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) || (DecorationMode.BGINAIDHDOM(ConstructionUI.current.JIIGOACEIKL).GABNNLJOMHI() && !((Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "Scratch", 1235f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.Cellar:
				CNDNFJMKJDL(3);
				break;
			case TavernFloor.Cellar | TavernFloor.SecondFloor:
				MDKBIIHIOON(0);
				break;
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, " set to value ", 1314f))
		{
			switch (LKOFIKKFNMC)
			{
			case TavernFloor.None:
				CABBEPJAHFA(0);
				break;
			case TavernFloor.Cellar | TavernFloor.FirstFloor:
				KAGELMPBJDO(5);
				break;
			}
		}
	}
}
