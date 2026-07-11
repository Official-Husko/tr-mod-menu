using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;

public class ElevatorSwitchUI : UIWindow
{
	[CompilerGenerated]
	private sealed class KMIOEEOEDIE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ElevatorSwitchUI _003C_003E4__this;

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
		public KMIOEEOEDIE(int _003C_003E1__state)
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
			ElevatorSwitchUI elevatorSwitchUI = _003C_003E4__this;
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
				UISelectionManager.GetPlayer(elevatorSwitchUI.JIIGOACEIKL).Select(((Component)elevatorSwitchUI.levelButtons[PlayerController.GetPlayer(elevatorSwitchUI.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
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

	public static ElevatorSwitchUI[] instances = new ElevatorSwitchUI[3];

	public List<ElevatorSwitchButtonUI> levelButtons = new List<ElevatorSwitchButtonUI>();

	public GameObject levelButtonPrefab;

	public TravelZone elevatorTravelZone;

	[SerializeField]
	private AudioObject elevatorHandleSound;

	private ElevatorSwitch GLCIPPNLBFC;

	[SerializeField]
	private Sprite lockIcon;

	[SerializeField]
	private Sprite baseCamp;

	[SerializeField]
	private Sprite firstMine;

	[SerializeField]
	private Sprite secondMine;

	[SerializeField]
	private Sprite thirdMine;

	[SerializeField]
	private Sprite puzzleSolved;

	[SerializeField]
	private Sprite puzzleFound;

	public static ElevatorSwitchUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		base.OpenUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		FIDGJDFADJD();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
	}

	protected void OFHCCIDHFFN()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			((MonoBehaviour)this).StartCoroutine(PIJEJJCPNLN());
		}
	}

	private void FLOGFNLLCHJ(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			FDKHEMJKBJL();
		}
	}

	private void KDCALGDOGCP()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			HKOPNIHDFEC(levelButtons[i], i);
		}
	}

	protected void HEPOGKAJGPN()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).LBFFIBKMLGO();
			((MonoBehaviour)this).StartCoroutine(INBHHLBAFJN());
		}
	}

	private IEnumerator CKFBAIOOPJC()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NMHNOBKLKCK()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			CBEHKCLLGCE(levelButtons[i], i);
		}
	}

	public void MPFLMPONLKB(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.PDECKLKPKCG().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void OLBBAILMGPB(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("UnNuevoMaestro/KujakuTalk");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.OOKBNHMMFON().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Already Travelling");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Fill");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("NotMyChest");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Treasure hit");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveInfoTerrain");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Week");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Exit");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveCantPlaceItem");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("MapBeach");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
	}

	public static ElevatorSwitchUI MLJJHLNAGBP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ABKDPEOJAEN()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CDPHLCKNPPP(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.PDECKLKPKCG().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void GKINKOIFLID()
	{
		for (int i = 0; i < levelButtons.Count; i++)
		{
			PDPNHPCMIHB(levelButtons[i], i);
		}
	}

	public void KLEJOHIJNPF(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 1)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void JMNIHKLCJPK(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			MLONFEADGEC();
		}
	}

	private void OMAGHGMJMAD()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			BFAPACELJHP(levelButtons[i], i);
		}
	}

	public void HFLJGAEGLHC(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.OOKBNHMMFON().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	public void INLDPHJCNEN(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 2)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	protected void IMHFMHFBPBD()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).CKNJJKJDBGA();
			((MonoBehaviour)this).StartCoroutine(CKFBAIOOPJC());
		}
	}

	private void NDGGPNNGLEP()
	{
		for (int i = 0; i < levelButtons.Count; i += 0)
		{
			NHKJIOPDAKA(levelButtons[i], i);
		}
	}

	private void LIAKAHEKKME()
	{
		for (int i = 0; i < levelButtons.Count; i++)
		{
			BJLFCMIFCMO(levelButtons[i], i);
		}
	}

	public static ElevatorSwitchUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void NKICBFDECOO()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LCLJFCKELJN();
			((MonoBehaviour)this).StartCoroutine(GBHDIGHLOFP());
		}
	}

	private IEnumerator PKIBDENHGJA()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	protected void JJAAKFECBMJ()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CKMLGHPIEEK();
			((MonoBehaviour)this).StartCoroutine(DEFFKNMFFHI());
		}
	}

	private IEnumerator BENPPHOBCEC()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPFCNFGDHOM(int EONJGMONIOM)
	{
		if (HDEPMJIDJEM())
		{
			AONPBEIODII();
		}
	}

	protected void KOGHPCGMGHL()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			((MonoBehaviour)this).StartCoroutine(IAJPKNPADDP());
		}
	}

	public void IGMEFIHGKGA(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.BGMJCCFNNDL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			BOBCIFEDJED();
		}
	}

	public static ElevatorSwitchUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void KONLLOLHGGK(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 3)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void IKEFDCKJPOA()
	{
		for (int i = 1; i < levelButtons.Count; i += 0)
		{
			OBNGGGBMLML(levelButtons[i], i);
		}
	}

	protected void POOCFLCPFKP()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).BIHHMCBFPNK();
			((MonoBehaviour)this).StartCoroutine(DEFFKNMFFHI());
		}
	}

	private void ODPNPEHNBEI()
	{
		for (int i = 1; i < levelButtons.Count; i += 0)
		{
			PDPNHPCMIHB(levelButtons[i], i);
		}
	}

	private IEnumerator NNMEFDLFMFO()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	public static ElevatorSwitchUI MOMKLDLOAGD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MFGHFNHIJIN(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 1)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	protected void KCJDPHLBFEI()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).LBFFIBKMLGO();
			((MonoBehaviour)this).StartCoroutine(GBHDIGHLOFP());
		}
	}

	private void INICNHMAGEA(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			HAOPPNHACPB();
		}
	}

	private IEnumerator DFONMNAHKPI()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private IEnumerator OLFALFNEOGI()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	public static ElevatorSwitchUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OCHOECIHAFP(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			CLHBEDJEFGE();
		}
	}

	private void ABLIDJAKKJH(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			FIDGJDFADJD();
		}
	}

	protected void EILNMFLDHGL()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BIHHMCBFPNK();
			((MonoBehaviour)this).StartCoroutine(IAJPKNPADDP());
		}
	}

	private void MBCLKMKFNCB(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			FIDGJDFADJD();
		}
	}

	public void ENKMCLFMKPA(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 3)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	public void LGFMOOIGKAD(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 8)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	public void NBAOOEDKGHI(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 6)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private IEnumerator GBHDIGHLOFP()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	public static ElevatorSwitchUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HAOPPNHACPB()
	{
		for (int i = 0; i < levelButtons.Count; i += 0)
		{
			BDFEOKHHMJN(levelButtons[i], i);
		}
	}

	private void FLPJLIMILKO(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			KDCALGDOGCP();
		}
	}

	private IEnumerator LDAHHPJDLHO()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private void FIDGJDFADJD()
	{
		for (int i = 0; i < levelButtons.Count; i++)
		{
			EEBLLGEHCNA(levelButtons[i], i);
		}
	}

	public void HOCIBLAMMMO(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void CAGKALOBFJO()
	{
		for (int i = 1; i < levelButtons.Count; i += 0)
		{
			PDPNHPCMIHB(levelButtons[i], i);
		}
	}

	protected void CMANMOLHFIL()
	{
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LBFFIBKMLGO();
			((MonoBehaviour)this).StartCoroutine(INBHHLBAFJN());
		}
	}

	private void IEOBAOANHDI(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			JAHHAAKNCMG();
		}
	}

	protected void HNJACJDPPMH()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FJAKDODEIIF();
			((MonoBehaviour)this).StartCoroutine(BLKMGNEDFIF());
		}
	}

	public void IPMFHNDCMJI(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void HKOPNIHDFEC(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.AGGAGCBAGLL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Cellar");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("attachment");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("<sprite name=");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("[OfferingStatuePuzzle] FillOfferingSlotFromNetwork: item {0} not found.");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Drink");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_name_654");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(" ");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("\n");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("mForMins");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	public void LNMAGKEGEKJ(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 8)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void HLCAGMEIONO(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			MLONFEADGEC();
		}
	}

	public void MMNOKLBKKMF(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.PDECKLKPKCG().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void BFAPACELJHP(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Custom lobby data (Lobby owner): {0}");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.PDECKLKPKCG().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Chest opened, granting loot to player ");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/15/Dialogue Text");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(" not found. Cannot add to surface");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Dialogue System/Conversation/TavernClean/Entry/4/Dialogue Text");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Could not assign file ");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("\n");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("]");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Setup ");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Pet");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
	}

	private void EPAEKCBCAFH()
	{
		for (int i = 0; i < levelButtons.Count; i += 0)
		{
			PDPNHPCMIHB(levelButtons[i], i);
		}
	}

	private void CLHBEDJEFGE()
	{
		for (int i = 1; i < levelButtons.Count; i += 0)
		{
			CBEHKCLLGCE(levelButtons[i], i);
		}
	}

	private void INNPBBKKONM()
	{
		for (int i = 1; i < levelButtons.Count; i += 0)
		{
			BJLFCMIFCMO(levelButtons[i], i);
		}
	}

	protected void NBGDMPOFLAO()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).GGNLGAMLOKK();
			((MonoBehaviour)this).StartCoroutine(DKCENGOOIEP());
		}
	}

	private IEnumerator CGFIBMAHBAJ()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private void JAHHAAKNCMG()
	{
		for (int i = 0; i < levelButtons.Count; i += 0)
		{
			BDFEOKHHMJN(levelButtons[i], i);
		}
	}

	public void FPNCMJOOHAN(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 3)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void PPFOGMIGGBD()
	{
		for (int i = 0; i < levelButtons.Count; i++)
		{
			IKGHJOJOKHL(levelButtons[i], i);
		}
	}

	protected void EOLOHLCBFBP()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).IHDPOMIAKOO();
			((MonoBehaviour)this).StartCoroutine(OLFALFNEOGI());
		}
	}

	private void JLHCGALNMGP()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			LFIOOJECGBL(levelButtons[i], i);
		}
	}

	private void MLONFEADGEC()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			BFAPACELJHP(levelButtons[i], i);
		}
	}

	public void HCHMJEKHIBA(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			BOBCIFEDJED();
		}
	}

	private void HPJMBFCEBGG()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			COKOMLLIOHO(levelButtons[i], i);
		}
	}

	public static ElevatorSwitchUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HHIIJKHBOII(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			BOBCIFEDJED();
		}
	}

	private void AONPBEIODII()
	{
		for (int i = 0; i < levelButtons.Count; i += 0)
		{
			EEBLLGEHCNA(levelButtons[i], i);
		}
	}

	public void BDDNHJIBJMB(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.BGMJCCFNNDL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	protected void EELCGMLOBJA()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FPLPECHEGGI();
			((MonoBehaviour)this).StartCoroutine(GFNEOAPCADA());
		}
	}

	private IEnumerator INBHHLBAFJN()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private IEnumerator EHHMBOFMKPH()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GFMMMNEFCBG(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			FDKHEMJKBJL();
		}
	}

	private IEnumerator BLKMGNEDFIF()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void DBAMCPJMKFC()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).CKMLGHPIEEK();
			((MonoBehaviour)this).StartCoroutine(ENKFKHGDOPD());
		}
	}

	private void CBEHKCLLGCE(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveRemoveDrink");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.PDECKLKPKCG().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("UIInteract");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("[HasEnoughCandidates] Total available respecting maxPuzzleSpawners: {0}, needed: {1}");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Could not find Quest with id: ");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("No bed assigned to actor number: {0}");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("itemRedGrapeMust");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Price of ");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveAskHostForRoomToJoin");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ActiveDecoMode");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Must have a unique ID assigned.");
				break;
			case 9:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("OnlinePlayer");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	private IEnumerator DEFFKNMFFHI()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Start()
	{
		base.Start();
		MineManager instance = MineManager.GGFJGHHHEJC;
		instance.LevelUnlocked = (Action<int>)Delegate.Combine(instance.LevelUnlocked, new Action<int>(ABLIDJAKKJH));
	}

	protected void JNIBIICEFCL()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LBFFIBKMLGO();
			((MonoBehaviour)this).StartCoroutine(AFMNJCCEIGM());
		}
	}

	private void BJLFCMIFCMO(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("itemLeekSeeds");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.BGMJCCFNNDL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Received pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ErrorKicked");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("[Brown");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Select");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(" seconds.");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("[");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("cloth_name_");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Empty bites list");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("VerticalMove");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
	}

	private void JHBGODEBHOF(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			JLHCGALNMGP();
		}
	}

	private void DHIKMNMKLPC(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Idle");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.OOKBNHMMFON().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveStartEatingAtTable");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Player2");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("NoEresDigno/EndEvent");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("%><sprite name=LeftStick></size>");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("customersInTavern");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("LearnBalance");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_name_1069");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("NormalRightExterior");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("\nCode not found\n");
				break;
			case 9:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("UINextCategory");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	private IEnumerator IAJPKNPADDP()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	public void SetElevatorSwitch(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 2)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void PDPNHPCMIHB(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("SkeletonBird");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.AGGAGCBAGLL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("City/Carpenters/Ash/Bark");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(")");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("KentaProgress");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("tutorialPopUp28");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Actionbar 4");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("LE_10");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Pause");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Disabled");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("InteractPermissionAccepted");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("You have to use the PixelPerfectCamera script on the assigned UI camera!");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	public void NNJOFMOCKMJ(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 0)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void MKBHJKDLPCP()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			HKOPNIHDFEC(levelButtons[i], i);
		}
	}

	private void OBNGGGBMLML(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("SendHome");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.PDECKLKPKCG().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("]");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveAddZone");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Trying to set a player's steam name but they're not playing on a steam platform");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("0");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("<br>");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("R2");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ShieldTrigger");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("<sprite name=\"ironBarIcon\"><color=#8E1818>");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Tutorial/T106/Dialogue1");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("\" unlocked");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	public override void CloseUI()
	{
		base.CloseUI();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
	}

	public void FKEGGCLEBGN(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 0)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void NHKJIOPDAKA(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("action");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.AGGAGCBAGLL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("XNewRecipes");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("OnlinePlayer");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_name_1125");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(" ");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("[");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_description_706");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(">");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Unlocked at Tavern Reputation {0}");
				break;
			case 9:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Up");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
	}

	public override void OnContentActivated()
	{
		OFHCCIDHFFN();
	}

	public void MFEEDHNAILK(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.PDECKLKPKCG().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			BOBCIFEDJED();
		}
	}

	protected void IGPDBEDCDEF()
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).OKEACDGEJIB();
			((MonoBehaviour)this).StartCoroutine(BLKMGNEDFIF());
		}
	}

	public void ButtonPressed(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.GGFJGHHHEJC.unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void MBADJCABACK(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			CBAMEBHFGIP();
		}
	}

	private IEnumerator PIJEJJCPNLN()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	public void PINIOJFENPJ(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 1)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	public static ElevatorSwitchUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GFNEOAPCADA()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private void BDFEOKHHMJN(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ToggleGroup/ToggleBasic");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.AGGAGCBAGLL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Failed to join the game.\nPlease try again later.");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Wilson/Bark/Bark_Shop");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_description_593");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReciveLoadCrowlyEventToMaster");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_description_1065");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("itemAubergine");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("player2ToJoinGame");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ObjectHorizontalMove");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Pants_L");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	private void EOMCEPBKDFJ(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			HAOPPNHACPB();
		}
	}

	public void EANJCOJDNJF(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.OOKBNHMMFON().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void PPKEHDICIKF(int EONJGMONIOM)
	{
		if (IsOpen())
		{
			GKINKOIFLID();
		}
	}

	private void IFGMGKNIMNI(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			IKEFDCKJPOA();
		}
	}

	public void DKAOMIGMAIP(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.PDECKLKPKCG().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void GBFDDIBCHEL(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			GKINKOIFLID();
		}
	}

	public static ElevatorSwitchUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CBAMEBHFGIP()
	{
		for (int i = 1; i < levelButtons.Count; i += 0)
		{
			BDFEOKHHMJN(levelButtons[i], i);
		}
	}

	protected void DHKJJONJDGK()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).IHDPOMIAKOO();
			((MonoBehaviour)this).StartCoroutine(GBHDIGHLOFP());
		}
	}

	private void BDHLPIIFEIO(int EONJGMONIOM)
	{
		if (BGLJFMHCFJF())
		{
			FDKHEMJKBJL();
		}
	}

	public void PGDHFMMICLJ(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void EEBLLGEHCNA(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("BaseCamp");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.GGFJGHHHEJC.unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Blocked");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_1");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_2");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_3");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_4");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_5");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_6");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_7");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_8");
				break;
			case 9:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Floor_9");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	public void OBEHPGKLNFH(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 7)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private IEnumerator ENKFKHGDOPD()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private void COKOMLLIOHO(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("tutorialPopUp94");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.BGMJCCFNNDL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("StartLucenDialogue ");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_name_1230");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Start water quality test");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Moving");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveRenewCandle Unique id ");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("itemBarleySeeds");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Selected");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_name_1115");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("halloweenActivated");
				break;
			case 9:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Customise Character");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
	}

	public void IFEKHIMMJKA(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 8)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private IEnumerator DKCENGOOIEP()
	{
		return new KMIOEEOEDIE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PKKNCFENKCB(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 1)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	public void LAMGIENNNLH(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			BOBCIFEDJED();
		}
	}

	protected void JEPICGBBJGB()
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FJAKDODEIIF();
			((MonoBehaviour)this).StartCoroutine(GBHDIGHLOFP());
		}
	}

	public void AIFKDBBHMIH(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 8)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	public static ElevatorSwitchUI JHJKHEBKCFL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void FHNLEOBLLAB()
	{
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).GGNLGAMLOKK();
			((MonoBehaviour)this).StartCoroutine(ABKDPEOJAEN());
		}
	}

	public static ElevatorSwitchUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator AFMNJCCEIGM()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)levelButtons[PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF]).gameObject);
	}

	private void NCDGAPHNICF(int EONJGMONIOM)
	{
		if (HDEPMJIDJEM())
		{
			JAHHAAKNCMG();
		}
	}

	private void IKGHJOJOKHL(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveAddMoney");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.PDECKLKPKCG().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(" to user for reason ");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
			}
			switch (APFEFELKAPH)
			{
			case 0:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("/ExtraSettings.sd");
				break;
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("TimeLeft");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("GO");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Wilson/Bark/Bark_Clue");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceiveRentedRoomMessage");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Rotate");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Close");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("></size>");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Cannot place mine block piece at ");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(true);
		}
	}

	public static ElevatorSwitchUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ElevatorSwitchUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected void PDGCOFAHBDD()
	{
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL) && ((Component)this).gameObject.activeInHierarchy)
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEGCHMCDPOK();
			((MonoBehaviour)this).StartCoroutine(DKCENGOOIEP());
		}
	}

	public void DHACPLCHAIP(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.BGMJCCFNNDL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void OEJFAKHIDBI(ElevatorSwitch GIJHIMAMOJN)
	{
		if (base.JIIGOACEIKL == 6)
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone2;
		}
		else
		{
			elevatorTravelZone = GIJHIMAMOJN.travelZone;
		}
		GLCIPPNLBFC = GIJHIMAMOJN;
	}

	private void LFIOOJECGBL(ElevatorSwitchButtonUI DPICFKCAIEA, int APFEFELKAPH)
	{
		if (APFEFELKAPH == 0)
		{
			((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Visita Nocturna/MaiDialogue 01");
			DPICFKCAIEA.levelIcon.sprite = baseCamp;
		}
		else
		{
			if (MineManager.BGMJCCFNNDL().unlockedLevels < APFEFELKAPH)
			{
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Farm/Event/PiedrasVioletyArthur");
				DPICFKCAIEA.levelIcon.sprite = lockIcon;
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = false;
				return;
			}
			if ((Object)(object)MinePuzzleManager.puzzleInstances[APFEFELKAPH] != (Object)null && MinePuzzleManager.puzzleInstances[APFEFELKAPH].canGeneratePuzzle)
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
				if (MinePuzzleManager.puzzleInstances[APFEFELKAPH].rewardHandler.chest.IsChestOpened())
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleSolved;
				}
				else
				{
					DPICFKCAIEA.puzzleIcon.sprite = puzzleFound;
				}
			}
			else
			{
				((Behaviour)DPICFKCAIEA.puzzleIcon).enabled = true;
			}
			switch (APFEFELKAPH)
			{
			case 1:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("itemWineYeast");
				break;
			case 2:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("<sprite name=\"ironBarIcon\">");
				break;
			case 3:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(". Time since startup: ");
				break;
			case 4:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Rummage");
				break;
			case 5:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Return To Last Basic Mood");
				break;
			case 6:
				DPICFKCAIEA.levelIcon.sprite = firstMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("City/Hallmund/Talk/ForgeTool");
				break;
			case 7:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get(" ");
				break;
			case 8:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("Items/item_description_620");
				break;
			case 9:
				DPICFKCAIEA.levelIcon.sprite = thirdMine;
				((TMP_Text)DPICFKCAIEA.levelName).text = LocalisationSystem.Get("ReceivePhaseSlotFromContainer");
				break;
			}
		}
		if (APFEFELKAPH == PlayerController.OPHDCMJLLEC(base.JIIGOACEIKL).HCBDDKHPHCF)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
		else if (((Component)DPICFKCAIEA.playerIcon).gameObject.activeInHierarchy)
		{
			((Component)DPICFKCAIEA.playerIcon).gameObject.SetActive(false);
		}
	}

	public void ICAGGOBCOOL(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.AGGAGCBAGLL().unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.KACGDPCMGPL(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}

	private void FDKHEMJKBJL()
	{
		for (int i = 1; i < levelButtons.Count; i++)
		{
			EEBLLGEHCNA(levelButtons[i], i);
		}
	}

	public void JBJPDBNJNEM(int EONJGMONIOM)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (EONJGMONIOM != PlayerController.GetPlayer(base.JIIGOACEIKL).HCBDDKHPHCF && MineManager.GGFJGHHHEJC.unlockedLevels >= EONJGMONIOM)
		{
			elevatorTravelZone.forceTravelToMineLevel = EONJGMONIOM;
			elevatorTravelZone.StartTravelZone(base.JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(elevatorHandleSound, ((Component)GLCIPPNLBFC).transform.position);
			CloseUI();
		}
	}
}
