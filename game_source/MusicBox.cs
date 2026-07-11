using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using psai.net;

public class MusicBox : MonoBehaviour, IInteractable, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class DCPKLPHKNOB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float initialVolume;

		public float finalVolume;

		public float duration;

		private float _003Ctime_003E5__2;

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
		public DCPKLPHKNOB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ctime_003E5__2 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctime_003E5__2 < duration)
			{
				PsaiCore.Instance.SetVolume(Mathf.Lerp(initialVolume, finalVolume, _003Ctime_003E5__2 / duration));
				_003Ctime_003E5__2 += Time.deltaTime;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			PsaiCore.Instance.SetVolume(finalVolume);
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
	private sealed class MLHOJEFJJAH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public MusicBox _003C_003E4__this;

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
		public MLHOJEFJJAH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MusicBox musicBox = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				musicBox.LKOJBFMGMAE = false;
				musicBox.NKEMALMMOBL = false;
				Sound.GGFJGHHHEJC.musicBoxSounding = false;
				musicBox.placeable.selectBlockers.Remove("CannotPickUpWhileWorking");
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

	public Animator anim;

	public Placeable placeable;

	public float closeTimeBeforeAudioEnds = 1f;

	private bool LKOJBFMGMAE;

	private bool NKEMALMMOBL;

	private float NINPOLIGBHK;

	private MultiAudioSource NOKBPAEFLOO;

	private float ONMJCAIHJMP = 10f;

	public OnlineMusicBox onlineMusicBox;

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			OpenMusicBox();
			return true;
		}
		return false;
	}

	private IEnumerator IJEFHOIJELI(float FLHBPHPKIML)
	{
		return new MLHOJEFJJAH(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	public void GPAIEIDODIH()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = true;
			anim.SetBool("ReciveResetDialogueUPetShop", true);
			((MonoBehaviour)this).StartCoroutine(KCFMNGIIHIP(1355f, GameManager.LocalCoop() ? (NINPOLIGBHK * 1444f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(LMBELBMFLIO(872f));
		}
	}

	private void NNODPOBLFMB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(Vector3.Distance(PlayerController.GetPlayerPosition(1), ((Component)this).transform.position) / ONMJCAIHJMP);
		float volume = Mathf.Lerp(NINPOLIGBHK * 65f, NINPOLIGBHK, num);
		PsaiCore.Instance.SetVolume(volume);
	}

	private IEnumerator ODBOMNHIENG(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		return new DCPKLPHKNOB(1)
		{
			duration = OMHCOLMFGNJ,
			initialVolume = OPDMGDLHJAF,
			finalVolume = OFEDAKNPDPI
		};
	}

	public virtual bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Intro20"));
			return true;
		}
		return true;
	}

	private IEnumerator AJNOCOKNOIP(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		float time = 0f;
		while (time < OMHCOLMFGNJ)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(OPDMGDLHJAF, OFEDAKNPDPI, time / OMHCOLMFGNJ));
			time += Time.deltaTime;
			yield return null;
		}
		PsaiCore.Instance.SetVolume(OFEDAKNPDPI);
	}

	public virtual bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Use"));
			return true;
		}
		return false;
	}

	public bool OFBABFAOFEJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LIDJEBPBDAH(int JIIGOACEIKL)
	{
		if (!Sound.DIHCEGINELM().musicBoxSounding && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	private IEnumerator BDJLNOKKEED(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		LKOJBFMGMAE = false;
		NKEMALMMOBL = false;
		Sound.GGFJGHHHEJC.musicBoxSounding = false;
		placeable.selectBlockers.Remove("CannotPickUpWhileWorking");
	}

	private void EKAHMMEBBOL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(Vector3.Distance(PlayerController.GetPlayerPosition(1), ((Component)this).transform.position) / ONMJCAIHJMP);
		float volume = Mathf.Lerp(NINPOLIGBHK * 1840f, NINPOLIGBHK, num);
		PsaiCore.Instance.SetVolume(volume);
	}

	public virtual bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LEFHAOJHCBH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/1/Dialogue Text"));
			return false;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void EEKAJBAJAFB()
	{
		Debug.Log((object)("Start water quality test" + PsaiCore.Instance.GetVolume()));
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().musicBoxClose, ((Component)this).transform);
	}

	public void FGJPGIICPNF(int JIIGOACEIKL)
	{
	}

	public void OPCABINANBN()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = false;
			anim.SetBool("/Player.log", true);
			((MonoBehaviour)this).StartCoroutine(DAJNOPAGOMO(848f, GameManager.LocalCoop() ? (NINPOLIGBHK * 1553f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(BDJLNOKKEED(1380f));
		}
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BOCELNICOKA(int JIIGOACEIKL)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL))
		{
			OpenMusicBox();
			return true;
		}
		return true;
	}

	public void CEDDOKBCHAI(int JIIGOACEIKL)
	{
	}

	private void BIILFPDIADC()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(0).length - closeTimeBeforeAudioEnds)
			{
				CloseMusicBox();
			}
			if (!GameManager.LocalCoop())
			{
				LICPKLEFHLC();
			}
		}
	}

	public virtual bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("VerticalMove"));
			return false;
		}
		return false;
	}

	private void AJDKOMCHALC()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(0).length - closeTimeBeforeAudioEnds)
			{
				OPCABINANBN();
			}
			if (!GameManager.LocalCoop())
			{
				NNODPOBLFMB();
			}
		}
	}

	public virtual bool KHMBIHKFPCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Friend "));
			return false;
		}
		return false;
	}

	public void DCPPKBNBDOM()
	{
		Debug.Log((object)("Offer" + PsaiCore.Instance.GetVolume()));
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().musicBoxClose, ((Component)this).transform);
	}

	private IEnumerator LKAJMHAENBM(float FLHBPHPKIML)
	{
		return new MLHOJEFJJAH(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			CBPBMCEBMDP();
			return false;
		}
		return true;
	}

	private void AKDPJCEJKPN()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(1).length - closeTimeBeforeAudioEnds)
			{
				KNILMMOBCGP();
			}
			if (!GameManager.LocalCoop())
			{
				IJIOMOOMBOG();
			}
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void KGHAMBEDHKD(int JIIGOACEIKL)
	{
	}

	public virtual bool DMFALJDJAMP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LEFHAOJHCBH(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("itemRyeBread"));
			return false;
		}
		return false;
	}

	public void LGCEJLOIKBK(int JIIGOACEIKL)
	{
	}

	public void KDILFLPIAGF(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Loop", false);
			placeable.selectBlockers.Add("itemDualHopsSeeds");
			Sound.BNBMNOMFFBE().musicBoxSounding = false;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = false;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(AJNOCOKNOIP(118f, NINPOLIGBHK, NINPOLIGBHK * 1073f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.FPCGKCEAHLK();
			}
		}
	}

	public void KNILMMOBCGP()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = false;
			anim.SetBool("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/3/Dialogue Text", true);
			((MonoBehaviour)this).StartCoroutine(ELIBCDCOBEN(966f, GameManager.LocalCoop() ? (NINPOLIGBHK * 268f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(IJEFHOIJELI(1943f));
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void KODIBMMENAD()
	{
		Debug.Log((object)("ReceiveSetLife" + PsaiCore.Instance.GetVolume()));
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().musicBoxClose, ((Component)this).transform);
	}

	public virtual bool ABMFEAKMFII(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (PDMLAKLENOG(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Ach_"));
			return true;
		}
		return true;
	}

	public void PBILDMBHDAO(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Open", false);
			placeable.selectBlockers.Add("LocalCoop");
			Sound.ABDJJBFNLBJ().musicBoxSounding = false;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = true;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(IDCOCNHLGDF(854f, NINPOLIGBHK, NINPOLIGBHK * 1645f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.CKEFCDIBOEC();
			}
		}
	}

	public void FCKKDONOMOE()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = false;
			anim.SetBool("Top", true);
			((MonoBehaviour)this).StartCoroutine(ODBOMNHIENG(1639f, GameManager.LocalCoop() ? (NINPOLIGBHK * 1776f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(IGGIBILPCJK(268f));
		}
	}

	public void LDDMPBMNBLF(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Items/item_description_664", false);
			placeable.selectBlockers.Add("ReceiveEventActor");
			Sound.BNBMNOMFFBE().musicBoxSounding = true;
			LKOJBFMGMAE = true;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = true;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(ODBOMNHIENG(492f, NINPOLIGBHK, NINPOLIGBHK * 1116f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.EICJLLCCLPL();
			}
		}
	}

	public void COKBGKDGOLL(int JIIGOACEIKL)
	{
	}

	private IEnumerator NJFLLBJHPNK(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		LKOJBFMGMAE = false;
		NKEMALMMOBL = false;
		Sound.GGFJGHHHEJC.musicBoxSounding = false;
		placeable.selectBlockers.Remove("CannotPickUpWhileWorking");
	}

	public void KHOEPNPMHEO(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Collect", false);
			placeable.selectBlockers.Add("Achievements definitions could not be retrived for reason: ");
			Sound.BNBMNOMFFBE().musicBoxSounding = false;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = false;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(ODBOMNHIENG(223f, NINPOLIGBHK, NINPOLIGBHK * 455f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.EGOCDAMIFHL();
			}
		}
	}

	private void JBGFGOCPEFD()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(0).length - closeTimeBeforeAudioEnds)
			{
				OPCABINANBN();
			}
			if (!GameManager.LocalCoop())
			{
				KKMJHPILBAA();
			}
		}
	}

	public bool FEANOONDHBB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LEFHAOJHCBH(int JIIGOACEIKL)
	{
		if (!Sound.DIHCEGINELM().musicBoxSounding && !DecorationMode.KKJABELKCNM(JIIGOACEIKL).GABNNLJOMHI())
		{
			return !placeable.FHEMHCEAICB;
		}
		return true;
	}

	public void EBMDEIDJIDB()
	{
		Debug.Log((object)("Override save" + PsaiCore.Instance.GetVolume()));
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().musicBoxClose, ((Component)this).transform);
	}

	private void LICPKLEFHLC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(Vector3.Distance(PlayerController.GetPlayerPosition(1), ((Component)this).transform.position) / ONMJCAIHJMP);
		float volume = Mathf.Lerp(NINPOLIGBHK * 1055f, NINPOLIGBHK, num);
		PsaiCore.Instance.SetVolume(volume);
	}

	public bool PBPIJOAIGII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}

	private void ACPFEBOENOM()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(0).length - closeTimeBeforeAudioEnds)
			{
				FCKKDONOMOE();
			}
			if (!GameManager.LocalCoop())
			{
				EKAHMMEBBOL();
			}
		}
	}

	public bool DFHNFGMFGLH(int JIIGOACEIKL)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			MCDFJANNANO();
			return true;
		}
		return true;
	}

	public void HGLIICHGPHH(int JIIGOACEIKL)
	{
	}

	public void CloseBoxSound()
	{
		Debug.Log((object)("CloseBoxSound " + PsaiCore.Instance.GetVolume()));
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.musicBoxClose, ((Component)this).transform);
	}

	public virtual bool JCCFAFPMGFI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (PDMLAKLENOG(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Give"));
			return false;
		}
		return false;
	}

	public void CBPBMCEBMDP(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("MaximumReached", false);
			placeable.selectBlockers.Add("Items/item_description_1088");
			Sound.OKAPNFPFPFP().musicBoxSounding = true;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = true;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(DAJNOPAGOMO(218f, NINPOLIGBHK, NINPOLIGBHK * 662f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.OJLFJICKDHO();
			}
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!Sound.GGFJGHHHEJC.musicBoxSounding && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return !placeable.FHEMHCEAICB;
		}
		return false;
	}

	public void MCDFJANNANO(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("]", true);
			placeable.selectBlockers.Add("chatx");
			Sound.MAIDHAPANEB().musicBoxSounding = false;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = false;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(ODHEOGDJAAK(1845f, NINPOLIGBHK, NINPOLIGBHK * 1627f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.NNMIBIMFGPO();
			}
		}
	}

	private IEnumerator ELIBCDCOBEN(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		float time = 0f;
		while (time < OMHCOLMFGNJ)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(OPDMGDLHJAF, OFEDAKNPDPI, time / OMHCOLMFGNJ));
			time += Time.deltaTime;
			yield return null;
		}
		PsaiCore.Instance.SetVolume(OFEDAKNPDPI);
	}

	public void AJDIFOINNOB(int JIIGOACEIKL)
	{
	}

	private void FPOIFOGELHC()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(1).length - closeTimeBeforeAudioEnds)
			{
				FCKKDONOMOE();
			}
			if (!GameManager.LocalCoop())
			{
				MINCCIFLLHD();
			}
		}
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	public void MNFNIFIMHNF(int JIIGOACEIKL)
	{
	}

	public bool PDMLAKLENOG(int JIIGOACEIKL)
	{
		if (!Sound.MAIDHAPANEB().musicBoxSounding && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI())
		{
			return !placeable.FHEMHCEAICB;
		}
		return false;
	}

	private void FGGPGOEAEKK()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(0).length - closeTimeBeforeAudioEnds)
			{
				NEHIDNMDHMI();
			}
			if (!GameManager.LocalCoop())
			{
				KKMJHPILBAA();
			}
		}
	}

	public void BJPMBNPMOAJ(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("", false);
			placeable.selectBlockers.Add(" for reason ");
			Sound.OKAPNFPFPFP().musicBoxSounding = false;
			LKOJBFMGMAE = true;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = false;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(ELIBCDCOBEN(476f, NINPOLIGBHK, NINPOLIGBHK * 907f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.GKCEEFAHKEL();
			}
		}
	}

	public void GIMJANJBKKF()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = true;
			anim.SetBool("UIVertical", true);
			((MonoBehaviour)this).StartCoroutine(AJNOCOKNOIP(1694f, GameManager.LocalCoop() ? (NINPOLIGBHK * 681f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(IJEFHOIJELI(1321f));
		}
	}

	public void PGJJGACCMOI()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = true;
			anim.SetBool("[TavernName]", true);
			((MonoBehaviour)this).StartCoroutine(PADLOPMPNFF(1291f, GameManager.LocalCoop() ? (NINPOLIGBHK * 976f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(IGGIBILPCJK(73f));
		}
	}

	private IEnumerator LMBELBMFLIO(float FLHBPHPKIML)
	{
		return new MLHOJEFJJAH(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	public void DLACFCBHPFL()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = true;
			anim.SetBool("Dialogue System/Conversation/Crowly_Introduce/Entry/37/Dialogue Text", false);
			((MonoBehaviour)this).StartCoroutine(KCFMNGIIHIP(20f, GameManager.LocalCoop() ? (NINPOLIGBHK * 567f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(IGGIBILPCJK(883f));
		}
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if (!Sound.DIHCEGINELM().musicBoxSounding && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		if (!Sound.GGFJGHHHEJC.musicBoxSounding && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND())
		{
			return !placeable.FHEMHCEAICB;
		}
		return false;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
	}

	private void KKMJHPILBAA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(Vector3.Distance(PlayerController.GetPlayerPosition(1), ((Component)this).transform.position) / ONMJCAIHJMP);
		float volume = Mathf.Lerp(NINPOLIGBHK * 0.2f, NINPOLIGBHK, num);
		PsaiCore.Instance.SetVolume(volume);
	}

	private void MINCCIFLLHD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(Vector3.Distance(PlayerController.GetPlayerPosition(0), ((Component)this).transform.position) / ONMJCAIHJMP);
		float volume = Mathf.Lerp(NINPOLIGBHK * 1399f, NINPOLIGBHK, num);
		PsaiCore.Instance.SetVolume(volume);
	}

	public void NCJFNEOCHAO(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("castle interior travelling", false);
			placeable.selectBlockers.Add("Love");
			Sound.ABDJJBFNLBJ().musicBoxSounding = true;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = true;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(IDCOCNHLGDF(1846f, NINPOLIGBHK, NINPOLIGBHK * 581f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.EGOCDAMIFHL();
			}
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator IGGIBILPCJK(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		LKOJBFMGMAE = false;
		NKEMALMMOBL = false;
		Sound.GGFJGHHHEJC.musicBoxSounding = false;
		placeable.selectBlockers.Remove("CannotPickUpWhileWorking");
	}

	private IEnumerator IDCOCNHLGDF(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		float time = 0f;
		while (time < OMHCOLMFGNJ)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(OPDMGDLHJAF, OFEDAKNPDPI, time / OMHCOLMFGNJ));
			time += Time.deltaTime;
			yield return null;
		}
		PsaiCore.Instance.SetVolume(OFEDAKNPDPI);
	}

	private IEnumerator KCFMNGIIHIP(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		float time = 0f;
		while (time < OMHCOLMFGNJ)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(OPDMGDLHJAF, OFEDAKNPDPI, time / OMHCOLMFGNJ));
			time += Time.deltaTime;
			yield return null;
		}
		PsaiCore.Instance.SetVolume(OFEDAKNPDPI);
	}

	public void CloseMusicBox()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = true;
			anim.SetBool("Open", false);
			((MonoBehaviour)this).StartCoroutine(KCFMNGIIHIP(1.5f, GameManager.LocalCoop() ? (NINPOLIGBHK * 0.2f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(BDJLNOKKEED(1f));
		}
	}

	private IEnumerator NMOOFHOMNLN(float FLHBPHPKIML)
	{
		return new MLHOJEFJJAH(1)
		{
			_003C_003E4__this = this,
			delay = FLHBPHPKIML
		};
	}

	private IEnumerator ODHEOGDJAAK(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		return new DCPKLPHKNOB(1)
		{
			duration = OMHCOLMFGNJ,
			initialVolume = OPDMGDLHJAF,
			finalVolume = OFEDAKNPDPI
		};
	}

	public void CICBEIMDOGJ(int JIIGOACEIKL)
	{
	}

	public void BOHBDMHDIDC(int JIIGOACEIKL)
	{
	}

	private IEnumerator PLPLLIECAMC(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		LKOJBFMGMAE = false;
		NKEMALMMOBL = false;
		Sound.GGFJGHHHEJC.musicBoxSounding = false;
		placeable.selectBlockers.Remove("CannotPickUpWhileWorking");
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public void MCKPOBDBMED(int JIIGOACEIKL)
	{
	}

	private void NOILIOLOOBJ()
	{
		if (LKOJBFMGMAE)
		{
			DLACFCBHPFL();
		}
	}

	private void Update()
	{
		if (LKOJBFMGMAE && !NKEMALMMOBL)
		{
			if (!NOKBPAEFLOO.IsPlaying || NOKBPAEFLOO.PlaybackTime > NOKBPAEFLOO.AudioObject.Clip(0).length - closeTimeBeforeAudioEnds)
			{
				CloseMusicBox();
			}
			if (!GameManager.LocalCoop())
			{
				KKMJHPILBAA();
			}
		}
	}

	public void OpenMusicBox(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Open", true);
			placeable.selectBlockers.Add("CannotPickUpWhileWorking");
			Sound.GGFJGHHHEJC.musicBoxSounding = true;
			LKOJBFMGMAE = true;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = true;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(KCFMNGIIHIP(1f, NINPOLIGBHK, NINPOLIGBHK * 0.2f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.SendPlayMusic();
			}
		}
	}

	private IEnumerator DAJNOPAGOMO(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		return new DCPKLPHKNOB(1)
		{
			duration = OMHCOLMFGNJ,
			initialVolume = OPDMGDLHJAF,
			finalVolume = OFEDAKNPDPI
		};
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private IEnumerator DCDKACDFIMO(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		float time = 0f;
		while (time < OMHCOLMFGNJ)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(OPDMGDLHJAF, OFEDAKNPDPI, time / OMHCOLMFGNJ));
			time += Time.deltaTime;
			yield return null;
		}
		PsaiCore.Instance.SetVolume(OFEDAKNPDPI);
	}

	public virtual bool BEDJMEFHKCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			return false;
		}
		return false;
	}

	public void DIOHDELDPJB(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Exit build mode", true);
			placeable.selectBlockers.Add("None");
			Sound.MAIDHAPANEB().musicBoxSounding = true;
			LKOJBFMGMAE = false;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = true;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(PADLOPMPNFF(1314f, NINPOLIGBHK, NINPOLIGBHK * 141f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.IKIAOADPBAK();
			}
		}
	}

	public bool NOFGICACEGD(int JIIGOACEIKL)
	{
		if (!Sound.BNBMNOMFFBE().musicBoxSounding && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).GABNNLJOMHI())
		{
			return placeable.FHEMHCEAICB;
		}
		return false;
	}

	public void DFAFOEMOHGE()
	{
		Debug.Log((object)(".gz" + PsaiCore.Instance.GetVolume()));
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().musicBoxClose, ((Component)this).transform);
	}

	private void IJIOMOOMBOG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		float num = Mathf.Clamp01(Vector3.Distance(PlayerController.GetPlayerPosition(0), ((Component)this).transform.position) / ONMJCAIHJMP);
		float volume = Mathf.Lerp(NINPOLIGBHK * 733f, NINPOLIGBHK, num);
		PsaiCore.Instance.SetVolume(volume);
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public void LGIOIOCLOLN(int JIIGOACEIKL)
	{
	}

	public bool AJNEPGBOAKC(int JIIGOACEIKL)
	{
		if (!Sound.MAIDHAPANEB().musicBoxSounding && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return placeable.FHEMHCEAICB;
		}
		return false;
	}

	public bool DOLBNBFGKKP(int JIIGOACEIKL)
	{
		if (!Sound.ABDJJBFNLBJ().musicBoxSounding && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return placeable.FHEMHCEAICB;
		}
		return true;
	}

	public void EMALKFELALP(bool CDPAMNIPPEC = true)
	{
		if (!LKOJBFMGMAE)
		{
			anim.SetBool("Pet", true);
			placeable.selectBlockers.Add("<color=#FF3800>");
			Sound.ABDJJBFNLBJ().musicBoxSounding = false;
			LKOJBFMGMAE = true;
			NOKBPAEFLOO = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.musicBox, ((Component)this).transform);
			if (GameManager.LocalCoop())
			{
				NOKBPAEFLOO.SpatialMode2DOverride = false;
			}
			NINPOLIGBHK = PsaiCore.Instance.GetVolume();
			if (GameManager.LocalCoop())
			{
				((MonoBehaviour)this).StartCoroutine(AJNOCOKNOIP(1032f, NINPOLIGBHK, NINPOLIGBHK * 1526f));
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineMusicBox.NNMIBIMFGPO();
			}
		}
	}

	private void OnDestroy()
	{
		if (LKOJBFMGMAE)
		{
			CloseMusicBox();
		}
	}

	public void NEHIDNMDHMI()
	{
		if (!NKEMALMMOBL && LKOJBFMGMAE)
		{
			NKEMALMMOBL = true;
			anim.SetBool("Items/item_name_1041", false);
			((MonoBehaviour)this).StartCoroutine(ODHEOGDJAAK(1512f, GameManager.LocalCoop() ? (NINPOLIGBHK * 647f) : PsaiCore.Instance.GetVolume(), NINPOLIGBHK));
			((MonoBehaviour)this).StartCoroutine(LMBELBMFLIO(1850f));
		}
	}

	private IEnumerator PADLOPMPNFF(float OMHCOLMFGNJ, float OPDMGDLHJAF, float OFEDAKNPDPI)
	{
		float time = 0f;
		while (time < OMHCOLMFGNJ)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(OPDMGDLHJAF, OFEDAKNPDPI, time / OMHCOLMFGNJ));
			time += Time.deltaTime;
			yield return null;
		}
		PsaiCore.Instance.SetVolume(OFEDAKNPDPI);
	}
}
