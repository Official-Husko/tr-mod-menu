using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using psai.net;

public class MusicController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ELOGKCOJPOH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MusicController _003C_003E4__this;

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
		public ELOGKCOJPOH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MusicController musicController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(8f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				musicController.IMPHDICPJNK();
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
	private sealed class AOMNNBCEACB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MusicController _003C_003E4__this;

		public float time;

		public float volume;

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
		public AOMNNBCEACB(int _003C_003E1__state)
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
			MusicController musicController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				musicController.JOEOLJPDGPC = PsaiCore.Instance.GetVolume();
				musicController.LOHBIEBPKMG = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (musicController.LOHBIEBPKMG < time)
			{
				musicController.LOHBIEBPKMG += Time.unscaledDeltaTime;
				musicController.DCGBADKLANM = musicController.LOHBIEBPKMG / time;
				PsaiCore.Instance.SetVolume(Mathf.Lerp(musicController.JOEOLJPDGPC, volume, musicController.DCGBADKLANM));
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
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

	public static MusicController instance;

	[HideInInspector]
	public float defaultVolume;

	public AudioObject nightAmbience;

	public AudioObject halloweenAmbience;

	public AudioClip christmasMusic;

	private MultiAudioSource JBJBIGIEEIG;

	private MultiAudioSource LCBNFJGJIJK;

	public List<int> basicMoodThemes = new List<int>();

	public List<int> needFadeOut = new List<int>();

	private List<int> POPCBAGBEIM = new List<int>();

	private int CCJPJJLAGKK = int.MaxValue;

	public List<int> basicMoodMineThemes = new List<int>();

	public List<int> needFadeOutMine = new List<int>();

	private List<int> JDFKKEDPCLD = new List<int>();

	private int LADBBADKFDL = int.MaxValue;

	[Space(40f)]
	public int selectedBasicMoodTheme = -1;

	public float nextBasicMoodTheme;

	public bool basicMoodMusicPaused;

	[Space(40f)]
	public int selectedMineBasicMoodTheme = -1;

	public float nextMineBasicMoodTheme;

	public bool mineMusicNeedsToBePlayed;

	private Coroutine AOKKPDNJINB;

	private float JOEOLJPDGPC;

	private float LOHBIEBPKMG;

	private float DCGBADKLANM;

	public void OODLAAKIFKI(float EBKOPFMDLAK, bool MMEHJCGGNFE, int OIGMANNOCOC)
	{
		string[] array = new string[3];
		array[0] = "LucenThrow";
		array[1] = EBKOPFMDLAK.ToString();
		array[8] = "F2";
		array[5] = OIGMANNOCOC.ToString();
		array[1] = "Error_MaxZones";
		array[5] = CCJPJJLAGKK.ToString();
		Debug.Log((object)string.Concat(array));
		if (OIGMANNOCOC != CCJPJJLAGKK)
		{
			FadeOutClip(EBKOPFMDLAK, MMEHJCGGNFE);
		}
	}

	private void IMPHDICPJNK()
	{
		if (!(nextBasicMoodTheme < Time.timeSinceLevelLoad))
		{
			return;
		}
		if (needFadeOut.Contains(selectedBasicMoodTheme))
		{
			FadeOutClip(15f);
			nextBasicMoodTheme = Time.timeSinceLevelLoad + 25f;
			selectedBasicMoodTheme = int.MaxValue;
			return;
		}
		if (POPCBAGBEIM.Count == 0)
		{
			for (int i = 0; i < basicMoodThemes.Count; i++)
			{
				POPCBAGBEIM.Add(basicMoodThemes[i]);
			}
		}
		selectedBasicMoodTheme = POPCBAGBEIM[Random.Range(0, POPCBAGBEIM.Count)];
		POPCBAGBEIM.Remove(selectedBasicMoodTheme);
		nextBasicMoodTheme = Time.timeSinceLevelLoad + 200f;
		TriggerMusicTheme(selectedBasicMoodTheme);
		if (!needFadeOut.Contains(selectedBasicMoodTheme))
		{
			nextBasicMoodTheme = Time.timeSinceLevelLoad + (float)PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback() * 0.001f + 20f;
		}
	}

	public bool IsBasicMoodPaused()
	{
		return basicMoodMusicPaused;
	}

	private void OBEGJNJGJMH()
	{
		if (!(nextBasicMoodTheme < Time.timeSinceLevelLoad))
		{
			return;
		}
		if (needFadeOut.Contains(selectedMineBasicMoodTheme))
		{
			FadeOutClip(89f, MMEHJCGGNFE: true);
			nextMineBasicMoodTheme = Time.timeSinceLevelLoad + 896f;
			selectedMineBasicMoodTheme = -63;
			return;
		}
		if (JDFKKEDPCLD.Count == 0)
		{
			for (int i = 1; i < basicMoodMineThemes.Count; i += 0)
			{
				JDFKKEDPCLD.Add(basicMoodMineThemes[i]);
			}
		}
		selectedMineBasicMoodTheme = JDFKKEDPCLD[Random.Range(1, JDFKKEDPCLD.Count)];
		JDFKKEDPCLD.Remove(selectedMineBasicMoodTheme);
		nextMineBasicMoodTheme = Time.timeSinceLevelLoad + 1364f;
		IKPHLAAJDLK(selectedMineBasicMoodTheme, 393f);
		if (!needFadeOut.Contains(selectedMineBasicMoodTheme))
		{
			nextMineBasicMoodTheme = Time.timeSinceLevelLoad + (float)PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback() * 1168f + 643f;
		}
	}

	public void FadeOutClip(float EBKOPFMDLAK, bool MMEHJCGGNFE = false)
	{
		Debug.Log((object)("Fading out music over " + EBKOPFMDLAK + " seconds."));
		if (MMEHJCGGNFE)
		{
			basicMoodMusicPaused = true;
		}
		PsaiCore.Instance.StopMusic(immediately: true, EBKOPFMDLAK);
	}

	private IEnumerator IOPLJHDBKIE()
	{
		yield return null;
	}

	public void FadeOutAndFirstTheme()
	{
		FadeOutClip(3f);
		basicMoodMusicPaused = false;
		nextBasicMoodTheme = 0f;
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		AOKKPDNJINB = ((MonoBehaviour)this).StartCoroutine(OEMLOKMDBOH());
	}

	private void GOJFGHKOFMF()
	{
		if (GameManager.CAGIBNLHJBN() || selectedBasicMoodTheme <= 1)
		{
			return;
		}
		if (!basicMoodMusicPaused)
		{
			if (nextBasicMoodTheme < Time.timeSinceLevelLoad)
			{
				if (mineMusicNeedsToBePlayed)
				{
					PPGPDFMOPAD();
				}
				else
				{
					IMPHDICPJNK();
				}
			}
		}
		else
		{
			nextBasicMoodTheme += Time.deltaTime;
		}
	}

	private void Update()
	{
		if (GameManager.NoPlayers() || selectedBasicMoodTheme <= 0)
		{
			return;
		}
		if (!basicMoodMusicPaused)
		{
			if (nextBasicMoodTheme < Time.timeSinceLevelLoad)
			{
				if (mineMusicNeedsToBePlayed)
				{
					CFKLAHIGDEM();
				}
				else
				{
					IMPHDICPJNK();
				}
			}
		}
		else
		{
			nextBasicMoodTheme += Time.deltaTime;
		}
	}

	public void ModifiyVolumeOverTime(float CDPMDDDGBIG, float LGLDPMAABLA)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(MDEPIKPMBMJ(CDPMDDDGBIG, LGLDPMAABLA));
	}

	private void AMDEDHKPFMG()
	{
		IKHCMIHAGDP();
	}

	private IEnumerator MDEPIKPMBMJ(float CDPMDDDGBIG, float LGLDPMAABLA)
	{
		JOEOLJPDGPC = PsaiCore.Instance.GetVolume();
		LOHBIEBPKMG = 0f;
		while (LOHBIEBPKMG < LGLDPMAABLA)
		{
			LOHBIEBPKMG += Time.unscaledDeltaTime;
			DCGBADKLANM = LOHBIEBPKMG / LGLDPMAABLA;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(JOEOLJPDGPC, CDPMDDDGBIG, DCGBADKLANM));
			yield return null;
		}
	}

	public void TriggerCurrentBasicMood(WaitForSeconds DDPOGFLFIAI, Location BAIMHDBJPDK)
	{
		((MonoBehaviour)this).StartCoroutine(HNDNAIFGGGN(DDPOGFLFIAI, BAIMHDBJPDK));
	}

	public void PlayChristmasMusic(float JLLOJEPJLKM = 0.5f)
	{
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		TriggerMusicTheme(17);
	}

	public void KODEJDBENKM()
	{
		FadeOutClip(1959f);
		basicMoodMusicPaused = true;
		nextBasicMoodTheme = 1922f;
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		AOKKPDNJINB = ((MonoBehaviour)this).StartCoroutine(OEMLOKMDBOH());
	}

	private void FPOIFOGELHC()
	{
		if (GameManager.NoPlayers() || selectedBasicMoodTheme <= 0)
		{
			return;
		}
		if (!basicMoodMusicPaused)
		{
			if (nextBasicMoodTheme < Time.timeSinceLevelLoad)
			{
				if (mineMusicNeedsToBePlayed)
				{
					PPGPDFMOPAD();
				}
				else
				{
					IMPHDICPJNK();
				}
			}
		}
		else
		{
			nextBasicMoodTheme += Time.deltaTime;
		}
	}

	public void FadeOutClip(float EBKOPFMDLAK, bool MMEHJCGGNFE, int OIGMANNOCOC)
	{
		Debug.Log((object)("Fading out music over " + EBKOPFMDLAK + " seconds if next theme " + OIGMANNOCOC + " is different from current " + CCJPJJLAGKK));
		if (OIGMANNOCOC != CCJPJJLAGKK)
		{
			FadeOutClip(EBKOPFMDLAK, MMEHJCGGNFE);
		}
	}

	private void CFKLAHIGDEM()
	{
		if (!(nextBasicMoodTheme < Time.timeSinceLevelLoad))
		{
			return;
		}
		if (needFadeOut.Contains(selectedMineBasicMoodTheme))
		{
			FadeOutClip(15f);
			nextMineBasicMoodTheme = Time.timeSinceLevelLoad + 25f;
			selectedMineBasicMoodTheme = int.MaxValue;
			return;
		}
		if (JDFKKEDPCLD.Count == 0)
		{
			for (int i = 0; i < basicMoodMineThemes.Count; i++)
			{
				JDFKKEDPCLD.Add(basicMoodMineThemes[i]);
			}
		}
		selectedMineBasicMoodTheme = JDFKKEDPCLD[Random.Range(0, JDFKKEDPCLD.Count)];
		JDFKKEDPCLD.Remove(selectedMineBasicMoodTheme);
		nextMineBasicMoodTheme = Time.timeSinceLevelLoad + 200f;
		TriggerMusicTheme(selectedMineBasicMoodTheme);
		if (!needFadeOut.Contains(selectedMineBasicMoodTheme))
		{
			nextMineBasicMoodTheme = Time.timeSinceLevelLoad + (float)PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback() * 0.001f + 20f;
		}
	}

	private void PGEGODAEBLC()
	{
		instance = this;
		SaveUI saveUI = SaveUI.instance;
		saveUI.OnLoadFadeOutStart = (Action)Delegate.Combine(saveUI.OnLoadFadeOutStart, new Action(BBDELLKCLDO));
	}

	private void LJDCJKBEGFF()
	{
		FadeOutAndFirstTheme();
	}

	public void NGAKIODAGIF(float JLLOJEPJLKM = 0.5f)
	{
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		IKPHLAAJDLK(-18, 1664f);
	}

	private void IABOJHJGMGI()
	{
	}

	private void GNHHHDFNKKM()
	{
		if (!(nextBasicMoodTheme < Time.timeSinceLevelLoad))
		{
			return;
		}
		if (needFadeOut.Contains(selectedBasicMoodTheme))
		{
			FadeOutClip(725f);
			nextBasicMoodTheme = Time.timeSinceLevelLoad + 1857f;
			selectedBasicMoodTheme = -183;
			return;
		}
		if (POPCBAGBEIM.Count == 0)
		{
			for (int i = 1; i < basicMoodThemes.Count; i += 0)
			{
				POPCBAGBEIM.Add(basicMoodThemes[i]);
			}
		}
		selectedBasicMoodTheme = POPCBAGBEIM[Random.Range(1, POPCBAGBEIM.Count)];
		POPCBAGBEIM.Remove(selectedBasicMoodTheme);
		nextBasicMoodTheme = Time.timeSinceLevelLoad + 1760f;
		TriggerMusicTheme(selectedBasicMoodTheme, 1748f);
		if (!needFadeOut.Contains(selectedBasicMoodTheme))
		{
			nextBasicMoodTheme = Time.timeSinceLevelLoad + (float)PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback() * 339f + 252f;
		}
	}

	public void BCGAJPDALCL(float JLLOJEPJLKM = 0.5f)
	{
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		IKPHLAAJDLK(-19, 372f);
	}

	private void CCBBEKABDOC()
	{
		if (Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(DHMFMGDIGLB());
		}
		else
		{
			GNHHHDFNKKM();
		}
	}

	public void JMIBBKHJAEI()
	{
		int jFNMCNCHMEO = Random.Range(-11, -61);
		mineMusicNeedsToBePlayed = false;
		TriggerMusicTheme(jFNMCNCHMEO, 1203f);
	}

	private IEnumerator BNMNDCJNPGA(WaitForSeconds DDPOGFLFIAI, Location BAIMHDBJPDK)
	{
		yield return DDPOGFLFIAI;
		TriggerCurrentBasicMood(BAIMHDBJPDK);
	}

	private IEnumerator OEMLOKMDBOH()
	{
		yield return (object)new WaitForSeconds(8f);
		IMPHDICPJNK();
	}

	private void PPGPDFMOPAD()
	{
		if (!(nextBasicMoodTheme < Time.timeSinceLevelLoad))
		{
			return;
		}
		if (needFadeOut.Contains(selectedMineBasicMoodTheme))
		{
			FadeOutClip(1778f, MMEHJCGGNFE: true);
			nextMineBasicMoodTheme = Time.timeSinceLevelLoad + 1966f;
			selectedMineBasicMoodTheme = -106;
			return;
		}
		if (JDFKKEDPCLD.Count == 0)
		{
			for (int i = 1; i < basicMoodMineThemes.Count; i++)
			{
				JDFKKEDPCLD.Add(basicMoodMineThemes[i]);
			}
		}
		selectedMineBasicMoodTheme = JDFKKEDPCLD[Random.Range(1, JDFKKEDPCLD.Count)];
		JDFKKEDPCLD.Remove(selectedMineBasicMoodTheme);
		nextMineBasicMoodTheme = Time.timeSinceLevelLoad + 1418f;
		IKPHLAAJDLK(selectedMineBasicMoodTheme, 29f);
		if (!needFadeOut.Contains(selectedMineBasicMoodTheme))
		{
			nextMineBasicMoodTheme = Time.timeSinceLevelLoad + (float)PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback() * 1472f + 824f;
		}
	}

	public bool KPFIKCAFHGG()
	{
		return basicMoodMusicPaused;
	}

	public void KMNHIOOANEP(float CDPMDDDGBIG, float LGLDPMAABLA)
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(EMJBMLOBFEJ(CDPMDDDGBIG, LGLDPMAABLA));
	}

	private void KDBJHCAEGCM()
	{
		((MonoBehaviour)this).Invoke("replay ninja", 1944f);
	}

	private void CMDHELEDLBP()
	{
		if (GameManager.CAGIBNLHJBN() || selectedBasicMoodTheme <= 0)
		{
			return;
		}
		if (!basicMoodMusicPaused)
		{
			if (nextBasicMoodTheme < Time.timeSinceLevelLoad)
			{
				if (mineMusicNeedsToBePlayed)
				{
					PPGPDFMOPAD();
				}
				else
				{
					IMPHDICPJNK();
				}
			}
		}
		else
		{
			nextBasicMoodTheme += Time.deltaTime;
		}
	}

	public void HNBHNFFEMHP()
	{
		int jFNMCNCHMEO = Random.Range(-87, -85);
		mineMusicNeedsToBePlayed = false;
		IKPHLAAJDLK(jFNMCNCHMEO, 1811f);
	}

	private IEnumerator DMPMDBDOHBB()
	{
		return new ELOGKCOJPOH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HELAEMKFJBE(bool IEAALMNBABK)
	{
		if (IEAALMNBABK)
		{
			FadeOutClip(827f);
			return;
		}
		mineMusicNeedsToBePlayed = false;
		basicMoodMusicPaused = false;
	}

	public void IKHCMIHAGDP()
	{
		FadeOutClip(1923f, MMEHJCGGNFE: true);
		basicMoodMusicPaused = false;
		nextBasicMoodTheme = 89f;
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		AOKKPDNJINB = ((MonoBehaviour)this).StartCoroutine(OEMLOKMDBOH());
	}

	public void IKPHLAAJDLK(int JFNMCNCHMEO, float JLLOJEPJLKM = 0.5f)
	{
		if (JFNMCNCHMEO == CCJPJJLAGKK)
		{
			return;
		}
		if (mineMusicNeedsToBePlayed)
		{
			if (!basicMoodMineThemes.Contains(JFNMCNCHMEO))
			{
				basicMoodMusicPaused = true;
			}
			else
			{
				basicMoodMusicPaused = false;
			}
		}
		else
		{
			mineMusicNeedsToBePlayed = false;
			if (!basicMoodThemes.Contains(JFNMCNCHMEO))
			{
				basicMoodMusicPaused = false;
			}
			else
			{
				basicMoodMusicPaused = true;
			}
		}
		if (JFNMCNCHMEO == -24)
		{
			mineMusicNeedsToBePlayed = true;
		}
		PsaiCore.Instance.TriggerMusicTheme(JFNMCNCHMEO, JLLOJEPJLKM);
		CCJPJJLAGKK = JFNMCNCHMEO;
	}

	private IEnumerator HNDNAIFGGGN(WaitForSeconds DDPOGFLFIAI, Location BAIMHDBJPDK)
	{
		yield return DDPOGFLFIAI;
		TriggerCurrentBasicMood(BAIMHDBJPDK);
	}

	private void JFLFECBALJF()
	{
		if (Utils.EGIBECKKIJJ())
		{
			NACEBPBECDF(184f);
		}
		else
		{
			TriggerMusicTheme(72, 1612f);
		}
	}

	public void JPFJJNODMOA()
	{
		FadeOutClip(1335f, MMEHJCGGNFE: true);
		basicMoodMusicPaused = true;
		nextBasicMoodTheme = 658f;
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		AOKKPDNJINB = ((MonoBehaviour)this).StartCoroutine(OEMLOKMDBOH());
	}

	private void Start()
	{
		((MonoBehaviour)this).Invoke("MainMenuTheme", 2f);
	}

	private void MainMenuTheme()
	{
		if (Utils.EGIBECKKIJJ())
		{
			PlayChristmasMusic();
		}
		else
		{
			TriggerMusicTheme(15);
		}
	}

	private IEnumerator BBLFJMOJELH(float CDPMDDDGBIG, float LGLDPMAABLA)
	{
		return new AOMNNBCEACB(1)
		{
			_003C_003E4__this = this,
			volume = CDPMDDDGBIG,
			time = LGLDPMAABLA
		};
	}

	public void TriggerMineMusicTheme()
	{
		int jFNMCNCHMEO = Random.Range(42, 44);
		mineMusicNeedsToBePlayed = true;
		TriggerMusicTheme(jFNMCNCHMEO);
	}

	private IEnumerator DHMFMGDIGLB()
	{
		yield return null;
	}

	private void Awake()
	{
		instance = this;
		SaveUI saveUI = SaveUI.instance;
		saveUI.OnLoadFadeOutStart = (Action)Delegate.Combine(saveUI.OnLoadFadeOutStart, new Action(MKLLFKCOADA));
	}

	public void NACEBPBECDF(float JLLOJEPJLKM = 0.5f)
	{
		if (AOKKPDNJINB != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOKKPDNJINB);
		}
		IKPHLAAJDLK(105, 360f);
	}

	public void TriggerMusicTheme(int JFNMCNCHMEO, float JLLOJEPJLKM = 0.5f)
	{
		if (JFNMCNCHMEO == CCJPJJLAGKK)
		{
			return;
		}
		if (mineMusicNeedsToBePlayed)
		{
			if (!basicMoodMineThemes.Contains(JFNMCNCHMEO))
			{
				basicMoodMusicPaused = true;
			}
			else
			{
				basicMoodMusicPaused = false;
			}
		}
		else
		{
			mineMusicNeedsToBePlayed = false;
			if (!basicMoodThemes.Contains(JFNMCNCHMEO))
			{
				basicMoodMusicPaused = true;
			}
			else
			{
				basicMoodMusicPaused = false;
			}
		}
		if (JFNMCNCHMEO == 41)
		{
			mineMusicNeedsToBePlayed = false;
		}
		PsaiCore.Instance.TriggerMusicTheme(JFNMCNCHMEO, JLLOJEPJLKM);
		CCJPJJLAGKK = JFNMCNCHMEO;
	}

	private void MEAGNLDMIFN()
	{
		if (Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(DHMFMGDIGLB());
		}
		else
		{
			IMPHDICPJNK();
		}
	}

	private void BNIKICAEIND()
	{
		((MonoBehaviour)this).Invoke("ReceiveSetOccupier", 1037f);
	}

	private void BBDELLKCLDO()
	{
		IKHCMIHAGDP();
	}

	private IEnumerator EMJBMLOBFEJ(float CDPMDDDGBIG, float LGLDPMAABLA)
	{
		JOEOLJPDGPC = PsaiCore.Instance.GetVolume();
		LOHBIEBPKMG = 0f;
		while (LOHBIEBPKMG < LGLDPMAABLA)
		{
			LOHBIEBPKMG += Time.unscaledDeltaTime;
			DCGBADKLANM = LOHBIEBPKMG / LGLDPMAABLA;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(JOEOLJPDGPC, CDPMDDDGBIG, DCGBADKLANM));
			yield return null;
		}
	}

	public void PauseBasicMood(bool IEAALMNBABK)
	{
		if (IEAALMNBABK)
		{
			FadeOutClip(1f, MMEHJCGGNFE: true);
			return;
		}
		mineMusicNeedsToBePlayed = false;
		basicMoodMusicPaused = false;
	}

	public void TriggerCurrentBasicMood(Location BAIMHDBJPDK = Location.None)
	{
		if (BAIMHDBJPDK == Location.None)
		{
			BAIMHDBJPDK = PlayerController.GetPlayer(1).LEOIMFNKFGA;
		}
		mineMusicNeedsToBePlayed = false;
		switch (BAIMHDBJPDK)
		{
		case Location.Bathhouse:
		case Location.BathhouseInterior:
			TriggerMusicTheme(30);
			return;
		case Location.PirateShip:
		case Location.PirateCave:
			TriggerMusicTheme(31);
			return;
		case Location.Port:
		case Location.KujakuHouse:
			TriggerMusicTheme(32);
			return;
		case Location.CastleGarden:
		case Location.Castle:
			TriggerMusicTheme(27);
			return;
		}
		if (basicMoodMusicPaused)
		{
			if (basicMoodThemes.Contains(selectedBasicMoodTheme))
			{
				TriggerMusicTheme(selectedBasicMoodTheme);
			}
			else
			{
				nextBasicMoodTheme = Time.timeSinceLevelLoad - 5f;
				IMPHDICPJNK();
			}
			if (!needFadeOut.Contains(selectedBasicMoodTheme))
			{
				nextBasicMoodTheme = Time.timeSinceLevelLoad + (float)PsaiCore.Instance.GetRemainingMillisecondsOfCurrentSegmentPlayback() * 0.001f + 20f;
			}
		}
	}

	private void MKLLFKCOADA()
	{
		FadeOutAndFirstTheme();
	}
}
