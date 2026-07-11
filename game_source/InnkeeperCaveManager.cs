using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;

public class InnkeeperCaveManager : MonoBehaviour, IInteractable, IProximity, IHoverable, ISelectable
{
	[CompilerGenerated]
	private sealed class JCJILPBDNMM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnkeeperCaveManager _003C_003E4__this;

		public int index;

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
		public JCJILPBDNMM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			int num = _003C_003E1__state;
			InnkeeperCaveManager innkeeperCaveManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MultiAudioManager.PlayAudioObject(innkeeperCaveManager.audioBlueFire, ((Component)innkeeperCaveManager.objectsToActivate[index]).transform);
				innkeeperCaveManager.objectsToActivate[index].SetActive(FAFHGCBNNJO: true);
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

	[CompilerGenerated]
	private sealed class FHHNCOPNCAH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InnkeeperCaveManager _003C_003E4__this;

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
		public FHHNCOPNCAH(int _003C_003E1__state)
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
			InnkeeperCaveManager innkeeperCaveManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				EventTextUI.Get(innkeeperCaveManager.GELMAIBEHDO).Close();
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerInputs.EnableKeyboardInputs(innkeeperCaveManager.GELMAIBEHDO, (MonoBehaviour)(object)innkeeperCaveManager);
				PlayerController.RemoveMovementBlocker(innkeeperCaveManager.GELMAIBEHDO, (Object)(object)innkeeperCaveManager);
				if (GameManager.LocalCoop())
				{
					int jIIGOACEIKL = ((innkeeperCaveManager.GELMAIBEHDO != 1) ? 1 : 2);
					PlayerInputs.EnableKeyboardInputs(jIIGOACEIKL, (MonoBehaviour)(object)innkeeperCaveManager);
					PlayerController.RemoveMovementBlocker(jIIGOACEIKL, (Object)(object)innkeeperCaveManager);
				}
				PlayerInputs.GetPlayer(innkeeperCaveManager.GELMAIBEHDO).SwitchMapCategoryNextFrame("Game");
				GameActionBarUI.Get(innkeeperCaveManager.GELMAIBEHDO).OpenUI();
				if (GameManager.LocalCoop())
				{
					GameActionBarUI.Get((innkeeperCaveManager.GELMAIBEHDO != 1) ? 1 : 2).OpenUI();
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

	public ActiveAndDisableObjects[] objectsToActivate;

	public ActiveAndDisableObjects[] objectsPermanentActivated;

	public AudioObject audioBlueFire;

	[SerializeField]
	private ShopType shopType;

	private int GELMAIBEHDO = 1;

	private float LGLDPMAABLA;

	public bool ALGCHPCDFBM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator GJLILOGFNEM(int MOFKEDGAOEE)
	{
		return new JCJILPBDNMM(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	private void ADOHOCJOFAC()
	{
		((MonoBehaviour)this).StartCoroutine(FPENBJJOJEP());
	}

	private void Update()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 1 && EventTextUI.Get(GELMAIBEHDO).IsOpen() && Time.time > LGLDPMAABLA && PlayerInputs.GetPlayer(GELMAIBEHDO).GetAnyButtonDown())
		{
			ADOHOCJOFAC();
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void CLHGAEEHEAB(int JIIGOACEIKL)
	{
	}

	private void EFCNKPEPELL()
	{
		if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 2)
		{
			PPAEGFKFEJN();
		}
	}

	public void GHJNDIDNJKA(int JIIGOACEIKL)
	{
	}

	public bool JEHOCIKPEJD(int JIIGOACEIKL)
	{
		if (ANLNJIGAEJM(JIIGOACEIKL))
		{
			GELMAIBEHDO = JIIGOACEIKL;
			if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 0)
			{
				((TMP_Text)EventTextUI.CJMILOMGFJL(JIIGOACEIKL).eventText).text = LocalisationSystem.Get("talentHerbs");
				EventTextUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
				PlayerInputs.JBKHOPCMBAC(JIIGOACEIKL, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
				if (GameManager.LocalCoop())
				{
					bool jIIGOACEIKL = JIIGOACEIKL == 1;
					PlayerInputs.DisableKeyboardInputs(jIIGOACEIKL ? 1 : 0, (MonoBehaviour)(object)this);
					PlayerController.AddMovementBlocker(jIIGOACEIKL ? 1 : 0, (Object)(object)this, ANJCLPDCJHL: true);
				}
				PlayerInputs.GetPlayer(JIIGOACEIKL).AMMIOLBGBPB("Direction");
				GameActionBarUI.MGLNAMHAIDG(JIIGOACEIKL).BOBCIFEDJED();
				if (GameManager.LocalCoop())
				{
					GameActionBarUI.MGLNAMHAIDG((JIIGOACEIKL == 1) ? 1 : 0).CloseUI();
				}
				CommonReferences.GGFJGHHHEJC.eventNum[0] = 1;
				LGLDPMAABLA = Time.time + 94f;
			}
			else
			{
				if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 1)
				{
					if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == -118)
					{
						(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).AKLIBLOJJMF();
					}
					ActiveObject();
					CommonReferences.MNFMOEKMJKN().eventNum[0] = 5;
					return false;
				}
				if (CommonReferences.MNFMOEKMJKN().eventNum[1] == 6)
				{
					ShopUI.IEKODILKIHJ(JIIGOACEIKL).shop = ShopDatabaseAccessor.MNLIACMLIEG(shopType);
					ShopUI.JCBPABNCBPI(JIIGOACEIKL).OpenUI();
					SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
					return true;
				}
			}
		}
		return true;
	}

	public bool GPANAJKPLPO(int JIIGOACEIKL)
	{
		return false;
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
	}

	public bool JNOMKJLMPKK(int JIIGOACEIKL)
	{
		if (ANLNJIGAEJM(JIIGOACEIKL))
		{
			GELMAIBEHDO = JIIGOACEIKL;
			if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 0)
			{
				((TMP_Text)EventTextUI.MHOKIBDMIPL(JIIGOACEIKL).eventText).text = LocalisationSystem.Get("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
				EventTextUI.BGIMGOJDLFG(JIIGOACEIKL).OpenUI();
				PlayerInputs.DisableKeyboardInputs(JIIGOACEIKL, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
				if (GameManager.LocalCoop())
				{
					int jIIGOACEIKL = ((JIIGOACEIKL == 1) ? 5 : 0);
					PlayerInputs.JBKHOPCMBAC(jIIGOACEIKL, (MonoBehaviour)(object)this);
					PlayerController.AddMovementBlocker(jIIGOACEIKL, (Object)(object)this);
				}
				PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).AMMIOLBGBPB("Player num by bed assigned failed. Finding by name...");
				GameActionBarUI.PHDBJGOEKHB(JIIGOACEIKL).BOBCIFEDJED();
				if (GameManager.LocalCoop())
				{
					GameActionBarUI.JGNOJMLHPOK((JIIGOACEIKL != 0) ? 1 : 7).BOBCIFEDJED();
				}
				CommonReferences.MNFMOEKMJKN().eventNum[0] = 1;
				LGLDPMAABLA = Time.time + 1686f;
			}
			else
			{
				if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 1)
				{
					if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 191)
					{
						(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).HIIFPJLHCJE();
					}
					OHJIBGCFEHN();
					CommonReferences.MNFMOEKMJKN().eventNum[1] = 7;
					return true;
				}
				if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 8)
				{
					ShopUI.NALKHGMLALJ(JIIGOACEIKL).shop = ShopDatabaseAccessor.MDLINJLBFPH(shopType);
					ShopUI.EPKNOMLADCL(JIIGOACEIKL).EDHEIFHAAKO();
					SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
					return false;
				}
			}
		}
		return true;
	}

	public bool FKCBIGBKHAP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DGDIKLAMDNI()
	{
		for (int i = 1; i < objectsToActivate.Length; i += 0)
		{
			((MonoBehaviour)this).StartCoroutine(DHIEDEKAKIL(i));
		}
		Utils.DLIIAHACOJB(68, CDPAMNIPPEC: true);
	}

	public void OHJIBGCFEHN()
	{
		for (int i = 0; i < objectsToActivate.Length; i++)
		{
			((MonoBehaviour)this).StartCoroutine(GCHNIPKKJDB(i));
		}
		Utils.DLIIAHACOJB(68, CDPAMNIPPEC: true);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void ActiveObject()
	{
		for (int i = 0; i < objectsToActivate.Length; i++)
		{
			((MonoBehaviour)this).StartCoroutine(GCHNIPKKJDB(i));
		}
		Utils.DLIIAHACOJB(29);
	}

	public bool ANLNJIGAEJM(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool OEJADJPDOHK(int JIIGOACEIKL)
	{
		return true;
	}

	private void Awake()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 2)
		{
			PPAEGFKFEJN();
		}
	}

	private void Start()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 2 && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 137)
		{
			(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).FireStart();
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void MGKLDEDLCGL()
	{
		for (int i = 0; i < objectsPermanentActivated.Length; i += 0)
		{
			objectsPermanentActivated[i].HCKPPINKDNE(FAFHGCBNNJO: true);
		}
		Utils.DLIIAHACOJB(-37, CDPAMNIPPEC: true);
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void GHNIOKFDOMC(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void NIHJCJJKDBA()
	{
		if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 0 && EventTextUI.PNCKAKBBKJL(GELMAIBEHDO).IsOpen() && Time.time > LGLDPMAABLA && PlayerInputs.DEGBDMMDIIL(GELMAIBEHDO).AFGBJBJBIAG())
		{
			GFAPCLNJJHH();
		}
	}

	public bool JONCEAPNGEC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !EventTextUI.JGNOJMLHPOK(JIIGOACEIKL).BGLJFMHCFJF())
		{
			if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 0)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("quest_description_30"));
			}
			else if (CommonReferences.MNFMOEKMJKN().eventNum[1] == 0)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("itemStoutWort"));
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 4)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UINextPage"));
			}
			return false;
		}
		return true;
	}

	public bool CCHCKHEDBII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator KEPMLIEPBHM()
	{
		return new FHHNCOPNCAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MFMMHDPGCBO()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 1 && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 193)
		{
			(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).NJIGICOLMAO();
		}
	}

	public bool LKLOBCHCMJE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void KDHLJKMKFMG()
	{
		if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 8)
		{
			PPAEGFKFEJN();
		}
	}

	private void MIKNFPCDLML()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 0)
		{
			PKLOPMBCEHK();
		}
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	private void HPJBLOPJIMI()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 6)
		{
			MGKLDEDLCGL();
		}
	}

	private void DCKKIDMJKJM()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 6 && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 187)
		{
			(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).PJIECGAMMAP();
		}
	}

	private IEnumerator CLABCKLBLHO(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		MultiAudioManager.PlayAudioObject(audioBlueFire, ((Component)objectsToActivate[MOFKEDGAOEE]).transform);
		objectsToActivate[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	private void PKLOPMBCEHK()
	{
		for (int i = 1; i < objectsPermanentActivated.Length; i++)
		{
			objectsPermanentActivated[i].GKDHBBJFIDL(FAFHGCBNNJO: true);
		}
		Utils.DLIIAHACOJB(-90);
	}

	private IEnumerator GCHNIPKKJDB(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		MultiAudioManager.PlayAudioObject(audioBlueFire, ((Component)objectsToActivate[MOFKEDGAOEE]).transform);
		objectsToActivate[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !EventTextUI.Get(JIIGOACEIKL).IsOpen())
		{
			if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 0)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Read"));
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 1)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Light Fire"));
			}
			else if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 2)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			}
			return true;
		}
		return false;
	}

	public void NIPHFNAJKBN(int JIIGOACEIKL)
	{
	}

	private void PPAEGFKFEJN()
	{
		for (int i = 0; i < objectsPermanentActivated.Length; i++)
		{
			objectsPermanentActivated[i].SetActive(FAFHGCBNNJO: true);
		}
		Utils.DLIIAHACOJB(29);
	}

	public bool BKAEMAHKBBM(int JIIGOACEIKL)
	{
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).CloseUI();
		return false;
	}

	public void FICHLOJLIIP(int JIIGOACEIKL)
	{
	}

	private IEnumerator DHIEDEKAKIL(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		MultiAudioManager.PlayAudioObject(audioBlueFire, ((Component)objectsToActivate[MOFKEDGAOEE]).transform);
		objectsToActivate[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
	}

	public void JOLMKBCLDPM()
	{
		for (int i = 1; i < objectsToActivate.Length; i += 0)
		{
			((MonoBehaviour)this).StartCoroutine(GJLILOGFNEM(i));
		}
		Utils.DLIIAHACOJB(-100);
	}

	public bool EBIDPMLPLIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void FOHGHCPODBJ()
	{
		if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 3 && NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 84)
		{
			(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).FireStart();
		}
	}

	public void DPDBGCIINLA()
	{
		for (int i = 1; i < objectsToActivate.Length; i++)
		{
			((MonoBehaviour)this).StartCoroutine(GCHNIPKKJDB(i));
		}
		Utils.DLIIAHACOJB(-6);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			GELMAIBEHDO = JIIGOACEIKL;
			if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 0)
			{
				((TMP_Text)EventTextUI.Get(JIIGOACEIKL).eventText).text = LocalisationSystem.Get("InkeepersCave_Message");
				EventTextUI.Get(JIIGOACEIKL).OpenUI();
				PlayerInputs.DisableKeyboardInputs(JIIGOACEIKL, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
				if (GameManager.LocalCoop())
				{
					int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 1 : 2);
					PlayerInputs.DisableKeyboardInputs(jIIGOACEIKL, (MonoBehaviour)(object)this);
					PlayerController.AddMovementBlocker(jIIGOACEIKL, (Object)(object)this);
				}
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("UI");
				GameActionBarUI.Get(JIIGOACEIKL).CloseUI();
				if (GameManager.LocalCoop())
				{
					GameActionBarUI.Get((JIIGOACEIKL != 1) ? 1 : 2).CloseUI();
				}
				CommonReferences.GGFJGHHHEJC.eventNum[0] = 1;
				LGLDPMAABLA = Time.time + 10f;
			}
			else
			{
				if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 1)
				{
					if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 137)
					{
						(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).FireStart();
					}
					ActiveObject();
					CommonReferences.GGFJGHHHEJC.eventNum[0] = 2;
					return true;
				}
				if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 2)
				{
					ShopUI.Get(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
					ShopUI.Get(JIIGOACEIKL).OpenUI();
					SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
					return true;
				}
			}
		}
		return false;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		ShopUI.Get(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool EBMAMAPEJPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator FPENBJJOJEP()
	{
		EventTextUI.Get(GELMAIBEHDO).Close();
		yield return CommonReferences.wait1;
		PlayerInputs.EnableKeyboardInputs(GELMAIBEHDO, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(GELMAIBEHDO, (Object)(object)this);
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((GELMAIBEHDO != 1) ? 1 : 2);
			PlayerInputs.EnableKeyboardInputs(jIIGOACEIKL, (MonoBehaviour)(object)this);
			PlayerController.RemoveMovementBlocker(jIIGOACEIKL, (Object)(object)this);
		}
		PlayerInputs.GetPlayer(GELMAIBEHDO).SwitchMapCategoryNextFrame("Game");
		GameActionBarUI.Get(GELMAIBEHDO).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get((GELMAIBEHDO != 1) ? 1 : 2).OpenUI();
		}
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	private void GFAPCLNJJHH()
	{
		((MonoBehaviour)this).StartCoroutine(FPENBJJOJEP());
	}

	public bool HOGBEKJNJBM(int JIIGOACEIKL)
	{
		return false;
	}

	private IEnumerator LDIIKMLAPLB(int MOFKEDGAOEE)
	{
		return new JCJILPBDNMM(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	public bool JKNLDABKJIE(int JIIGOACEIKL)
	{
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool PHGADHENHDF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			GELMAIBEHDO = JIIGOACEIKL;
			if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 0)
			{
				((TMP_Text)EventTextUI.JOAAFGBPJOC(JIIGOACEIKL).eventText).text = LocalisationSystem.Get("Disabled");
				EventTextUI.CJMILOMGFJL(JIIGOACEIKL).OpenUI();
				PlayerInputs.JBKHOPCMBAC(JIIGOACEIKL, (MonoBehaviour)(object)this);
				PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
				if (GameManager.LocalCoop())
				{
					int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 1 : 7);
					PlayerInputs.JBKHOPCMBAC(jIIGOACEIKL, (MonoBehaviour)(object)this);
					PlayerController.AddMovementBlocker(jIIGOACEIKL, (Object)(object)this, ANJCLPDCJHL: true);
				}
				PlayerInputs.GetPlayer(JIIGOACEIKL).SwitchMapCategoryNextFrame("<mark=#000000><alpha=#00> ");
				GameActionBarUI.PHDBJGOEKHB(JIIGOACEIKL).BOBCIFEDJED();
				if (GameManager.LocalCoop())
				{
					GameActionBarUI.NIDHCIHFOHB((JIIGOACEIKL == 0) ? 4 : 0).BOBCIFEDJED();
				}
				CommonReferences.MNFMOEKMJKN().eventNum[0] = 1;
				LGLDPMAABLA = Time.time + 1738f;
			}
			else
			{
				if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 0)
				{
					if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 167)
					{
						(NewTutorialManager.instance.currentTutorialPhase as T137_EncenderAntorcha).GPOENCCKMGD();
					}
					JOLMKBCLDPM();
					CommonReferences.GGFJGHHHEJC.eventNum[1] = 2;
					return true;
				}
				if (CommonReferences.MNFMOEKMJKN().eventNum[1] == 2)
				{
					ShopUI.FKFNANNBIAM(JIIGOACEIKL).shop = ShopDatabaseAccessor.MNLIACMLIEG(shopType);
					ShopUI.FKFNANNBIAM(JIIGOACEIKL).EDHEIFHAAKO();
					SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
					return true;
				}
			}
		}
		return false;
	}
}
