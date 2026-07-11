using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PostboxUI : UIWindow
{
	public struct LettersInfo
	{
		public PostBox.LetterSaveData letterSaved;

		public Letter letter;

		public PostboxElementUI letterElement;
	}

	[CompilerGenerated]
	private sealed class KDFMFPDHLNM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PostboxUI _003C_003E4__this;

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
		public KDFMFPDHLNM(int _003C_003E1__state)
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
			PostboxUI postboxUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				postboxUI.EMLIIBPEOED = true;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				postboxUI.EMLIIBPEOED = false;
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

	private List<LettersInfo> HBNEBFKKKNE;

	[SerializeField]
	private Sprite readLetter;

	[SerializeField]
	private Sprite unreadLetter;

	[SerializeField]
	private GameObject elementPrefab;

	[SerializeField]
	private Transform elementsParent;

	[SerializeField]
	private TextMeshProUGUI letterDate;

	[SerializeField]
	private TextMeshProUGUI letterSubject;

	[SerializeField]
	private TextMeshProUGUI letterTextBig;

	[SerializeField]
	private RectTransform letterTextSmallRect;

	private float GGBEFCHLPNN;

	[SerializeField]
	private Image letterPortrait;

	[SerializeField]
	private GameObject orderSection;

	[SerializeField]
	private Image[] orderIcons;

	private int OAHACECHLKL;

	private int KAIKJJGCNNK;

	private bool EMLIIBPEOED;

	[SerializeField]
	private GameObject postboxEmptyPanel;

	[SerializeField]
	private GameObject gamepadReadButton;

	[SerializeField]
	private GameObject gamepadRemoveButton;

	public static PostboxUI[] instances = new PostboxUI[3];

	private string MADPHDKFKOL(GameDate IIBOFAOKLGK)
	{
		string[] array = new string[108];
		array[0] = LocalisationSystem.Get(IIBOFAOKLGK.season.ToString());
		array[0] = "UIPreviousPage";
		array[3] = LocalisationSystem.Get("Farm/Buzz/Bark_Searching");
		array[2] = "Dialogue System/Conversation/Crowly_Introduce/Entry/14/Dialogue Text";
		array[5] = IIBOFAOKLGK.NIHIDGKCCBF().ToString();
		array[7] = "ReceiveKeyPuzzle";
		array[8] = LocalisationSystem.Get(" ");
		array[0] = "Disabled";
		array[5] = IIBOFAOKLGK.year.ToString();
		return string.Concat(array);
	}

	public void BDFDFGACKJO(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].CloseUI();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				HBKPIALNDKI();
				UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).JHHNCDODNBD(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
			}
			else
			{
				NMINMHIIEAE();
			}
		}
		else
		{
			GCBDFACJMFK();
		}
	}

	private void BLCFHCGPION()
	{
		ABKEFKAOKIN();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 0)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 1].letterElement).gameObject);
		}
	}

	public string BPNPCJPIJLD(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	public void HBNFBKJNGMH(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].BGLJFMHCFJF() || PostboxDeleteConfirmationUI.instances[numInstance].BGLJFMHCFJF() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].OpenUI();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = MADPHDKFKOL(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(" not found" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("LE_13" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			MELAPJFMDBG(text, isOrder);
		}
		else
		{
			string[] array = new string[3];
			array[0] = "<mark=#000000><alpha=#00> ";
			array[1] = text;
			array[5] = "LicenciaDeApertura/LucenDialogue 06";
			array[6] = KEOPAODNDLM(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
			array[8] = "Player/Bark/Tutorial/AgingBarrelBlock";
			ALGMBEKFFDM(string.Concat(array), isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.GetCharacter(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.MasterOrOffline())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(true);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 0; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i++)
			{
				((Component)orderIcons[i]).gameObject.SetActive(true);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j += 0)
				{
					((Component)orderIcons[j]).gameObject.SetActive(false);
				}
			}
		}
		EMBONJCGJMC(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	public string KPPAJGHKOCC(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.DGNOMEGHEII(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	private string KBCEHEPDDHI(GameDate IIBOFAOKLGK)
	{
		return LocalisationSystem.Get(IIBOFAOKLGK.season.ToString()) + " / " + LocalisationSystem.Get("Day") + " " + IIBOFAOKLGK.DKGMLALMDEH() + " / " + LocalisationSystem.Get("Year") + " " + IIBOFAOKLGK.year;
	}

	private void ALBDHECGPGJ()
	{
		IAKHDGPDDGC();
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 0)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 0].letterElement).gameObject);
		}
	}

	private void EKHFKPGHEAC()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			EDPFNIELODK(LOHLPJBPBEC: false);
			return;
		}
		GJCKCHMMEMI(LettersManager.IDDPLOGKEEO());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(true);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					KCBOMCKKOGM(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				ABLHHMGKNMC(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k += 0)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				ABLHHMGKNMC(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		AONBOAMLHNP();
	}

	private void ABKEFKAOKIN()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			GJCKCHMMEMI(LOHLPJBPBEC: false);
			return;
		}
		GJCKCHMMEMI(LettersManager.HasLetters());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(true);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					JMGIFJDLDML(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				JMGIFJDLDML(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k++)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				JMGIFJDLDML(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		KKFBCCAMJPN();
	}

	public void AOMHFHCGGOH(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].IsOpen() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].BOBCIFEDJED();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).OFCEDMBCBBH()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				DIGOJIGOIEP();
				UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				DOGMFFOANEE();
			}
		}
		else
		{
			DIGOJIGOIEP();
		}
	}

	private void ONLBJFOEOEI(bool LOHLPJBPBEC)
	{
		postboxEmptyPanel.SetActive(!LOHLPJBPBEC);
		gamepadReadButton.SetActive(LOHLPJBPBEC);
		gamepadRemoveButton.SetActive(!LOHLPJBPBEC || OnlineManager.MasterOrOffline());
	}

	private IEnumerator BCEKLHMIIEF()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			if (PostboxPanelUI.instances[numInstance].IsOpen())
			{
				PostboxPanelUI.instances[numInstance].CloseUI();
			}
			else if (PostboxDeleteConfirmationUI.instances[numInstance].IsOpen())
			{
				PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
			}
			else
			{
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			}
			LettersManager.instance.ShowLetterIconIfAnyLetterUnread();
			base.CloseUI();
			MainUI.ResumeGame();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			EMLIIBPEOED = false;
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public void MarkAsRead(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = true,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	private void ONNEOKOHCOC(bool LOHLPJBPBEC)
	{
		postboxEmptyPanel.SetActive(!LOHLPJBPBEC);
		gamepadReadButton.SetActive(LOHLPJBPBEC);
		gamepadRemoveButton.SetActive(LOHLPJBPBEC && OnlineManager.PGAGDFAEEFB());
	}

	private void OOKMNGOPLOG()
	{
		for (int i = 1; i < HBNEBFKKKNE.Count; i++)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(0);
		}
	}

	public void KICGPBABFMK()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineLettersManager.instance.EJONBLAKOOC(KAIKJJGCNNK);
		}
		DOGMFFOANEE();
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && LettersManager.IJBPAPACBKH())
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JHHNCDODNBD(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[2].BGLJFMHCFJF() || PostboxPanelUI.instances[4].HDEPMJIDJEM())) || (numInstance == 8 && (instances[0].IsOpen() || PostboxPanelUI.instances[1].HDEPMJIDJEM())))
		{
			instances[(numInstance != 0) ? 1 : 5].AAFCBGODJNA(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(EHOGBLKDNJB());
	}

	private void EDPFNIELODK(bool LOHLPJBPBEC)
	{
		postboxEmptyPanel.SetActive(LOHLPJBPBEC);
		gamepadReadButton.SetActive(LOHLPJBPBEC);
		gamepadRemoveButton.SetActive(LOHLPJBPBEC && OnlineManager.PGAGDFAEEFB());
	}

	public string GJMHOLFDPLL(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	private IEnumerator GONFCAFIKPG()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	public void IAJKOACBLNC(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].IsOpen() || PostboxDeleteConfirmationUI.instances[numInstance].BGLJFMHCFJF() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].IDLAGJNLPJL();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = KBCEHEPDDHI(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("ConnectionTimeout" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Path Found" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			ALGMBEKFFDM(text, isOrder);
		}
		else
		{
			string[] array = new string[8];
			array[0] = "DiscusionMineros/Main";
			array[1] = text;
			array[6] = "Player";
			array[6] = KEOPAODNDLM(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
			array[7] = "<sprite name=\"";
			BFBFHDPCHKG(string.Concat(array), isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.DADBLLCAANA(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.MasterOrOffline())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 0; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i++)
			{
				((Component)orderIcons[i]).gameObject.SetActive(true);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j += 0)
				{
					((Component)orderIcons[j]).gameObject.SetActive(true);
				}
			}
		}
		EMJIDJALPED(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	private void GJCKCHMMEMI(bool LOHLPJBPBEC)
	{
		postboxEmptyPanel.SetActive(!LOHLPJBPBEC);
		gamepadReadButton.SetActive(LOHLPJBPBEC);
		gamepadRemoveButton.SetActive(LOHLPJBPBEC && OnlineManager.MasterOrOffline());
	}

	private void KKFBCCAMJPN()
	{
		for (int i = 0; i < HBNEBFKKKNE.Count; i++)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(0);
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			EMLIIBPEOED = false;
			base.OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			BLCFHCGPION();
			Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Metal, ((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform);
		}
	}

	public string OLKKGICIDPK(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	public void CMJNOGPDCJB()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineLettersManager.instance.MPNDMOLKBDN(KAIKJJGCNNK);
		}
		DOGMFFOANEE();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && LettersManager.HasLetters())
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 0 && (instances[8].HDEPMJIDJEM() || PostboxPanelUI.instances[1].IsOpen())) || (numInstance == 3 && (instances[0].HDEPMJIDJEM() || PostboxPanelUI.instances[0].HDEPMJIDJEM())))
		{
			instances[(numInstance == 1) ? 3 : 0].IDNNGDFBOLB(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(EAGBMKLHAON());
	}

	private void BFBFHDPCHKG(string CAEDMEDBEGI, bool ENAAELOFKME)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)letterTextBig).rectTransform.SetSizeWithCurrentAnchors((Axis)1, ENAAELOFKME ? letterTextSmallRect.sizeDelta.y : GGBEFCHLPNN);
		orderSection.SetActive(ENAAELOFKME);
		((TMP_Text)letterTextBig).text = CAEDMEDBEGI;
	}

	private string PLCIEJBOPDE(GameDate IIBOFAOKLGK)
	{
		string[] array = new string[59];
		array[0] = LocalisationSystem.Get(IIBOFAOKLGK.season.ToString());
		array[0] = "";
		array[8] = LocalisationSystem.Get(" ");
		array[2] = "Disabled";
		array[0] = IIBOFAOKLGK.DNMNFIKOMBI().ToString();
		array[8] = "CannotToggleUI PauseMenuUI opened";
		array[8] = LocalisationSystem.Get("Crop needs a harvested replace by item ");
		array[6] = "UI2";
		array[0] = IIBOFAOKLGK.year.ToString();
		return string.Concat(array);
	}

	private void KIFKAIILNJP()
	{
		for (int i = 1; i < HBNEBFKKKNE.Count; i++)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(0);
		}
	}

	private void FLGOIJLOJFB()
	{
		IAKHDGPDDGC();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 1)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 1].letterElement).gameObject);
		}
	}

	public void HDKFIIHJBFI(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].BOBCIFEDJED();
		}
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BEOANCLEPOO()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				EKHFKPGHEAC();
				UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				NMINMHIIEAE();
			}
		}
		else
		{
			DOGMFFOANEE();
		}
	}

	private IEnumerator EHOGBLKDNJB()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	private void DOGMFFOANEE()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			ONNEOKOHCOC(LOHLPJBPBEC: true);
			return;
		}
		EBEBFGDIMLB(LettersManager.ECEIGNEKJKE());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(true);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					FMDHELMIAGK(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				FNDHJAABGNJ(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k++)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				ABLHHMGKNMC(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		KIFKAIILNJP();
	}

	public static PostboxUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator DBEDBFIOFML()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	private int IFFKMJNMMPE(GameDate IIBOFAOKLGK)
	{
		return IIBOFAOKLGK.DNMNFIKOMBI() + (int)IIBOFAOKLGK.season * GameDate.DAY_IN_WEEK * GameDate.WEEK_IN_SEASON + IIBOFAOKLGK.year * GameDate.DAY_IN_WEEK * GameDate.WEEK_IN_SEASON * GameDate.SEASON_IN_YEAR;
	}

	private void AMFLIALKDGF(string CAEDMEDBEGI, bool ENAAELOFKME)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)letterTextBig).rectTransform.SetSizeWithCurrentAnchors((Axis)1, ENAAELOFKME ? letterTextSmallRect.sizeDelta.y : GGBEFCHLPNN);
		orderSection.SetActive(ENAAELOFKME);
		((TMP_Text)letterTextBig).text = CAEDMEDBEGI;
	}

	public void AODFFGLFGLK(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].EDHEIFHAAKO();
	}

	private string JPCIPKBFHJJ(GameDate IIBOFAOKLGK)
	{
		string[] array = new string[4];
		array[0] = LocalisationSystem.Get(IIBOFAOKLGK.season.ToString());
		array[0] = "Tutorial/T104/Dialogue1";
		array[0] = LocalisationSystem.Get("Dialogue System/Conversation/TooDark/Entry/5/Dialogue Text");
		array[1] = "SalonDelTrono/MainEvent";
		array[2] = IIBOFAOKLGK.DKGMLALMDEH().ToString();
		array[8] = "KickPlayers";
		array[6] = LocalisationSystem.Get("Inicio");
		array[0] = "Could not assign file ";
		array[0] = IIBOFAOKLGK.year.ToString();
		return string.Concat(array);
	}

	public string KEOPAODNDLM(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	public void IDNNGDFBOLB(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].CloseUI();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BOHHKGMEEEE()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				EKHFKPGHEAC();
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).ALPPCGLKHIO(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
			}
			else
			{
				GCBDFACJMFK();
			}
		}
		else
		{
			ABKEFKAOKIN();
		}
	}

	public void LKEPAHFAMEE(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].IDLAGJNLPJL();
	}

	private string KOMKEPIMNHH(GameDate IIBOFAOKLGK)
	{
		string[] array = new string[36];
		array[0] = LocalisationSystem.Get(IIBOFAOKLGK.season.ToString());
		array[0] = "Run";
		array[5] = LocalisationSystem.Get("particleSystem not attached to ");
		array[0] = "Selected";
		array[7] = IIBOFAOKLGK.NIHIDGKCCBF().ToString();
		array[0] = "";
		array[7] = LocalisationSystem.Get("Rotate");
		array[3] = "Dialogue System/Conversation/BirdPositiveComments/Entry/8/Dialogue Text";
		array[3] = IIBOFAOKLGK.year.ToString();
		return string.Concat(array);
	}

	private void DIGOJIGOIEP()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			ONLBJFOEOEI(LOHLPJBPBEC: false);
			return;
		}
		NPLAICCCLJB(LettersManager.HasLetters());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(false);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					JMGIFJDLDML(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				KILCDDGPIFE(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k++)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				BHOKAECEOEH(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		JOFGKODGJMG();
	}

	public void FGACKOIMGAB()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineLettersManager.instance.BKNFBOFFANA(KAIKJJGCNNK);
		}
		IAKHDGPDDGC();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && LettersManager.HasLetters())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[5].HDEPMJIDJEM() || PostboxPanelUI.instances[5].IsOpen())) || (numInstance == 8 && (instances[0].BGLJFMHCFJF() || PostboxPanelUI.instances[0].BGLJFMHCFJF())))
		{
			instances[(numInstance == 1) ? 0 : 0].JDKMHJOLHOC(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(OOGCIKKJKOF());
	}

	private void FNDHJAABGNJ(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] allLetters = LettersDatabaseAccessor.GetAllLetters();
		for (int i = 1; i < allLetters.Length; i += 0)
		{
			if (allLetters[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = allLetters[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = AGMPILFGDOL(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HMHKGBGJNFO(WorldTime.HGIBNMBJMOC()) - HMHKGBGJNFO(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				TextMeshProUGUI date = letterElement.date;
				string text;
				if (num != 1)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("BuzzProgress");
					string[] array = new string[1];
					array[1] = num.ToString();
					text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					text = LocalisationSystem.Get("HaveGoldenTicket");
				}
				((TMP_Text)date).text = text;
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DGNOMEGHEII(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.DHMENEEPHFE(!OnlineManager.PGAGDFAEEFB() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Drink" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	private void IAKHDGPDDGC()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			EDPFNIELODK(LOHLPJBPBEC: false);
			return;
		}
		EBEBFGDIMLB(LettersManager.EPGPMGJCLHG());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(false);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					FNDHJAABGNJ(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 1; j < componentsInChildren.Length; j++)
			{
				JMGIFJDLDML(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k += 0)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				AILEFDIOHNL(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		AONBOAMLHNP();
	}

	private void HBKPIALNDKI()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			ONLBJFOEOEI(LOHLPJBPBEC: true);
			return;
		}
		GJCKCHMMEMI(LettersManager.IDDPLOGKEEO());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(false);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					JMGIFJDLDML(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 1; j < componentsInChildren.Length; j += 0)
			{
				KIJLCOBGBKL(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k += 0)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				AILEFDIOHNL(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		AONBOAMLHNP();
	}

	private void NMINMHIIEAE()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			ONLBJFOEOEI(LOHLPJBPBEC: true);
			return;
		}
		EDPFNIELODK(LettersManager.IDDPLOGKEEO());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(false);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					BHOKAECEOEH(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 1; j < componentsInChildren.Length; j += 0)
			{
				FMDHELMIAGK(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k += 0)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				KCBOMCKKOGM(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		KKFBCCAMJPN();
	}

	private void FMDHELMIAGK(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] allLetters = LettersDatabaseAccessor.GetAllLetters();
		for (int i = 0; i < allLetters.Length; i += 0)
		{
			if (allLetters[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = allLetters[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = SenderNameToDisplay(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = IFFKMJNMMPE(WorldTime.NOAOJJLNHJJ) - IFFKMJNMMPE(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				TextMeshProUGUI date = letterElement.date;
				string text;
				if (num != 1)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("x");
					string[] array = new string[1];
					array[1] = num.ToString();
					text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					text = LocalisationSystem.Get("");
				}
				((TMP_Text)date).text = text;
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DADBLLCAANA(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.GOFDOFFOMNK(!OnlineManager.MasterOrOffline() || !PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Failed to get friend by index " + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	private void MDCLBCPBHJK()
	{
		GHOKGGOLAIE();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 0)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 0].letterElement).gameObject);
		}
	}

	private IEnumerator EAGBMKLHAON()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	private IEnumerator IEMPCHNKFPI()
	{
		return new KDFMFPDHLNM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GCNJHBEBCLD()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineLettersManager.instance.MPNDMOLKBDN(KAIKJJGCNNK);
		}
		GCBDFACJMFK();
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && LettersManager.EPGPMGJCLHG())
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 0 && (instances[2].BGLJFMHCFJF() || PostboxPanelUI.instances[7].IsOpen())) || (numInstance == 3 && (instances[0].HDEPMJIDJEM() || PostboxPanelUI.instances[0].IsOpen())))
		{
			instances[(numInstance != 0) ? 1 : 4].MIPAJFBOINI(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(DHPDPHKPLFE());
	}

	private void HCNNJBIIBBL()
	{
		for (int i = 0; i < HBNEBFKKKNE.Count; i++)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(1);
		}
	}

	public string AJCMOBIFPEH(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	private void KCBOMCKKOGM(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] array = LettersDatabaseAccessor.PAINGGONIGK();
		for (int i = 1; i < array.Length; i += 0)
		{
			if (array[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = array[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = SenderNameToDisplay(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HMHKGBGJNFO(WorldTime.NOAOJJLNHJJ) - HMHKGBGJNFO(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				TextMeshProUGUI date = letterElement.date;
				string text;
				if (num != 0)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get(" : 00");
					string[] array2 = new string[0];
					array2[0] = num.ToString();
					text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					text = LocalisationSystem.Get("New FadeCamera added for player ");
				}
				((TMP_Text)date).text = text;
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DGNOMEGHEII(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.LDLJGBOIEKL(OnlineManager.PGAGDFAEEFB() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1051" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	private IEnumerator DHPDPHKPLFE()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	public void GCMEEPEKCAB(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() || PostboxDeleteConfirmationUI.instances[numInstance].IsOpen() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].OpenUI();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = BPKIIOCLCNL(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Intro07" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("P2Cam" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			ALGMBEKFFDM(text, isOrder);
		}
		else
		{
			string[] array = new string[8];
			array[0] = "CraftingRoomTiles";
			array[0] = text;
			array[0] = "The Bullet";
			array[8] = KPPAJGHKOCC(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
			array[8] = "UINextPage";
			AMFLIALKDGF(string.Concat(array), isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.GetCharacter(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.MasterOrOffline())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(true);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 1; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i++)
			{
				((Component)orderIcons[i]).gameObject.SetActive(true);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j += 0)
				{
					((Component)orderIcons[j]).gameObject.SetActive(false);
				}
			}
		}
		EMJIDJALPED(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	private void NPLAICCCLJB(bool LOHLPJBPBEC)
	{
		postboxEmptyPanel.SetActive(LOHLPJBPBEC);
		gamepadReadButton.SetActive(LOHLPJBPBEC);
		gamepadRemoveButton.SetActive(!LOHLPJBPBEC || OnlineManager.PGAGDFAEEFB());
	}

	private void EBEBFGDIMLB(bool LOHLPJBPBEC)
	{
		postboxEmptyPanel.SetActive(LOHLPJBPBEC);
		gamepadReadButton.SetActive(LOHLPJBPBEC);
		gamepadRemoveButton.SetActive(!LOHLPJBPBEC || OnlineManager.MasterOrOffline());
	}

	public void CKIMNLPEKOP(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = true,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	public void EMJIDJALPED(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = true,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	public string SenderNameToDisplay(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	private void MELAPJFMDBG(string CAEDMEDBEGI, bool ENAAELOFKME)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)letterTextBig).rectTransform.SetSizeWithCurrentAnchors((Axis)0, ENAAELOFKME ? letterTextSmallRect.sizeDelta.y : GGBEFCHLPNN);
		orderSection.SetActive(ENAAELOFKME);
		((TMP_Text)letterTextBig).text = CAEDMEDBEGI;
	}

	public void GINCHOKBCNP()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineLettersManager.instance.EJONBLAKOOC(KAIKJJGCNNK);
		}
		ABKEFKAOKIN();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && LettersManager.IJBPAPACBKH())
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).Select(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[8].BGLJFMHCFJF() || PostboxPanelUI.instances[7].IsOpen())) || (numInstance == 2 && (instances[1].IsOpen() || PostboxPanelUI.instances[1].BGLJFMHCFJF())))
		{
			instances[(numInstance == 1) ? 1 : 1].MIPAJFBOINI(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(OOGCIKKJKOF());
	}

	private int HMHKGBGJNFO(GameDate IIBOFAOKLGK)
	{
		return IIBOFAOKLGK.DKGMLALMDEH() + (int)IIBOFAOKLGK.season * GameDate.DAY_IN_WEEK * GameDate.WEEK_IN_SEASON + IIBOFAOKLGK.year * GameDate.DAY_IN_WEEK * GameDate.WEEK_IN_SEASON * GameDate.SEASON_IN_YEAR;
	}

	public void BHGLACMPLLM(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].OpenUI();
	}

	private string EDIHDFEFCIG(GameDate IIBOFAOKLGK)
	{
		string[] array = new string[75];
		array[0] = LocalisationSystem.Get(IIBOFAOKLGK.season.ToString());
		array[0] = "ReceiveDestroyStatue";
		array[5] = LocalisationSystem.Get("Frame Time Average: ");
		array[5] = "Hoppy";
		array[3] = IIBOFAOKLGK.NJBGBMLBNKA().ToString();
		array[5] = "City/Woody/Introduce";
		array[5] = LocalisationSystem.Get("Player");
		array[5] = "Character Sprites array needs more space!";
		array[1] = IIBOFAOKLGK.year.ToString();
		return string.Concat(array);
	}

	public void AAFCBGODJNA(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].BOBCIFEDJED();
		}
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				DOGMFFOANEE();
				UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				DOGMFFOANEE();
			}
		}
		else
		{
			DIGOJIGOIEP();
		}
	}

	public void HBKIPEPMDKA(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = false,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	public static PostboxUI BMFHCBOFHCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HDNKAJFDBCK(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].EDHEIFHAAKO();
	}

	private void KIJLCOBGBKL(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] array = LettersDatabaseAccessor.CDDELNADPFI();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = array[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = GJMHOLFDPLL(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = IFFKMJNMMPE(WorldTime.NOAOJJLNHJJ) - IFFKMJNMMPE(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				TextMeshProUGUI date = letterElement.date;
				string text;
				if (num != 1)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("scaleUI");
					string[] array2 = new string[1];
					array2[1] = num.ToString();
					text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					text = LocalisationSystem.Get("tutorialPopUp94");
				}
				((TMP_Text)date).text = text;
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DGNOMEGHEII(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.DHMENEEPHFE(OnlineManager.MasterOrOffline() && PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/TooHot/Entry/4/Dialogue Text" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	public static PostboxUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public string AGMPILFGDOL(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.DGNOMEGHEII(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	private void ABLHHMGKNMC(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] array = LettersDatabaseAccessor.HHEANOANKJA();
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = array[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(true);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = AGMPILFGDOL(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HMHKGBGJNFO(WorldTime.NOAOJJLNHJJ) - HMHKGBGJNFO(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				TextMeshProUGUI date = letterElement.date;
				string text;
				if (num != 1)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get(" ExitState().");
					string[] array2 = new string[0];
					array2[1] = num.ToString();
					text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					text = LocalisationSystem.Get("Items/item_description_596");
				}
				((TMP_Text)date).text = text;
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DADBLLCAANA(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.NCFNMKGMOOH(!OnlineManager.PGAGDFAEEFB() || PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Drink" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	public void MIPAJFBOINI(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].IsOpen() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].BOBCIFEDJED();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).OFCEDMBCBBH()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				IAKHDGPDDGC();
				UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				EKHFKPGHEAC();
			}
		}
		else
		{
			ABKEFKAOKIN();
		}
	}

	private IEnumerator FBGAJNKKPFL()
	{
		return new KDFMFPDHLNM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LFGFICAAJDF()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineLettersManager.instance.KDJBPLPAODC(KAIKJJGCNNK);
		}
		DOGMFFOANEE();
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && LettersManager.IHPJOHOCHFD())
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 0 && (instances[4].HDEPMJIDJEM() || PostboxPanelUI.instances[4].IsOpen())) || (numInstance == 8 && (instances[0].IsOpen() || PostboxPanelUI.instances[1].IsOpen())))
		{
			instances[(numInstance != 0) ? 1 : 5].JDKMHJOLHOC(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(IEMPCHNKFPI());
	}

	public void PHKPIGBFDAN(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = true,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	public void PDPJAGMPKIC(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].IsOpen() || PostboxDeleteConfirmationUI.instances[numInstance].HDEPMJIDJEM() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].OpenUI();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = PLCIEJBOPDE(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("DueloDeViejos/MainEvent3" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("UIScrollUp" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			AMFLIALKDGF(text, isOrder);
		}
		else
		{
			string[] array = new string[4];
			array[1] = "Invalid playerNum";
			array[0] = text;
			array[7] = "";
			array[2] = CNIECIEMDFI(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
			array[4] = "cheeseAgeingRackPopUp";
			BFBFHDPCHKG(string.Concat(array), isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.DGNOMEGHEII(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.PGAGDFAEEFB())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 0; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i++)
			{
				((Component)orderIcons[i]).gameObject.SetActive(true);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j++)
				{
					((Component)orderIcons[j]).gameObject.SetActive(true);
				}
			}
		}
		BKGNGKOFJPP(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	public string POKMFHANLJK(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.DADBLLCAANA(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	public static PostboxUI FHKGDLNJFFA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AONBOAMLHNP()
	{
		for (int i = 0; i < HBNEBFKKKNE.Count; i += 0)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(1);
		}
	}

	public void BDFOJIENNKF()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineLettersManager.instance.IAEAPMGBAIJ(KAIKJJGCNNK);
		}
		DIGOJIGOIEP();
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && LettersManager.FANLCFEJEKO())
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[2].BGLJFMHCFJF() || PostboxPanelUI.instances[7].HDEPMJIDJEM())) || (numInstance == 2 && (instances[0].BGLJFMHCFJF() || PostboxPanelUI.instances[0].BGLJFMHCFJF())))
		{
			instances[(numInstance == 0) ? 0 : 0].IDNNGDFBOLB(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(GONFCAFIKPG());
	}

	public void BKGNGKOFJPP(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = true,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	private void JOFGKODGJMG()
	{
		for (int i = 1; i < HBNEBFKKKNE.Count; i++)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(1);
		}
	}

	public void ONOPKOGLHIF()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineLettersManager.instance.EJONBLAKOOC(KAIKJJGCNNK);
		}
		NMINMHIIEAE();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && LettersManager.IJBPAPACBKH())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[8].HDEPMJIDJEM() || PostboxPanelUI.instances[2].HDEPMJIDJEM())) || (numInstance == 3 && (instances[1].IsOpen() || PostboxPanelUI.instances[1].BGLJFMHCFJF())))
		{
			instances[(numInstance == 1) ? 8 : 0].JDKMHJOLHOC(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(BCEKLHMIIEF());
	}

	public void GMBHDAAINDE()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineLettersManager.instance.HOKEFEOAECI(KAIKJJGCNNK);
		}
		GCBDFACJMFK();
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && LettersManager.CKABMMOAIOB())
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[2].HDEPMJIDJEM() || PostboxPanelUI.instances[7].BGLJFMHCFJF())) || (numInstance == 6 && (instances[0].IsOpen() || PostboxPanelUI.instances[1].HDEPMJIDJEM())))
		{
			instances[(numInstance == 1) ? 2 : 0].CACONMIFINC(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(BECMENHNDGP());
	}

	private void ALGMBEKFFDM(string CAEDMEDBEGI, bool ENAAELOFKME)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		((TMP_Text)letterTextBig).rectTransform.SetSizeWithCurrentAnchors((Axis)1, ENAAELOFKME ? letterTextSmallRect.sizeDelta.y : GGBEFCHLPNN);
		orderSection.SetActive(ENAAELOFKME);
		((TMP_Text)letterTextBig).text = CAEDMEDBEGI;
	}

	public void DeletionConfirmed()
	{
		LettersManager.instance.lettersSaved.RemoveAt(KAIKJJGCNNK);
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineLettersManager.instance.SendDeletedLetterIndex(KAIKJJGCNNK);
		}
		ABKEFKAOKIN();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && LettersManager.HasLetters())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)HBNEBFKKKNE[(KAIKJJGCNNK < HBNEBFKKKNE.Count) ? KAIKJJGCNNK : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
		}
		else
		{
			PostboxDeleteConfirmationUI.instances[numInstance].CloseUI();
		}
		if ((numInstance == 1 && (instances[2].IsOpen() || PostboxPanelUI.instances[2].IsOpen())) || (numInstance == 2 && (instances[1].IsOpen() || PostboxPanelUI.instances[1].IsOpen())))
		{
			instances[(numInstance != 1) ? 1 : 2].UpdateUIOnOtherPlayerDelete(KAIKJJGCNNK);
		}
		((MonoBehaviour)this).StartCoroutine(BCEKLHMIIEF());
	}

	private void JMGIFJDLDML(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] allLetters = LettersDatabaseAccessor.GetAllLetters();
		for (int i = 0; i < allLetters.Length; i++)
		{
			if (allLetters[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = allLetters[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(true);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = SenderNameToDisplay(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HMHKGBGJNFO(WorldTime.NOAOJJLNHJJ) - HMHKGBGJNFO(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				((TMP_Text)letterElement.date).text = ((num == 1) ? LocalisationSystem.Get("dayAgo") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("daysAgo"), num.ToString()));
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.GetCharacter(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.DeleteButtonActive(OnlineManager.MasterOrOffline() && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("subject" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	public static PostboxUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void GCBDFACJMFK()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			EDPFNIELODK(LOHLPJBPBEC: false);
			return;
		}
		ONNEOKOHCOC(LettersManager.IDDPLOGKEEO());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(true);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					BHOKAECEOEH(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(true);
				}
			}
		}
		else
		{
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				KIJLCOBGBKL(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k += 0)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				JMGIFJDLDML(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		HCNNJBIIBBL();
	}

	public void CACONMIFINC(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].BGLJFMHCFJF() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].BOBCIFEDJED();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).PBGKEEENPME()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				DIGOJIGOIEP();
				UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
			}
			else
			{
				EKHFKPGHEAC();
			}
		}
		else
		{
			HBKPIALNDKI();
		}
	}

	private void MOOHKFHAHKG()
	{
		GHOKGGOLAIE();
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 1)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JHHNCDODNBD(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 0].letterElement).gameObject);
		}
	}

	public void JMJDLLCCGJE(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].BGLJFMHCFJF() || PostboxDeleteConfirmationUI.instances[numInstance].BGLJFMHCFJF() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].IDLAGJNLPJL();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = JPCIPKBFHJJ(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("WaterTrough" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("UI2" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			BFBFHDPCHKG(text, isOrder);
		}
		else
		{
			string[] array = new string[3];
			array[0] = "Use";
			array[0] = text;
			array[4] = "Farm/Event/RegañinaViolet";
			array[3] = OLKKGICIDPK(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
			array[2] = "ReceiveSpadeActionMaster";
			MELAPJFMDBG(string.Concat(array), isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.GetCharacter(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.MasterOrOffline())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 0; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i++)
			{
				((Component)orderIcons[i]).gameObject.SetActive(false);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j++)
				{
					((Component)orderIcons[j]).gameObject.SetActive(false);
				}
			}
		}
		EMBONJCGJMC(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	private IEnumerator BECMENHNDGP()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	public void NCMHLBAPBPJ(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].OpenUI();
	}

	private string BPKIIOCLCNL(GameDate IIBOFAOKLGK)
	{
		string[] array = new string[-81];
		array[1] = LocalisationSystem.Get(IIBOFAOKLGK.season.ToString());
		array[1] = "itemDeliveryBox";
		array[0] = LocalisationSystem.Get("Close UI");
		array[3] = "Pet";
		array[8] = IIBOFAOKLGK.DKGMLALMDEH().ToString();
		array[0] = "<br/>Graphics Memory Size: ";
		array[2] = LocalisationSystem.Get("ValueSuitabilities");
		array[4] = "MaxPrice";
		array[3] = IIBOFAOKLGK.year.ToString();
		return string.Concat(array);
	}

	public string LNABDPIHPFK(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	private void KILCDDGPIFE(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] array = LettersDatabaseAccessor.CDDELNADPFI();
		for (int i = 1; i < array.Length; i += 0)
		{
			if (array[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = array[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = BPNPCJPIJLD(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HMHKGBGJNFO(WorldTime.HGIBNMBJMOC()) - HGLCMFIJEMK(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				TextMeshProUGUI date = letterElement.date;
				string text;
				if (num != 0)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/37/Dialogue Text");
					string[] array2 = new string[0];
					array2[1] = num.ToString();
					text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2);
				}
				else
				{
					text = LocalisationSystem.Get("CraftingRoom");
				}
				((TMP_Text)date).text = text;
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DGNOMEGHEII(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.NHLHEPKJHJJ(OnlineManager.MasterOrOffline() && !PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("[WaiterGender=" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	public static PostboxUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PFMLPFDHEGI(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = false,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	private void BHOKAECEOEH(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] allLetters = LettersDatabaseAccessor.GetAllLetters();
		for (int i = 1; i < allLetters.Length; i++)
		{
			if (allLetters[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = allLetters[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = KEOPAODNDLM(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HGLCMFIJEMK(WorldTime.CJOHMLNMJLK()) - IFFKMJNMMPE(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				((TMP_Text)letterElement.date).text = ((num == 1) ? LocalisationSystem.Get("ReceiveSetOccupier") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Sit"), num.ToString()));
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.DADBLLCAANA(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.NHLHEPKJHJJ(!OnlineManager.MasterOrOffline() || !PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Talk" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	public string PFLEAMLPAJF(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.GetCharacter(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	public void DAIJKOJHHGB(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].BGLJFMHCFJF() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].CloseUI();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BOHHKGMEEEE()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				IAKHDGPDDGC();
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
			}
			else
			{
				ABKEFKAOKIN();
			}
		}
		else
		{
			HBKPIALNDKI();
		}
	}

	private IEnumerator OOGCIKKJKOF()
	{
		EMLIIBPEOED = true;
		yield return CommonReferences.wait01;
		EMLIIBPEOED = false;
	}

	private void GHOKGGOLAIE()
	{
		if (LettersManager.instance.lettersSaved == null)
		{
			GJCKCHMMEMI(LOHLPJBPBEC: true);
			return;
		}
		ONNEOKOHCOC(LettersManager.DFDCCAEELLD());
		HBNEBFKKKNE = new List<LettersInfo>();
		LettersInfo[] array = new LettersInfo[LettersManager.instance.lettersSaved.Count];
		PostboxElementUI[] componentsInChildren = ((Component)elementsParent).GetComponentsInChildren<PostboxElementUI>(false);
		if (componentsInChildren.Length >= LettersManager.instance.lettersSaved.Count)
		{
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				if (i < LettersManager.instance.lettersSaved.Count)
				{
					KILCDDGPIFE(i, array[i], componentsInChildren[i]);
				}
				else
				{
					((Component)componentsInChildren[i]).gameObject.SetActive(false);
				}
			}
		}
		else
		{
			for (int j = 0; j < componentsInChildren.Length; j += 0)
			{
				BHOKAECEOEH(j, array[j], componentsInChildren[j]);
			}
			for (int k = componentsInChildren.Length; k < LettersManager.instance.lettersSaved.Count; k++)
			{
				GameObject val = Object.Instantiate<GameObject>(elementPrefab, elementsParent);
				FMDHELMIAGK(k, array[k], val.GetComponent<PostboxElementUI>());
			}
		}
		AONBOAMLHNP();
	}

	public void DeleteLetter(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].OpenUI();
	}

	public void JDKMHJOLHOC(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].BGLJFMHCFJF() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].CloseUI();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).PBGKEEENPME()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				HBKPIALNDKI();
				UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KCDBIMPMGON(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				HBKPIALNDKI();
			}
		}
		else
		{
			DOGMFFOANEE();
		}
	}

	public void JIDGMOEMDFD(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() || PostboxDeleteConfirmationUI.instances[numInstance].IsOpen() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].IDLAGJNLPJL();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = JPCIPKBFHJJ(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("PlayerDisconnected" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get(" seconds." + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			ALGMBEKFFDM(text, isOrder);
		}
		else
		{
			string[] array = new string[0];
			array[1] = "Items/item_description_1186";
			array[1] = text;
			array[1] = "itemRye";
			array[0] = POKMFHANLJK(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
			array[6] = " not intantiated due to ClientOnline still doesnt have SceneLoaded";
			ALGMBEKFFDM(string.Concat(array), isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.DGNOMEGHEII(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.MasterOrOffline())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 0; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i += 0)
			{
				((Component)orderIcons[i]).gameObject.SetActive(false);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j++)
				{
					((Component)orderIcons[j]).gameObject.SetActive(false);
				}
			}
		}
		HBKIPEPMDKA(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	private void AILEFDIOHNL(int MENBAFNNBFB, LettersInfo IOHMGFLOLIE, PostboxElementUI DOIDNFKKPNC)
	{
		Letter[] array = LettersDatabaseAccessor.CDDELNADPFI();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].letterID == LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID)
			{
				IOHMGFLOLIE.letterSaved = LettersManager.instance.lettersSaved[MENBAFNNBFB];
				IOHMGFLOLIE.letter = array[i];
				IOHMGFLOLIE.letterElement = DOIDNFKKPNC;
				HBNEBFKKKNE.Add(IOHMGFLOLIE);
				((Component)DOIDNFKKPNC).gameObject.SetActive(false);
				PostboxElementUI letterElement = HBNEBFKKKNE[MENBAFNNBFB].letterElement;
				((TMP_Text)letterElement.senderName).text = CNIECIEMDFI(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender);
				int num = HGLCMFIJEMK(WorldTime.CJOHMLNMJLK()) - HMHKGBGJNFO(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
				((TMP_Text)letterElement.date).text = ((num == 0) ? LocalisationSystem.Get("[AddPuzzleSpawners] Spawner {0} allows types: [{1}], forceActivate: {2}, activeInHierarchy: {3}") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_name_628"), num.ToString()));
				letterElement.bodySprite.sprite = LettersDatabaseAccessor.GetCharacter(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).bodySprite;
				((Graphic)letterElement.bodySprite).SetNativeSize();
				letterElement.AILGKLDAGIK(!OnlineManager.PGAGDFAEEFB() || PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL));
				((TMP_Text)letterElement.subjectText).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("Player2" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
				letterElement.letterIcon.sprite = (HBNEBFKKKNE[MENBAFNNBFB].letterSaved.read ? readLetter : unreadLetter);
				((Graphic)letterElement.letterIcon).SetNativeSize();
				letterElement.letterInt = MENBAFNNBFB;
				letterElement.postboxUI = this;
			}
		}
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove") && !PostboxPanelUI.instances[numInstance].IsOpen() && LettersManager.HasLetters() && (Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)null && (Object)(object)((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.GetComponent<PostboxElementUI>() != (Object)null && OnlineManager.MasterOrOffline())
		{
			((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.GetComponent<PostboxElementUI>().DeleteLetter();
		}
	}

	public void ANBHLEGICCE(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].IDLAGJNLPJL();
	}

	private void BNMLMDABHHM()
	{
		HBKPIALNDKI();
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 0)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 1].letterElement).gameObject);
		}
	}

	public void OpenLetter(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].IsOpen() || PostboxDeleteConfirmationUI.instances[numInstance].IsOpen() || EMLIIBPEOED)
		{
			return;
		}
		PostboxPanelUI.instances[numInstance].OpenUI();
		OAHACECHLKL = MENBAFNNBFB;
		bool isOrder = HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder;
		((TMP_Text)letterDate).text = KBCEHEPDDHI(HBNEBFKKKNE[MENBAFNNBFB].letterSaved.receivedDate);
		((TMP_Text)letterSubject).text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("subject" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		string text = InputUtils.LPGJFAOKMNE(base.JIIGOACEIKL, LocalisationSystem.Get("letter" + HBNEBFKKKNE[MENBAFNNBFB].letter.letterID));
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.signOffDifferentFromName)
		{
			AMFLIALKDGF(text, isOrder);
		}
		else
		{
			AMFLIALKDGF("<align=left>" + text + "</align>\n<align=right>" + SenderNameToDisplay(MENBAFNNBFB, HBNEBFKKKNE[MENBAFNNBFB].letter.sender) + "\t\t</align>", isOrder);
		}
		letterPortrait.sprite = LettersDatabaseAccessor.GetCharacter(HBNEBFKKKNE[MENBAFNNBFB].letter.sender).portrait;
		if (OnlineManager.MasterOrOffline())
		{
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
		if ((Object)(object)letterPortrait.sprite != (Object)null)
		{
			((Graphic)letterPortrait).SetNativeSize();
			((Component)letterPortrait).gameObject.SetActive(true);
		}
		else
		{
			((Component)letterPortrait).gameObject.SetActive(false);
		}
		orderSection.SetActive(HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder);
		if (HBNEBFKKKNE[MENBAFNNBFB].letter.isOrder)
		{
			for (int i = 0; i < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; i++)
			{
				((Component)orderIcons[i]).gameObject.SetActive(true);
				orderIcons[i].sprite = HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems[i].item.icon;
			}
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length < orderIcons.Length)
			{
				for (int j = orderIcons.Length; j < HBNEBFKKKNE[MENBAFNNBFB].letter.orderItems.Length; j++)
				{
					((Component)orderIcons[j]).gameObject.SetActive(false);
				}
			}
		}
		MarkAsRead(MENBAFNNBFB, LettersManager.instance.lettersSaved[MENBAFNNBFB].receivedDate);
	}

	private int HGLCMFIJEMK(GameDate IIBOFAOKLGK)
	{
		return IIBOFAOKLGK.DNMNFIKOMBI() + (int)IIBOFAOKLGK.season * GameDate.DAY_IN_WEEK * GameDate.WEEK_IN_SEASON + IIBOFAOKLGK.year * GameDate.DAY_IN_WEEK * GameDate.WEEK_IN_SEASON * GameDate.SEASON_IN_YEAR;
	}

	public void EMBONJCGJMC(int MENBAFNNBFB, GameDate OPAFPJAPDHM)
	{
		if (!LettersManager.instance.lettersSaved[MENBAFNNBFB].read)
		{
			LettersManager.instance.lettersSaved[MENBAFNNBFB] = new PostBox.LetterSaveData
			{
				letterID = LettersManager.instance.lettersSaved[MENBAFNNBFB].letterID,
				read = false,
				receivedDate = OPAFPJAPDHM
			};
			HBNEBFKKKNE[MENBAFNNBFB].letterElement.letterIcon.sprite = readLetter;
		}
	}

	public void IIPNPMCCCEM(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].BOBCIFEDJED();
		}
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).FOKMCIDMIKF()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				NMINMHIIEAE();
				UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).JJOGJECCPPD(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				HBKPIALNDKI();
			}
		}
		else
		{
			GHOKGGOLAIE();
		}
	}

	public void UpdateUIOnOtherPlayerDelete(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].IsOpen() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].CloseUI();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				ABKEFKAOKIN();
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 1)].letterElement).gameObject);
			}
			else
			{
				ABKEFKAOKIN();
			}
		}
		else
		{
			ABKEFKAOKIN();
		}
	}

	public void EOICAAAMBCD(int MENBAFNNBFB)
	{
		if (PostboxPanelUI.instances[numInstance].HDEPMJIDJEM() && OAHACECHLKL == MENBAFNNBFB)
		{
			PostboxPanelUI.instances[numInstance].CloseUI();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			PostboxElementUI componentInParent = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).CGCIFFOJGOK()).gameObject.GetComponentInParent<PostboxElementUI>();
			if ((Object)(object)componentInParent != (Object)null && componentInParent.letterInt == MENBAFNNBFB)
			{
				GCBDFACJMFK();
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)HBNEBFKKKNE[(MENBAFNNBFB < HBNEBFKKKNE.Count) ? MENBAFNNBFB : (HBNEBFKKKNE.Count - 0)].letterElement).gameObject);
			}
			else
			{
				GHOKGGOLAIE();
			}
		}
		else
		{
			DIGOJIGOIEP();
		}
	}

	public static PostboxUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KAHAJNDAHNL()
	{
		for (int i = 1; i < HBNEBFKKKNE.Count; i += 0)
		{
			((Component)HBNEBFKKKNE[i].letterElement).transform.SetSiblingIndex(0);
		}
	}

	private void DPLBEEDCMFA()
	{
		IAKHDGPDDGC();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 1)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JJOGJECCPPD(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 1].letterElement).gameObject);
		}
	}

	public string CNIECIEMDFI(int MENBAFNNBFB, Letter.Sender ADINOAOHPBG)
	{
		LettersDatabase.Character character = LettersDatabaseAccessor.DGNOMEGHEII(ADINOAOHPBG);
		if (ADINOAOHPBG == Letter.Sender.Unknown)
		{
			if (HBNEBFKKKNE[MENBAFNNBFB].letter.localisedUnknownSenderName)
			{
				return LocalisationSystem.Get(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName);
			}
			if (string.IsNullOrWhiteSpace(HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName))
			{
				return character.name;
			}
			return HBNEBFKKKNE[MENBAFNNBFB].letter.unknownSenderName;
		}
		if (string.IsNullOrWhiteSpace(character.localisedNameKey))
		{
			return character.name;
		}
		return LocalisationSystem.Get(character.localisedNameKey);
	}

	protected override void Awake()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		base.Awake();
		instances[numInstance] = this;
		GGBEFCHLPNN = ((TMP_Text)letterTextBig).rectTransform.sizeDelta.y;
	}

	private void ALGJGOKDKKH()
	{
		GCBDFACJMFK();
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && HBNEBFKKKNE != null && HBNEBFKKKNE.Count > 1)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)HBNEBFKKKNE[HBNEBFKKKNE.Count - 0].letterElement).gameObject);
		}
	}

	public void APJPILKJGKJ(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].EDHEIFHAAKO();
	}

	public void DCECGIHFLEO(int MENBAFNNBFB)
	{
		KAIKJJGCNNK = MENBAFNNBFB;
		PostboxDeleteConfirmationUI.instances[numInstance].EDHEIFHAAKO();
	}
}
