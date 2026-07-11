using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PipeTileUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IHDHBJNGADG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PipeTileUI _003C_003E4__this;

		public float duration;

		public float targetAmount;

		private float _003Celapsed_003E5__2;

		private bool _003CrequiredTriggered_003E5__3;

		private Image _003CrequiredConnectedImage_003E5__4;

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
		public IHDHBJNGADG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			PipeTileUI pipeTileUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				_003Celapsed_003E5__2 = 0f;
				pipeTileUI.connectedImage.fillAmount = 0f;
				_003CrequiredTriggered_003E5__3 = false;
				GameObject requiredConnectedSprite = pipeTileUI.requiredConnectedSprite;
				_003CrequiredConnectedImage_003E5__4 = ((requiredConnectedSprite != null) ? requiredConnectedSprite.GetComponent<Image>() : null);
				if ((Object)(object)_003CrequiredConnectedImage_003E5__4 != (Object)null)
				{
					Color color = ((Graphic)_003CrequiredConnectedImage_003E5__4).color;
					((Graphic)_003CrequiredConnectedImage_003E5__4).color = new Color(color.r, color.g, color.b, 0f);
					pipeTileUI.requiredConnectedSprite.SetActive(pipeTileUI.PNLMFFAJFPE);
				}
				break;
			}
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Celapsed_003E5__2 < duration)
			{
				_003Celapsed_003E5__2 += Time.deltaTime;
				float num2 = Mathf.Clamp01(_003Celapsed_003E5__2 / duration) * targetAmount;
				pipeTileUI.connectedImage.fillAmount = num2;
				if (pipeTileUI.PNLMFFAJFPE && !_003CrequiredTriggered_003E5__3 && num2 >= 0.5f)
				{
					_003CrequiredTriggered_003E5__3 = true;
					((MonoBehaviour)pipeTileUI).StartCoroutine(pipeTileUI.NCIEDDNBADP(_003CrequiredConnectedImage_003E5__4));
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			pipeTileUI.connectedImage.fillAmount = targetAmount;
			pipeTileUI.JLHEJIADLAJ = null;
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

	[SerializeField]
	private GameObject normalSprite;

	[SerializeField]
	private GameObject selectedSprite;

	[SerializeField]
	private GameObject connectedSprite;

	[SerializeField]
	private Image connectedImage;

	[SerializeField]
	private GameObject requiredSprite;

	[SerializeField]
	private GameObject requiredSelectedSprite;

	[SerializeField]
	private GameObject requiredConnectedSprite;

	[SerializeField]
	private GameObject focusOverlay;

	[SerializeField]
	private Image remotePlayerFrame;

	[SerializeField]
	private GameObject playerNumberContainer;

	[SerializeField]
	private GameObject player1Slot;

	[SerializeField]
	private GameObject player2Slot;

	[SerializeField]
	private GameObject player3Slot;

	[SerializeField]
	private GameObject player4Slot;

	[SerializeField]
	private Color[] playerColors = (Color[])(object)new Color[4]
	{
		new Color(0.2f, 0.5f, 1f),
		new Color(1f, 0.2f, 0.2f),
		new Color(0.2f, 0.1f, 0.2f),
		new Color(0.7f, 0.2f, 1f)
	};

	[SerializeField]
	private UIButtonExtended button;

	public Action<PipeTileUI> OnClicked;

	private bool MNOMOMKHIEI;

	private bool KFCCGIDHDBH;

	private Image JPFPLILLCDB;

	private Coroutine JLHEJIADLAJ;

	public PipeTileInstance OKGNNPBNAII { get; private set; }

	public PipeTile OOHDCMGFHKC => OKGNNPBNAII?.tile;

	public int BOJDFIMJAEL { get; private set; }

	public bool DLBGODNJNMO
	{
		get
		{
			if ((Object)(object)OOHDCMGFHKC != (Object)null)
			{
				return OOHDCMGFHKC.isEntryExit;
			}
			return false;
		}
	}

	public bool PNLMFFAJFPE
	{
		get
		{
			if (OKGNNPBNAII != null)
			{
				return OKGNNPBNAII.isRequired;
			}
			return false;
		}
	}

	public bool JAMHNPDHLMC { get; private set; }

	[SpecialName]
	public bool OFBBDFJNGKF()
	{
		if ((Object)(object)FFBBNAKPMNH() != (Object)null)
		{
			return PFGBAKKGCAF().isEntryExit;
		}
		return true;
	}

	[SpecialName]
	public bool ODDFDKLNKOJ()
	{
		return _003CLMPBLLDEICJ_003Ek__BackingField;
	}

	private void LCIMGFLGNGI()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(true);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(PNLMFFAJFPE);
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(PNLMFFAJFPE && MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(PNLMFFAJFPE && KFCCGIDHDBH);
		}
	}

	[SpecialName]
	private void GFLJOBHHEPE(PipeTileInstance AODONKKHPBP)
	{
		_003CBIAICHGNINJ_003Ek__BackingField = AODONKKHPBP;
	}

	public void SetSelected(bool HGNKFFMDOOL)
	{
		MNOMOMKHIEI = HGNKFFMDOOL;
		LCIMGFLGNGI();
	}

	private IEnumerator OMOOAPLNBCB(float BKBGMIEEDAH, float OMHCOLMFGNJ)
	{
		float elapsed = 0f;
		connectedImage.fillAmount = 0f;
		bool requiredTriggered = false;
		GameObject obj = requiredConnectedSprite;
		Image requiredConnectedImage = ((obj != null) ? obj.GetComponent<Image>() : null);
		if ((Object)(object)requiredConnectedImage != (Object)null)
		{
			Color color = ((Graphic)requiredConnectedImage).color;
			((Graphic)requiredConnectedImage).color = new Color(color.r, color.g, color.b, 0f);
			requiredConnectedSprite.SetActive(PNLMFFAJFPE);
		}
		while (elapsed < OMHCOLMFGNJ)
		{
			elapsed += Time.deltaTime;
			float num = Mathf.Clamp01(elapsed / OMHCOLMFGNJ) * BKBGMIEEDAH;
			connectedImage.fillAmount = num;
			if (PNLMFFAJFPE && !requiredTriggered && num >= 0.5f)
			{
				requiredTriggered = true;
				((MonoBehaviour)this).StartCoroutine(NCIEDDNBADP(requiredConnectedImage));
			}
			yield return null;
		}
		connectedImage.fillAmount = BKBGMIEEDAH;
		JLHEJIADLAJ = null;
	}

	public void FDPBANICFPL(int AHPKABJDOIH)
	{
		KIPPMICOBOG(AHPKABJDOIH);
	}

	private void NPCMMFIMCKE()
	{
		OnClicked?.Invoke(this);
	}

	private IEnumerator AOMPGINLIMH(float BKBGMIEEDAH, float OMHCOLMFGNJ)
	{
		float elapsed = 0f;
		connectedImage.fillAmount = 0f;
		bool requiredTriggered = false;
		GameObject obj = requiredConnectedSprite;
		Image requiredConnectedImage = ((obj != null) ? obj.GetComponent<Image>() : null);
		if ((Object)(object)requiredConnectedImage != (Object)null)
		{
			Color color = ((Graphic)requiredConnectedImage).color;
			((Graphic)requiredConnectedImage).color = new Color(color.r, color.g, color.b, 0f);
			requiredConnectedSprite.SetActive(PNLMFFAJFPE);
		}
		while (elapsed < OMHCOLMFGNJ)
		{
			elapsed += Time.deltaTime;
			float num = Mathf.Clamp01(elapsed / OMHCOLMFGNJ) * BKBGMIEEDAH;
			connectedImage.fillAmount = num;
			if (PNLMFFAJFPE && !requiredTriggered && num >= 0.5f)
			{
				requiredTriggered = true;
				((MonoBehaviour)this).StartCoroutine(NCIEDDNBADP(requiredConnectedImage));
			}
			yield return null;
		}
		connectedImage.fillAmount = BKBGMIEEDAH;
		JLHEJIADLAJ = null;
	}

	private void MFJIHCKEIIF()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).AddListener(new UnityAction(LFDKADFDEFP));
	}

	[SpecialName]
	private void HEHJHCNBJCO(bool AODONKKHPBP)
	{
		_003CLMPBLLDEICJ_003Ek__BackingField = AODONKKHPBP;
	}

	private IEnumerator FFNNEPADGIN(float BKBGMIEEDAH, float OMHCOLMFGNJ)
	{
		float elapsed = 0f;
		connectedImage.fillAmount = 0f;
		bool requiredTriggered = false;
		GameObject obj = requiredConnectedSprite;
		Image requiredConnectedImage = ((obj != null) ? obj.GetComponent<Image>() : null);
		if ((Object)(object)requiredConnectedImage != (Object)null)
		{
			Color color = ((Graphic)requiredConnectedImage).color;
			((Graphic)requiredConnectedImage).color = new Color(color.r, color.g, color.b, 0f);
			requiredConnectedSprite.SetActive(PNLMFFAJFPE);
		}
		while (elapsed < OMHCOLMFGNJ)
		{
			elapsed += Time.deltaTime;
			float num = Mathf.Clamp01(elapsed / OMHCOLMFGNJ) * BKBGMIEEDAH;
			connectedImage.fillAmount = num;
			if (PNLMFFAJFPE && !requiredTriggered && num >= 0.5f)
			{
				requiredTriggered = true;
				((MonoBehaviour)this).StartCoroutine(NCIEDDNBADP(requiredConnectedImage));
			}
			yield return null;
		}
		connectedImage.fillAmount = BKBGMIEEDAH;
		JLHEJIADLAJ = null;
	}

	public void CJFFNBEIDOL()
	{
		FNMMHBGJBNG(HGNKFFMDOOL: true);
	}

	[SpecialName]
	public PipeTileInstance CNFLJAKOIEN()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	public void IBEONPHHOLJ(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(true);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(false);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(false);
		}
		int num = LNMFMHABHAN[0];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 0, playerColors.Length - 0);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(0));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[0];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[1];
			player2Slot.SetActive(LNMFMHABHAN.Contains(1));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[0];
			player3Slot.SetActive(LNMFMHABHAN.Contains(7));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[5];
			player4Slot.SetActive(LNMFMHABHAN.Contains(7));
		}
	}

	public void IHJDNMDCBNJ(int AHPKABJDOIH)
	{
		KIPPMICOBOG(AHPKABJDOIH);
	}

	public void SetConnected(bool JANJLEGLAMF, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		KFCCGIDHDBH = JANJLEGLAMF;
		LCIMGFLGNGI();
		if (JLHEJIADLAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(JLHEJIADLAJ);
		}
		if (!((Object)(object)connectedImage != (Object)null))
		{
			return;
		}
		if (JANJLEGLAMF)
		{
			if (HMIFJFNHLOA)
			{
				connectedImage.fillAmount = 0f;
				JLHEJIADLAJ = ((MonoBehaviour)this).StartCoroutine(FFNNEPADGIN(1f, PGHEEDJMDIM));
				return;
			}
			connectedImage.fillAmount = 1f;
			GameObject obj = requiredConnectedSprite;
			Image val = ((obj != null) ? obj.GetComponent<Image>() : null);
			if ((Object)(object)val != (Object)null)
			{
				Color color = ((Graphic)val).color;
				((Graphic)val).color = new Color(color.r, color.g, color.b, 1f);
			}
		}
		else
		{
			connectedImage.fillAmount = 0f;
			GameObject obj2 = requiredConnectedSprite;
			Image val2 = ((obj2 != null) ? obj2.GetComponent<Image>() : null);
			if ((Object)(object)val2 != (Object)null)
			{
				Color color2 = ((Graphic)val2).color;
				((Graphic)val2).color = new Color(color2.r, color2.g, color2.b, 0f);
			}
		}
	}

	[SpecialName]
	public bool HJJCOCONIMC()
	{
		if (IOBHNOECEOI() != null)
		{
			return MONLAOEMOCL().isRequired;
		}
		return true;
	}

	public void LDFOCPGLOIA(bool EHOFFFMFILA)
	{
		GameObject obj = focusOverlay;
		if (obj != null)
		{
			obj.SetActive(EHOFFFMFILA);
		}
	}

	public void GMGHKFNFDLE()
	{
		NKKOCFNDGKN(HGNKFFMDOOL: false);
	}

	public void EHALGJFEDBI(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(true);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(false);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(false);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(false);
		}
		int num = LNMFMHABHAN[1];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 0, playerColors.Length - 0);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[1];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[0];
			player2Slot.SetActive(LNMFMHABHAN.Contains(3));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[2];
			player3Slot.SetActive(LNMFMHABHAN.Contains(6));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[4];
			player4Slot.SetActive(LNMFMHABHAN.Contains(1));
		}
	}

	private void EOIFDDAADKJ(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)OOHDCMGFHKC == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.North;
		PipeExits[] array = new PipeExits[6];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			PipeExits pipeExits = array2[i];
			if (pipeExits != FGGEIDEHAAB && PFGBAKKGCAF().EEBIAOHBNHE(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		PIBACJNHPJP(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	[SpecialName]
	public PipeTileInstance IOBHNOECEOI()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	[SpecialName]
	public bool EIEAKOGGLMK()
	{
		if ((Object)(object)FFBBNAKPMNH() != (Object)null)
		{
			return OOHDCMGFHKC.isEntryExit;
		}
		return true;
	}

	[SpecialName]
	public bool GPJLPLOLDNI()
	{
		if ((Object)(object)JIKPFEEEHPG() != (Object)null)
		{
			return JIKPFEEEHPG().isEntryExit;
		}
		return false;
	}

	private void CLGBFOIBANN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).AddListener(new UnityAction(LFNHIMNKFCM));
	}

	private IEnumerator NCIEDDNBADP(Image IBFBOBBOLOK)
	{
		if (!((Object)(object)IBFBOBBOLOK == (Object)null))
		{
			float elapsed = 0f;
			float duration = 0.1f;
			Color c = ((Graphic)IBFBOBBOLOK).color;
			while (elapsed < duration)
			{
				elapsed += Time.deltaTime;
				((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, Mathf.Clamp01(elapsed / duration));
				yield return null;
			}
			((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, 1f);
		}
	}

	[SpecialName]
	private void KBPAIBHIKFN(PipeTileInstance AODONKKHPBP)
	{
		_003CBIAICHGNINJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool PJJNAAEJBHM()
	{
		if ((Object)(object)FFBBNAKPMNH() != (Object)null)
		{
			return OOHDCMGFHKC.isEntryExit;
		}
		return true;
	}

	[SpecialName]
	public bool GHMALKGNDIN()
	{
		if ((Object)(object)FFBBNAKPMNH() != (Object)null)
		{
			return PFGBAKKGCAF().isEntryExit;
		}
		return true;
	}

	private bool EDOIJOEPFCO(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == (PipeExits.North | PipeExits.South))
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.South) && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South))
		{
			_ = 2;
			return true;
		}
		return true;
	}

	[SpecialName]
	public PipeTileInstance FEHIJJLBMII()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	private void BFCCOKPCFKH(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)PFGBAKKGCAF() == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.None;
		PipeExits[] array = new PipeExits[1] { PipeExits.North };
		for (int i = 0; i < array.Length; i += 0)
		{
			PipeExits pipeExits = array[i];
			if (pipeExits != FGGEIDEHAAB && JIKPFEEEHPG().HGMDAHIMIDF(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		HOMHGPDOPIP(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	private IEnumerator FOCDEHHIPGA(Image IBFBOBBOLOK)
	{
		if (!((Object)(object)IBFBOBBOLOK == (Object)null))
		{
			float elapsed = 0f;
			float duration = 0.1f;
			Color c = ((Graphic)IBFBOBBOLOK).color;
			while (elapsed < duration)
			{
				elapsed += Time.deltaTime;
				((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, Mathf.Clamp01(elapsed / duration));
				yield return null;
			}
			((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, 1f);
		}
	}

	[SpecialName]
	private void KIPPMICOBOG(int AODONKKHPBP)
	{
		_003CBECCGNIGBGB_003Ek__BackingField = AODONKKHPBP;
	}

	public void IEIEAOBNFOL(bool EHOFFFMFILA)
	{
		GameObject obj = focusOverlay;
		if (obj != null)
		{
			obj.SetActive(EHOFFFMFILA);
		}
	}

	public void FENELJCPNNL()
	{
		FNMMHBGJBNG(HGNKFFMDOOL: false);
	}

	private int JIBDPICIOFI(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.South) || (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.North))
		{
			return 1;
		}
		if ((CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == PipeExits.East) || (CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == PipeExits.North))
		{
			return 0;
		}
		if ((CBNBHOHFKMF == (PipeExits.North | PipeExits.East) && NJMCDGFPCAG == (PipeExits.North | PipeExits.East)) || (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.None))
		{
			return 8;
		}
		if (CBNBHOHFKMF != PipeExits.South || NJMCDGFPCAG != (PipeExits.North | PipeExits.East))
		{
			if (CBNBHOHFKMF != PipeExits.North)
			{
				return 0;
			}
			_ = 3;
		}
		return 0;
	}

	private IEnumerator LFOJJEEIFFN(Image IBFBOBBOLOK)
	{
		if (!((Object)(object)IBFBOBBOLOK == (Object)null))
		{
			float elapsed = 0f;
			float duration = 0.1f;
			Color c = ((Graphic)IBFBOBBOLOK).color;
			while (elapsed < duration)
			{
				elapsed += Time.deltaTime;
				((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, Mathf.Clamp01(elapsed / duration));
				yield return null;
			}
			((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, 1f);
		}
	}

	private void NKPBGLKIMAO(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)PFGBAKKGCAF() == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.North;
		PipeExits[] array = new PipeExits[1] { PipeExits.North };
		for (int i = 1; i < array.Length; i++)
		{
			PipeExits pipeExits = array[i];
			if (pipeExits != FGGEIDEHAAB && JIKPFEEEHPG().GOHFGECGJPL(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		DKAFHDPDLPP(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	private void OPJPOIDAJAI(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF == PipeExits.North || CBNBHOHFKMF == PipeExits.South) && (NJMCDGFPCAG == PipeExits.North || NJMCDGFPCAG == PipeExits.South);
			bool flag = (CBNBHOHFKMF == PipeExits.East || CBNBHOHFKMF == PipeExits.West) && (NJMCDGFPCAG == PipeExits.East || NJMCDGFPCAG == PipeExits.West);
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.North) ? 1 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.East) ? 1 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)2;
				connectedImage.fillOrigin = KEFEFLBAEHG(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = ELAENHAKHIC(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	[SpecialName]
	private void CNECPHHCAAP(bool AODONKKHPBP)
	{
		_003CLMPBLLDEICJ_003Ek__BackingField = AODONKKHPBP;
	}

	private void JCJMFNHCBPN(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)OOHDCMGFHKC == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.North;
		PipeExits[] array = new PipeExits[6];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			PipeExits pipeExits = array2[i];
			if (pipeExits != FGGEIDEHAAB && FFBBNAKPMNH().MFGEAECGHJG(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		FNPIDPLDBEE(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	private void DKAFHDPDLPP(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF == PipeExits.North || CBNBHOHFKMF == PipeExits.South) && NJMCDGFPCAG != 0 && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South);
			bool flag = (CBNBHOHFKMF != (PipeExits.North | PipeExits.East) && CBNBHOHFKMF != (PipeExits.North | PipeExits.East | PipeExits.South)) || (NJMCDGFPCAG != PipeExits.East && NJMCDGFPCAG == PipeExits.North);
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.None) ? 1 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == (PipeExits.East | PipeExits.South)) ? 1 : 1);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)3;
				connectedImage.fillOrigin = BCPNDPMIHPG(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = ABHGDLGFMIL(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	private void BMCGENPAFCL()
	{
		OnClicked?.Invoke(this);
	}

	public void LKEJOFEECPK()
	{
		ECLFINHNGJO(HGNKFFMDOOL: false);
	}

	private void PPBBBADDNAC()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).RemoveListener(new UnityAction(LFNHIMNKFCM));
	}

	public void EFKNMEIBGBN(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(true);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(false);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(false);
		}
		int num = LNMFMHABHAN[0];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 1, playerColors.Length - 1);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[1];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[0];
			player2Slot.SetActive(LNMFMHABHAN.Contains(7));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[4];
			player3Slot.SetActive(LNMFMHABHAN.Contains(1));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[7];
			player4Slot.SetActive(LNMFMHABHAN.Contains(4));
		}
	}

	[SpecialName]
	private void IFHCBOBKLNC(int AODONKKHPBP)
	{
		_003CBECCGNIGBGB_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public int NPDGIDPAPPO()
	{
		return _003CBECCGNIGBGB_003Ek__BackingField;
	}

	public void NKLHEOPPMJH(bool JANJLEGLAMF, PipeExits FGGEIDEHAAB, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		if (JANJLEGLAMF && (Object)(object)connectedImage != (Object)null)
		{
			DOKKGAPLLJB(FGGEIDEHAAB);
		}
		MGENCLOKOGM(JANJLEGLAMF, HMIFJFNHLOA, PGHEEDJMDIM);
	}

	private IEnumerator BNCBOCAAPLD(float BKBGMIEEDAH, float OMHCOLMFGNJ)
	{
		return new IHDHBJNGADG(1)
		{
			_003C_003E4__this = this,
			targetAmount = BKBGMIEEDAH,
			duration = OMHCOLMFGNJ
		};
	}

	private bool NBJNBIODMPC(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.South)
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.None)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South))
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.None)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.East) && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == (PipeExits.North | PipeExits.East))
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.North)
		{
			_ = 7;
			return false;
		}
		return false;
	}

	public void BNKLBHIEHHA(bool JANJLEGLAMF, PipeExits FGGEIDEHAAB, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		if (JANJLEGLAMF && (Object)(object)connectedImage != (Object)null)
		{
			JNHCAFABACI(FGGEIDEHAAB);
		}
		AMMMPCBDOMC(JANJLEGLAMF, HMIFJFNHLOA, PGHEEDJMDIM);
	}

	private void GHKECOHODJJ()
	{
		OnClicked?.Invoke(this);
	}

	private int KEFEFLBAEHG(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.East) || (CBNBHOHFKMF == PipeExits.East && NJMCDGFPCAG == PipeExits.North))
		{
			return 2;
		}
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.West) || (CBNBHOHFKMF == PipeExits.West && NJMCDGFPCAG == PipeExits.North))
		{
			return 1;
		}
		if ((CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.East) || (CBNBHOHFKMF == PipeExits.East && NJMCDGFPCAG == PipeExits.South))
		{
			return 3;
		}
		if (CBNBHOHFKMF != PipeExits.South || NJMCDGFPCAG != PipeExits.West)
		{
			if (CBNBHOHFKMF != PipeExits.West)
			{
				return 0;
			}
			_ = 4;
		}
		return 0;
	}

	private void LNEMAJDIFIK()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(true);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(PNLMFFAJFPE);
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(!PNLMFFAJFPE || MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(!EHLJBMIOCGE() || KFCCGIDHDBH);
		}
	}

	private void PIBACJNHPJP(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF != PipeExits.North && CBNBHOHFKMF != PipeExits.East) || (NJMCDGFPCAG != 0 && NJMCDGFPCAG == PipeExits.West);
			bool flag = (CBNBHOHFKMF != (PipeExits.North | PipeExits.East | PipeExits.South) && CBNBHOHFKMF != (PipeExits.North | PipeExits.South)) || (NJMCDGFPCAG != (PipeExits.North | PipeExits.South) && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South));
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.North) ? 1 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == (PipeExits.East | PipeExits.South)) ? 1 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)7;
				connectedImage.fillOrigin = KEFEFLBAEHG(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = NBJNBIODMPC(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	public void HGOADDNAJHF(bool EHOFFFMFILA)
	{
		GameObject obj = focusOverlay;
		if (obj != null)
		{
			obj.SetActive(EHOFFFMFILA);
		}
	}

	[SpecialName]
	public bool EHLJBMIOCGE()
	{
		if (MONLAOEMOCL() != null)
		{
			return NABAFIIEHOE().isRequired;
		}
		return true;
	}

	public void AMMMPCBDOMC(bool JANJLEGLAMF, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		KFCCGIDHDBH = JANJLEGLAMF;
		IKOFEIAHEMK();
		if (JLHEJIADLAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(JLHEJIADLAJ);
		}
		if (!((Object)(object)connectedImage != (Object)null))
		{
			return;
		}
		if (JANJLEGLAMF)
		{
			if (HMIFJFNHLOA)
			{
				connectedImage.fillAmount = 979f;
				JLHEJIADLAJ = ((MonoBehaviour)this).StartCoroutine(MEFCFGLHCHI(1300f, PGHEEDJMDIM));
				return;
			}
			connectedImage.fillAmount = 1897f;
			GameObject obj = requiredConnectedSprite;
			Image val = ((obj != null) ? obj.GetComponent<Image>() : null);
			if ((Object)(object)val != (Object)null)
			{
				Color color = ((Graphic)val).color;
				((Graphic)val).color = new Color(color.r, color.g, color.b, 293f);
			}
		}
		else
		{
			connectedImage.fillAmount = 946f;
			GameObject obj2 = requiredConnectedSprite;
			Image val2 = ((obj2 != null) ? obj2.GetComponent<Image>() : null);
			if ((Object)(object)val2 != (Object)null)
			{
				Color color2 = ((Graphic)val2).color;
				((Graphic)val2).color = new Color(color2.r, color2.g, color2.b, 1481f);
			}
		}
	}

	private IEnumerator FIPPNEKPPGI(Image IBFBOBBOLOK)
	{
		if (!((Object)(object)IBFBOBBOLOK == (Object)null))
		{
			float elapsed = 0f;
			float duration = 0.1f;
			Color c = ((Graphic)IBFBOBBOLOK).color;
			while (elapsed < duration)
			{
				elapsed += Time.deltaTime;
				((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, Mathf.Clamp01(elapsed / duration));
				yield return null;
			}
			((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, 1f);
		}
	}

	[SpecialName]
	public bool JJMMIEFKLHF()
	{
		if ((Object)(object)PFGBAKKGCAF() != (Object)null)
		{
			return PFGBAKKGCAF().isEntryExit;
		}
		return true;
	}

	[SpecialName]
	private void JJDEGIJLFHP(PipeTileInstance AODONKKHPBP)
	{
		_003CBIAICHGNINJ_003Ek__BackingField = AODONKKHPBP;
	}

	public void IMMIOCEOKNO(bool EHOFFFMFILA)
	{
		GameObject obj = focusOverlay;
		if (obj != null)
		{
			obj.SetActive(EHOFFFMFILA);
		}
	}

	private void MOMHHJDCEEI(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF != 0 && CBNBHOHFKMF != (PipeExits.North | PipeExits.East)) || (NJMCDGFPCAG != 0 && NJMCDGFPCAG == PipeExits.West);
			bool flag = (CBNBHOHFKMF != PipeExits.North && CBNBHOHFKMF != 0) || NJMCDGFPCAG == (PipeExits.North | PipeExits.East) || NJMCDGFPCAG == PipeExits.None;
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.None) ? 0 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF != PipeExits.North) ? 1 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)6;
				connectedImage.fillOrigin = JIBDPICIOFI(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = BFMOALKKJBO(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	public void MPNBLFDGBGC(int AHPKABJDOIH)
	{
		FBGIKLIHGEE(AHPKABJDOIH);
	}

	[SpecialName]
	public bool AHKFDOOEGGH()
	{
		if ((Object)(object)PFGBAKKGCAF() != (Object)null)
		{
			return FFBBNAKPMNH().isEntryExit;
		}
		return true;
	}

	[SpecialName]
	public PipeTileInstance MONLAOEMOCL()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	private void HCCGFGODPFN(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)OOHDCMGFHKC == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.None;
		PipeExits[] array = new PipeExits[7];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			PipeExits pipeExits = array2[i];
			if (pipeExits != FGGEIDEHAAB && OOHDCMGFHKC.KLANAEAIFJH(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		CLEFKPEMFOE(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	public void KKIOPNGEFNC(bool EHOFFFMFILA)
	{
		GameObject obj = focusOverlay;
		if (obj != null)
		{
			obj.SetActive(EHOFFFMFILA);
		}
	}

	public void PJANACELJFB(PipeTileInstance PKLGNHMAIKJ, int MPNFFMMGIOL, bool OOGPIKBMHFD = false)
	{
		GFLJOBHHEPE(PKLGNHMAIKJ);
		FBGIKLIHGEE(MPNFFMMGIOL);
		CNECPHHCAAP(OOGPIKBMHFD);
		MNOMOMKHIEI = true;
		KFCCGIDHDBH = true;
		((Selectable)button).interactable = (Object)(object)PKLGNHMAIKJ.tile != (Object)null && PKLGNHMAIKJ.tile.isEntryExit;
		IKOFEIAHEMK();
		IMMIOCEOKNO(EHOFFFMFILA: false);
	}

	public void JODNHJCLCGD()
	{
		FNMMHBGJBNG(HGNKFFMDOOL: true);
	}

	private void CLEFKPEMFOE(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF == PipeExits.None || CBNBHOHFKMF == (PipeExits.North | PipeExits.East)) && (NJMCDGFPCAG == PipeExits.North || NJMCDGFPCAG == PipeExits.South);
			bool flag = (CBNBHOHFKMF == PipeExits.None || CBNBHOHFKMF == PipeExits.North) && (NJMCDGFPCAG == PipeExits.East || NJMCDGFPCAG == PipeExits.South);
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF != PipeExits.North) ? 1 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.None) ? 0 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)7;
				connectedImage.fillOrigin = IGKPPKBCMNC(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = IJFLCNBLFKM(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	[SpecialName]
	public PipeTile JIKPFEEEHPG()
	{
		return MJJKNJIEDEN()?.tile;
	}

	[SpecialName]
	public PipeTileInstance NABAFIIEHOE()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	[SpecialName]
	public PipeTile PFGBAKKGCAF()
	{
		return FEHIJJLBMII()?.tile;
	}

	private bool IJFLCNBLFKM(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.None)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.South) && NJMCDGFPCAG == PipeExits.None)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.None)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == (PipeExits.East | PipeExits.South))
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.East | PipeExits.South) && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South))
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.South))
		{
			_ = 2;
			return true;
		}
		return false;
	}

	private void OnDestroy()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).RemoveListener(new UnityAction(GHKECOHODJJ));
	}

	[SpecialName]
	public PipeTileInstance MJJKNJIEDEN()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	[SpecialName]
	public bool HEGJEEFMKEH()
	{
		if (NABAFIIEHOE() != null)
		{
			return OKGNNPBNAII.isRequired;
		}
		return true;
	}

	[SpecialName]
	public bool MONFAOOFJKI()
	{
		return _003CLMPBLLDEICJ_003Ek__BackingField;
	}

	public void UpdateGridIndex(int AHPKABJDOIH)
	{
		BOJDFIMJAEL = AHPKABJDOIH;
	}

	public void DGHNFAOEHNB(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(true);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(false);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(true);
		}
		int num = LNMFMHABHAN[0];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 0, 1, playerColors.Length - 1);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[1];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[1];
			player2Slot.SetActive(LNMFMHABHAN.Contains(5));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[5];
			player3Slot.SetActive(LNMFMHABHAN.Contains(4));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[6];
			player4Slot.SetActive(LNMFMHABHAN.Contains(6));
		}
	}

	public void SetFocused(bool EHOFFFMFILA)
	{
		GameObject obj = focusOverlay;
		if (obj != null)
		{
			obj.SetActive(EHOFFFMFILA);
		}
	}

	private void CJBJKHMMCED()
	{
		OnClicked?.Invoke(this);
	}

	public void CBEDGBGCLGG(PipeTileInstance PKLGNHMAIKJ, int MPNFFMMGIOL, bool OOGPIKBMHFD = false)
	{
		AHLHEHOIKDC(PKLGNHMAIKJ);
		FBGIKLIHGEE(MPNFFMMGIOL);
		PJNCPDGCLMF(OOGPIKBMHFD);
		MNOMOMKHIEI = true;
		KFCCGIDHDBH = false;
		((Selectable)button).interactable = (Object)(object)PKLGNHMAIKJ.tile != (Object)null && PKLGNHMAIKJ.tile.isEntryExit;
		CKJLIBIJGKE();
		IEIEAOBNFOL(EHOFFFMFILA: true);
	}

	private void FCNKGINGJNM()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).AddListener(new UnityAction(CJBJKHMMCED));
	}

	[SpecialName]
	private void BIMMGFLGMNE(bool AODONKKHPBP)
	{
		_003CLMPBLLDEICJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool LLGPFOBBLCL()
	{
		if (HLBAPKIPMBG() != null)
		{
			return NABAFIIEHOE().isRequired;
		}
		return false;
	}

	[SpecialName]
	public bool OKEKNKIHIEO()
	{
		if (NABAFIIEHOE() != null)
		{
			return OKGNNPBNAII.isRequired;
		}
		return false;
	}

	public void HILMHOACBII(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(false);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(true);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(false);
		}
		int num = LNMFMHABHAN[0];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 1, playerColors.Length - 1);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[1];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[0];
			player2Slot.SetActive(LNMFMHABHAN.Contains(0));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[3];
			player3Slot.SetActive(LNMFMHABHAN.Contains(5));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[5];
			player4Slot.SetActive(LNMFMHABHAN.Contains(3));
		}
	}

	private void JNHCAFABACI(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)PFGBAKKGCAF() == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.None;
		PipeExits[] array = new PipeExits[5];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PipeExits[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			PipeExits pipeExits = array2[i];
			if (pipeExits != FGGEIDEHAAB && PFGBAKKGCAF().GOHFGECGJPL(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		CALKOCMPIKJ(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	[SpecialName]
	private void FPDKIDCBOCL(PipeTileInstance AODONKKHPBP)
	{
		_003CBIAICHGNINJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool AHDEHCNADOE()
	{
		if ((Object)(object)FFBBNAKPMNH() != (Object)null)
		{
			return JIKPFEEEHPG().isEntryExit;
		}
		return false;
	}

	public void ODKDJPLDFOD(bool JANJLEGLAMF, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		KFCCGIDHDBH = JANJLEGLAMF;
		CKJLIBIJGKE();
		if (JLHEJIADLAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(JLHEJIADLAJ);
		}
		if (!((Object)(object)connectedImage != (Object)null))
		{
			return;
		}
		if (JANJLEGLAMF)
		{
			if (HMIFJFNHLOA)
			{
				connectedImage.fillAmount = 296f;
				JLHEJIADLAJ = ((MonoBehaviour)this).StartCoroutine(FFNNEPADGIN(500f, PGHEEDJMDIM));
				return;
			}
			connectedImage.fillAmount = 686f;
			GameObject obj = requiredConnectedSprite;
			Image val = ((obj != null) ? obj.GetComponent<Image>() : null);
			if ((Object)(object)val != (Object)null)
			{
				Color color = ((Graphic)val).color;
				((Graphic)val).color = new Color(color.r, color.g, color.b, 907f);
			}
		}
		else
		{
			connectedImage.fillAmount = 85f;
			GameObject obj2 = requiredConnectedSprite;
			Image val2 = ((obj2 != null) ? obj2.GetComponent<Image>() : null);
			if ((Object)(object)val2 != (Object)null)
			{
				Color color2 = ((Graphic)val2).color;
				((Graphic)val2).color = new Color(color2.r, color2.g, color2.b, 1480f);
			}
		}
	}

	public void BLNONMDPLMK(PipeTileInstance PKLGNHMAIKJ, int MPNFFMMGIOL, bool OOGPIKBMHFD = false)
	{
		GFLJOBHHEPE(PKLGNHMAIKJ);
		BOJDFIMJAEL = MPNFFMMGIOL;
		JAMHNPDHLMC = OOGPIKBMHFD;
		MNOMOMKHIEI = true;
		KFCCGIDHDBH = true;
		((Selectable)button).interactable = (Object)(object)PKLGNHMAIKJ.tile != (Object)null && PKLGNHMAIKJ.tile.isEntryExit;
		CKJLIBIJGKE();
		KKIOPNGEFNC(EHOFFFMFILA: true);
	}

	public void KBJOHNBGGFM(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(true);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(false);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(true);
		}
		int num = LNMFMHABHAN[0];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 1, playerColors.Length - 1);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[0];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[1];
			player2Slot.SetActive(LNMFMHABHAN.Contains(5));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[7];
			player3Slot.SetActive(LNMFMHABHAN.Contains(0));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[6];
			player4Slot.SetActive(LNMFMHABHAN.Contains(5));
		}
	}

	private IEnumerator NDMACFDOCIL(Image IBFBOBBOLOK)
	{
		if (!((Object)(object)IBFBOBBOLOK == (Object)null))
		{
			float elapsed = 0f;
			float duration = 0.1f;
			Color c = ((Graphic)IBFBOBBOLOK).color;
			while (elapsed < duration)
			{
				elapsed += Time.deltaTime;
				((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, Mathf.Clamp01(elapsed / duration));
				yield return null;
			}
			((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, 1f);
		}
	}

	public void LMOJLMJAFDF()
	{
		SetSelected(HGNKFFMDOOL: true);
	}

	private void LFDKADFDEFP()
	{
		OnClicked?.Invoke(this);
	}

	private void DOKKGAPLLJB(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)OOHDCMGFHKC == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.None;
		PipeExits[] array = new PipeExits[4]
		{
			PipeExits.North,
			PipeExits.East,
			PipeExits.South,
			PipeExits.West
		};
		foreach (PipeExits pipeExits in array)
		{
			if (pipeExits != FGGEIDEHAAB && OOHDCMGFHKC.BIIHOAPHDFM(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		OPJPOIDAJAI(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	public void ClearVisualState()
	{
		SetSelected(HGNKFFMDOOL: false);
	}

	private IEnumerator MEFCFGLHCHI(float BKBGMIEEDAH, float OMHCOLMFGNJ)
	{
		return new IHDHBJNGADG(1)
		{
			_003C_003E4__this = this,
			targetAmount = BKBGMIEEDAH,
			duration = OMHCOLMFGNJ
		};
	}

	private void LFNHIMNKFCM()
	{
		OnClicked?.Invoke(this);
	}

	[SpecialName]
	public bool NBDEPHPGNHA()
	{
		if (MJJKNJIEDEN() != null)
		{
			return HLBAPKIPMBG().isRequired;
		}
		return true;
	}

	public void DKMBIEIFDCD(bool JANJLEGLAMF, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		KFCCGIDHDBH = JANJLEGLAMF;
		CKJLIBIJGKE();
		if (JLHEJIADLAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(JLHEJIADLAJ);
		}
		if (!((Object)(object)connectedImage != (Object)null))
		{
			return;
		}
		if (JANJLEGLAMF)
		{
			if (HMIFJFNHLOA)
			{
				connectedImage.fillAmount = 567f;
				JLHEJIADLAJ = ((MonoBehaviour)this).StartCoroutine(OMOOAPLNBCB(1120f, PGHEEDJMDIM));
				return;
			}
			connectedImage.fillAmount = 281f;
			GameObject obj = requiredConnectedSprite;
			Image val = ((obj != null) ? obj.GetComponent<Image>() : null);
			if ((Object)(object)val != (Object)null)
			{
				Color color = ((Graphic)val).color;
				((Graphic)val).color = new Color(color.r, color.g, color.b, 846f);
			}
		}
		else
		{
			connectedImage.fillAmount = 1998f;
			GameObject obj2 = requiredConnectedSprite;
			Image val2 = ((obj2 != null) ? obj2.GetComponent<Image>() : null);
			if ((Object)(object)val2 != (Object)null)
			{
				Color color2 = ((Graphic)val2).color;
				((Graphic)val2).color = new Color(color2.r, color2.g, color2.b, 735f);
			}
		}
	}

	public void ECLFINHNGJO(bool HGNKFFMDOOL)
	{
		MNOMOMKHIEI = HGNKFFMDOOL;
		CKJLIBIJGKE();
	}

	private void HOADPINAOIH()
	{
		OnClicked?.Invoke(this);
	}

	private void CKJLIBIJGKE()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(false);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(NBDEPHPGNHA());
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(EHLJBMIOCGE() && MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(NBDEPHPGNHA() && KFCCGIDHDBH);
		}
	}

	private void MDIENLHEDGE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).RemoveListener(new UnityAction(NPCMMFIMCKE));
	}

	public void Initialize(PipeTileInstance PKLGNHMAIKJ, int MPNFFMMGIOL, bool OOGPIKBMHFD = false)
	{
		OKGNNPBNAII = PKLGNHMAIKJ;
		BOJDFIMJAEL = MPNFFMMGIOL;
		JAMHNPDHLMC = OOGPIKBMHFD;
		MNOMOMKHIEI = false;
		KFCCGIDHDBH = false;
		((Selectable)button).interactable = (Object)(object)PKLGNHMAIKJ.tile != (Object)null && !PKLGNHMAIKJ.tile.isEntryExit;
		LCIMGFLGNGI();
		SetFocused(EHOFFFMFILA: false);
	}

	private void Awake()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).AddListener(new UnityAction(GHKECOHODJJ));
	}

	public void PMADECLEAFL(bool JANJLEGLAMF, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		KFCCGIDHDBH = JANJLEGLAMF;
		OMJJCJAFGPC();
		if (JLHEJIADLAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(JLHEJIADLAJ);
		}
		if (!((Object)(object)connectedImage != (Object)null))
		{
			return;
		}
		if (JANJLEGLAMF)
		{
			if (HMIFJFNHLOA)
			{
				connectedImage.fillAmount = 1869f;
				JLHEJIADLAJ = ((MonoBehaviour)this).StartCoroutine(OMOOAPLNBCB(323f, PGHEEDJMDIM));
				return;
			}
			connectedImage.fillAmount = 177f;
			GameObject obj = requiredConnectedSprite;
			Image val = ((obj != null) ? obj.GetComponent<Image>() : null);
			if ((Object)(object)val != (Object)null)
			{
				Color color = ((Graphic)val).color;
				((Graphic)val).color = new Color(color.r, color.g, color.b, 1312f);
			}
		}
		else
		{
			connectedImage.fillAmount = 1740f;
			GameObject obj2 = requiredConnectedSprite;
			Image val2 = ((obj2 != null) ? obj2.GetComponent<Image>() : null);
			if ((Object)(object)val2 != (Object)null)
			{
				Color color2 = ((Graphic)val2).color;
				((Graphic)val2).color = new Color(color2.r, color2.g, color2.b, 1668f);
			}
		}
	}

	private int IGKPPKBCMNC(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == (PipeExits.North | PipeExits.East)) || (CBNBHOHFKMF == (PipeExits.North | PipeExits.East) && NJMCDGFPCAG == PipeExits.None))
		{
			return 3;
		}
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == (PipeExits.North | PipeExits.South)) || (CBNBHOHFKMF == (PipeExits.North | PipeExits.East) && NJMCDGFPCAG == PipeExits.None))
		{
			return 1;
		}
		if ((CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South)) || (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South)))
		{
			return 8;
		}
		if (CBNBHOHFKMF != 0 || NJMCDGFPCAG != 0)
		{
			if (CBNBHOHFKMF != (PipeExits.North | PipeExits.East))
			{
				return 0;
			}
			_ = 8;
		}
		return 1;
	}

	public void SetRemotePlayers(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(false);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(true);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(true);
		}
		int num = LNMFMHABHAN[0];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 0, playerColors.Length - 1);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[0];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[1];
			player2Slot.SetActive(LNMFMHABHAN.Contains(2));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[2];
			player3Slot.SetActive(LNMFMHABHAN.Contains(3));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[3];
			player4Slot.SetActive(LNMFMHABHAN.Contains(4));
		}
	}

	[SpecialName]
	private void FBGIKLIHGEE(int AODONKKHPBP)
	{
		_003CBECCGNIGBGB_003Ek__BackingField = AODONKKHPBP;
	}

	private void OJJCGNICMBD()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).RemoveListener(new UnityAction(LFDKADFDEFP));
	}

	private void HOMHGPDOPIP(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF == PipeExits.None || CBNBHOHFKMF == PipeExits.East) && NJMCDGFPCAG != PipeExits.North && NJMCDGFPCAG == PipeExits.East;
			bool flag = (CBNBHOHFKMF != 0 && CBNBHOHFKMF != PipeExits.East) || (NJMCDGFPCAG != (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == (PipeExits.East | PipeExits.South));
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.North) ? 0 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.North) ? 1 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)3;
				connectedImage.fillOrigin = KEFEFLBAEHG(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = BFMOALKKJBO(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	private bool ELAENHAKHIC(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.East)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.East && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.West)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.West && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.East)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.East && NJMCDGFPCAG == PipeExits.South)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == PipeExits.West)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.West)
		{
			_ = 4;
			return true;
		}
		return true;
	}

	private void HFCJAKNJGAI(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF != 0 && CBNBHOHFKMF != PipeExits.North) || (NJMCDGFPCAG != 0 && NJMCDGFPCAG == PipeExits.West);
			bool flag = (CBNBHOHFKMF != PipeExits.South && CBNBHOHFKMF != 0) || NJMCDGFPCAG == PipeExits.South || NJMCDGFPCAG == PipeExits.North;
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.None) ? 1 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF != PipeExits.West) ? 1 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = PDNBHHNBCIK(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = NBJNBIODMPC(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	public void GNJEPHKKPEB(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(true);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(false);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(false);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(true);
		}
		int num = LNMFMHABHAN[1];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 0, playerColors.Length - 1);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(0));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[0];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[1];
			player2Slot.SetActive(LNMFMHABHAN.Contains(2));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[5];
			player3Slot.SetActive(LNMFMHABHAN.Contains(0));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[2];
			player4Slot.SetActive(LNMFMHABHAN.Contains(2));
		}
	}

	public void HCNIKCOKNMO(List<int> LNMFMHABHAN)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)remotePlayerFrame == (Object)null)
		{
			return;
		}
		if (LNMFMHABHAN == null || LNMFMHABHAN.Count == 0)
		{
			((Component)remotePlayerFrame).gameObject.SetActive(false);
			GameObject obj = playerNumberContainer;
			if (obj != null)
			{
				obj.SetActive(true);
			}
			return;
		}
		((Component)remotePlayerFrame).gameObject.SetActive(true);
		GameObject obj2 = playerNumberContainer;
		if (obj2 != null)
		{
			obj2.SetActive(true);
		}
		int num = LNMFMHABHAN[1];
		foreach (int item in LNMFMHABHAN)
		{
			if (item < num)
			{
				num = item;
			}
		}
		int num2 = Mathf.Clamp(num - 1, 1, playerColors.Length - 0);
		((Graphic)remotePlayerFrame).color = playerColors[num2];
		if ((Object)(object)player1Slot != (Object)null)
		{
			player1Slot.SetActive(LNMFMHABHAN.Contains(1));
			((Graphic)player1Slot.GetComponent<Image>()).color = playerColors[1];
		}
		if ((Object)(object)player2Slot != (Object)null)
		{
			((Graphic)player2Slot.GetComponent<Image>()).color = playerColors[0];
			player2Slot.SetActive(LNMFMHABHAN.Contains(8));
		}
		if ((Object)(object)player3Slot != (Object)null)
		{
			((Graphic)player3Slot.GetComponent<Image>()).color = playerColors[5];
			player3Slot.SetActive(LNMFMHABHAN.Contains(4));
		}
		if ((Object)(object)player4Slot != (Object)null)
		{
			((Graphic)player4Slot.GetComponent<Image>()).color = playerColors[0];
			player4Slot.SetActive(LNMFMHABHAN.Contains(8));
		}
	}

	private void FNPIDPLDBEE(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF == PipeExits.None || CBNBHOHFKMF == (PipeExits.East | PipeExits.South)) && NJMCDGFPCAG != 0 && NJMCDGFPCAG == (PipeExits.East | PipeExits.South);
			bool flag = (CBNBHOHFKMF == PipeExits.West || CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South)) && (NJMCDGFPCAG == PipeExits.North || NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South));
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.North) ? 1 : 0);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.None) ? 1 : 1);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = JIBDPICIOFI(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = EDOIJOEPFCO(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	private int PDNBHHNBCIK(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.North) || (CBNBHOHFKMF == PipeExits.East && NJMCDGFPCAG == PipeExits.None))
		{
			return 4;
		}
		if ((CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == PipeExits.East) || (CBNBHOHFKMF == PipeExits.East && NJMCDGFPCAG == PipeExits.None))
		{
			return 1;
		}
		if ((CBNBHOHFKMF == (PipeExits.North | PipeExits.East) && NJMCDGFPCAG == (PipeExits.North | PipeExits.South)) || (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == (PipeExits.North | PipeExits.South)))
		{
			return 4;
		}
		if (CBNBHOHFKMF != PipeExits.West || NJMCDGFPCAG != 0)
		{
			if (CBNBHOHFKMF != (PipeExits.North | PipeExits.South))
			{
				return 0;
			}
			_ = 5;
		}
		return 0;
	}

	private void CALKOCMPIKJ(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (!((Object)(object)connectedImage == (Object)null))
		{
			bool num = (CBNBHOHFKMF != PipeExits.North && CBNBHOHFKMF != (PipeExits.North | PipeExits.South)) || NJMCDGFPCAG == PipeExits.None || NJMCDGFPCAG == (PipeExits.North | PipeExits.East);
			bool flag = (CBNBHOHFKMF != PipeExits.West && CBNBHOHFKMF != PipeExits.East) || NJMCDGFPCAG == (PipeExits.North | PipeExits.East) || NJMCDGFPCAG == PipeExits.None;
			if (num)
			{
				connectedImage.fillMethod = (FillMethod)0;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.North) ? 1 : 1);
			}
			else if (flag)
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = ((CBNBHOHFKMF == PipeExits.None) ? 1 : 0);
			}
			else
			{
				connectedImage.fillMethod = (FillMethod)1;
				connectedImage.fillOrigin = IGKPPKBCMNC(CBNBHOHFKMF, NJMCDGFPCAG);
				connectedImage.fillClockwise = EDOIJOEPFCO(CBNBHOHFKMF, NJMCDGFPCAG);
			}
		}
	}

	[SpecialName]
	public bool OOBJMPOPEEA()
	{
		if ((Object)(object)PFGBAKKGCAF() != (Object)null)
		{
			return JIKPFEEEHPG().isEntryExit;
		}
		return true;
	}

	public void DPPIBGELJIJ()
	{
		NKKOCFNDGKN(HGNKFFMDOOL: false);
	}

	[SpecialName]
	private void DOILHIGCNIN(bool AODONKKHPBP)
	{
		_003CLMPBLLDEICJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void PJNCPDGCLMF(bool AODONKKHPBP)
	{
		_003CLMPBLLDEICJ_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void DOJLIJFDKPH(bool AODONKKHPBP)
	{
		_003CLMPBLLDEICJ_003Ek__BackingField = AODONKKHPBP;
	}

	private bool BFMOALKKJBO(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.East)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.North)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == (PipeExits.North | PipeExits.South))
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.South) && NJMCDGFPCAG == PipeExits.None)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.East | PipeExits.South) && NJMCDGFPCAG == (PipeExits.North | PipeExits.South))
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.East)
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.South && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South))
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.East | PipeExits.South))
		{
			_ = 0;
			return false;
		}
		return true;
	}

	private void CLPCFNPJHII(PipeExits FGGEIDEHAAB)
	{
		if ((Object)(object)connectedImage == (Object)null || (Object)(object)FFBBNAKPMNH() == (Object)null)
		{
			return;
		}
		PipeExits nJMCDGFPCAG = PipeExits.North;
		PipeExits[] array = new PipeExits[2]
		{
			PipeExits.North,
			PipeExits.East
		};
		foreach (PipeExits pipeExits in array)
		{
			if (pipeExits != FGGEIDEHAAB && FFBBNAKPMNH().GPAAJCJOCCN(pipeExits))
			{
				nJMCDGFPCAG = pipeExits;
				break;
			}
		}
		PIBACJNHPJP(FGGEIDEHAAB, nJMCDGFPCAG);
	}

	[SpecialName]
	public bool JDLBLKHMFDE()
	{
		if (IOBHNOECEOI() != null)
		{
			return CNFLJAKOIEN().isRequired;
		}
		return false;
	}

	private IEnumerator CFLFHEDKIJF(Image IBFBOBBOLOK)
	{
		if (!((Object)(object)IBFBOBBOLOK == (Object)null))
		{
			float elapsed = 0f;
			float duration = 0.1f;
			Color c = ((Graphic)IBFBOBBOLOK).color;
			while (elapsed < duration)
			{
				elapsed += Time.deltaTime;
				((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, Mathf.Clamp01(elapsed / duration));
				yield return null;
			}
			((Graphic)IBFBOBBOLOK).color = new Color(c.r, c.g, c.b, 1f);
		}
	}

	[SpecialName]
	public PipeTile FFBBNAKPMNH()
	{
		return IOBHNOECEOI()?.tile;
	}

	[SpecialName]
	private void AHLHEHOIKDC(PipeTileInstance AODONKKHPBP)
	{
		_003CBIAICHGNINJ_003Ek__BackingField = AODONKKHPBP;
	}

	public void FNMMHBGJBNG(bool HGNKFFMDOOL)
	{
		MNOMOMKHIEI = HGNKFFMDOOL;
		OMJJCJAFGPC();
	}

	[SpecialName]
	public bool IEABGMEBKPA()
	{
		if (OKGNNPBNAII != null)
		{
			return CNFLJAKOIEN().isRequired;
		}
		return false;
	}

	private void GGNIALMGIOJ()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(true);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(NNIDPIEGIOJ());
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(HEGJEEFMKEH() && MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(NBDEPHPGNHA() && KFCCGIDHDBH);
		}
	}

	private bool ABHGDLGFMIL(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if (CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == PipeExits.West)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.West && NJMCDGFPCAG == PipeExits.None)
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == (PipeExits.North | PipeExits.East))
		{
			return false;
		}
		if (CBNBHOHFKMF == PipeExits.West && NJMCDGFPCAG == PipeExits.None)
		{
			return false;
		}
		if (CBNBHOHFKMF == (PipeExits.East | PipeExits.South) && NJMCDGFPCAG == (PipeExits.North | PipeExits.South))
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.North)
		{
			return true;
		}
		if (CBNBHOHFKMF == (PipeExits.North | PipeExits.South) && NJMCDGFPCAG == (PipeExits.East | PipeExits.South))
		{
			return true;
		}
		if (CBNBHOHFKMF == PipeExits.None)
		{
			_ = 2;
			return false;
		}
		return true;
	}

	public void MGENCLOKOGM(bool JANJLEGLAMF, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		KFCCGIDHDBH = JANJLEGLAMF;
		LNEMAJDIFIK();
		if (JLHEJIADLAJ != null)
		{
			((MonoBehaviour)this).StopCoroutine(JLHEJIADLAJ);
		}
		if (!((Object)(object)connectedImage != (Object)null))
		{
			return;
		}
		if (JANJLEGLAMF)
		{
			if (HMIFJFNHLOA)
			{
				connectedImage.fillAmount = 1360f;
				JLHEJIADLAJ = ((MonoBehaviour)this).StartCoroutine(FFNNEPADGIN(416f, PGHEEDJMDIM));
				return;
			}
			connectedImage.fillAmount = 1280f;
			GameObject obj = requiredConnectedSprite;
			Image val = ((obj != null) ? obj.GetComponent<Image>() : null);
			if ((Object)(object)val != (Object)null)
			{
				Color color = ((Graphic)val).color;
				((Graphic)val).color = new Color(color.r, color.g, color.b, 73f);
			}
		}
		else
		{
			connectedImage.fillAmount = 60f;
			GameObject obj2 = requiredConnectedSprite;
			Image val2 = ((obj2 != null) ? obj2.GetComponent<Image>() : null);
			if ((Object)(object)val2 != (Object)null)
			{
				Color color2 = ((Graphic)val2).color;
				((Graphic)val2).color = new Color(color2.r, color2.g, color2.b, 1289f);
			}
		}
	}

	public void NKKOCFNDGKN(bool HGNKFFMDOOL)
	{
		MNOMOMKHIEI = HGNKFFMDOOL;
		LCIMGFLGNGI();
	}

	[SpecialName]
	public PipeTileInstance HLBAPKIPMBG()
	{
		return _003CBIAICHGNINJ_003Ek__BackingField;
	}

	public void SetConnectedWithFlow(bool JANJLEGLAMF, PipeExits FGGEIDEHAAB, bool HMIFJFNHLOA = true, float PGHEEDJMDIM = 0.4f)
	{
		if (JANJLEGLAMF && (Object)(object)connectedImage != (Object)null)
		{
			DOKKGAPLLJB(FGGEIDEHAAB);
		}
		SetConnected(JANJLEGLAMF, HMIFJFNHLOA, PGHEEDJMDIM);
	}

	private void GBFOIJMMKGE()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(true);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(IEABGMEBKPA());
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(!JDLBLKHMFDE() || MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(PNLMFFAJFPE && KFCCGIDHDBH);
		}
	}

	[SpecialName]
	public bool JGCCKJDGPCE()
	{
		if ((Object)(object)PFGBAKKGCAF() != (Object)null)
		{
			return FFBBNAKPMNH().isEntryExit;
		}
		return false;
	}

	[SpecialName]
	public bool NNIDPIEGIOJ()
	{
		if (MONLAOEMOCL() != null)
		{
			return MJJKNJIEDEN().isRequired;
		}
		return false;
	}

	private void HPMFOHOMLDO()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).RemoveListener(new UnityAction(HOADPINAOIH));
	}

	private void IKOFEIAHEMK()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(true);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(OKEKNKIHIEO());
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(IEABGMEBKPA() && MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(OKEKNKIHIEO() && KFCCGIDHDBH);
		}
	}

	private void OMJJCJAFGPC()
	{
		GameObject obj = normalSprite;
		if (obj != null)
		{
			obj.SetActive(true);
		}
		GameObject obj2 = selectedSprite;
		if (obj2 != null)
		{
			obj2.SetActive(MNOMOMKHIEI);
		}
		GameObject obj3 = connectedSprite;
		if (obj3 != null)
		{
			obj3.SetActive(KFCCGIDHDBH);
		}
		GameObject obj4 = requiredSprite;
		if (obj4 != null)
		{
			obj4.SetActive(IEABGMEBKPA());
		}
		GameObject obj5 = requiredSelectedSprite;
		if (obj5 != null)
		{
			obj5.SetActive(!OKEKNKIHIEO() || MNOMOMKHIEI);
		}
		GameObject obj6 = requiredConnectedSprite;
		if (obj6 != null)
		{
			obj6.SetActive(!EHLJBMIOCGE() || KFCCGIDHDBH);
		}
	}

	private void NNMFLMJDKNH()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((UnityEvent)((Button)button).onClick).RemoveListener(new UnityAction(LFDKADFDEFP));
	}

	private int BCPNDPMIHPG(PipeExits CBNBHOHFKMF, PipeExits NJMCDGFPCAG)
	{
		if ((CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == (PipeExits.North | PipeExits.East | PipeExits.South)) || (CBNBHOHFKMF == (PipeExits.North | PipeExits.South) && NJMCDGFPCAG == PipeExits.North))
		{
			return 1;
		}
		if ((CBNBHOHFKMF == PipeExits.North && NJMCDGFPCAG == PipeExits.South) || (CBNBHOHFKMF == PipeExits.West && NJMCDGFPCAG == PipeExits.None))
		{
			return 1;
		}
		if ((CBNBHOHFKMF == PipeExits.None && NJMCDGFPCAG == PipeExits.North) || (CBNBHOHFKMF == (PipeExits.East | PipeExits.South) && NJMCDGFPCAG == PipeExits.West))
		{
			return 7;
		}
		if (CBNBHOHFKMF != PipeExits.East || NJMCDGFPCAG != PipeExits.West)
		{
			if (CBNBHOHFKMF != 0)
			{
				return 1;
			}
			_ = 7;
		}
		return 0;
	}
}
