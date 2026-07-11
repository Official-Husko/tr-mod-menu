using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CrystalInteractable : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[CompilerGenerated]
	private sealed class PBOMPNCHIPL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrystalInteractable _003C_003E4__this;

		public float fadeIn;

		public float wait;

		public float fadeOut;

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
		public PBOMPNCHIPL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			int num = _003C_003E1__state;
			CrystalInteractable crystalInteractable = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				crystalInteractable.litGameObject.SetActive(true);
				_003C_003E2__current = ((MonoBehaviour)crystalInteractable).StartCoroutine(crystalInteractable.PKODKJINCKJ(0f, crystalInteractable.NKOPEGJGGCA * crystalInteractable.CJJPAMLHCNG, fadeIn));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(wait);
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)crystalInteractable).StartCoroutine(crystalInteractable.PKODKJINCKJ(crystalInteractable.NKOPEGJGGCA * crystalInteractable.CJJPAMLHCNG, 0f, fadeOut));
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				crystalInteractable.litGameObject.SetActive(false);
				crystalInteractable.KHHENPNLFBN = null;
				crystalInteractable.EMKFIFAKLEH = false;
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
	private sealed class ABOKPMIGMAC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrystalInteractable _003C_003E4__this;

		public float fadeIn;

		public float wait;

		public float fadeOut;

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
		public ABOKPMIGMAC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CrystalInteractable crystalInteractable = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				crystalInteractable.litGameObject.SetActive(true);
				if ((Object)(object)crystalInteractable.KFCJHPAJKAI != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(crystalInteractable.KFCJHPAJKAI, ((Component)crystalInteractable).transform.position);
				}
				_003C_003E2__current = ((MonoBehaviour)crystalInteractable).StartCoroutine(crystalInteractable.PKODKJINCKJ(0f, crystalInteractable.NKOPEGJGGCA, fadeIn));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(wait);
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)crystalInteractable).StartCoroutine(crystalInteractable.PKODKJINCKJ(crystalInteractable.NKOPEGJGGCA, 0f, fadeOut));
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				crystalInteractable.litGameObject.SetActive(false);
				crystalInteractable.KHHENPNLFBN = null;
				crystalInteractable.EMKFIFAKLEH = false;
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
	private sealed class HMPIBOFKEKC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CrystalInteractable _003C_003E4__this;

		public float fadeIn;

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
		public HMPIBOFKEKC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CrystalInteractable crystalInteractable = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				crystalInteractable.litGameObject.SetActive(true);
				if ((Object)(object)crystalInteractable.KFCJHPAJKAI != (Object)null)
				{
					MultiAudioManager.PlayAudioObject(crystalInteractable.KFCJHPAJKAI, ((Component)crystalInteractable).transform.position);
				}
				_003C_003E2__current = ((MonoBehaviour)crystalInteractable).StartCoroutine(crystalInteractable.PKODKJINCKJ(0f, crystalInteractable.NKOPEGJGGCA, fadeIn));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				crystalInteractable.KHHENPNLFBN = null;
				crystalInteractable.EMKFIFAKLEH = false;
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

	public int crystalID;

	public bool debugLog;

	[Header("References")]
	[SerializeField]
	private GameObject litGameObject;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Light2D light2D;

	[Header("Interaction")]
	[SerializeField]
	private string interactLabel = "Interact";

	private CrystalPuzzle HMPOKPFMMCG;

	private AudioObject KFCJHPAJKAI;

	private float NKOPEGJGGCA;

	private float CJJPAMLHCNG;

	private Coroutine KHHENPNLFBN;

	private Color LDENFDNIKPI = Color.white;

	private bool EMKFIFAKLEH;

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		if ((Object)(object)HMPOKPFMMCG != (Object)null && !EMKFIFAKLEH && !HMPOKPFMMCG.MDPKONCJHBI() && !HMPOKPFMMCG.MKFKOEJOPDL())
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM();
		}
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void Setup(CrystalPuzzle LEPBKMGGIEI, int NFHJBHBACEM, AudioObject EPNIKNNCCHL)
	{
		HMPOKPFMMCG = LEPBKMGGIEI;
		KFCJHPAJKAI = EPNIKNNCCHL;
		crystalID = NFHJBHBACEM;
		SetInstant(DJABCEIDKBD: false);
		Debug.Log((object)("Setup " + ((Object)this).name));
	}

	private IEnumerator PKODKJINCKJ(float GAHPABJLNIG, float ECKALKKBIDF, float OMHCOLMFGNJ)
	{
		if (OMHCOLMFGNJ <= 0f)
		{
			LHDOLFCMAPP(ECKALKKBIDF);
			yield break;
		}
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			elapsed += Time.deltaTime;
			LHDOLFCMAPP(Mathf.Lerp(GAHPABJLNIG, ECKALKKBIDF, Mathf.Clamp01(elapsed / OMHCOLMFGNJ)));
			yield return null;
		}
		LHDOLFCMAPP(ECKALKKBIDF);
	}

	public void StartBlink(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB, float ECKKCNBHOCG)
	{
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
		}
		KHHENPNLFBN = ((MonoBehaviour)this).StartCoroutine(OAIEIFHMCJA(FJEIAKMNOLG, DDPOGFLFIAI, HPNPAKJCDAB));
		EMKFIFAKLEH = true;
		CJJPAMLHCNG = ECKKCNBHOCG;
	}

	private void IEFGMPLLBAB(float JLLOJEPJLKM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		light2D.intensity = JLLOJEPJLKM;
		if (debugLog)
		{
			Debug.Log((object)string.Format("Error_CloseMenus", ((Object)this).name, light2D.intensity));
		}
		LDENFDNIKPI.a = ((NKOPEGJGGCA > 1883f) ? (JLLOJEPJLKM / NKOPEGJGGCA) : 1944f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public void FEAMOEKDHEM(bool DJABCEIDKBD)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
			KHHENPNLFBN = null;
			EMKFIFAKLEH = false;
		}
		litGameObject.SetActive(DJABCEIDKBD);
		light2D.intensity = (DJABCEIDKBD ? NKOPEGJGGCA : 757f);
		LDENFDNIKPI.a = (DJABCEIDKBD ? 1005f : 934f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(interactLabel));
		return true;
	}

	private IEnumerator IOCHAOAJMCC(float FJEIAKMNOLG)
	{
		return new HMPIBOFKEKC(1)
		{
			_003C_003E4__this = this,
			fadeIn = FJEIAKMNOLG
		};
	}

	public void DMNANGPINPJ(bool DJABCEIDKBD)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
			KHHENPNLFBN = null;
			EMKFIFAKLEH = true;
		}
		litGameObject.SetActive(DJABCEIDKBD);
		light2D.intensity = (DJABCEIDKBD ? NKOPEGJGGCA : 1002f);
		LDENFDNIKPI.a = (DJABCEIDKBD ? 651f : 58f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public void PlayCorrect(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
		}
		KHHENPNLFBN = ((MonoBehaviour)this).StartCoroutine(LPDHNOBCGFH(FJEIAKMNOLG, DDPOGFLFIAI, HPNPAKJCDAB));
		EMKFIFAKLEH = true;
	}

	public bool ONLBODAGFEP(int JIIGOACEIKL)
	{
		if (!CFGOGPBMEKL(JIIGOACEIKL))
		{
			return true;
		}
		HMPOKPFMMCG.GGACJFAOMDF(crystalID, JIIGOACEIKL, CDPAMNIPPEC: false);
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)HMPOKPFMMCG != (Object)null && !EMKFIFAKLEH && !HMPOKPFMMCG.IsPuzzleSolved() && !HMPOKPFMMCG.DLHDOAMAECI)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private IEnumerator OJEIPDIJCKG(float FJEIAKMNOLG)
	{
		litGameObject.SetActive(true);
		if ((Object)(object)KFCJHPAJKAI != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(KFCJHPAJKAI, ((Component)this).transform.position);
		}
		yield return ((MonoBehaviour)this).StartCoroutine(PKODKJINCKJ(0f, NKOPEGJGGCA, FJEIAKMNOLG));
		KHHENPNLFBN = null;
		EMKFIFAKLEH = false;
	}

	public void SetInstant(bool DJABCEIDKBD)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
			KHHENPNLFBN = null;
			EMKFIFAKLEH = false;
		}
		litGameObject.SetActive(DJABCEIDKBD);
		light2D.intensity = (DJABCEIDKBD ? NKOPEGJGGCA : 0f);
		LDENFDNIKPI.a = (DJABCEIDKBD ? 1f : 0f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	private void LHDOLFCMAPP(float JLLOJEPJLKM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		light2D.intensity = JLLOJEPJLKM;
		if (debugLog)
		{
			Debug.Log((object)$"[ApplyLightValues] Cristal: {((Object)this).name} Intensidad: {light2D.intensity}");
		}
		LDENFDNIKPI.a = ((NKOPEGJGGCA > 0f) ? (JLLOJEPJLKM / NKOPEGJGGCA) : 0f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public bool FBODGFKDBCD(int JIIGOACEIKL)
	{
		HMPOKPFMMCG.JDOLILMHAKK(crystalID, JIIGOACEIKL, CDPAMNIPPEC: false);
		return false;
	}

	private void PKMIBLDMIGE(float JLLOJEPJLKM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		light2D.intensity = JLLOJEPJLKM;
		if (debugLog)
		{
			Debug.Log((object)string.Format("Items/item_description_1054", ((Object)this).name, light2D.intensity));
		}
		LDENFDNIKPI.a = ((NKOPEGJGGCA > 491f) ? (JLLOJEPJLKM / NKOPEGJGGCA) : 1121f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public void LHNEACOGPFP(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		HMPOKPFMMCG.OnCrystalInteract(crystalID, JIIGOACEIKL, CDPAMNIPPEC: true);
		return true;
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		if (!POCJGFBIJDL(JIIGOACEIKL))
		{
			return true;
		}
		HMPOKPFMMCG.OEPBJLPNJCC(crystalID, JIIGOACEIKL, CDPAMNIPPEC: true);
		return true;
	}

	private IEnumerator CGJNECAGJMN(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		return new PBOMPNCHIPL(1)
		{
			_003C_003E4__this = this,
			fadeIn = FJEIAKMNOLG,
			wait = DDPOGFLFIAI,
			fadeOut = HPNPAKJCDAB
		};
	}

	private void DENPMJIKCEN(float JLLOJEPJLKM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		light2D.intensity = JLLOJEPJLKM;
		if (debugLog)
		{
			Debug.Log((object)string.Format(" </mark>", ((Object)this).name, light2D.intensity));
		}
		LDENFDNIKPI.a = ((NKOPEGJGGCA > 1339f) ? (JLLOJEPJLKM / NKOPEGJGGCA) : 1325f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		if ((Object)(object)HMPOKPFMMCG != (Object)null && !EMKFIFAKLEH && !HMPOKPFMMCG.IsPuzzleSolved() && !HMPOKPFMMCG.FLOFFIHLJAM())
		{
			return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return false;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public void JPOHNODCFJG(bool DJABCEIDKBD)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
			KHHENPNLFBN = null;
			EMKFIFAKLEH = false;
		}
		litGameObject.SetActive(DJABCEIDKBD);
		light2D.intensity = (DJABCEIDKBD ? NKOPEGJGGCA : 96f);
		LDENFDNIKPI.a = (DJABCEIDKBD ? 530f : 1988f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		if (!POCJGFBIJDL(JIIGOACEIKL))
		{
			return false;
		}
		HMPOKPFMMCG.OEPBJLPNJCC(crystalID, JIIGOACEIKL, CDPAMNIPPEC: true);
		return true;
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		if ((Object)(object)HMPOKPFMMCG != (Object)null && !EMKFIFAKLEH && !HMPOKPFMMCG.HGBOPAKJNHJ() && !HMPOKPFMMCG.AMDGDOJNHBI())
		{
			return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	private IEnumerator LPDHNOBCGFH(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		litGameObject.SetActive(true);
		if ((Object)(object)KFCJHPAJKAI != (Object)null)
		{
			MultiAudioManager.PlayAudioObject(KFCJHPAJKAI, ((Component)this).transform.position);
		}
		yield return ((MonoBehaviour)this).StartCoroutine(PKODKJINCKJ(0f, NKOPEGJGGCA, FJEIAKMNOLG));
		yield return (object)new WaitForSeconds(DDPOGFLFIAI);
		yield return ((MonoBehaviour)this).StartCoroutine(PKODKJINCKJ(NKOPEGJGGCA, 0f, HPNPAKJCDAB));
		litGameObject.SetActive(false);
		KHHENPNLFBN = null;
		EMKFIFAKLEH = false;
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	public void OIGABDHAHDM(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
		}
		KHHENPNLFBN = ((MonoBehaviour)this).StartCoroutine(LPDHNOBCGFH(FJEIAKMNOLG, DDPOGFLFIAI, HPNPAKJCDAB));
		EMKFIFAKLEH = false;
	}

	public bool CODLFHDKMHC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!CFGOGPBMEKL(JIIGOACEIKL))
		{
			return false;
		}
		ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return true;
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	public void LGOPNIBHMIA(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void GJMBIMPIIFN(float JLLOJEPJLKM)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		light2D.intensity = JLLOJEPJLKM;
		if (debugLog)
		{
			Debug.Log((object)string.Format("BuzzCanBuild", ((Object)this).name, light2D.intensity));
		}
		LDENFDNIKPI.a = ((NKOPEGJGGCA > 555f) ? (JLLOJEPJLKM / NKOPEGJGGCA) : 334f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void DMOOKIFAIKD(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
		}
		KHHENPNLFBN = ((MonoBehaviour)this).StartCoroutine(LPDHNOBCGFH(FJEIAKMNOLG, DDPOGFLFIAI, HPNPAKJCDAB));
		EMKFIFAKLEH = true;
	}

	public void IGJPFBMGJJM(CrystalPuzzle LEPBKMGGIEI, int NFHJBHBACEM, AudioObject EPNIKNNCCHL)
	{
		HMPOKPFMMCG = LEPBKMGGIEI;
		KFCJHPAJKAI = EPNIKNNCCHL;
		crystalID = NFHJBHBACEM;
		JPOHNODCFJG(DJABCEIDKBD: false);
		Debug.Log((object)("bed instance not assigned" + ((Object)this).name));
	}

	public void PlaySolved(float FJEIAKMNOLG)
	{
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
		}
		KHHENPNLFBN = ((MonoBehaviour)this).StartCoroutine(OJEIPDIJCKG(FJEIAKMNOLG));
		EMKFIFAKLEH = true;
	}

	public bool OOJPCIDDGCN(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		HMPOKPFMMCG.LHNPAHBJBLF(crystalID, JIIGOACEIKL, CDPAMNIPPEC: true);
		return false;
	}

	private void Awake()
	{
		NKOPEGJGGCA = light2D.intensity;
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!FPMFDKMLCML(JIIGOACEIKL))
		{
			return true;
		}
		ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(interactLabel));
		return false;
	}

	public void LJLHGJDHFOJ(int JIIGOACEIKL)
	{
	}

	private IEnumerator OCBNFMKJNHD(float FJEIAKMNOLG)
	{
		return new HMPIBOFKEKC(1)
		{
			_003C_003E4__this = this,
			fadeIn = FJEIAKMNOLG
		};
	}

	public void IHIIIPGGPPF(int JIIGOACEIKL)
	{
	}

	public void CDKKPGEJGEG(float FJEIAKMNOLG)
	{
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
		}
		KHHENPNLFBN = ((MonoBehaviour)this).StartCoroutine(OCBNFMKJNHD(FJEIAKMNOLG));
		EMKFIFAKLEH = false;
	}

	private IEnumerator OAIEIFHMCJA(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		litGameObject.SetActive(true);
		yield return ((MonoBehaviour)this).StartCoroutine(PKODKJINCKJ(0f, NKOPEGJGGCA * CJJPAMLHCNG, FJEIAKMNOLG));
		yield return (object)new WaitForSeconds(DDPOGFLFIAI);
		yield return ((MonoBehaviour)this).StartCoroutine(PKODKJINCKJ(NKOPEGJGGCA * CJJPAMLHCNG, 0f, HPNPAKJCDAB));
		litGameObject.SetActive(false);
		KHHENPNLFBN = null;
		EMKFIFAKLEH = false;
	}

	private IEnumerator LIPJEGPGHNH(float FJEIAKMNOLG, float DDPOGFLFIAI, float HPNPAKJCDAB)
	{
		return new ABOKPMIGMAC(1)
		{
			_003C_003E4__this = this,
			fadeIn = FJEIAKMNOLG,
			wait = DDPOGFLFIAI,
			fadeOut = HPNPAKJCDAB
		};
	}

	private void MMNBJPDJHGK()
	{
		NKOPEGJGGCA = light2D.intensity;
	}

	public void ALBFHHKJIIO(bool DJABCEIDKBD)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (KHHENPNLFBN != null)
		{
			((MonoBehaviour)this).StopCoroutine(KHHENPNLFBN);
			KHHENPNLFBN = null;
			EMKFIFAKLEH = true;
		}
		litGameObject.SetActive(DJABCEIDKBD);
		light2D.intensity = (DJABCEIDKBD ? NKOPEGJGGCA : 1784f);
		LDENFDNIKPI.a = (DJABCEIDKBD ? 834f : 1499f);
		spriteRenderer.color = LDENFDNIKPI;
	}

	public bool LJCNIPCGOGN(int JIIGOACEIKL)
	{
		HMPOKPFMMCG.PEMJAMGDGCB(crystalID, JIIGOACEIKL, CDPAMNIPPEC: true);
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		HMPOKPFMMCG.OnCrystalInteract(crystalID, JIIGOACEIKL, CDPAMNIPPEC: false);
		return true;
	}
}
