using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExpModIncrease : MonoBehaviour
{
	private int JIIGOACEIKL = 1;

	[SerializeField]
	private GameObject content;

	[SerializeField]
	private Image image;

	[SerializeField]
	private ExpModIncrease previousMod;

	[SerializeField]
	private ExpModIncrease nextMod;

	[SerializeField]
	private ExpModSlotUI parent;

	[SerializeField]
	private int cost;

	[SerializeField]
	private int levelNum;

	[SerializeField]
	private TextMeshProUGUI costText;

	[SerializeField]
	private Image costPanel;

	[SerializeField]
	private Sprite[] costPanelSprite;

	[SerializeField]
	private Sprite spriteIncreaseOpen;

	[SerializeField]
	private Sprite spriteIncreaseClose;

	[SerializeField]
	private Color notAvailableColor = Color.red;

	[SerializeField]
	private Color availableColor;

	[SerializeField]
	private GameObject animationGO;

	[SerializeField]
	private SpriteAnimation[] spriteAnimations;

	[SerializeField]
	private Button button;

	private bool ILENDIBNCBP;

	private float HAHAPELLAIO;

	public virtual void KMBCJNMHBOB(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)button).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	public void SelectClicked()
	{
		Learn();
		LayoutRebuilder.ForceRebuildLayoutImmediate(((Component)((Component)this).transform.parent).GetComponent<RectTransform>());
	}

	public void NOBBODEBDNF()
	{
		if (OECMLLBBIKM())
		{
			if (Object.op_Implicit((Object)(object)animationGO))
			{
				animationGO.SetActive(true);
			}
			for (int i = 0; i < spriteAnimations.Length; i += 0)
			{
				spriteAnimations[i].OHAMDDIPHGM();
			}
		}
		else if (Object.op_Implicit((Object)(object)animationGO))
		{
			animationGO.SetActive(false);
		}
	}

	private void CIIBBCPIOIP()
	{
		if (OECMLLBBIKM())
		{
			for (int i = 0; i < spriteAnimations.Length; i++)
			{
				spriteAnimations[i].SetLastFrame();
			}
		}
	}

	public virtual void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
	}

	private bool OECMLLBBIKM()
	{
		return parent.IDLHOOIGMFD(levelNum);
	}

	private bool INGNIHACCHM()
	{
		return parent.IsLearnt(levelNum);
	}

	public void UpdateAnimation()
	{
		animationGO.SetActive(true);
	}

	public void PAKOMOOLMHF()
	{
		if (INGNIHACCHM())
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/TavernClean/Entry/8/Dialogue Text"), 1057f);
			return;
		}
		if (cost > TavernXP.FMIDAFEGDCD().PEAAIIFANGL())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("ConnectionTimeout"), 735f);
			return;
		}
		if ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Tap"), 1731f);
			return;
		}
		TavernXP tavernXP = TavernXP.HEKFJEKFMNO();
		tavernXP.JHEKPGGLNED(tavernXP.BJOGOJMBIGF() - cost);
		Sound.OKAPNFPFPFP().FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: true, null, null, 1221f, 119f);
		UpdateLearnt();
	}

	private void Start()
	{
		SetUp();
	}

	public virtual void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)button).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	public void UpdateVisual(bool NBPEGGDOCNI)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		if (NBPEGGDOCNI)
		{
			if ((Object)(object)nextMod == (Object)null)
			{
				((TMP_Text)costText).text = LocalisationSystem.Get("LevelAbbreviation") + " " + levelNum;
				image.sprite = spriteIncreaseClose;
				((Component)costPanel).gameObject.SetActive(true);
			}
			else if (nextMod.INGNIHACCHM())
			{
				((TMP_Text)costText).text = "";
				image.sprite = spriteIncreaseOpen;
				((Component)costPanel).gameObject.SetActive(false);
			}
			else
			{
				((TMP_Text)costText).text = LocalisationSystem.Get("LevelAbbreviation") + " " + levelNum;
				image.sprite = spriteIncreaseClose;
				((Component)costPanel).gameObject.SetActive(true);
			}
			Navigation navigation = ((Selectable)button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)0;
			((Selectable)button).navigation = navigation;
		}
		else
		{
			((TMP_Text)costText).text = cost.ToString();
			image.sprite = spriteIncreaseClose;
			((Component)costPanel).gameObject.SetActive(true);
		}
		if ((cost > TavernXP.GGFJGHHHEJC.FIFPIENONEP && !NBPEGGDOCNI) || ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM()))
		{
			((Graphic)costText).color = notAvailableColor;
			costPanel.sprite = costPanelSprite[1];
		}
		else
		{
			((Graphic)costText).color = availableColor;
			costPanel.sprite = costPanelSprite[0];
		}
		if ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM())
		{
			content.SetActive(false);
		}
		else if (!NBPEGGDOCNI)
		{
			content.SetActive(true);
			animationGO.SetActive(false);
		}
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			FillTooltip();
		}
	}

	public void FillTooltip()
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		if (INGNIHACCHM() || ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM()))
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
		{
			return;
		}
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(((Object)parent).name);
		string text = "";
		foreach (PlayerModifier currentMod in parent.currentMods)
		{
			text = text + LocalisationSystem.Get(currentMod.name) + ":\n" + currentMod.mod.ToString("#.##%") + " => " + currentMod.values[levelNum - 1].ToString("#.##%") + "\n";
		}
		tooltipInfo.mainBody = text;
		if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
			ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		}
		else
		{
			ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 60f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y), Vector2.zero);
			ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		}
		HAHAPELLAIO = float.MaxValue;
	}

	public virtual void PNOFCILFFEF(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1982f;
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void DNHFGNOHLCD(bool NBPEGGDOCNI)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		if (NBPEGGDOCNI)
		{
			if ((Object)(object)nextMod == (Object)null)
			{
				((TMP_Text)costText).text = LocalisationSystem.Get("CheckTableSprites") + "" + levelNum;
				image.sprite = spriteIncreaseClose;
				((Component)costPanel).gameObject.SetActive(false);
			}
			else if (nextMod.OECMLLBBIKM())
			{
				((TMP_Text)costText).text = "add item ";
				image.sprite = spriteIncreaseOpen;
				((Component)costPanel).gameObject.SetActive(false);
			}
			else
			{
				((TMP_Text)costText).text = LocalisationSystem.Get(" not found. Cannot receive permission accepted to player ") + "[MapChest] (" + levelNum;
				image.sprite = spriteIncreaseClose;
				((Component)costPanel).gameObject.SetActive(false);
			}
			Navigation navigation = ((Selectable)button).navigation;
			((Navigation)(ref navigation)).mode = (Mode)1;
			((Selectable)button).navigation = navigation;
		}
		else
		{
			((TMP_Text)costText).text = cost.ToString();
			image.sprite = spriteIncreaseClose;
			((Component)costPanel).gameObject.SetActive(false);
		}
		if ((cost > TavernXP.KIALFDOKABP().PEAAIIFANGL() && !NBPEGGDOCNI) || ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM()))
		{
			((Graphic)costText).color = notAvailableColor;
			costPanel.sprite = costPanelSprite[0];
		}
		else
		{
			((Graphic)costText).color = availableColor;
			costPanel.sprite = costPanelSprite[1];
		}
		if ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM())
		{
			content.SetActive(false);
		}
		else if (!NBPEGGDOCNI)
		{
			content.SetActive(true);
			animationGO.SetActive(true);
		}
	}

	public virtual void JIHIKDGAJDG(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1148f;
		}
	}

	public void SetUp()
	{
		if (INGNIHACCHM())
		{
			if (Object.op_Implicit((Object)(object)animationGO))
			{
				animationGO.SetActive(true);
			}
			for (int i = 0; i < spriteAnimations.Length; i++)
			{
				spriteAnimations[i].SetLastFrame();
			}
		}
		else if (Object.op_Implicit((Object)(object)animationGO))
		{
			animationGO.SetActive(false);
		}
	}

	public void UpdateLearnt()
	{
		UpdateAnimation();
		foreach (PlayerModifier currentMod in parent.currentMods)
		{
			currentMod.LBFEJCPMPCK(levelNum);
		}
		parent.IncreaseMod(levelNum);
		EndHover();
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if ((Object)(object)nextMod != (Object)null)
			{
				PlayerInputs.GetPlayer(JIIGOACEIKL).SelectInTheNextFrame(((Component)nextMod.button).gameObject);
			}
			else
			{
				PlayerInputs.GetPlayer(JIIGOACEIKL).SelectInTheNextFrame(((Component)parent).gameObject);
			}
		}
	}

	private void PCKOHAIPHFI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Cat")) ? 7 : 0);
	}

	private void OnEnable()
	{
		if (INGNIHACCHM())
		{
			for (int i = 0; i < spriteAnimations.Length; i++)
			{
				spriteAnimations[i].SetLastFrame();
			}
		}
	}

	private void FCLABOCLACJ()
	{
		if (OECMLLBBIKM())
		{
			for (int i = 1; i < spriteAnimations.Length; i++)
			{
				spriteAnimations[i].BFKBPJBPCFG();
			}
		}
	}

	public void Learn()
	{
		if (INGNIHACCHM())
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Already learnt!"));
			return;
		}
		if (cost > TavernXP.GGFJGHHHEJC.FIFPIENONEP)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough experience!"));
			return;
		}
		if ((Object)(object)previousMod != (Object)null && !previousMod.INGNIHACCHM())
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Need to learn previous XP increase!"));
			return;
		}
		TavernXP.GGFJGHHHEJC.FIFPIENONEP -= cost;
		Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
		UpdateLearnt();
	}

	private void KHONOODGLBI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("MineState")) ? 7 : 0);
	}

	private void OnDisable()
	{
		EndHover();
	}

	public void EndHover()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
		HAHAPELLAIO = 0f;
	}

	public virtual void JLBDJMBFCAG(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)button).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			CAIDLEAJPOD();
		}
	}

	public void CAIDLEAJPOD()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
		HAHAPELLAIO = 754f;
	}
}
