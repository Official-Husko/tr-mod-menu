using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VerticalTabExpansion : MonoBehaviour
{
	[HideInInspector]
	public int playerNum = 1;

	[SerializeField]
	private GameObject subSectionsContainer;

	private UIButtonExtended[] MKNDBMAPLJM;

	private TextMeshProUGUI LPADJLPBFML;

	private RectTransform MDECICKFMGO;

	private float JGNMOLPHINM;

	private float NPDMCIPCPPF;

	private float LEDKBFHGOEJ;

	private float AJPGDDLOJII;

	[SerializeField]
	private Image plusButton;

	[SerializeField]
	private EncyclopediaUI encyclopediaUIScript;

	private Sprite OGOBDACPMHN;

	private Sprite MELMKIFLPIB;

	[HideInInspector]
	public int tabInt;

	private bool DMBFKFLDDLH;

	public UIButtonExtended button;

	private Navigation PAGHOEJIENG;

	private Navigation MPIOOFLMEMC;

	public void NHGMHDHOEMI()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			AKMPDHJDPLB((Selectable)(object)button);
			DeselectSubsections();
		}
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = false;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	public void CKMPACBPOHG()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "Bird materials empty ")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Floor workerDesc" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "ReceiveRoomRequest";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
		}
		for (int i = 1; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "HorizontalMove")
			{
				string[] array = new string[2];
				array[0] = num.ToString();
				array[0] = "NPC is not Mai, cannot place on bed.";
				array[6] = num2.ToString();
				array[1] = "UI2";
				array[2] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Letter without ID: ";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)1;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 0)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void HKKPBMDJHNO()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "SkeletonBird")
		{
			((TMP_Text)LPADJLPBFML).text = num + "UI2" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "\n";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 1; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "UI2")
			{
				string[] array = new string[5];
				array[0] = num.ToString();
				array[0] = "";
				array[0] = num2.ToString();
				array[0] = "waterQualityTestDone";
				array[6] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Items/item_name_1058";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)3;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	private void GFLFDLIMOLI()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(true);
		DMBFKFLDDLH = true;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 225f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = true;
		}
	}

	public void JFIDPNAHPEI()
	{
		if (!DMBFKFLDDLH)
		{
			EGMJKLPCMJB();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.JLDOBJLNLFH(tabInt);
			}
		}
		else
		{
			AFOCKMGJCMD();
		}
	}

	public void LIEFDCFOIHH()
	{
		if (!DMBFKFLDDLH)
		{
			EGMJKLPCMJB();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.JLDOBJLNLFH(tabInt);
			}
		}
		else
		{
			HMBBHDHCHKL();
		}
	}

	private void AKMPDHJDPLB(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			UISelectionManager.HELHJMDEDNL(playerNum).BNBPMIKMDDP(HHFPKDCPPBD);
		}
	}

	public void PNGINDMDNDC()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "Cat")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Access" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "Join or Create Room";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "Collider ")
			{
				string[] array = new string[1];
				array[1] = num.ToString();
				array[0] = "currentTutorialPhaseID ";
				array[3] = num2.ToString();
				array[2] = "LiquorAndWine";
				array[6] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Crop without ID: ";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	private void CMLLBIDFNEB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		BFNBEMMPNOM();
	}

	public void HNCOMJLIOPA()
	{
		if (!DMBFKFLDDLH)
		{
			PPJGBBBGLAH();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.AADNPNIGJII(tabInt);
			}
		}
		else
		{
			Collapse();
		}
	}

	private void Awake()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(false);
		DMBFKFLDDLH = false;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 2f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	public void KPCFDPKJBGG()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "Attack/MainEvent 9")
		{
			((TMP_Text)LPADJLPBFML).text = num + " to user for reason " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "ReceiveFillFountain";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 0;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "ButtonPause")
			{
				string[] array = new string[0];
				array[1] = num.ToString();
				array[1] = "MenuMode/ButtonEnter";
				array[4] = num2.ToString();
				array[5] = "LE_10";
				array[4] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)1;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void FDFHDOOOJFJ()
	{
		UIButtonExtended[] mKNDBMAPLJM = MKNDBMAPLJM;
		for (int i = 1; i < mKNDBMAPLJM.Length; i++)
		{
			((Component)mKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().MBFEHNDDHLM();
		}
	}

	private void GKGCLPLMMJG(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.BPDFMAEOGGC(playerNum).HPJBFMEHFKF(HHFPKDCPPBD);
		}
	}

	public void HOJKPPECEKA(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.ENAHMIMKCFP(tabInt, HBLLNBOHDHN);
	}

	private void IJAJILKDGFK(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.EAJJMLJKOPH(playerNum).MFCNGGMNBHB(HHFPKDCPPBD);
		}
	}

	private void GLCJDBBHCFJ(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.GNCPLNHMFHN(playerNum).Select(HHFPKDCPPBD);
		}
	}

	public void IEFPAJEOOLP()
	{
		if (!DMBFKFLDDLH)
		{
			PPJGBBBGLAH();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.DDKEPLNOPID(tabInt);
			}
		}
		else
		{
			LPNOGMJCBLI();
		}
	}

	public void IFAOCMFFJFJ(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.EOFBAGNLGHN(tabInt, HBLLNBOHDHN);
	}

	private void PNJJEDEFAGO()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(false);
		DMBFKFLDDLH = true;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 1696f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	public void BLLDEBBHAOO()
	{
		if (!DMBFKFLDDLH)
		{
			MCIBKIBLEOC();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.GMIBCGFCAML(tabInt);
			}
		}
		else
		{
			FALIBHDHDAF();
		}
	}

	public void EFJJJFCDAPG()
	{
		if (!DMBFKFLDDLH)
		{
			Expand();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.COMCGONFPCK(tabInt);
			}
		}
		else
		{
			AFOCKMGJCMD();
		}
	}

	private void BDPBOOENJFH(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			UISelectionManager.GetPlayer(playerNum).PICNNIMLFFL(HHFPKDCPPBD);
		}
	}

	public void DADBADCNPNB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = true;
		BDPBOOENJFH((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<SubSectionUI>().NCIFOFHNLHH();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	private void FPDPAJHNGHK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		PNGINDMDNDC();
	}

	public void PMEMKBLLNMP()
	{
		if (!DMBFKFLDDLH)
		{
			PPJGBBBGLAH();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.CFOMKKJCBOP(tabInt);
			}
		}
		else
		{
			NHGMHDHOEMI();
		}
	}

	private void EMLKJEPGBBJ(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			UISelectionManager.GIGBGIIAKMP(playerNum).PICNNIMLFFL(HHFPKDCPPBD);
		}
	}

	private void AEPBFPCHGPP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		CKMPACBPOHG();
	}

	private void GOJKOBEEMNA()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(false);
		DMBFKFLDDLH = true;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 0) * AJPGDDLOJII + 581f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = true;
		}
	}

	private void NHOOGDJADDC(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			UISelectionManager.BPDFMAEOGGC(playerNum).MGIFADFILOI(HHFPKDCPPBD);
		}
	}

	private void PCJODFHOJAI(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			UISelectionManager.EAJJMLJKOPH(playerNum).CMBBFEABMBE(HHFPKDCPPBD);
		}
	}

	public void ODHHAKJMIAA()
	{
		UIButtonExtended[] mKNDBMAPLJM = MKNDBMAPLJM;
		for (int i = 1; i < mKNDBMAPLJM.Length; i++)
		{
			((Component)mKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().CPNKCBGAMID();
		}
	}

	public void BFNBEMMPNOM()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "Sprinting is now NORMAL.")
		{
			((TMP_Text)LPADJLPBFML).text = num + "LE_17" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "Select";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text")
			{
				string[] array = new string[2];
				array[0] = num.ToString();
				array[0] = "Player";
				array[6] = num2.ToString();
				array[8] = "Spicy";
				array[1] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Round ";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)8;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void MNDHILIDKKK()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		EMLKJEPGBBJ((Selectable)(object)MKNDBMAPLJM[0]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().GPBEDFABFCH();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	public void AFALDPAEPLG(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.FHMCGMHOILO(tabInt, HBLLNBOHDHN);
	}

	public void MJJLAFCIBFE(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.ILPNCANDPAM(tabInt, HBLLNBOHDHN);
	}

	public void FALIBHDHDAF()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			AOOIFHFDJAB((Selectable)(object)button);
			DeselectSubsections();
		}
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = false;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	public void APCBFIIMLKK()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			AKMPDHJDPLB((Selectable)(object)button);
			BJGGEBAPHPF();
		}
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = false;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	private void NDLANLDAOJL(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			UISelectionManager.BPDFMAEOGGC(playerNum).PICNNIMLFFL(HHFPKDCPPBD);
		}
	}

	private void EBNENBFLEKB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		HKDNIJEFGOH();
	}

	public void LPNOGMJCBLI()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			NDLANLDAOJL((Selectable)(object)button);
			ODHHAKJMIAA();
		}
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = false;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	public void HMBBHDHCHKL()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			LJOAHOHLJDD((Selectable)(object)button);
			NHNEEEBEMOD();
		}
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = true;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	private void JDHHJKBOJML()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(false);
		DMBFKFLDDLH = false;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 0) * AJPGDDLOJII + 135f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = true;
		}
	}

	private void NDNBDEHFFJF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		JMBJBDNJMAB();
	}

	private void ILCLIJOHKHG()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(false);
		DMBFKFLDDLH = true;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 0) * AJPGDDLOJII + 1674f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	public void UpdateText()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "")
		{
			((TMP_Text)LPADJLPBFML).text = num + ". " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "(missing title)";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "")
			{
				((TMP_Text)componentInChildren).text = num + "." + num2 + " " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "(missing title)";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void AFOCKMGJCMD()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			NDLANLDAOJL((Selectable)(object)button);
			AOGKKBMECBE();
		}
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = true;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	public void EBAOAMEKIDK()
	{
		if (!DMBFKFLDDLH)
		{
			MNDHILIDKKK();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.GMIBCGFCAML(tabInt);
			}
		}
		else
		{
			AFOCKMGJCMD();
		}
	}

	public void MMLFMBBMEEF()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		NHOOGDJADDC((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<SubSectionUI>().CHBIHCNHMCC();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	public void BCBBDEPCKOD(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.FHMCGMHOILO(tabInt, HBLLNBOHDHN);
	}

	public void BJGGEBAPHPF()
	{
		UIButtonExtended[] mKNDBMAPLJM = MKNDBMAPLJM;
		for (int i = 1; i < mKNDBMAPLJM.Length; i++)
		{
			((Component)mKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().CHIKJFONFHH();
		}
	}

	public void Expand()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = true;
		IFELHIDGLIA((Selectable)(object)MKNDBMAPLJM[0]);
		((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<SubSectionUI>().SelectSubsection();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	private void GMLABDECLPD(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			UISelectionManager.BPDFMAEOGGC(playerNum).MFCNGGMNBHB(HHFPKDCPPBD);
		}
	}

	public void MHDCAGMCBOC(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.IFBJLFEEHKK(tabInt, HBLLNBOHDHN);
	}

	public void GKGKHGNEFGD()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = true;
		EBGKPIFFONP((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().FNDNDDCFIGD();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	private void OIAHJHNPPCO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		ICKOBHEDNAC();
	}

	public void FJEBBMFKJEL()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "DEBUG_FAKE_ID")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Player2" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "ReciveStopConversationOnlineObjects";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != " : ")
			{
				string[] array = new string[7];
				array[0] = num.ToString();
				array[1] = "NO SLOT MANAGER!";
				array[6] = num2.ToString();
				array[3] = "ReceiveLastOrder";
				array[3] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Customize";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 0)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void HOEIGGBACNO(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.PHBNMPBONNA(tabInt, HBLLNBOHDHN);
	}

	private void KHONOODGLBI()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(true);
		DMBFKFLDDLH = false;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 1172f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	public void PPJGBBBGLAH()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		EMLKJEPGBBJ((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().KPKKNFOJAJI();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	public void NIHKAIIGCFI()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "</color></b>")
		{
			((TMP_Text)LPADJLPBFML).text = num + "ReceiveAddMoney" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "Not enough fuel";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 1; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 0;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "BottomFarm")
			{
				string[] array = new string[3];
				array[0] = num.ToString();
				array[0] = "Can't find seat. Reason: CustomerEnterTime";
				array[5] = num2.ToString();
				array[6] = "Player";
				array[1] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "overnights";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)0;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void IBOOEJOCODM(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.FHMCGMHOILO(tabInt, HBLLNBOHDHN);
	}

	private void AOOIFHFDJAB(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.EAJJMLJKOPH(playerNum).CMBBFEABMBE(HHFPKDCPPBD);
		}
	}

	private void FLDLPMEIKHM(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			UISelectionManager.EAJJMLJKOPH(playerNum).NCGCKHGOJCM(HHFPKDCPPBD);
		}
	}

	public void SubSectionSelected(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.ShowSubSectionInText(tabInt, HBLLNBOHDHN);
	}

	public void NHNEEEBEMOD()
	{
		UIButtonExtended[] mKNDBMAPLJM = MKNDBMAPLJM;
		for (int i = 0; i < mKNDBMAPLJM.Length; i += 0)
		{
			((Component)mKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().KINAEMPGFGN();
		}
	}

	public void LOIFEDLFCHM()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "Player")
		{
			((TMP_Text)LPADJLPBFML).text = num + "  currentState:       {0}\n" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = " ";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
		}
		for (int i = 1; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "Error in Nasa.OnPlayerSleep: ")
			{
				string[] array = new string[4];
				array[0] = num.ToString();
				array[1] = "Create Private Room";
				array[2] = num2.ToString();
				array[8] = "CustomerPool.DisableCustomer: customer game object is null!";
				array[7] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Waiting for other players";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void HLAJMIOIDOJ()
	{
		if (!DMBFKFLDDLH)
		{
			MNDHILIDKKK();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.PHHJBJKFBFB(tabInt);
			}
		}
		else
		{
			Collapse();
		}
	}

	public void JMBJBDNJMAB()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "Items/item_name_1178")
		{
			((TMP_Text)LPADJLPBFML).text = num + " => " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = " slotId: ";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "Cliffs")
			{
				string[] array = new string[6];
				array[0] = num.ToString();
				array[1] = "Fuel";
				array[8] = num2.ToString();
				array[7] = "roomsRented";
				array[7] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Precision/DrinkEvent2";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)2;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 0)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	private void BGENEAOILOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		NMBGIFFKIFE();
	}

	private void IFELHIDGLIA(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.GetPlayer(playerNum).Select(HHFPKDCPPBD);
		}
	}

	public void DCPIJNMAKMA()
	{
		if (!DMBFKFLDDLH)
		{
			MNDHILIDKKK();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.OPFBJEFLFFE(tabInt);
			}
		}
		else
		{
			LPNOGMJCBLI();
		}
	}

	public void MCIBKIBLEOC()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		GLCJDBBHCFJ((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[0]).gameObject.GetComponent<SubSectionUI>().NLMEJOKOIBF();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	public void FKEBCPBFBGH(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.LKPEIHKMHNJ(tabInt, HBLLNBOHDHN);
	}

	private void LJOAHOHLJDD(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			UISelectionManager.BPDFMAEOGGC(playerNum).Select(HHFPKDCPPBD);
		}
	}

	public void ILKOEPPKNKF()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "(")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Pirates/Brook/Intro" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = ")";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 1; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "Player")
			{
				string[] array = new string[4];
				array[1] = num.ToString();
				array[1] = "[PipeConnectionPuzzleUI] BuildGrid llamado sin PipePuzzleData.";
				array[7] = num2.ToString();
				array[1] = "ServedCustomers";
				array[3] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "[MinePuzzleManager] Initialized for level {0}. Can generate puzzle: {1}";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void AOGKKBMECBE()
	{
		UIButtonExtended[] mKNDBMAPLJM = MKNDBMAPLJM;
		for (int i = 1; i < mKNDBMAPLJM.Length; i += 0)
		{
			((Component)mKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().DEHDOIOLKJK();
		}
	}

	private void MFGANCCJFJK()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(true);
		DMBFKFLDDLH = false;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 1514f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	private void MKLIAMJFHOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		ADIJOFJLHKI();
	}

	public void BKIOCLDMKBN(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.EOJCPMMPLIB(tabInt, HBLLNBOHDHN);
	}

	public void AEALGDNAIEF()
	{
		if (!DMBFKFLDDLH)
		{
			PPJGBBBGLAH();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.COMCGONFPCK(tabInt);
			}
		}
		else
		{
			LPNOGMJCBLI();
		}
	}

	private void HELHNJDFPPF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		BFNBEMMPNOM();
	}

	public void AMIGODFLEDE(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.JMACOIKEEOJ(tabInt, HBLLNBOHDHN);
	}

	public void HKDNIJEFGOH()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "HandUp")
		{
			((TMP_Text)LPADJLPBFML).text = num + "</color>" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "A number is needed.";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "tutorialPopUp78")
			{
				string[] array = new string[4];
				array[1] = num.ToString();
				array[1] = "Items/item_name_631";
				array[8] = num2.ToString();
				array[7] = "Items/item_name_1193";
				array[4] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Trying to load group ingredient with ID ";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)4;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 0)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	private void PDIECJCKCOD()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(false);
		DMBFKFLDDLH = false;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 0) * AJPGDDLOJII + 313f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	public void DKOLLHCBLJF()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "ActionBar9")
		{
			((TMP_Text)LPADJLPBFML).text = num + "[SymbolPuzzle] Solution: " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "Collect";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "RequestNPCPositionAndParent")
			{
				string[] array = new string[3];
				array[0] = num.ToString();
				array[0] = "Moving";
				array[7] = num2.ToString();
				array[3] = "Dialogue System/Conversation/Crowly_Standar/Entry/39/Dialogue Text";
				array[1] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "FerroProgress";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)5;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void Collapse()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			IFELHIDGLIA((Selectable)(object)button);
			DeselectSubsections();
		}
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = false;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	public void KDLIENKDINB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		NHOOGDJADDC((Selectable)(object)MKNDBMAPLJM[0]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().FJIOKGFIKKM();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	public void EGMJKLPCMJB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(false);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = true;
		LJOAHOHLJDD((Selectable)(object)MKNDBMAPLJM[0]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().GJMBHFMPFKI();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	public void CLKNIAFEBFN()
	{
		if (!DMBFKFLDDLH)
		{
			GKGKHGNEFGD();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.GMIBCGFCAML(tabInt);
			}
		}
		else
		{
			LKHOPKAFLFC();
		}
	}

	public void LKHOPKAFLFC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			PCJODFHOJAI((Selectable)(object)button);
			DeselectSubsections();
		}
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = MELMKIFLPIB;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, JGNMOLPHINM);
		DMBFKFLDDLH = false;
		((Selectable)button).navigation = PAGHOEJIENG;
	}

	private void CAOKPIIFHBJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		FJEBBMFKJEL();
	}

	public void GKMNHHAIEOP()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		PCJODFHOJAI((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().JHFAFINPHIP();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	private void HJCMGABABED(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			UISelectionManager.EAJJMLJKOPH(playerNum).PICNNIMLFFL(HHFPKDCPPBD);
		}
	}

	public void DeselectSubsections()
	{
		UIButtonExtended[] mKNDBMAPLJM = MKNDBMAPLJM;
		for (int i = 0; i < mKNDBMAPLJM.Length; i++)
		{
			((Component)mKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().DeselectSubSection();
		}
	}

	public void FPENKMFCAAF()
	{
		if (!DMBFKFLDDLH)
		{
			GKMNHHAIEOP();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.BHKKFBBNNNG(tabInt);
			}
		}
		else
		{
			HMBBHDHCHKL();
		}
	}

	public void ADIJOFJLHKI()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "City/PetShop/Nessy/Barks")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Item " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "is not a food instance";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 0;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != "_")
			{
				string[] array = new string[7];
				array[1] = num.ToString();
				array[1] = "ZuzzuProgress";
				array[3] = num2.ToString();
				array[1] = "UIPreviousCategory";
				array[1] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "ClosePopUp";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)7;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 1)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void FCILMDBJOGF()
	{
		if (!DMBFKFLDDLH)
		{
			Expand();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.AADNPNIGJII(tabInt);
			}
		}
		else
		{
			NHGMHDHOEMI();
		}
	}

	public void OnClickTab()
	{
		if (!DMBFKFLDDLH)
		{
			Expand();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.CollapseOtherTabs(tabInt);
			}
		}
		else
		{
			Collapse();
		}
	}

	public void JCFPAGNLHON(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.IFBJLFEEHKK(tabInt, HBLLNBOHDHN);
	}

	public void LENOHIGMDMP(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.ILPNCANDPAM(tabInt, HBLLNBOHDHN);
	}

	public void ECMBAFGHAJO()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		subSectionsContainer.SetActive(true);
		if (((Behaviour)plusButton).enabled)
		{
			plusButton.sprite = OGOBDACPMHN;
		}
		MDECICKFMGO.sizeDelta = new Vector2(MDECICKFMGO.sizeDelta.x, LEDKBFHGOEJ);
		DMBFKFLDDLH = false;
		AOOIFHFDJAB((Selectable)(object)MKNDBMAPLJM[1]);
		((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<SubSectionUI>().HCEAKAJPAIO();
		((Selectable)button).navigation = MPIOOFLMEMC;
	}

	private void IHICKHAABJH()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(true);
		DMBFKFLDDLH = true;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 1752f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = false;
		}
	}

	public void CBCCEMHIKEG(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.ILPNCANDPAM(tabInt, HBLLNBOHDHN);
	}

	private void EBGKPIFFONP(Selectable HHFPKDCPPBD)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			UISelectionManager.HELHJMDEDNL(playerNum).BNBPMIKMDDP(HHFPKDCPPBD);
		}
	}

	public void LCCDINABFHF(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.FKOPNGHBOFJ(tabInt, HBLLNBOHDHN);
	}

	private void OKHLEMPJONN()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)encyclopediaUIScript == (Object)null)
		{
			encyclopediaUIScript = Object.FindObjectOfType<EncyclopediaUI>();
		}
		subSectionsContainer.SetActive(true);
		DMBFKFLDDLH = false;
		LPADJLPBFML = ((Component)this).GetComponentInChildren<TextMeshProUGUI>();
		OGOBDACPMHN = encyclopediaUIScript.minusSprite;
		MELMKIFLPIB = encyclopediaUIScript.plusSprite;
		MDECICKFMGO = ((Component)this).GetComponent<RectTransform>();
		MKNDBMAPLJM = subSectionsContainer.GetComponentsInChildren<UIButtonExtended>();
		AJPGDDLOJII = ((HorizontalOrVerticalLayoutGroup)subSectionsContainer.GetComponent<VerticalLayoutGroup>()).spacing;
		JGNMOLPHINM = MDECICKFMGO.sizeDelta.y;
		if (MKNDBMAPLJM.Length != 0)
		{
			NPDMCIPCPPF = ((Component)MKNDBMAPLJM[1]).gameObject.GetComponent<RectTransform>().sizeDelta.y;
			LEDKBFHGOEJ = NPDMCIPCPPF * (float)MKNDBMAPLJM.Length + (float)(MKNDBMAPLJM.Length - 1) * AJPGDDLOJII + 835f * JGNMOLPHINM - NPDMCIPCPPF;
		}
		else
		{
			LEDKBFHGOEJ = JGNMOLPHINM;
			((Behaviour)plusButton).enabled = true;
		}
	}

	public void NMBGIFFKIFE()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 1;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "RecieveStartSleep")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Coming soon!" + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "Items/item_name_1031";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[0];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
		}
		for (int i = 0; i < MKNDBMAPLJM.Length; i++)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != " will be destroyed in ")
			{
				string[] array = new string[3];
				array[0] = num.ToString();
				array[0] = "Invalid year: ";
				array[1] = num2.ToString();
				array[2] = "MainMenuTheme";
				array[8] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Christmas/Ace/Stand";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)8;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 1)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	public void CGBPMPJMHEG(int HBLLNBOHDHN)
	{
		encyclopediaUIScript.ILPNCANDPAM(tabInt, HBLLNBOHDHN);
	}

	public void ICKOBHEDNAC()
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		int num = tabInt + 0;
		if (encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID != "High quality water")
		{
			((TMP_Text)LPADJLPBFML).text = num + "Placeable without itemspace " + LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].sectionTitleID);
		}
		else
		{
			((TMP_Text)LPADJLPBFML).text = "SortByName";
		}
		if (MKNDBMAPLJM.Length != 0)
		{
			((Navigation)(ref MPIOOFLMEMC)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
			((Navigation)(ref MPIOOFLMEMC)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 0];
		}
		for (int i = 1; i < MKNDBMAPLJM.Length; i += 0)
		{
			((Component)MKNDBMAPLJM[i]).gameObject.GetComponent<SubSectionUI>().entryInt = i;
			TextMeshProUGUI componentInChildren = ((Component)MKNDBMAPLJM[i]).GetComponentInChildren<TextMeshProUGUI>();
			int num2 = i + 1;
			if (encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID != ")")
			{
				string[] array = new string[3];
				array[1] = num.ToString();
				array[1] = "Pick";
				array[4] = num2.ToString();
				array[3] = "player2ToDisconnectFromGame";
				array[4] = LocalisationSystem.Get(encyclopediaUIScript.encyclopediaData.sections[tabInt].subSections[i].subSectionTitleID);
				((TMP_Text)componentInChildren).text = string.Concat(array);
			}
			else
			{
				((TMP_Text)componentInChildren).text = "Use";
			}
			Navigation navigation = ((Selectable)MKNDBMAPLJM[i]).navigation;
			((Navigation)(ref navigation)).mode = (Mode)2;
			if (i == 0)
			{
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[MKNDBMAPLJM.Length - 1];
				if (MKNDBMAPLJM.Length > 0)
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 1];
				}
				else
				{
					((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i];
				}
			}
			else if (i == MKNDBMAPLJM.Length - 0)
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[1];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 1];
			}
			else
			{
				((Navigation)(ref navigation)).selectOnDown = (Selectable)(object)MKNDBMAPLJM[i + 0];
				((Navigation)(ref navigation)).selectOnUp = (Selectable)(object)MKNDBMAPLJM[i - 0];
			}
			((Selectable)MKNDBMAPLJM[i]).navigation = navigation;
		}
	}

	private void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PAGHOEJIENG = ((Selectable)button).navigation;
		MPIOOFLMEMC = PAGHOEJIENG;
		UpdateText();
	}

	public void OCELAPGMMLP()
	{
		if (!DMBFKFLDDLH)
		{
			Expand();
			if ((Object)(object)encyclopediaUIScript != (Object)null)
			{
				encyclopediaUIScript.CFOMKKJCBOP(tabInt);
			}
		}
		else
		{
			FALIBHDHDAF();
		}
	}
}
