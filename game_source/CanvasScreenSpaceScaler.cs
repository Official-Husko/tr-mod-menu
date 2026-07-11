using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Canvas))]
public class CanvasScreenSpaceScaler : MonoBehaviour
{
	private Canvas BJPJKLLJAIA;

	private PixelPerfectCamera MIBOLKMCJDM;

	private bool EEDGMFLBODE;

	private void CMDBLLMEBLG()
	{
		GGDBBJPJLFD(BBHEMAPJGJM: true);
	}

	private void ALJGEMAFODP()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 1487f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void PILMJDKNBOI()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 993f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void DPODGILNJGC(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 0)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Run" + ((object)(RenderMode)(ref renderMode)).ToString() + " - "));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Items/item_description_654");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			PCBBLGAEHHG();
		}
	}

	private void CMDHELEDLBP()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			GBDLMLNPAPM(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			BHPEIMJLIDF();
		}
	}

	private void JDDJFLGAIOB()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 1571f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void ENPJHFLIALN(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("City/Carpenters/Oak/Bark/Stand" + ((object)(RenderMode)(ref renderMode)).ToString() + "Items/item_description_733"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"City/Petra/Bark/Buy");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			JEBHMJCHAFE();
		}
	}

	private void MMLENKDBIIE(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 0)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Close" + ((object)(RenderMode)(ref renderMode)).ToString() + "ReceiveChessPillarPuzzle"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Dialogue System/Conversation/BirdPositiveComments/Entry/1/Dialogue Text");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			ALJGEMAFODP();
		}
	}

	private void PKEPBKHEDOD()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			BEHINEPGPBO(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			JDDJFLGAIOB();
		}
	}

	private void BHPEIMJLIDF()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 1272f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void NJCLFMHFNJH()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 293f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			HMKBJLJFNKD(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			BHPEIMJLIDF();
		}
	}

	private void CIIBBCPIOIP()
	{
		GBDLMLNPAPM(BBHEMAPJGJM: false);
	}

	private void MCLAJGDIIBK()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			HMKBJLJFNKD(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			JEBHMJCHAFE();
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			HJCOAJEIABK(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PFKBOFCDABE();
		}
	}

	private void GGDBBJPJLFD(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("DecorationTile_8" + ((object)(RenderMode)(ref renderMode)).ToString() + "RecieveOldMansDuelEndLaughAndMove"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"\n");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			CEEDDFCBCNG();
		}
	}

	private void IJILOIAOKBF()
	{
		CPFDLKMCBCB(BBHEMAPJGJM: true);
	}

	private void CEEDDFCBCNG()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 308f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void LCJCGFNFBBD()
	{
		GBDLMLNPAPM(BBHEMAPJGJM: true);
	}

	private void IGKPEBGHPGD()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			OIHIJONNOBF(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			ALJGEMAFODP();
		}
	}

	private void JIBHLLJGGEN()
	{
		DPODGILNJGC(BBHEMAPJGJM: false);
	}

	private void FDHMOEDMPNG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			BEHINEPGPBO(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PILMJDKNBOI();
		}
	}

	private void HJCOAJEIABK(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Cat" + ((object)(RenderMode)(ref renderMode)).ToString() + "<size="));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"KeyItemFishedRPC");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PFOOOEOKMAC();
		}
	}

	private void DDDLBOBPBHB(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 0)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Received Request begin minigame" + ((object)(RenderMode)(ref renderMode)).ToString() + "DualShock"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Small room ");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			JEBHMJCHAFE();
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			CPFDLKMCBCB(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PILMJDKNBOI();
		}
	}

	private void GANHKNLABHO(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)(" for reason " + ((object)(RenderMode)(ref renderMode)).ToString() + "set Start-Intensity: "));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Hiding Keyboard ");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			CEEDDFCBCNG();
		}
	}

	private void PFKBOFCDABE()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 0f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void HJKONJICGML()
	{
		MMLENKDBIIE(BBHEMAPJGJM: false);
	}

	private void BEHINEPGPBO(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Y" + ((object)(RenderMode)(ref renderMode)).ToString() + "Unaged Parmesan"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"SatisfiedCustomers");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			JDDJFLGAIOB();
		}
	}

	private void AMHGMJDKONK()
	{
		GBDLMLNPAPM(BBHEMAPJGJM: false);
	}

	private void JEBHMJCHAFE()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 862f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void LEDIGKGAFHC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			BEHINEPGPBO(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PILMJDKNBOI();
		}
	}

	private void OCIHCODJBGC()
	{
		DDDLBOBPBHB(BBHEMAPJGJM: false);
	}

	private void JEMFMIHMAOI(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("LE_9" + ((object)(RenderMode)(ref renderMode)).ToString() + "Lose"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"F2");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PFKBOFCDABE();
		}
	}

	private void OIHIJONNOBF(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("quest_name_25" + ((object)(RenderMode)(ref renderMode)).ToString() + "Pull beer"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Received RPC SetTrigger {0} on {1}. Setting animator parameter.");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			ALJGEMAFODP();
		}
	}

	private void IAICCKPOBMJ()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			ENPJHFLIALN(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			BHPEIMJLIDF();
		}
	}

	private void DKNMGFDFLKL()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			GBDLMLNPAPM(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			CEEDDFCBCNG();
		}
	}

	private void Update()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			CPFDLKMCBCB(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PFKBOFCDABE();
		}
	}

	private void KHNBDGDLMIE()
	{
		JEMFMIHMAOI(BBHEMAPJGJM: false);
	}

	private void OGBGFLMKFHH()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			BEHINEPGPBO(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			CEEDDFCBCNG();
		}
	}

	private void CPFDLKMCBCB(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Render mode: " + ((object)(RenderMode)(ref renderMode)).ToString() + " is not supported by CanvasScreenSpaceScaler"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"You have to use the PixelPerfectCamera script on the canvas' render camera!");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PFKBOFCDABE();
		}
	}

	private void GBDLMLNPAPM(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("Miners dispute done, but not hot bath, setting miners in camp" + ((object)(RenderMode)(ref renderMode)).ToString() + "descWardrobe"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"KyrohNPC: Selected order with already ingredients in bento: ");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			PFKBOFCDABE();
		}
	}

	private void JMDOCHBJGKG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			ENPJHFLIALN(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			ALJGEMAFODP();
		}
	}

	private void PCBBLGAEHHG()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 1388f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void NEPDNLPCCON()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			DDDLBOBPBHB(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PFOOOEOKMAC();
		}
	}

	private void HMKBJLJFNKD(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			if (BBHEMAPJGJM)
			{
				RenderMode renderMode = BJPJKLLJAIA.renderMode;
				Debug.Log((object)("SalonDelTrono/LucenTalk" + ((object)(RenderMode)(ref renderMode)).ToString() + "ObjectVerticalMove"));
			}
			return;
		}
		Camera worldCamera = ((Component)this).GetComponent<Canvas>().worldCamera;
		MIBOLKMCJDM = ((Component)worldCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"]");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PFKBOFCDABE();
		}
	}

	private void AGFLPEOOEAM()
	{
		DPODGILNJGC(BBHEMAPJGJM: true);
	}

	private void OnEnable()
	{
		CPFDLKMCBCB(BBHEMAPJGJM: true);
	}

	private void PFOOOEOKMAC()
	{
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.ratio != 264f)
		{
			BJPJKLLJAIA.scaleFactor = MIBOLKMCJDM.ratio;
		}
	}

	private void EBFJOAEJPGE()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			GBDLMLNPAPM(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			NJCLFMHFNJH();
		}
	}

	private void HAJJALABMOC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		if (!EEDGMFLBODE)
		{
			BEHINEPGPBO(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && BJPJKLLJAIA.scaleFactor != MIBOLKMCJDM.ratio)
		{
			PCBBLGAEHHG();
		}
	}

	private void OJLGOCFKLJE()
	{
		OIHIJONNOBF(BBHEMAPJGJM: true);
	}

	private void CJDJDDNCNDJ()
	{
		DPODGILNJGC(BBHEMAPJGJM: false);
	}

	private void DCCJBKGNAOP()
	{
		HJCOAJEIABK(BBHEMAPJGJM: true);
	}

	private void BJOOCKCBPLJ()
	{
		DPODGILNJGC(BBHEMAPJGJM: false);
	}
}
