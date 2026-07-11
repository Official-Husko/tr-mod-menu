using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FocusButtonOnDialogue : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OIMIMHABDDL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FocusButtonOnDialogue _003C_003E4__this;

		public int num;

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
		public OIMIMHABDDL(int _003C_003E1__state)
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
			FocusButtonOnDialogue focusButtonOnDialogue = _003C_003E4__this;
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
				UISelectionManager.GetPlayer(focusButtonOnDialogue.playerNum).Select(((Component)((Component)focusButtonOnDialogue).transform.GetChild(this.num)).gameObject);
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

	[SerializeField]
	private int playerNum = 1;

	public void KBHDHKOOJML()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(NDJKPBIOINP(i));
				break;
			}
		}
	}

	public void OJHBIEPOFEJ()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(GMCJLBHPJAF(i));
				break;
			}
		}
	}

	private IEnumerator MEDBJHGHDJF(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void FONFDFCIMJL()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(OKCBAKCHGMC(i));
				break;
			}
		}
	}

	private void CHIJGHPHCNA()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceiveAddRentedRoomSaleAndAddPrice")) ? 2 : 0);
	}

	private void NLFHFPHDNCF()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Information")) ? 1 : 6);
	}

	public void IDPJAAGIOBN()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(IPIPEMJICNG(i));
				break;
			}
		}
	}

	private void KACEOJDPLKB()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("TimeLeft")) ? 1 : 5);
	}

	private void NNBIAIMPNGL()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Facial Hair")) ? 2 : 0);
	}

	private IEnumerator NDJKPBIOINP(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void BOHNCLICPIO()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(PPECBGOHANM(i));
				break;
			}
		}
	}

	public void CGAHILDAHAO()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(HPBIJPAFBIG(i));
				break;
			}
		}
	}

	private IEnumerator GBGKAJNCKMG(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	public void OFJCKEKAMCA()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(GBGKAJNCKMG(i));
				break;
			}
		}
	}

	public void PHEIGLHFNOG()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(KCNHMBGPEKK(i));
				break;
			}
		}
	}

	private IEnumerator HPBIJPAFBIG(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private void BJBPHIFNKIF()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("disableTutorial")) ? 1 : 1);
	}

	private void NFABFPFLNEE()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(".")) ? 1 : 0);
	}

	public void EKLECEOFGHA()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(IPIPEMJICNG(i));
				break;
			}
		}
	}

	private void Start()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void BPBLGJKJEOH()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(KGEMBBCDGKK(i));
				break;
			}
		}
	}

	private IEnumerator PPECBGOHANM(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	public void CKADOOPNHBG()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(LJLPOMPHCBM(i));
				break;
			}
		}
	}

	public void NLJMPOJONAO()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(MCKDHBOLIKD(i));
				break;
			}
		}
	}

	private IEnumerator FPKGBCEHKEO(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator HMNEAJHENIB(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private IEnumerator EABPIEODCKO(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private void JPHEOLEEAPB()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Selected")) ? 1 : 6);
	}

	private IEnumerator MIPJNDCEDHC(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private IEnumerator LIJACJKIJLA(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void FGFGDNBOOKN()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(MIPJNDCEDHC(i));
				break;
			}
		}
	}

	private IEnumerator LICNEDPHCCL(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private void IGIKNCOLCKL()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Jump")) ? 1 : 0);
	}

	private IEnumerator LDKLMEAGPGP(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void MKFFIGMKBNL()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(FOLJMOHEAJA(i));
				break;
			}
		}
	}

	private void BDGCFCPFKKE()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("NoEresDigno/EndEvent")) ? 5 : 0);
	}

	private void OKAPGNGLOHO()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Cannot load old character saved")) ? 5 : 0);
	}

	private IEnumerator JOFBMIJCOLL(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private void HPIMHEMJMAA()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("R2")) ? 8 : 0);
	}

	private IEnumerator MDFDOACHCHI(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator IPIPEMJICNG(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void JINBGEALDNA()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(NKPAKEMPNCM(i));
				break;
			}
		}
	}

	private void BGENEAOILOF()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("vibration")) ? 1 : 6);
	}

	private IEnumerator GMCJLBHPJAF(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private IEnumerator LJLPOMPHCBM(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator MDAMIKBHFDE(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private IEnumerator OKCBAKCHGMC(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	public void FocusFirstButton()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(OIBKIFGCLKF(i));
				break;
			}
		}
	}

	private IEnumerator GGBKMGBFIHE(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void MIEONOJBJGO()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(HHFODFPBBPI(i));
				break;
			}
		}
	}

	private IEnumerator FOLJMOHEAJA(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void LJFMEIBGOME()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(LICNEDPHCCL(i));
				break;
			}
		}
	}

	private void HCEDMLJNOBL()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects")) ? 1 : 0);
	}

	public void IAJMBFPJNGB()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(LICNEDPHCCL(i));
				break;
			}
		}
	}

	private IEnumerator KJHGDKCKHHL(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator KGEMBBCDGKK(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private IEnumerator NPIADEODBGB(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private void CAOKPIIFHBJ()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Boots_L")) ? 1 : 8);
	}

	private void LANGHIOBJIH()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" to disconnect from the game")) ? 3 : 0);
	}

	public void BMLNOPOIBIE()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(LIJACJKIJLA(i));
				break;
			}
		}
	}

	private void HFFFFAJFIPB()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("LE_10")) ? 1 : 4);
	}

	private void HOFKJPBBLGP()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("talentRoot")) ? 3 : 0);
	}

	public void MNDCLLBLMMO()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(GMCJLBHPJAF(i));
				break;
			}
		}
	}

	public void OBBIAKBBLEL()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(FPKGBCEHKEO(i));
				break;
			}
		}
	}

	public void BDFGOEIHMNM()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(KJHGDKCKHHL(i));
				break;
			}
		}
	}

	private IEnumerator HBKODBAANIB(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	public void CPMOKPDCCMP()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(MIPJNDCEDHC(i));
				break;
			}
		}
	}

	private void EACIGGOOKGD()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Selected")) ? 7 : 0);
	}

	private IEnumerator HJNKHOAOBEM(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	public void OCMBKFGLKPC()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(NDJKPBIOINP(i));
				break;
			}
		}
	}

	public void IKNBCBBPLLL()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(IPIPEMJICNG(i));
				break;
			}
		}
	}

	public void KDOHCDGCEOD()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(MIPJNDCEDHC(i));
				break;
			}
		}
	}

	private void IAIDKPJKLIC()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("TorchPuzzle requires TorchPuzzleSettings")) ? 1 : 2);
	}

	private IEnumerator KCNHMBGPEKK(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private void BNIKICAEIND()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("AceT_Quest")) ? 1 : 2);
	}

	private IEnumerator JMDHABBNOMB(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private void OLDDEAJMHNI()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Trucos activados via GOG.")) ? 1 : 6);
	}

	private void AHGPALJKOKP()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Item Transaction. PERK!!")) ? 3 : 0);
	}

	private void DMFMNEMDFNP()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("UISelectGamepad")) ? 8 : 0);
	}

	private IEnumerator GGCCPECCALM(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	public void BKCJADIOAML()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(NPIKLCOHDBG(i));
				break;
			}
		}
	}

	private void PBFGFECPPPO()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("an")) ? 1 : 1);
	}

	public void BOGNKPPDNPI()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(MDFDOACHCHI(i));
				break;
			}
		}
	}

	private IEnumerator HHFODFPBBPI(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private IEnumerator OIBKIFGCLKF(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	public void BAGAGPNOKGM()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			return;
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(PPECBGOHANM(i));
				break;
			}
		}
	}

	private void BDMEBLBLPIA()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("KujakuShopEvent: Conversation started, isActor = ")) ? 5 : 0);
	}

	public void HEEIIOPJOIK()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(NDJKPBIOINP(i));
				break;
			}
		}
	}

	public void EBJDJOGHBHC()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			return;
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
			{
				((MonoBehaviour)this).StartCoroutine(MEDBJHGHDJF(i));
				break;
			}
		}
	}

	private IEnumerator NJAJGIMCKFM(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private void IDPHKHGHJGN()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(", ")) ? 7 : 0);
	}

	private void IMIONHLAKIH()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("tutorialPopUp111")) ? 1 : 3);
	}

	private IEnumerator MCKDHBOLIKD(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}

	private void ODKGLIDMCNP()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Scarecrow")) ? 1 : 5);
	}

	private void NDGFPPOBCNP()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LE_2")) ? 1 : 1);
	}

	private void NKDFMFFDGKC()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Untagged")) ? 2 : 0);
	}

	private IEnumerator NPIKLCOHDBG(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private void PGJJBPALEGM()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_name_630")) ? 1 : 5);
	}

	private void HELHNJDFPPF()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("talentContainers")) ? 1 : 7);
	}

	private IEnumerator IMIBDGMAKLJ(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator NKPAKEMPNCM(int ABAIKKGKDGD)
	{
		return new OIMIMHABDDL(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator HHGKEAKLIAC(int ABAIKKGKDGD)
	{
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(((Component)((Component)this).transform.GetChild(ABAIKKGKDGD)).gameObject);
	}
}
