using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BirdNPC : MonoBehaviour, IInteractable, IProximity, ISelectable, IHoverable
{
	[CompilerGenerated]
	private sealed class GCFHCNPJEMN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BirdNPC _003C_003E4__this;

		public BirdInstance birdInstance;

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
		public GCFHCNPJEMN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			int num = _003C_003E1__state;
			BirdNPC birdNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				birdNPC.DLCNBKAEOBP = false;
				if (OnlineManager.MasterOrOffline() && SpawnCat.GGFJGHHHEJC.catNPC.currentCatState is CatStateBirdInteract)
				{
					SpawnCat.GGFJGHHHEJC.catNPC.WalkAround();
				}
				birdNPC.emotions.StartEmotion("Dead");
				if (birdNPC.birdAnimator.reskins[0].spriteInfo.id == 6)
				{
					((Renderer)birdNPC.featherExplosion).material = birdNPC.birdExplosionMaterial;
				}
				else
				{
					((Renderer)birdNPC.featherExplosion).material = birdNPC.birdAnimator.reskins[0].characterMaterial.material;
				}
				_003C_003E2__current = (object)new WaitForSeconds(2.8f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				birdNPC.skeletonFx.SetActive(true);
				_003C_003E2__current = CommonReferences.wait03;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (birdNPC.birdAnimator.reskins[0].spriteInfo.id == 6)
				{
					MultiAudioManager.PlayAudioObject(birdNPC.owlExplosionSound, ((Component)birdNPC).transform);
				}
				else
				{
					MultiAudioManager.PlayAudioObject(birdNPC.birdExplosionSound, ((Component)birdNPC).transform);
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
			{
				_003C_003E1__state = -1;
				birdNPC.EACGPIGFLDC(birdInstance);
				Result variable = DialogueLua.GetVariable("SkeletonBird");
				if (((Result)(ref variable)).asInt == 0)
				{
					DialogueLua.SetVariable("SkeletonBird", (object)1);
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 4;
				return true;
			}
			case 4:
				_003C_003E1__state = -1;
				birdNPC.skeletonFx.SetActive(false);
				birdNPC.DLCNBKAEOBP = true;
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

	public static BirdNPC currentBird;

	public BasicAnimator birdAnimator;

	public Placeable placeable;

	public Placeable perchPlaceable;

	public Item cookieItem;

	public Item cookieDemonItem;

	public Item elixirItem;

	public BirdSpriteInfo birdSkeleton;

	public Animator fullEmote;

	public GameObject cookieEmote;

	public Canvas canvas;

	public BirdSpeech birdSpeech;

	public int probabilityToTurnIntoSkeleton = 25;

	public float cookieIncrement = 0.1f;

	public float cookieDecrement = 0.02f;

	public float timeBetweenFlight = 30f;

	public float timeBetweenSwinging = 4f;

	public float timeBetweenLeftMovement = 12f;

	public float timeBetweenLookAround = 16f;

	public float timeBetweenScratch = 15f;

	public float canGiveCookieTime = 20f;

	public bool catInteract;

	public bool catAttack;

	private float DAMEAKLPFAK;

	private float IKKIDINONGI;

	private float NEIOKIGPAKF;

	public AudioObject cookieAudio;

	public AudioObject birdWingsSound;

	public EmotionsController emotions;

	public GameObject skeletonFx;

	public SpriteRenderer featherExplosion;

	public AudioObject birdExplosionSound;

	public AudioObject owlExplosionSound;

	public Material birdExplosionMaterial;

	public OnlineBird onlineBird;

	private bool HDMPGBFOMFA = true;

	private bool DLCNBKAEOBP
	{
		get
		{
			return HDMPGBFOMFA;
		}
		set
		{
			if (HDMPGBFOMFA == value)
			{
				return;
			}
			HDMPGBFOMFA = value;
			string item = "Error_CannotPickUp";
			if (HDMPGBFOMFA)
			{
				placeable.selectBlockers.Remove(item);
				if ((Object)(object)placeable.currentSurface != (Object)null)
				{
					placeable.currentSurface.placeable.selectBlockers.Remove(item);
				}
			}
			else if (!placeable.selectBlockers.Contains(item))
			{
				placeable.selectBlockers.Add(item);
				if ((Object)(object)placeable.currentSurface != (Object)null)
				{
					placeable.currentSurface.placeable.selectBlockers.Add(item);
				}
			}
		}
	}

	private float BKIJBBELCEM(float DEBHPJDIAEK)
	{
		return Time.time + DEBHPJDIAEK + Random.Range((0f - DEBHPJDIAEK) / 2f, DEBHPJDIAEK / 2f);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && DLCNBKAEOBP && Object.op_Implicit((Object)(object)perchPlaceable))
		{
			return !perchPlaceable.FHEMHCEAICB;
		}
		return false;
	}

	private void OKHLEMPJONN()
	{
		if ((Object)(object)currentBird == (Object)null)
		{
			currentBird = this;
		}
		DAMEAKLPFAK = BKIJBBELCEM(timeBetweenLeftMovement);
		IKKIDINONGI = BKIJBBELCEM(timeBetweenLookAround);
		NEIOKIGPAKF = BKIJBBELCEM(timeBetweenScratch);
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	public bool BGHCJHPNKHP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void AGLMGDNBHBF()
	{
		if ((Object)(object)currentBird == (Object)null)
		{
			currentBird = this;
		}
		DAMEAKLPFAK = BKIJBBELCEM(timeBetweenLeftMovement);
		IKKIDINONGI = BKIJBBELCEM(timeBetweenLookAround);
		NEIOKIGPAKF = BKIJBBELCEM(timeBetweenScratch);
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void HCNDNDGKJHE(float JPCPNGLHGAI)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.educationText, ((Component)this).transform.position, Quaternion.identity).GetComponent<RepText>().ELMCPNGHKOI = (int)(JPCPNGLHGAI * 100f);
	}

	public void SetBool(int GJKKNOKIKBJ, bool EGFGNGJGBOP, bool CDPAMNIPPEC)
	{
		birdAnimator.animator.SetBool(GJKKNOKIKBJ, EGFGNGJGBOP);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			onlineBird.SendSetBool(GJKKNOKIKBJ, EGFGNGJGBOP);
		}
	}

	public void SetTrigger(string GEGDHHIDEEF, bool CDPAMNIPPEC)
	{
		SetTrigger(Animator.StringToHash(GEGDHHIDEEF), CDPAMNIPPEC);
	}

	private void HFFFFAJFIPB()
	{
		if (placeable.itemSetup.OKKMOHLMHAM() is BirdInstance birdInstance)
		{
			SetBirdCharacterSpriteAndMaterial(birdInstance.birdId, birdInstance.birdMaterialId);
			placeable.initialMaterial = birdInstance.DAGEBDLEHKA();
		}
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	public void ChangeToBird()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
		{
			((MonoBehaviour)this).StartCoroutine(FOIGAPMNJFK(NKFPJPCFBJI: true, 3f));
			birdInstance.birdId = birdInstance.prevSkelBirdId;
			birdInstance.birdMaterialId = birdInstance.prevSkelBirdMaterialId;
			BirdSpriteInfo bird = CharacterSpritesDBAccessor.GetBird(birdInstance.birdId);
			birdAnimator.ChangeSkin(bird);
			birdAnimator.ChangeMaterial(CharacterSpritesDBAccessor.GetMaterial(birdInstance.birdMaterialId));
			placeable.initialMaterial = birdInstance.IEHJMMBMLPO();
		}
	}

	private void Awake()
	{
		if ((Object)(object)currentBird == (Object)null)
		{
			currentBird = this;
		}
		DAMEAKLPFAK = BKIJBBELCEM(timeBetweenLeftMovement);
		IKKIDINONGI = BKIJBBELCEM(timeBetweenLookAround);
		NEIOKIGPAKF = BKIJBBELCEM(timeBetweenScratch);
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	public bool FBODGFKDBCD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void IHDFGMAGNMG(bool CDPAMNIPPEC)
	{
		catAttack = false;
		CJKJAEAIABG(AnimatorParameterCache.p_Flight, CDPAMNIPPEC: false);
		NNNEKNDGOBM();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.CALOKGFCDPN();
		}
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)currentBird == (Object)null)
		{
			currentBird = this;
		}
		DAMEAKLPFAK = BKIJBBELCEM(timeBetweenLeftMovement);
		IKKIDINONGI = BKIJBBELCEM(timeBetweenLookAround);
		NEIOKIGPAKF = BKIJBBELCEM(timeBetweenScratch);
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private bool DGNLCHNPPLP(int JIIGOACEIKL)
	{
		if (EMAEIAPOGAN(JIIGOACEIKL, cookieDemonItem))
		{
			if (!CJCMCGHBJNK() && Random.Range(1, -97) < probabilityToTurnIntoSkeleton)
			{
				IMNJHOCGPIO(CDPAMNIPPEC: false);
			}
			return false;
		}
		return false;
	}

	private bool PIMLGBOAMEC()
	{
		if (placeable.itemSetup.FOIPFKPCIIN() is BirdInstance birdInstance)
		{
			return CharacterSpritesDBAccessor.IDPLFDGMIFL(birdInstance.birdId).isSkeleton;
		}
		return false;
	}

	private IEnumerator HHABKFOGEPO(BirdInstance CCDEPALBABD)
	{
		DLCNBKAEOBP = false;
		if (OnlineManager.MasterOrOffline() && SpawnCat.GGFJGHHHEJC.catNPC.currentCatState is CatStateBirdInteract)
		{
			SpawnCat.GGFJGHHHEJC.catNPC.WalkAround();
		}
		emotions.StartEmotion("Dead");
		if (birdAnimator.reskins[0].spriteInfo.id == 6)
		{
			((Renderer)featherExplosion).material = birdExplosionMaterial;
		}
		else
		{
			((Renderer)featherExplosion).material = birdAnimator.reskins[0].characterMaterial.material;
		}
		yield return (object)new WaitForSeconds(2.8f);
		skeletonFx.SetActive(true);
		yield return CommonReferences.wait03;
		if (birdAnimator.reskins[0].spriteInfo.id == 6)
		{
			MultiAudioManager.PlayAudioObject(owlExplosionSound, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(birdExplosionSound, ((Component)this).transform);
		}
		yield return CommonReferences.wait05;
		EACGPIGFLDC(CCDEPALBABD);
		Result variable = DialogueLua.GetVariable("SkeletonBird");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("SkeletonBird", (object)1);
		}
		yield return CommonReferences.wait2;
		skeletonFx.SetActive(false);
		DLCNBKAEOBP = true;
	}

	private void AIBKHNCMMHN(BirdInstance CCDEPALBABD)
	{
		CCDEPALBABD.prevSkelBirdId = CCDEPALBABD.birdId;
		CCDEPALBABD.prevSkelBirdMaterialId = CCDEPALBABD.birdMaterialId;
		CCDEPALBABD.birdId = birdSkeleton.id;
		CCDEPALBABD.birdMaterialId = birdSkeleton.FOHAFIBNNKD();
		birdAnimator.ODMMGJPCGOE(birdSkeleton);
		birdAnimator.DBFGCDIOAMA(CharacterSpritesDBAccessor.CIJJJBJNLIF(CCDEPALBABD.birdMaterialId));
		placeable.initialMaterial = CCDEPALBABD.NPBFLGNHIGM();
	}

	public void CatAttack(bool CDPAMNIPPEC)
	{
		catAttack = true;
		SetTrigger(AnimatorParameterCache.p_Flight, CDPAMNIPPEC: false);
		MakeWingsSound();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.SendCatAttack();
		}
	}

	public void GiveCookie(int JIIGOACEIKL, BirdInstance CCDEPALBABD, Item KILOIDFDOAD, bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(KILOIDFDOAD);
		}
		CCDEPALBABD.lastCookieGivenTime = Time.time;
		CCDEPALBABD.cookiesGivenPerDay++;
		MultiAudioManager.PlayAudioObject(cookieAudio, ((Component)this).transform);
		if (Time.time < birdSpeech.timeLastComment + canGiveCookieTime)
		{
			if (birdSpeech.lastCommentWasPositive)
			{
				CCDEPALBABD.commentsQuality += cookieIncrement;
				HCNDNDGKJHE(cookieIncrement);
			}
			else
			{
				CCDEPALBABD.commentsQuality -= cookieDecrement;
				HCNDNDGKJHE(0f - cookieDecrement);
			}
		}
		else
		{
			HCNDNDGKJHE(0f);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.SendGiveCookie();
		}
	}

	public void MIMAJADIHMA(bool CDPAMNIPPEC)
	{
		catAttack = true;
		SetTrigger(AnimatorParameterCache.p_Flight, CDPAMNIPPEC: true);
		NNNEKNDGOBM();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.SendCatAttack();
		}
	}

	public bool FLMGGAIJABG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool ALPPCGLKHIO(int JIIGOACEIKL)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			BirdUI.CNAPMIHPOKC(JIIGOACEIKL).EBHHIIAOIGL(placeable.itemSetup.GJAGNJIKPBF() as BirdInstance);
			perchPlaceable.selectBlockers.Add("Leave smoothly");
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			BirdUI.MIAOGLENOHL(JIIGOACEIKL).newBird = true;
			BirdUI.KNMACJDNGEE(JIIGOACEIKL).Open(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			List<Item> list = new List<Item>();
			BirdInstance birdInstance = placeable.itemSetup.CAFFKNLONIK() as BirdInstance;
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CCEPCEJIEOP(cookieItem))
				{
					list.Add(cookieItem);
				}
				if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(cookieDemonItem))
				{
					list.Add(cookieDemonItem);
				}
			}
			if (MIOGDGFMLAJ() && PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).CHOAPBFAAAM(elixirItem))
			{
				list.Add(elixirItem);
			}
			if (list.Count > 0)
			{
				InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
				ChooseItemUI.JHOHGMODKGM(JIIGOACEIKL).itemsList = list;
				ChooseItemUI chooseItemUI = ChooseItemUI.EPLOMIBMKFC(JIIGOACEIKL);
				chooseItemUI.OnItemSelected = (Action<int, Item>)Delegate.Combine(chooseItemUI.OnItemSelected, new Action<int, Item>(GFPFAOGHGEN));
				ChooseItemUI.HICGKNJMGOE(JIIGOACEIKL).EDHEIFHAAKO();
				return false;
			}
			if (list.Count == 1)
			{
				KIGPGBMMMMA(JIIGOACEIKL, list[0]);
				return false;
			}
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("City/Lia/Bark/Buy", JIIGOACEIKL);
			}
		}
		return true;
	}

	private IEnumerator FOIGAPMNJFK(bool NKFPJPCFBJI, float LGLDPMAABLA)
	{
		yield return (object)new WaitForSeconds(LGLDPMAABLA);
		DLCNBKAEOBP = NKFPJPCFBJI;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			BirdInstance birdInstance = placeable.itemSetup.DNLMCHDOMOK as BirdInstance;
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				flag = PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(cookieItem);
				if (flag)
				{
					num++;
				}
				flag2 = PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(cookieDemonItem);
				if (flag2)
				{
					num++;
				}
			}
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(elixirItem) && MIOGDGFMLAJ())
			{
				num++;
			}
			if (num > 1)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Give"));
			}
			else if (num == 1)
			{
				if (flag)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("GiveItem"), cookieItem.IABAKHPEOAF(OAFPBCPDOKH: true)));
				}
				else if (flag2)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("GiveItem"), cookieDemonItem.IABAKHPEOAF(OAFPBCPDOKH: true)));
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("GiveItem"), elixirItem.IABAKHPEOAF(OAFPBCPDOKH: true)));
				}
			}
			else if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("GiveItem"), cookieItem.IABAKHPEOAF(OAFPBCPDOKH: true)));
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Information"));
			return true;
		}
		return false;
	}

	private bool CJCMCGHBJNK()
	{
		if (placeable.itemSetup.FOIPFKPCIIN() is BirdInstance birdInstance)
		{
			return CharacterSpritesDBAccessor.NFDBLCCBIEL(birdInstance.birdId).isSkeleton;
		}
		return true;
	}

	public bool BHLKEMIONKG(int JIIGOACEIKL)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			List<Item> list = new List<Item>();
			BirdInstance birdInstance = placeable.itemSetup.OKKMOHLMHAM() as BirdInstance;
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).CCEPCEJIEOP(cookieItem))
				{
					list.Add(cookieItem);
				}
				if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).CHOAPBFAAAM(cookieDemonItem))
				{
					list.Add(cookieDemonItem);
				}
			}
			if (CJCMCGHBJNK() && PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).CHOAPBFAAAM(elixirItem))
			{
				list.Add(elixirItem);
			}
			if (list.Count > 0)
			{
				InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
				ChooseItemUI.EPLOMIBMKFC(JIIGOACEIKL).itemsList = list;
				ChooseItemUI chooseItemUI = ChooseItemUI.HICGKNJMGOE(JIIGOACEIKL);
				chooseItemUI.OnItemSelected = (Action<int, Item>)Delegate.Combine(chooseItemUI.OnItemSelected, new Action<int, Item>(KIGPGBMMMMA));
				ChooseItemUI.HEGPDGJEOPC(JIIGOACEIKL).EDHEIFHAAKO();
				return true;
			}
			if (list.Count == 0)
			{
				GFPFAOGHGEN(JIIGOACEIKL, list[1]);
				return false;
			}
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("ReceiveVIPEvent", JIIGOACEIKL, ECPEFDHOFHN: false);
			}
		}
		return false;
	}

	public void MakeWingsSound()
	{
		MultiAudioManager.PlayAudioObject(birdWingsSound, ((Component)this).transform);
	}

	private void PEOPFPEDFAK()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		}
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			BirdUI.Get(JIIGOACEIKL).CCDEPALBABD = placeable.itemSetup.DNLMCHDOMOK as BirdInstance;
			perchPlaceable.selectBlockers.Add("");
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			BirdUI.Get(JIIGOACEIKL).newBird = false;
			BirdUI.Get(JIIGOACEIKL).Open(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool CMBGCBGADCO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			BirdUI.MDINEPBJFKG(JIIGOACEIKL).KFPLLIHCDJE(placeable.itemSetup.FOIPFKPCIIN() as BirdInstance);
			perchPlaceable.selectBlockers.Add("</color>");
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			BirdUI.CCGPMEADLDG(JIIGOACEIKL).newBird = false;
			BirdUI.NDPAJCGHGOB(JIIGOACEIKL).Open(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	private IEnumerator KHNCCPFJIID(BirdInstance CCDEPALBABD)
	{
		return new GCFHCNPJEMN(1)
		{
			_003C_003E4__this = this,
			birdInstance = CCDEPALBABD
		};
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool LJHHANBIACF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private bool LAJJBBDGHAJ()
	{
		if (placeable.itemSetup.GLOLALBAEHM() is BirdInstance birdInstance)
		{
			return CharacterSpritesDBAccessor.IDPLFDGMIFL(birdInstance.birdId).isSkeleton;
		}
		return false;
	}

	public void KAOBCGJHHAF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		DLCNBKAEOBP = true;
		if (OnlineManager.MasterOrOffline() && SpawnCat.GGFJGHHHEJC.catNPC.currentCatState is CatStateBirdInteract)
		{
			SpawnCat.CHPEMJMLDCN().catNPC.PIOEMOGEOIN();
		}
		if (CDPAMNIPPEC)
		{
			PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OOEJMKIAPLC(elixirItem, CDPAMNIPPEC: false);
		}
		switch (birdAnimator.reskins[0].spriteInfo.id)
		{
		case 0:
			SetInt(AnimatorParameterCache.p_BirdType, 0, CDPAMNIPPEC: true);
			break;
		case 1:
			SetInt(AnimatorParameterCache.p_BirdType, 0, CDPAMNIPPEC: true);
			break;
		case 2:
			SetInt(AnimatorParameterCache.p_BirdType, 4, CDPAMNIPPEC: true);
			break;
		}
		MakeWingsSound();
		CJKJAEAIABG(AnimatorParameterCache.p_Res, CDPAMNIPPEC: true);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.LPJIMHAPBLG();
		}
	}

	public void SetTrigger(int GJKKNOKIKBJ, bool CDPAMNIPPEC)
	{
		birdAnimator.animator.SetTrigger(GJKKNOKIKBJ);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			onlineBird.SendSetTrigger(GJKKNOKIKBJ);
		}
	}

	public void LGCEJLOIKBK(int JIIGOACEIKL)
	{
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		perchPlaceable.selectBlockers.Remove("");
		return true;
	}

	private void Update()
	{
		if (!OnlineManager.ClientOnline() && !placeable.FHEMHCEAICB)
		{
			if (Time.time >= DAMEAKLPFAK)
			{
				SetTrigger(AnimatorParameterCache.p_LeftMovement, CDPAMNIPPEC: true);
				DAMEAKLPFAK = BKIJBBELCEM(timeBetweenLeftMovement);
			}
			if (Time.time >= IKKIDINONGI)
			{
				SetTrigger(AnimatorParameterCache.p_LookAround, CDPAMNIPPEC: true);
				IKKIDINONGI = BKIJBBELCEM(timeBetweenLookAround);
			}
			if (Time.time >= NEIOKIGPAKF)
			{
				SetTrigger(AnimatorParameterCache.p_Scratch, CDPAMNIPPEC: true);
				NEIOKIGPAKF = BKIJBBELCEM(timeBetweenScratch);
			}
		}
	}

	public bool KNJMJGOAJFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
		{
			birdInstance.hasBeenOnPerchToday = true;
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			List<Item> list = new List<Item>();
			BirdInstance birdInstance = placeable.itemSetup.DNLMCHDOMOK as BirdInstance;
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(cookieItem))
				{
					list.Add(cookieItem);
				}
				if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(cookieDemonItem))
				{
					list.Add(cookieDemonItem);
				}
			}
			if (MIOGDGFMLAJ() && PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(elixirItem))
			{
				list.Add(elixirItem);
			}
			if (list.Count > 1)
			{
				InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
				ChooseItemUI.Get(JIIGOACEIKL).itemsList = list;
				ChooseItemUI chooseItemUI = ChooseItemUI.Get(JIIGOACEIKL);
				chooseItemUI.OnItemSelected = (Action<int, Item>)Delegate.Combine(chooseItemUI.OnItemSelected, new Action<int, Item>(GFPFAOGHGEN));
				ChooseItemUI.Get(JIIGOACEIKL).OpenUI();
				return true;
			}
			if (list.Count == 1)
			{
				GFPFAOGHGEN(JIIGOACEIKL, list[0]);
				return true;
			}
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("CookiesNeeded", JIIGOACEIKL);
			}
		}
		return false;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI() && DLCNBKAEOBP && Object.op_Implicit((Object)(object)perchPlaceable))
		{
			return perchPlaceable.FHEMHCEAICB;
		}
		return false;
	}

	public void GiveElixir(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		DLCNBKAEOBP = false;
		if (OnlineManager.MasterOrOffline() && SpawnCat.GGFJGHHHEJC.catNPC.currentCatState is CatStateBirdInteract)
		{
			SpawnCat.GGFJGHHHEJC.catNPC.WalkAround();
		}
		if (CDPAMNIPPEC)
		{
			PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(elixirItem);
		}
		switch (birdAnimator.reskins[0].spriteInfo.id)
		{
		case 7:
			SetInt(AnimatorParameterCache.p_BirdType, 0, CDPAMNIPPEC: false);
			break;
		case 8:
			SetInt(AnimatorParameterCache.p_BirdType, 1, CDPAMNIPPEC: false);
			break;
		case 9:
			SetInt(AnimatorParameterCache.p_BirdType, 2, CDPAMNIPPEC: false);
			break;
		}
		MakeWingsSound();
		SetTrigger(AnimatorParameterCache.p_Res, CDPAMNIPPEC: false);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.SendGiveElixir();
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void EACGPIGFLDC(BirdInstance CCDEPALBABD)
	{
		CCDEPALBABD.prevSkelBirdId = CCDEPALBABD.birdId;
		CCDEPALBABD.prevSkelBirdMaterialId = CCDEPALBABD.birdMaterialId;
		CCDEPALBABD.birdId = birdSkeleton.id;
		CCDEPALBABD.birdMaterialId = birdSkeleton.LIGJOCEOHKB();
		birdAnimator.ChangeSkin(birdSkeleton);
		birdAnimator.ChangeMaterial(CharacterSpritesDBAccessor.GetMaterial(CCDEPALBABD.birdMaterialId));
		placeable.initialMaterial = CCDEPALBABD.IEHJMMBMLPO();
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return true;
	}

	private void Start()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
		{
			SetBirdCharacterSpriteAndMaterial(birdInstance.birdId, birdInstance.birdMaterialId);
			placeable.initialMaterial = birdInstance.IEHJMMBMLPO();
		}
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void SetBirdCharacterSpriteAndMaterial(int HJJJGEGJOCI, int FNDLEAOFMAJ)
	{
		BirdSpriteInfo bird = CharacterSpritesDBAccessor.GetBird(HJJJGEGJOCI);
		if (!((Object)(object)bird != (Object)null))
		{
			return;
		}
		for (int i = 0; i < birdAnimator.allReskins.Length; i++)
		{
			birdAnimator.reskins[i].ChangeSpriteInfo(bird);
			if (FNDLEAOFMAJ >= 0)
			{
				birdAnimator.reskins[i].ChangeMaterial(CharacterSpritesDBAccessor.GetMaterial(FNDLEAOFMAJ));
			}
		}
	}

	public void SetInt(int GJKKNOKIKBJ, int EGFGNGJGBOP, bool CDPAMNIPPEC)
	{
		birdAnimator.animator.SetInteger(GJKKNOKIKBJ, EGFGNGJGBOP);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			onlineBird.SendSetInt(GJKKNOKIKBJ, EGFGNGJGBOP);
		}
	}

	public void SetBool(string GEGDHHIDEEF, bool EGFGNGJGBOP, bool CDPAMNIPPEC)
	{
		SetBool(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, CDPAMNIPPEC);
	}

	private void MFIEPGBABAM()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		}
	}

	private bool IPKALHIGGBG(int JIIGOACEIKL)
	{
		if (EMAEIAPOGAN(JIIGOACEIKL, cookieDemonItem))
		{
			if (!MIOGDGFMLAJ() && Random.Range(0, 100) < probabilityToTurnIntoSkeleton)
			{
				GiveDemonCookie(CDPAMNIPPEC: true);
			}
			return true;
		}
		return false;
	}

	private void GFPFAOGHGEN(int JIIGOACEIKL, Item FFKMKIDPPKB)
	{
		if (((object)FFKMKIDPPKB).Equals((object?)cookieItem))
		{
			EMAEIAPOGAN(JIIGOACEIKL, cookieItem);
		}
		else if (((object)FFKMKIDPPKB).Equals((object?)cookieDemonItem))
		{
			IPKALHIGGBG(JIIGOACEIKL);
		}
		else if (((object)FFKMKIDPPKB).Equals((object?)elixirItem) && MIOGDGFMLAJ())
		{
			GiveElixir(JIIGOACEIKL, CDPAMNIPPEC: true);
		}
	}

	public void GiveDemonCookie(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(HHABKFOGEPO(placeable.itemSetup.DNLMCHDOMOK as BirdInstance));
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.SendGiveDemonCookie();
		}
	}

	public bool PHPDELKBOEH(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			BirdUI.NJOFJHCKGAL(JIIGOACEIKL).GBABHLGEIAJ(placeable.itemSetup.MOFDJHCHNPK() as BirdInstance);
			perchPlaceable.selectBlockers.Add("Error in DialogueNPCBase.EndConversation: ");
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			BirdUI.MIAOGLENOHL(JIIGOACEIKL).newBird = true;
			BirdUI.LBKJEHDEBEP(JIIGOACEIKL).Open(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void NNNEKNDGOBM()
	{
		MultiAudioManager.PlayAudioObject(birdWingsSound, ((Component)this).transform);
	}

	public void MKCAODHPLNF(string GEGDHHIDEEF, bool EGFGNGJGBOP, bool CDPAMNIPPEC)
	{
		SetBool(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, CDPAMNIPPEC);
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		}
	}

	public bool BBPIPCMFAMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void KIGPGBMMMMA(int JIIGOACEIKL, Item FFKMKIDPPKB)
	{
		if (((object)FFKMKIDPPKB).Equals((object?)cookieItem))
		{
			EMAEIAPOGAN(JIIGOACEIKL, cookieItem);
		}
		else if (((object)FFKMKIDPPKB).Equals((object?)cookieDemonItem))
		{
			DGNLCHNPPLP(JIIGOACEIKL);
		}
		else if (((object)FFKMKIDPPKB).Equals((object?)elixirItem) && PIMLGBOAMEC())
		{
			KAOBCGJHHAF(JIIGOACEIKL, CDPAMNIPPEC: true);
		}
	}

	public void SetInt(string GEGDHHIDEEF, int EGFGNGJGBOP, bool CDPAMNIPPEC)
	{
		SetInt(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, CDPAMNIPPEC);
	}

	private void LLIODCKIDPH(BirdInstance CCDEPALBABD)
	{
		CCDEPALBABD.prevSkelBirdId = CCDEPALBABD.birdId;
		CCDEPALBABD.prevSkelBirdMaterialId = CCDEPALBABD.birdMaterialId;
		CCDEPALBABD.birdId = birdSkeleton.id;
		CCDEPALBABD.birdMaterialId = birdSkeleton.LNCCGPCOEOK();
		birdAnimator.GBBDPBCGMNK(birdSkeleton);
		birdAnimator.IJGBCCGKOIH(CharacterSpritesDBAccessor.HACHFHGFFEB(CCDEPALBABD.birdMaterialId));
		placeable.initialMaterial = CCDEPALBABD.DAGEBDLEHKA();
	}

	public bool PGCGOBEMKKC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator DMHNFNAAEFF(BirdInstance CCDEPALBABD)
	{
		DLCNBKAEOBP = false;
		if (OnlineManager.MasterOrOffline() && SpawnCat.GGFJGHHHEJC.catNPC.currentCatState is CatStateBirdInteract)
		{
			SpawnCat.GGFJGHHHEJC.catNPC.WalkAround();
		}
		emotions.StartEmotion("Dead");
		if (birdAnimator.reskins[0].spriteInfo.id == 6)
		{
			((Renderer)featherExplosion).material = birdExplosionMaterial;
		}
		else
		{
			((Renderer)featherExplosion).material = birdAnimator.reskins[0].characterMaterial.material;
		}
		yield return (object)new WaitForSeconds(2.8f);
		skeletonFx.SetActive(true);
		yield return CommonReferences.wait03;
		if (birdAnimator.reskins[0].spriteInfo.id == 6)
		{
			MultiAudioManager.PlayAudioObject(owlExplosionSound, ((Component)this).transform);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(birdExplosionSound, ((Component)this).transform);
		}
		yield return CommonReferences.wait05;
		EACGPIGFLDC(CCDEPALBABD);
		Result variable = DialogueLua.GetVariable("SkeletonBird");
		if (((Result)(ref variable)).asInt == 0)
		{
			DialogueLua.SetVariable("SkeletonBird", (object)1);
		}
		yield return CommonReferences.wait2;
		skeletonFx.SetActive(false);
		DLCNBKAEOBP = true;
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			BirdInstance birdInstance = placeable.itemSetup.BODBEPJAFHL() as BirdInstance;
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				flag = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).NECEDHECGFN(cookieItem);
				if (flag)
				{
					num += 0;
				}
				flag2 = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DCEOCOOIBLI(cookieDemonItem);
				if (flag2)
				{
					num += 0;
				}
			}
			if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NECEDHECGFN(elixirItem) && LAJJBBDGHAJ())
			{
				num += 0;
			}
			if (num > 0)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("add item "));
			}
			else if (num == 0)
			{
				if (flag)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("Flour");
					string[] array = new string[1];
					array[1] = cookieItem.LJIFOHFEFCH(OAFPBCPDOKH: true);
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
				}
				else if (flag2)
				{
					string cAEDMEDBEGI2 = LocalisationSystem.Get("AddObjectInDictionary() uniqueId ");
					string[] array2 = new string[0];
					array2[0] = cookieDemonItem.IABAKHPEOAF();
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2));
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("RecieveMothersRecipeEventCof"), elixirItem.IABAKHPEOAF(OAFPBCPDOKH: true)));
				}
			}
			else if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Leave immediately"), cookieItem.IABAKHPEOAF()));
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("Items/item_name_626"));
			return true;
		}
		return true;
	}

	public void IMNJHOCGPIO(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(DMHNFNAAEFF(placeable.itemSetup.FOIPFKPCIIN() as BirdInstance));
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			onlineBird.EEOLPAEOKFL();
		}
	}

	private bool EMAEIAPOGAN(int JIIGOACEIKL, Item KILOIDFDOAD)
	{
		if (placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
		{
			if (birdInstance.cookiesGivenPerDay >= 2)
			{
				if (!cookieEmote.activeSelf)
				{
					((Behaviour)canvas).enabled = true;
					cookieEmote.SetActive(true);
				}
				return false;
			}
			GiveCookie(JIIGOACEIKL, birdInstance, KILOIDFDOAD, CDPAMNIPPEC: true);
		}
		return true;
	}

	private bool MIOGDGFMLAJ()
	{
		if (placeable.itemSetup.DNLMCHDOMOK is BirdInstance birdInstance)
		{
			return CharacterSpritesDBAccessor.GetBird(birdInstance.birdId).isSkeleton;
		}
		return false;
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			int num = 1;
			bool flag = true;
			bool flag2 = false;
			BirdInstance birdInstance = placeable.itemSetup.DNLMCHDOMOK as BirdInstance;
			if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				flag = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CHOAPBFAAAM(cookieItem);
				if (flag)
				{
					num++;
				}
				flag2 = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).CHOAPBFAAAM(cookieDemonItem);
				if (flag2)
				{
					num += 0;
				}
			}
			if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CHOAPBFAAAM(elixirItem) && MIOGDGFMLAJ())
			{
				num++;
			}
			if (num > 1)
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_name_1090"));
			}
			else if (num == 1)
			{
				if (flag)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("StartObserverDialogueWhenItIsPossible ");
					string[] array = new string[0];
					array[0] = cookieItem.KGHFCDELKMN(OAFPBCPDOKH: true);
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
				}
				else if (flag2)
				{
					string cAEDMEDBEGI2 = LocalisationSystem.Get("DecorationTile_14");
					string[] array2 = new string[0];
					array2[0] = cookieDemonItem.IABAKHPEOAF(OAFPBCPDOKH: true);
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2));
				}
				else
				{
					string cAEDMEDBEGI3 = LocalisationSystem.Get("Sweet");
					string[] array3 = new string[0];
					array3[0] = elixirItem.LJIFOHFEFCH(OAFPBCPDOKH: true);
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3));
				}
			}
			else if (Time.time > birdInstance.lastCookieGivenTime + canGiveCookieTime)
			{
				string cAEDMEDBEGI4 = LocalisationSystem.Get("RightMouseDetect");
				string[] array4 = new string[1];
				array4[1] = cookieItem.KGHFCDELKMN(OAFPBCPDOKH: true);
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4));
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" "));
			return false;
		}
		return false;
	}

	private void OKIPPPDPDPB(float JPCPNGLHGAI)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.educationText, ((Component)this).transform.position, Quaternion.identity).GetComponent<RepText>().MBNIFPLFDJO((int)(JPCPNGLHGAI * 1407f));
	}

	public void CJKJAEAIABG(int GJKKNOKIKBJ, bool CDPAMNIPPEC)
	{
		birdAnimator.animator.SetTrigger(GJKKNOKIKBJ);
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			onlineBird.MDBCCKCKHAH(GJKKNOKIKBJ);
		}
	}

	public void BDGEMFNLDGC(int JIIGOACEIKL)
	{
	}
}
