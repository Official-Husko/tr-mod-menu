using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LCNHONAOJMG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource source;

		public float startVolume;

		public bool isMusic;

		public float endVolume;

		public float fadeTime;

		public Action FinishedFade;

		private float _003CclipStartTime_003E5__2;

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
		public LCNHONAOJMG(int _003C_003E1__state)
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
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				source.volume = startVolume;
				if (isMusic && Utils.FFLNGLMHLBO() && HalloweenEvent.GGFJGHHHEJC.night && HalloweenEvent.GGFJGHHHEJC.PlayerOutside())
				{
					goto IL_00b9;
				}
				_003CclipStartTime_003E5__2 = Time.realtimeSinceStartup;
			}
			if (Time.realtimeSinceStartup - _003CclipStartTime_003E5__2 < fadeTime)
			{
				source.volume = Mathf.Lerp(startVolume, endVolume, (Time.realtimeSinceStartup - _003CclipStartTime_003E5__2) / fadeTime);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_00b9;
			IL_00b9:
			if (FinishedFade != null)
			{
				FinishedFade();
			}
			return false;
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
	private sealed class OCBFLOHKPAL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioClip clip;

		public float volume;

		public float delay;

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
		public OCBFLOHKPAL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			GGFJGHHHEJC.PlayOneShot(clip, HOMFPAFAOGD: false, null, null, volume);
			_003C_003E2__current = (object)new WaitForSeconds(delay);
			_003C_003E1__state = 1;
			return true;
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

	private static Sound IADEMLIIDPC;

	public AudioMixer audioMixer;

	public AudioSource ambientSource;

	public AudioMixerSnapshot exteriorSnapshot;

	public AudioMixerSnapshot interiorSnapshot;

	public AudioMixerSnapshot cityInteriorSnapshot;

	public AudioMixerSnapshot caveSnapshot;

	public GameObject audioSourceLoopPrefab;

	public GameObject audioSourceOneShotPrefab;

	public GameObject audioSourceUIOneShotPrefab;

	public HashSet<MonoBehaviour> blockSound = new HashSet<MonoBehaviour>();

	public bool musicBoxSounding;

	public AudioObject playerExplosion;

	public AudioObject shovelSfx;

	public AudioObject parrot;

	public AudioObject owl;

	public AudioObject soldierMovement;

	public AudioObject turkey;

	public AudioObject snowHit;

	public AudioObject snowmanSmash;

	public AudioObject success;

	public AudioObject fail;

	public AudioObject bell;

	public AudioObject deskBell;

	public AudioObject pickUpItem;

	public AudioObject happyCustomer;

	public AudioObject unhappyCustomer;

	public AudioObject exclamation;

	public AudioObject openMetal;

	public AudioObject crateOpenWood;

	public AudioObject openFermenter;

	public AudioObject chestJunk;

	public AudioObject waterSmallSplash;

	public AudioObject reelLaunch;

	public AudioObject banjoSuccess;

	public AudioObject banjoBigSuccess;

	public AudioObject heavyPunch;

	public AudioObject musicBox;

	public AudioObject musicBoxClose;

	public AudioObject exclamationFishing;

	public AudioObject doorStoneSlide;

	public AudioObject tavernRepair;

	public AudioObject workstationRepair;

	public AudioObject makingBedAudioObject;

	public AudioObject watermill;

	public AudioObject wateringCan;

	public AudioObject ax;

	public AudioObject closeDoor;

	public AudioObject placeSmallItem;

	public AudioObject placeBigItem;

	public AudioObject cannonFiring;

	public AudioObject cannonBallImpact;

	public AudioObject ferroIceMelting;

	public AudioObject pig;

	public AudioObject pigHit;

	public AudioObject cow;

	public AudioObject cowHit;

	public AudioObject sheep;

	public AudioObject sheepHit;

	public AudioObject chicken;

	public AudioObject chickenHit;

	public AudioObject catMeow;

	public AudioObject catAngry;

	public AudioObject catPurr;

	public AudioObject duck;

	public AudioObject seagull;

	public AudioObject hamsterHit;

	public AudioObject hamsterFall;

	public AudioObject jackyAngry;

	public AudioObject dogBark;

	public AudioObject dogDigging;

	public AudioObject dogDrinking;

	public AudioObject dogRefillingFood;

	public AudioObject dogStep;

	public AudioObject dogStepSoft;

	public AudioClip banjoSuccessClip;

	public AudioClip[] openWood;

	public AudioClip[] cleanTable;

	public AudioClip[] daylightOutAmb;

	public AudioClip[] fireplace;

	public AudioClip[] hoe;

	public AudioClip[] moveWoodBig;

	public AudioClip[] npcTalk;

	public AudioClip[] placeItemSmall;

	public AudioClip[] pourBeer;

	public AudioClip[] shovel;

	public AudioClip[] stepsDirt;

	public AudioClip[] stepsGrass;

	public AudioClip[] stepsWood;

	public AudioClip[] stepsStone;

	public AudioClip[] workingRummaging;

	public AudioClip[] uiWindowOpen;

	public AudioClip[] uiWindowClose;

	public AudioClip[] waterSplash;

	public AudioClip[] addFuel;

	public AudioClip[] mopHit;

	public AudioClip[] repairFurniture;

	public AudioClip[] lastOrderBell;

	public AudioClip[] uiClickPos;

	public AudioClip[] uiClickNeg;

	public AudioClip[] newQuest;

	public AudioClip[] UnreadQuest;

	public AudioClip[] exclaim;

	public AudioClip[] xpJingle;

	public AudioClip[] tavernOpen;

	public AudioClip[] tavernClose;

	public AudioClip[] tooHot;

	public AudioClip[] tooCold;

	public AudioClip[] cosy;

	public AudioClip[] dirty;

	public AudioClip[] clean;

	public AudioClip[] questComplete;

	public AudioClip[] musicChristmasOneShot;

	public AudioClip[] musicChristmasLoop;

	public AudioClip[] openDoor;

	public AudioClip[] doorKnock;

	public AudioClip[] magicBroom;

	public AudioClip[] makingBed;

	public static Sound GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<Sound>();
			}
			return IADEMLIIDPC;
		}
	}

	private bool OKGIFOJGOHB(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK)
	{
		if (JFNMCNCHMEO == -47 || JFNMCNCHMEO == -126 || JFNMCNCHMEO == -74)
		{
			return true;
		}
		if (KDAFFJHJJGE)
		{
			return true;
		}
		if (IMOLODHMPFK)
		{
			return false;
		}
		return false;
	}

	public void GIFLIMCCKAO()
	{
		audioMixer.SetFloat(" ", PEFOKEJGDJC(1096f));
	}

	public AudioSource BOFJJFJIBHB(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return INPNDHPDFNC(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(1114f, 292f));
	}

	public void PlayDeselectSound(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK, Transform CAGIIODGGAF)
	{
		switch (JFNMCNCHMEO)
		{
		case 1146:
		case 1147:
			MultiAudioManager.PlayAudioObject(parrot, ((Component)this).transform);
			return;
		case 1148:
			MultiAudioManager.PlayAudioObject(owl, ((Component)this).transform);
			return;
		}
		if (CHIAAKAEPFG(JFNMCNCHMEO, KDAFFJHJJGE, IMOLODHMPFK))
		{
			MultiAudioManager.PlayAudioObject(placeSmallItem, CAGIIODGGAF);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(placeBigItem, CAGIIODGGAF);
		}
	}

	public void FPBCHCFGINP(OpenSound CLBFEIKGHKJ, Transform CHGOBPEDDBJ)
	{
		if (!blockSound.Any())
		{
			MultiAudioManager.PlayAudioObject((AudioObject)(CLBFEIKGHKJ switch
			{
				(OpenSound)6 => openFermenter, 
				OpenSound.Metal => openMetal, 
				_ => crateOpenWood, 
			}), CHGOBPEDDBJ);
		}
	}

	public void AOFPNKDLFFB(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK, Transform CAGIIODGGAF)
	{
		switch (JFNMCNCHMEO)
		{
		case 18:
		case 81:
			MultiAudioManager.PlayAudioObject(parrot, ((Component)this).transform);
			return;
		case 169:
			MultiAudioManager.PlayAudioObject(owl, ((Component)this).transform);
			return;
		}
		if (CHIAAKAEPFG(JFNMCNCHMEO, KDAFFJHJJGE, IMOLODHMPFK))
		{
			MultiAudioManager.PlayAudioObject(placeSmallItem, CAGIIODGGAF);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(placeBigItem, CAGIIODGGAF);
		}
	}

	public static void OICFGHINCLE()
	{
		OKAPNFPFPFP().exteriorSnapshot.TransitionTo(284f);
	}

	public void GHDPAKLGKGI()
	{
		audioMixer.SetFloat(" ", PEFOKEJGDJC(1685f));
	}

	public static void SnapshotToInterior()
	{
		GGFJGHHHEJC.interiorSnapshot.TransitionTo(0.5f);
	}

	public static void IENLAMDEBPA()
	{
		OKAPNFPFPFP().cityInteriorSnapshot.TransitionTo(680f);
	}

	public IEnumerator OAEAACDJDDH(AudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI, Action AFMNLCGBEHO = null, bool MKEEMDIOHIK = false)
	{
		return new LCNHONAOJMG(1)
		{
			source = ODHLEHJPGKP,
			startVolume = IJHEMHEOJLB,
			endVolume = KEHHFCGOJGF,
			fadeTime = CBPHLLOGJAI,
			FinishedFade = AFMNLCGBEHO,
			isMusic = MKEEMDIOHIK
		};
	}

	public void AFILAFJFGMI()
	{
		audioMixer.SetFloat("hForHours", EFPBELILKED(1498f));
	}

	public void BBDPFGHLGML(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK, Transform CAGIIODGGAF)
	{
		switch (JFNMCNCHMEO)
		{
		case -171:
		case 173:
			MultiAudioManager.PlayAudioObject(parrot, ((Component)this).transform);
			return;
		case 97:
			MultiAudioManager.PlayAudioObject(owl, ((Component)this).transform);
			return;
		}
		if (OKGIFOJGOHB(JFNMCNCHMEO, KDAFFJHJJGE, IMOLODHMPFK))
		{
			MultiAudioManager.PlayAudioObject(placeSmallItem, CAGIIODGGAF);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(placeBigItem, CAGIIODGGAF);
		}
	}

	private AudioSource PDMLIEMMGOH(GameObject ANADFOCHOBF, AudioClip LOAKJDCMMOK, Transform DMBHHLKMHOH = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.zero;
		if ((Object)(object)DMBHHLKMHOH == (Object)null)
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				val = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position;
			}
		}
		else
		{
			val = DMBHHLKMHOH.position;
		}
		AudioSource component = Object.Instantiate<GameObject>(ANADFOCHOBF, val, Quaternion.identity, DMBHHLKMHOH).GetComponent<AudioSource>();
		DJKJEJFBICN(component, LOAKJDCMMOK);
		return component;
	}

	public void OCGHFDOMDAP()
	{
		audioMixer.SetFloat("NinjaChallengeEvent/Main", PEFOKEJGDJC(2f));
	}

	[SpecialName]
	public static Sound MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Sound>();
		}
		return IADEMLIIDPC;
	}

	private void BHAFCBHENPL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void DJKJEJFBICN(AudioSource EINDLGPJLCP, AudioClip LOAKJDCMMOK)
	{
		if (!((Object)(object)EINDLGPJLCP == (Object)null) && ((Behaviour)this).isActiveAndEnabled)
		{
			((MonoBehaviour)this).StartCoroutine(Utils.BBCAIEGMBPD<GameObject>(((Component)EINDLGPJLCP).gameObject, LOAKJDCMMOK.length));
		}
	}

	public AudioSource CHFFLKLLNNJ(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return INPNDHPDFNC(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(12f, 1648f));
	}

	public AudioSource PlayRandomPitch(AudioClip LOAKJDCMMOK, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return Play(LOAKJDCMMOK, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(0.85f, 1.15f));
	}

	public void MuteLoops()
	{
		audioMixer.SetFloat("LoopVolume", LevelToDB(0f));
	}

	public static void BOJBJNCBOPG()
	{
		DIHCEGINELM().cityInteriorSnapshot.TransitionTo(1284f);
	}

	public AudioSource HLLDGLLLNJF(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = FGHENPFLEBE(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}

	public static float LevelToDB(float EONJGMONIOM)
	{
		return Mathf.Log10(Mathf.Max(0.0001f, EONJGMONIOM / 10f)) * 20f;
	}

	public static void SnapshotToCave()
	{
		GGFJGHHHEJC.caveSnapshot.TransitionTo(0.5f);
	}

	public AudioSource Play(AudioClip LOAKJDCMMOK, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)ODHLEHJPGKP == (Object)null)
		{
			ODHLEHJPGKP = FGHENPFLEBE(audioSourceLoopPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		ODHLEHJPGKP.clip = LOAKJDCMMOK;
		ODHLEHJPGKP.volume = CDPMDDDGBIG;
		ODHLEHJPGKP.pitch = DHHKELJFPIG;
		ODHLEHJPGKP.Play();
		return ODHLEHJPGKP;
	}

	public IEnumerator LOHBOEMBMFE(AudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI, Action AFMNLCGBEHO = null, bool MKEEMDIOHIK = false)
	{
		return new LCNHONAOJMG(1)
		{
			source = ODHLEHJPGKP,
			startVolume = IJHEMHEOJLB,
			endVolume = KEHHFCGOJGF,
			fadeTime = CBPHLLOGJAI,
			FinishedFade = AFMNLCGBEHO,
			isMusic = MKEEMDIOHIK
		};
	}

	[SpecialName]
	public static Sound DIHCEGINELM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Sound>();
		}
		return IADEMLIIDPC;
	}

	public void BHAECLEDONB()
	{
		audioMixer.SetFloat("ReceiveDismissWorkerMaster", LevelToDB(1839f));
	}

	public AudioSource PlayOneShotRandomPitch(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return PlayOneShot(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(0.85f, 1.15f));
	}

	public static void INAMNDLLFGD()
	{
		BNBMNOMFFBE().cityInteriorSnapshot.TransitionTo(781f);
	}

	public IEnumerator GNLFKIJIBOI(AudioClip LOAKJDCMMOK, float CDPMDDDGBIG, float FLHBPHPKIML)
	{
		return new OCBFLOHKPAL(1)
		{
			clip = LOAKJDCMMOK,
			volume = CDPMDDDGBIG,
			delay = FLHBPHPKIML
		};
	}

	public void AHKNIMMBLCN()
	{
		audioMixer.SetFloat("UIBack", LevelToDB(1822f));
	}

	public static void SnapshotToCityInterior()
	{
		GGFJGHHHEJC.cityInteriorSnapshot.TransitionTo(0.5f);
	}

	public AudioSource INPNDHPDFNC(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = AOFLJHGHDOH(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}

	public void NPBFDPMLPDN(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK, Transform CAGIIODGGAF)
	{
		switch (JFNMCNCHMEO)
		{
		case -25:
		case 141:
			MultiAudioManager.PlayAudioObject(parrot, ((Component)this).transform);
			return;
		case 29:
			MultiAudioManager.PlayAudioObject(owl, ((Component)this).transform);
			return;
		}
		if (CHIAAKAEPFG(JFNMCNCHMEO, KDAFFJHJJGE, IMOLODHMPFK))
		{
			MultiAudioManager.PlayAudioObject(placeSmallItem, CAGIIODGGAF);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(placeBigItem, CAGIIODGGAF);
		}
	}

	public IEnumerator FadeVolume(AudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI, Action AFMNLCGBEHO = null, bool MKEEMDIOHIK = false)
	{
		ODHLEHJPGKP.volume = IJHEMHEOJLB;
		if (!MKEEMDIOHIK || !Utils.FFLNGLMHLBO() || !HalloweenEvent.GGFJGHHHEJC.night || !HalloweenEvent.GGFJGHHHEJC.PlayerOutside())
		{
			float clipStartTime = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
			{
				ODHLEHJPGKP.volume = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
				yield return null;
			}
		}
		AFMNLCGBEHO?.Invoke();
	}

	public static void BNADPBDBLDB()
	{
		DIHCEGINELM().caveSnapshot.TransitionTo(1472f);
	}

	public void UnmuteLoops()
	{
		audioMixer.SetFloat("LoopVolume", LevelToDB(10f));
	}

	public void DestroyAfterClip(AudioSource EINDLGPJLCP, AudioClip LOAKJDCMMOK)
	{
		if (!((Object)(object)EINDLGPJLCP == (Object)null) && ((Behaviour)this).isActiveAndEnabled)
		{
			((MonoBehaviour)this).StartCoroutine(Utils.BBCAIEGMBPD<GameObject>(((Component)EINDLGPJLCP).gameObject, LOAKJDCMMOK.length));
		}
	}

	public IEnumerator RepeatSound(AudioClip LOAKJDCMMOK, float CDPMDDDGBIG, float FLHBPHPKIML)
	{
		while (true)
		{
			GGFJGHHHEJC.PlayOneShot(LOAKJDCMMOK, HOMFPAFAOGD: false, null, null, CDPMDDDGBIG);
			yield return (object)new WaitForSeconds(FLHBPHPKIML);
		}
	}

	public void LFKBIIPACKO()
	{
		audioMixer.SetFloat("Force", LevelToDB(1238f));
	}

	public void GEGCIKJFCLP(AudioSource EINDLGPJLCP, AudioClip LOAKJDCMMOK)
	{
		if (!((Object)(object)EINDLGPJLCP == (Object)null) && ((Behaviour)this).isActiveAndEnabled)
		{
			((MonoBehaviour)this).StartCoroutine(Utils.BBCAIEGMBPD<GameObject>(((Component)EINDLGPJLCP).gameObject, LOAKJDCMMOK.length));
		}
	}

	public void NNGCIMHKMFF()
	{
		audioMixer.SetFloat("Custom lobby data (Lobby creator): {0}", EDAJBMLIJBD(1314f));
	}

	public void LFFGMMNEPHK(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK, Transform CAGIIODGGAF)
	{
		switch (JFNMCNCHMEO)
		{
		case 21:
		case 150:
			MultiAudioManager.PlayAudioObject(parrot, ((Component)this).transform);
			return;
		case -131:
			MultiAudioManager.PlayAudioObject(owl, ((Component)this).transform);
			return;
		}
		if (CHIAAKAEPFG(JFNMCNCHMEO, KDAFFJHJJGE, IMOLODHMPFK))
		{
			MultiAudioManager.PlayAudioObject(placeSmallItem, CAGIIODGGAF);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(placeBigItem, CAGIIODGGAF);
		}
	}

	public static void KEHDMEHNHEP()
	{
		OKAPNFPFPFP().interiorSnapshot.TransitionTo(1554f);
	}

	public static void CCHIBDKILPA()
	{
		GGFJGHHHEJC.interiorSnapshot.TransitionTo(1793f);
	}

	public void HMBHLPGFMPB()
	{
		audioMixer.SetFloat("bath travelling", LevelToDB(274f));
	}

	public AudioSource NADFIJPBNCH(AudioClip LOAKJDCMMOK, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return GNIEKPDEIOE(LOAKJDCMMOK, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(1106f, 1927f));
	}

	private AudioSource FGHENPFLEBE(GameObject ANADFOCHOBF, AudioClip LOAKJDCMMOK, Transform DMBHHLKMHOH = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.zero;
		if ((Object)(object)DMBHHLKMHOH == (Object)null)
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				val = ((Component)PlayerController.GetPlayer(1)).transform.position;
			}
		}
		else
		{
			val = DMBHHLKMHOH.position;
		}
		AudioSource component = Object.Instantiate<GameObject>(ANADFOCHOBF, val, Quaternion.identity, DMBHHLKMHOH).GetComponent<AudioSource>();
		DestroyAfterClip(component, LOAKJDCMMOK);
		return component;
	}

	public AudioSource KEDNCNEEGMA(AudioClip LOAKJDCMMOK, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)ODHLEHJPGKP == (Object)null)
		{
			ODHLEHJPGKP = FGHENPFLEBE(audioSourceLoopPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		ODHLEHJPGKP.clip = LOAKJDCMMOK;
		ODHLEHJPGKP.volume = CDPMDDDGBIG;
		ODHLEHJPGKP.pitch = DHHKELJFPIG;
		ODHLEHJPGKP.Play();
		return ODHLEHJPGKP;
	}

	public void CEPHFNKNHGB()
	{
		audioMixer.SetFloat("%", PEFOKEJGDJC(1851f));
	}

	public void EPJNFBCOGCD()
	{
		audioMixer.SetFloat("City/Amos/Bark/Buy", PEFOKEJGDJC(1325f));
	}

	[SpecialName]
	public static Sound BNBMNOMFFBE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Sound>();
		}
		return IADEMLIIDPC;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void MuteOneShotSFX()
	{
		audioMixer.SetFloat("OneShotVolume", LevelToDB(0f));
	}

	public void CPHBALPLLKH()
	{
		audioMixer.SetFloat("PirateMinigame/Talk", EFPBELILKED(1892f));
	}

	private void KDHLJKMKFMG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public static float EDAJBMLIJBD(float EONJGMONIOM)
	{
		return Mathf.Log10(Mathf.Max(221f, EONJGMONIOM / 107f)) * 325f;
	}

	public static void CNLFHIOODKA()
	{
		DIHCEGINELM().exteriorSnapshot.TransitionTo(563f);
	}

	public IEnumerator BGCNOJIKCMC(AudioClip LOAKJDCMMOK, float CDPMDDDGBIG, float FLHBPHPKIML)
	{
		while (true)
		{
			GGFJGHHHEJC.PlayOneShot(LOAKJDCMMOK, HOMFPAFAOGD: false, null, null, CDPMDDDGBIG);
			yield return (object)new WaitForSeconds(FLHBPHPKIML);
		}
	}

	public AudioSource FCGICGODFFA(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = FGHENPFLEBE(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}

	[SpecialName]
	public static Sound ABDJJBFNLBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Sound>();
		}
		return IADEMLIIDPC;
	}

	public AudioSource FDEMPPFKAFK(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = PDMLIEMMGOH(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}

	public void JEMKDNKLLPN()
	{
		audioMixer.SetFloat("HandUp", PEFOKEJGDJC(424f));
	}

	public void IGMHCAMLKBJ(AudioSource EINDLGPJLCP, AudioClip LOAKJDCMMOK)
	{
		if (!((Object)(object)EINDLGPJLCP == (Object)null) && ((Behaviour)this).isActiveAndEnabled)
		{
			((MonoBehaviour)this).StartCoroutine(Utils.BBCAIEGMBPD<GameObject>(((Component)EINDLGPJLCP).gameObject, LOAKJDCMMOK.length));
		}
	}

	public void EMPBOBCEGOK()
	{
		audioMixer.SetFloat("Travelling time decreased to ", EDAJBMLIJBD(954f));
	}

	public IEnumerator PFNKJCGDMEG(AudioSource ODHLEHJPGKP, float IJHEMHEOJLB, float KEHHFCGOJGF, float CBPHLLOGJAI, Action AFMNLCGBEHO = null, bool MKEEMDIOHIK = false)
	{
		ODHLEHJPGKP.volume = IJHEMHEOJLB;
		if (!MKEEMDIOHIK || !Utils.FFLNGLMHLBO() || !HalloweenEvent.GGFJGHHHEJC.night || !HalloweenEvent.GGFJGHHHEJC.PlayerOutside())
		{
			float clipStartTime = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup - clipStartTime < CBPHLLOGJAI)
			{
				ODHLEHJPGKP.volume = Mathf.Lerp(IJHEMHEOJLB, KEHHFCGOJGF, (Time.realtimeSinceStartup - clipStartTime) / CBPHLLOGJAI);
				yield return null;
			}
		}
		AFMNLCGBEHO?.Invoke();
	}

	public AudioSource NIILADBBPLG(AudioClip LOAKJDCMMOK, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)ODHLEHJPGKP == (Object)null)
		{
			ODHLEHJPGKP = PDMLIEMMGOH(audioSourceLoopPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		ODHLEHJPGKP.clip = LOAKJDCMMOK;
		ODHLEHJPGKP.volume = CDPMDDDGBIG;
		ODHLEHJPGKP.pitch = DHHKELJFPIG;
		ODHLEHJPGKP.Play();
		return ODHLEHJPGKP;
	}

	public void PLAKJDHJGLM()
	{
		audioMixer.SetFloat("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/12/Dialogue Text", PEFOKEJGDJC(1802f));
	}

	private void NAOBODGBECL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public AudioSource LNCINHJELIG(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return FCGICGODFFA(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(1874f, 1747f));
	}

	public void HFJHLMAGHPH(OpenSound CLBFEIKGHKJ, Transform CHGOBPEDDBJ)
	{
		if (!blockSound.Any())
		{
			MultiAudioManager.PlayAudioObject((AudioObject)(CLBFEIKGHKJ switch
			{
				(OpenSound)8 => openFermenter, 
				OpenSound.Metal => openMetal, 
				_ => crateOpenWood, 
			}), CHGOBPEDDBJ);
		}
	}

	public void PlayOpenSound(OpenSound CLBFEIKGHKJ, Transform CHGOBPEDDBJ)
	{
		if (!blockSound.Any())
		{
			MultiAudioManager.PlayAudioObject((AudioObject)(CLBFEIKGHKJ switch
			{
				OpenSound.Fermenter => openFermenter, 
				OpenSound.Metal => openMetal, 
				_ => crateOpenWood, 
			}), CHGOBPEDDBJ);
		}
	}

	public void FMECBJFOLBO()
	{
		audioMixer.SetFloat("Miners dispute done, but not hot bath, setting miners in camp", EFPBELILKED(1175f));
	}

	public AudioSource MFBBFAINMHG(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return PlayOneShot(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(1806f, 538f));
	}

	public void CNEICENEJJO()
	{
		audioMixer.SetFloat("City/PetShop/Nessy/Stand", PEFOKEJGDJC(1840f));
	}

	private AudioSource HECALDHNCAI(GameObject ANADFOCHOBF, AudioClip LOAKJDCMMOK, Transform DMBHHLKMHOH = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.zero;
		if ((Object)(object)DMBHHLKMHOH == (Object)null)
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null)
			{
				val = ((Component)PlayerController.GetPlayer(1)).transform.position;
			}
		}
		else
		{
			val = DMBHHLKMHOH.position;
		}
		AudioSource component = Object.Instantiate<GameObject>(ANADFOCHOBF, val, Quaternion.identity, DMBHHLKMHOH).GetComponent<AudioSource>();
		DestroyAfterClip(component, LOAKJDCMMOK);
		return component;
	}

	[SpecialName]
	public static Sound OKAPNFPFPFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<Sound>();
		}
		return IADEMLIIDPC;
	}

	public AudioSource MGMGHPCIBEK(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = AOFLJHGHDOH(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}

	public void AODEHOPLLLO()
	{
		audioMixer.SetFloat("DrinkVerb", PEFOKEJGDJC(1585f));
	}

	public void JBDJNCMPJDF()
	{
		audioMixer.SetFloat("position", PEFOKEJGDJC(488f));
	}

	private AudioSource AOFLJHGHDOH(GameObject ANADFOCHOBF, AudioClip LOAKJDCMMOK, Transform DMBHHLKMHOH = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.zero;
		if ((Object)(object)DMBHHLKMHOH == (Object)null)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null)
			{
				val = ((Component)PlayerController.GetPlayer(1)).transform.position;
			}
		}
		else
		{
			val = DMBHHLKMHOH.position;
		}
		AudioSource component = Object.Instantiate<GameObject>(ANADFOCHOBF, val, Quaternion.identity, DMBHHLKMHOH).GetComponent<AudioSource>();
		DJKJEJFBICN(component, LOAKJDCMMOK);
		return component;
	}

	public void UnmuteUI()
	{
		audioMixer.SetFloat("UIVolume", LevelToDB(10f));
	}

	public AudioSource PlayOneShot(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = FGHENPFLEBE(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}

	public AudioSource NFGPNLLFDCE(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return GFMCBGEFEOK(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(139f, 1448f));
	}

	public void HMOFEKICCCB()
	{
		audioMixer.SetFloat("piratecave", PEFOKEJGDJC(1305f));
	}

	private bool CHIAAKAEPFG(int JFNMCNCHMEO, bool KDAFFJHJJGE, bool IMOLODHMPFK)
	{
		if (JFNMCNCHMEO == 605 || JFNMCNCHMEO == 1083 || JFNMCNCHMEO == 1106)
		{
			return true;
		}
		if (KDAFFJHJJGE)
		{
			return true;
		}
		if (IMOLODHMPFK)
		{
			return true;
		}
		return false;
	}

	public static float PEFOKEJGDJC(float EONJGMONIOM)
	{
		return Mathf.Log10(Mathf.Max(1829f, EONJGMONIOM / 1464f)) * 1303f;
	}

	public static void GOCJDPAJCME()
	{
		ABDJJBFNLBJ().interiorSnapshot.TransitionTo(1760f);
	}

	public void JLFGDJCANGF(OpenSound CLBFEIKGHKJ, Transform CHGOBPEDDBJ)
	{
		if (!blockSound.Any())
		{
			MultiAudioManager.PlayAudioObject((AudioObject)(CLBFEIKGHKJ switch
			{
				OpenSound.Metal => openFermenter, 
				OpenSound.Wood => openMetal, 
				_ => crateOpenWood, 
			}), CHGOBPEDDBJ);
		}
	}

	public AudioSource IAEMMABJFLH(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return INPNDHPDFNC(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(1777f, 936f));
	}

	public AudioSource GAIDPALIDFG(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		return INPNDHPDFNC(LOAKJDCMMOK, HOMFPAFAOGD, ODHLEHJPGKP, DMBHHLKMHOH, CDPMDDDGBIG, Random.Range(253f, 1123f));
	}

	public static void DJPBOLECABD()
	{
		OKAPNFPFPFP().cityInteriorSnapshot.TransitionTo(1730f);
	}

	public AudioSource GNIEKPDEIOE(AudioClip LOAKJDCMMOK, AudioSource ODHLEHJPGKP = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)ODHLEHJPGKP == (Object)null)
		{
			ODHLEHJPGKP = HECALDHNCAI(audioSourceLoopPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		ODHLEHJPGKP.clip = LOAKJDCMMOK;
		ODHLEHJPGKP.volume = CDPMDDDGBIG;
		ODHLEHJPGKP.pitch = DHHKELJFPIG;
		ODHLEHJPGKP.Play();
		return ODHLEHJPGKP;
	}

	public static float EFPBELILKED(float EONJGMONIOM)
	{
		return Mathf.Log10(Mathf.Max(1462f, EONJGMONIOM / 389f)) * 1965f;
	}

	public void MuteUI()
	{
		audioMixer.SetFloat("UIVolume", LevelToDB(0f));
	}

	public void ALBEOGBKEPJ()
	{
		audioMixer.SetFloat("Triangle", PEFOKEJGDJC(164f));
	}

	public static void SnapshotToExterior()
	{
		GGFJGHHHEJC.exteriorSnapshot.TransitionTo(0.5f);
	}

	private AudioSource NGOHIMPHCBP(GameObject ANADFOCHOBF, AudioClip LOAKJDCMMOK, Transform DMBHHLKMHOH = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.zero;
		if ((Object)(object)DMBHHLKMHOH == (Object)null)
		{
			if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null)
			{
				val = ((Component)PlayerController.GetPlayer(1)).transform.position;
			}
		}
		else
		{
			val = DMBHHLKMHOH.position;
		}
		AudioSource component = Object.Instantiate<GameObject>(ANADFOCHOBF, val, Quaternion.identity, DMBHHLKMHOH).GetComponent<AudioSource>();
		IGMHCAMLKBJ(component, LOAKJDCMMOK);
		return component;
	}

	private void KMBEOPAHKGB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public static void GMGKNLOFHJF()
	{
		GGFJGHHHEJC.cityInteriorSnapshot.TransitionTo(1403f);
	}

	public void UnmuteOneShotSFX()
	{
		audioMixer.SetFloat("OneShotVolume", LevelToDB(10f));
	}

	public AudioSource GFMCBGEFEOK(AudioClip LOAKJDCMMOK, bool HOMFPAFAOGD = false, AudioSource BMELMNNFCGJ = null, Transform DMBHHLKMHOH = null, float CDPMDDDGBIG = 1f, float DHHKELJFPIG = 1f)
	{
		if (blockSound.Any())
		{
			return null;
		}
		if ((Object)(object)BMELMNNFCGJ == (Object)null)
		{
			BMELMNNFCGJ = AOFLJHGHDOH(HOMFPAFAOGD ? audioSourceUIOneShotPrefab : audioSourceOneShotPrefab, LOAKJDCMMOK, DMBHHLKMHOH);
		}
		BMELMNNFCGJ.pitch = DHHKELJFPIG;
		BMELMNNFCGJ.PlayOneShot(LOAKJDCMMOK, CDPMDDDGBIG);
		return BMELMNNFCGJ;
	}
}
