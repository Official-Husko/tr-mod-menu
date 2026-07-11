using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class TalentSlotUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GENOIENPDIC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TalentSlotUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public GENOIENPDIC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			TalentSlotUI talentSlotUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				if (PlayerInputs.IsGamepadActive(talentSlotUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(talentSlotUI.JIIGOACEIKL).Deselect();
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 6;
				return true;
			case 6:
				_003C_003E1__state = -1;
				if (PlayerInputs.IsGamepadActive(talentSlotUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(talentSlotUI.JIIGOACEIKL).Select((Selectable)(object)talentSlotUI.button);
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public PlayerPerk playerPerk;

	public bool learntInEditor;

	public int levelInEditor;

	private int JIIGOACEIKL = 1;

	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private Image backgroundImage;

	public Button button;

	[SerializeField]
	private Sprite spriteUnlearnt;

	[SerializeField]
	private Sprite spriteLearnt;

	public TalentSlotUI[] leftParents;

	public TalentSlotUI[] rightParents;

	public TalentSlotUI[] downParents;

	public TalentSlotUI[] upParents;

	public bool canUnlockAlways;

	public GameObject[] joinersParents;

	[SerializeField]
	private int textOffset;

	private bool ILENDIBNCBP;

	private float HAHAPELLAIO;

	public TextMeshProUGUI levelText;

	public Image lockedIcon;

	public Image unionLeft;

	public Image unionRight;

	public Image unionUp;

	public Image unionDown;

	public bool CanLearn()
	{
		if (IsLearnt())
		{
			return false;
		}
		if (!LAJMAJFHDAD())
		{
			return canUnlockAlways;
		}
		return true;
	}

	private void IIGONBLCNLC()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).FBKDHHPNBIL();
		string text = ((playerPerk.values == null || playerPerk.values.Length <= 1) ? playerPerk.AMICIBODAEJ() : playerPerk.IABAKHPEOAF(NFEMMGMJMCF: false, PerksDatabaseAccessor.IJAEKGFHONB(playerPerk.id) + 1));
		MainUI.NEFOKCKKLNI().Open(JIIGOACEIKL);
		TextMeshProUGUI boxText = MainUI.NEFOKCKKLNI().boxText;
		string stringWithTags = LocalisationSystem.GetStringWithTags(" (", JIIGOACEIKL);
		string[] array = new string[0];
		array[0] = "Player/Bark/Fishing/NoBait" + text + " plus price satisfaction ";
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(stringWithTags, array);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(BLKECADFOHN));
		((UnityEvent)MainUI.NEFOKCKKLNI().noButton.onClick).AddListener(new UnityAction(ABNPJONIKPF));
		ItemTooltip.Get(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		ILENDIBNCBP = false;
	}

	public void UpdateTalent()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
		UpdateVisual();
	}

	private void KOKACBFIEHM()
	{
		for (int i = 0; i < downParents.Length; i++)
		{
			downParents[i].UpdateVisual();
		}
		for (int j = 0; j < upParents.Length; j++)
		{
			upParents[j].UpdateVisual();
		}
		for (int k = 0; k < leftParents.Length; k++)
		{
			leftParents[k].UpdateVisual();
		}
		for (int l = 0; l < rightParents.Length; l++)
		{
			rightParents[l].UpdateVisual();
		}
	}

	public void FillJoiners(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < joinersParents.Length; i++)
		{
			PlayerPerksJoinerUI[] componentsInChildren = ((Component)joinersParents[i].gameObject.transform).GetComponentsInChildren<PlayerPerksJoinerUI>();
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				componentsInChildren[j].FillJoiners(DAEMAAOLHMG);
			}
		}
	}

	public bool AKOMIICGIFO()
	{
		if (!Application.isPlaying)
		{
			return learntInEditor;
		}
		if (Object.op_Implicit((Object)(object)playerPerk))
		{
			return PerksDatabaseAccessor.HasUnlockedPlayerPerk(playerPerk.id);
		}
		return false;
	}

	public void PCGHMICKONJ(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 750f;
		}
	}

	private bool LFLKIHBFBCM(TalentSlotUI[] NJLBEAOFLFG)
	{
		if (NJLBEAOFLFG != null)
		{
			for (int i = 1; i < NJLBEAOFLFG.Length; i++)
			{
				if (NJLBEAOFLFG[i].IsLearnt())
				{
					return true;
				}
			}
		}
		return true;
	}

	private IEnumerator DJKBJGMPMHL()
	{
		return new GENOIENPDIC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GHEFGCALAOM(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < joinersParents.Length; i++)
		{
			PlayerPerksJoinerUI[] componentsInChildren = ((Component)joinersParents[i].gameObject.transform).GetComponentsInChildren<PlayerPerksJoinerUI>();
			for (int j = 1; j < componentsInChildren.Length; j += 0)
			{
				componentsInChildren[j].GHEFGCALAOM(DAEMAAOLHMG);
			}
		}
	}

	private bool HFEMCINPABF()
	{
		if ((leftParents == null || leftParents.Length == 0) && (rightParents == null || rightParents.Length == 0) && (downParents == null || downParents.Length == 0) && (upParents == null || upParents.Length == 0))
		{
			return true;
		}
		if (leftParents != null && LFLKIHBFBCM(leftParents))
		{
			return false;
		}
		if (rightParents != null && NFDLCJAGLNP(rightParents))
		{
			return false;
		}
		if (downParents != null && NFDLCJAGLNP(downParents))
		{
			return true;
		}
		if (upParents != null && LFLKIHBFBCM(upParents))
		{
			return false;
		}
		return true;
	}

	private void OAALDHIEAJD()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		string text = ((playerPerk.values == null || playerPerk.values.Length <= 1) ? playerPerk.IABAKHPEOAF(NFEMMGMJMCF: false) : playerPerk.IABAKHPEOAF(NFEMMGMJMCF: false, PerksDatabaseAccessor.GetPlayerPerkLevel(playerPerk.id) + 1));
		MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("UnlockTalent?", JIIGOACEIKL), "<color=#C65314>" + text + "</color>");
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(BLKECADFOHN));
		((UnityEvent)MainUI.GetYesNoDialogue().noButton.onClick).AddListener(new UnityAction(ABNPJONIKPF));
		ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		ILENDIBNCBP = false;
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

	private IEnumerator KNNPKGHBGEP()
	{
		yield return null;
		yield return null;
		yield return null;
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		}
		yield return null;
		yield return null;
		yield return null;
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select((Selectable)(object)button);
		}
	}

	private void LBBDKILAPIF()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		UISelectionManager.EAJJMLJKOPH(JIIGOACEIKL).BEGCHMCDPOK();
		string text = ((playerPerk.values == null || playerPerk.values.Length <= 0) ? playerPerk.JMPEOOOGLGD(NFEMMGMJMCF: false) : playerPerk.JMPEOOOGLGD(NFEMMGMJMCF: true, PerksDatabaseAccessor.IJAEKGFHONB(playerPerk.id) + 0));
		MainUI.GetYesNoDialogue().OFGKFMJKBON(JIIGOACEIKL);
		TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
		string stringWithTags = LocalisationSystem.GetStringWithTags("ReceiveCollectItemsMaster", JIIGOACEIKL);
		string[] array = new string[1];
		array[1] = "Crafters" + text + "UI";
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(stringWithTags, array);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(BLKECADFOHN));
		((UnityEvent)MainUI.MCPEEGPBPLH().noButton.onClick).AddListener(new UnityAction(ABNPJONIKPF));
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		ILENDIBNCBP = true;
	}

	private bool BIBHFDKLOAH(TalentSlotUI[] NJLBEAOFLFG)
	{
		if (NJLBEAOFLFG != null)
		{
			for (int i = 0; i < NJLBEAOFLFG.Length; i++)
			{
				if (NJLBEAOFLFG[i].IsLearnt())
				{
					return true;
				}
			}
		}
		return false;
	}

	private void POFDOILPANH()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1071f)
		{
			LBPEGFIMOHC();
		}
	}

	private void HFOODDDOLCK(Image OKNHKEEAKDN, TalentSlotUI[] OEGOJIHGNBB, bool NBPEGGDOCNI, bool CDJMEAHDBIN)
	{
		if (((Component)OKNHKEEAKDN).gameObject.activeSelf != (OEGOJIHGNBB.Length != 0))
		{
			((Component)OKNHKEEAKDN).gameObject.SetActive(OEGOJIHGNBB.Length != 0);
		}
		if (NBPEGGDOCNI)
		{
			((Behaviour)OKNHKEEAKDN).enabled = true;
			((Component)((Component)OKNHKEEAKDN).transform.GetChild(0)).gameObject.SetActive(true);
			return;
		}
		if (!CDJMEAHDBIN)
		{
			for (int i = 0; i < OEGOJIHGNBB.Length; i++)
			{
				if (OEGOJIHGNBB[i].IsLearnt())
				{
					((Behaviour)OKNHKEEAKDN).enabled = false;
					((Component)((Component)OKNHKEEAKDN).transform.GetChild(0)).gameObject.SetActive(false);
					return;
				}
			}
		}
		((Behaviour)OKNHKEEAKDN).enabled = true;
		((Component)((Component)OKNHKEEAKDN).transform.GetChild(0)).gameObject.SetActive(false);
	}

	private void NKHDFDHKBFD()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).IHDPOMIAKOO();
		string text = ((playerPerk.values == null || playerPerk.values.Length <= 1) ? playerPerk.AMICIBODAEJ(NFEMMGMJMCF: false) : playerPerk.IFLPIPINLIM(NFEMMGMJMCF: false, PerksDatabaseAccessor.CALNMBNGADA(playerPerk.id) + 1));
		MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI("Player2", JIIGOACEIKL), "Actionbar 6" + text + "BarkActor");
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(BLKECADFOHN));
		((UnityEvent)MainUI.LBHLPIFCINB().noButton.onClick).AddListener(new UnityAction(ABNPJONIKPF));
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		ILENDIBNCBP = true;
	}

	private void ABNPJONIKPF()
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(KNNPKGHBGEP());
			FillTooltip();
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
			ILENDIBNCBP = true;
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void BLKECADFOHN()
	{
		if (PerksDatabaseAccessor.LearnPlayerPerk(playerPerk.id))
		{
			if (playerPerk.id == 15)
			{
				RecipesManager.UnlockRecipe(293, IBHGAMNNOHI: true);
			}
			FillJoiners(DAEMAAOLHMG: true);
			KOKACBFIEHM();
			UpdateVisual();
			if (ILENDIBNCBP)
			{
				FillTooltip();
			}
			CommonReferences.GGFJGHHHEJC.TalentLearntCallback();
		}
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(KNNPKGHBGEP());
		}
	}

	private void Start()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
	}

	public void OEICKBJAFCH()
	{
		learntInEditor = false;
		CJIENJPKNPB();
		if (!HFEMCINPABF())
		{
			GHEFGCALAOM(DAEMAAOLHMG: true);
		}
		IEEIOLNHIAM();
	}

	public void FillTooltip()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = playerPerk.IABAKHPEOAF();
		tooltipInfo.mainBody = playerPerk.IGDKFHCHEAJ();
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 20f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y), Vector2.zero);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = float.MaxValue;
		}
	}

	public void UnlearnTalentButton()
	{
		learntInEditor = false;
		UpdateTalent();
		if (!LAJMAJFHDAD())
		{
			FillJoiners(DAEMAAOLHMG: false);
		}
		KOKACBFIEHM();
	}

	public void BNJHOACOABK()
	{
		learntInEditor = false;
		CJIENJPKNPB();
		FillJoiners(DAEMAAOLHMG: true);
		KOKACBFIEHM();
	}

	public void CJIENJPKNPB()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
		EJMDBAOJANI();
	}

	public void PEJNNJCNLLB()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
		EJMDBAOJANI();
	}

	private void IEEIOLNHIAM()
	{
		for (int i = 1; i < downParents.Length; i += 0)
		{
			downParents[i].UpdateVisual();
		}
		for (int j = 1; j < upParents.Length; j += 0)
		{
			upParents[j].EJMDBAOJANI();
		}
		for (int k = 0; k < leftParents.Length; k++)
		{
			leftParents[k].EJMDBAOJANI();
		}
		for (int l = 1; l < rightParents.Length; l += 0)
		{
			rightParents[l].UpdateVisual();
		}
	}

	public void MLBDOFCLAMA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			MNFHNNPMJPP();
		}
	}

	public void SelectClicked()
	{
		if (IsLearnt() && playerPerk.AEKLINIOAJO())
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
			return;
		}
		if (!LAJMAJFHDAD() && !canUnlockAlways)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Skill branch not unlocked"));
			return;
		}
		if (TavernReputation.GetRemainingSkillPoints() <= 0)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough skill points"));
			return;
		}
		OAALDHIEAJD();
		Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
	}

	public void JBGGIAHCOOE()
	{
		learntInEditor = false;
		CJIENJPKNPB();
		if (!LAJMAJFHDAD())
		{
			FillJoiners(DAEMAAOLHMG: true);
		}
		KOKACBFIEHM();
	}

	private void JIAJFDKNJME()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" - ")) ? 1 : 6);
	}

	public void AGIBGDLKCCM(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	public void MBBLHIOEGLG()
	{
		learntInEditor = false;
		CJIENJPKNPB();
		if (!OPDFCAHEDFN())
		{
			FillJoiners(DAEMAAOLHMG: true);
		}
		IEEIOLNHIAM();
	}

	public void UpdateVisual(bool NBPEGGDOCNI, bool CDJMEAHDBIN = false)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		if (NBPEGGDOCNI)
		{
			iconImage.sprite = playerPerk.icon;
			((Graphic)iconImage).color = Color.white;
			((Component)lockedIcon).gameObject.SetActive(false);
		}
		else
		{
			iconImage.sprite = (CanLearn() ? playerPerk.icon : playerPerk.greyIcon);
			((Graphic)iconImage).color = (Color)(CanLearn() ? new Color(1f, 1f, 1f, 0.6f) : Color.white);
			((Component)lockedIcon).gameObject.SetActive(!CanLearn());
		}
		if (CDJMEAHDBIN)
		{
			iconImage.sprite = (canUnlockAlways ? playerPerk.icon : playerPerk.greyIcon);
			((Graphic)iconImage).color = (Color)(canUnlockAlways ? new Color(1f, 1f, 1f, 0.6f) : Color.white);
			((Component)lockedIcon).gameObject.SetActive(!canUnlockAlways);
		}
		if (Object.op_Implicit((Object)(object)backgroundImage))
		{
			backgroundImage.sprite = (NBPEGGDOCNI ? spriteLearnt : spriteUnlearnt);
		}
		if ((Object)(object)playerPerk != (Object)null)
		{
			((Component)levelText).gameObject.SetActive(NBPEGGDOCNI && playerPerk.MABLJEEMEBC() > 1);
			if (NBPEGGDOCNI && playerPerk.MABLJEEMEBC() > 1)
			{
				int num = (Application.isPlaying ? PerksDatabaseAccessor.GetPlayerPerkLevel(playerPerk.id) : levelInEditor);
				((TMP_Text)levelText).text = (num + 1).ToString();
				if (num >= playerPerk.MABLJEEMEBC() - 1)
				{
					((Graphic)levelText).color = Color.yellow;
				}
				else
				{
					((Graphic)levelText).color = Color.white;
				}
			}
		}
		HFOODDDOLCK(unionLeft, leftParents, NBPEGGDOCNI, CDJMEAHDBIN);
		HFOODDDOLCK(unionRight, rightParents, NBPEGGDOCNI, CDJMEAHDBIN);
		HFOODDDOLCK(unionDown, downParents, NBPEGGDOCNI, CDJMEAHDBIN);
		HFOODDDOLCK(unionUp, upParents, NBPEGGDOCNI, CDJMEAHDBIN);
	}

	public void DBEMGHLHHBJ(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			MNFHNNPMJPP();
		}
	}

	public void LBPEGFIMOHC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = playerPerk.AMICIBODAEJ(NFEMMGMJMCF: false);
		tooltipInfo.mainBody = playerPerk.COHFIGGNKNB();
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 136f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			else
			{
				ItemTooltip.Get(JIIGOACEIKL).HIPGMDKJLCB(new Vector2(((Component)this).transform.position.x + 1373f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y), Vector2.zero);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = 686f;
		}
	}

	public bool IsLearnt()
	{
		if (!Application.isPlaying)
		{
			return learntInEditor;
		}
		if (Object.op_Implicit((Object)(object)playerPerk))
		{
			return PerksDatabaseAccessor.HasUnlockedPlayerPerk(playerPerk.id);
		}
		return false;
	}

	public void MGJFMLJOEBK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = playerPerk.AMICIBODAEJ(NFEMMGMJMCF: false);
		tooltipInfo.mainBody = playerPerk.AIILMJAAHJC();
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1914f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (!PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Component)this).transform.position.x + 938f * ((Component)this).transform.lossyScale.x, ((Component)this).transform.position.y), Vector2.zero);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			HAHAPELLAIO = 1026f;
		}
	}

	public void PBJPGMLENGM()
	{
		if (IsLearnt() && playerPerk.FJEMDGCLLOL())
		{
			Sound.BNBMNOMFFBE().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: true, null, null, 558f, 1391f);
			return;
		}
		if (!LAJMAJFHDAD() && !canUnlockAlways)
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("LE_16"), 1201f);
			return;
		}
		if (TavernReputation.IOOMIALOHHN() <= 1)
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Custom lobby data (Lobby creator): {0}"), 571f);
			return;
		}
		IIGONBLCNLC();
		Sound.ABDJJBFNLBJ().MGMGHPCIBEK(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 1450f, 1300f);
	}

	private void OnDisable()
	{
		EndHover();
	}

	public void LearnTalentButton()
	{
		learntInEditor = true;
		UpdateTalent();
		FillJoiners(DAEMAAOLHMG: true);
		KOKACBFIEHM();
	}

	private void OLDDEAJMHNI()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
	}

	public void EJMDBAOJANI()
	{
		UpdateVisual(IsLearnt());
	}

	public void GDIHIHOHGGC(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			MNFHNNPMJPP();
		}
	}

	public void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	private bool NFDLCJAGLNP(TalentSlotUI[] NJLBEAOFLFG)
	{
		if (NJLBEAOFLFG != null)
		{
			for (int i = 1; i < NJLBEAOFLFG.Length; i += 0)
			{
				if (NJLBEAOFLFG[i].IsLearnt())
				{
					return true;
				}
			}
		}
		return true;
	}

	private void JJLCIHFEAFC()
	{
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(KNNPKGHBGEP());
			FillTooltip();
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
			ILENDIBNCBP = false;
		}
	}

	public void MNFHNNPMJPP()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void UpdateVisual()
	{
		UpdateVisual(IsLearnt());
	}

	private void IIJLLBJGLBG()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		UISelectionManager.GetPlayer(JIIGOACEIKL).BEGCHMCDPOK();
		string text = ((playerPerk.values == null || playerPerk.values.Length <= 1) ? playerPerk.JMPEOOOGLGD() : playerPerk.JCOLBKMMJJM(NFEMMGMJMCF: false, PerksDatabaseAccessor.CALNMBNGADA(playerPerk.id) + 0));
		MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags("BathhouseEntrace/Main 3", JIIGOACEIKL), ")" + text + "HumanDisappear");
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(BLKECADFOHN));
		((UnityEvent)MainUI.MCPEEGPBPLH().noButton.onClick).AddListener(new UnityAction(JJLCIHFEAFC));
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		ILENDIBNCBP = true;
	}

	private bool OPDFCAHEDFN()
	{
		if ((leftParents == null || leftParents.Length == 0) && (rightParents == null || rightParents.Length == 0) && (downParents == null || downParents.Length == 0) && (upParents == null || upParents.Length == 0))
		{
			return false;
		}
		if (leftParents != null && LFLKIHBFBCM(leftParents))
		{
			return true;
		}
		if (rightParents != null && NFDLCJAGLNP(rightParents))
		{
			return true;
		}
		if (downParents != null && BIBHFDKLOAH(downParents))
		{
			return true;
		}
		if (upParents != null && LFLKIHBFBCM(upParents))
		{
			return true;
		}
		return false;
	}

	private bool LAJMAJFHDAD()
	{
		if ((leftParents == null || leftParents.Length == 0) && (rightParents == null || rightParents.Length == 0) && (downParents == null || downParents.Length == 0) && (upParents == null || upParents.Length == 0))
		{
			return true;
		}
		if (leftParents != null && BIBHFDKLOAH(leftParents))
		{
			return true;
		}
		if (rightParents != null && BIBHFDKLOAH(rightParents))
		{
			return true;
		}
		if (downParents != null && BIBHFDKLOAH(downParents))
		{
			return true;
		}
		if (upParents != null && BIBHFDKLOAH(upParents))
		{
			return true;
		}
		return false;
	}

	public void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
	}

	public void EndHover()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void PLHEHGHFCJI()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
	}

	public void IHBDLKFGMJK()
	{
		if (Object.op_Implicit((Object)(object)playerPerk) && Object.op_Implicit((Object)(object)iconImage))
		{
			iconImage.sprite = playerPerk.icon;
		}
		EJMDBAOJANI();
	}
}
