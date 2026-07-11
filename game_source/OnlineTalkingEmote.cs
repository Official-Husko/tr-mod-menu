using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnlineTalkingEmote : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ONBPDICNJKM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineTalkingEmote _003C_003E4__this;

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
		public ONBPDICNJKM(int _003C_003E1__state)
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
			OnlineTalkingEmote onlineTalkingEmote = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				onlineTalkingEmote.animationEmote.SetBool("Loop", false);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				onlineTalkingEmote.emote.SetActive(false);
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

	public GameObject emote;

	public Animator animationEmote;

	private IEnumerator CGKDKPLLHHO()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	public void CNHLAHGBKOD()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool("Focused", true);
		}
	}

	public void MOIDMFJDJOL()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(ENJMPJPCBDB());
		}
	}

	public void DKBMGHOEOFB()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(ENJMPJPCBDB());
		}
	}

	public void GDMGMIEBFEB()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("Loop", true);
		}
	}

	private IEnumerator GLLOPECEDEI()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ELBLICBHGBH()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("Sleep", true);
		}
	}

	public void KPADJIKGJBC()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool("Not enough ingredients", true);
		}
	}

	private IEnumerator KNFGBMJCFEI()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	public void KFEMCKCPADD()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(ENJMPJPCBDB());
		}
	}

	private IEnumerator HFABBGPOLOF()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CIIJDKFBGJJ()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator APGGGDGNBHF()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PCPOODMMIID()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MJCCDLEBLIG()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(JGMJAIPNPJL());
		}
	}

	public void BNKIKDJMHFG()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("ReceiveLoadSlots", true);
		}
	}

	public void CCMCNHBGKEO()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("ReceiveRoomRequest", false);
		}
	}

	private IEnumerator JGMJAIPNPJL()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	public void FLCHDHCFEOJ()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(IHIBLGKELNO());
		}
	}

	private IEnumerator IHIBLGKELNO()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLNGIEIILAL()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	private IEnumerator CFBBNCAPBGG()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HCMKCNKFEGA()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("Direction", true);
		}
	}

	private IEnumerator JDOLAKFLFEB()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LDBCADAGCAN()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("", false);
		}
	}

	public void KNJFGJDMPDO()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool("]", true);
		}
	}

	public void FOJPAAIMIDF()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("EditorAction_5", false);
		}
	}

	private IEnumerator KDIJGMPFNED()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CECCCKHLBAP()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(JGMJAIPNPJL());
		}
	}

	public void HGPOJCNAABK()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool(" (", false);
		}
	}

	public void DBNNCJGAGKF()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool(":", false);
		}
	}

	private IEnumerator LEJHBBEDKLC()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FBKNHHHNPIL()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(FLBEFAMONPP());
		}
	}

	private IEnumerator ILHFCMAPPLH()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BKBMBBCNEKK()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BLNGIEIILAL());
		}
	}

	public void BCPGHBMHMGC()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("ReceiveRestartChallenge", false);
		}
	}

	public void DisableEmote()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(JGMJAIPNPJL());
		}
	}

	public void DGACHHEKODN()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(CFBBNCAPBGG());
		}
	}

	public void GGAJKPIMOLH()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(FLBEFAMONPP());
		}
	}

	public void ODHMCNPIBNF()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("NO SOUNDTRACK LOADED\n\n Troubleshooting:\n\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in your Project window onto the PsaiPlayerUi component.\n\nPlease see the log output window for more information.", false);
		}
	}

	private IEnumerator ENJMPJPCBDB()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	public void LKKHCIKBDPO()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("Pool Parent ", true);
		}
	}

	public void KDCCFFKBCCM()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool("", false);
		}
	}

	public void JICKIHNJAJI()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("NormalLeftExterior", false);
		}
	}

	public void ALGHJAGCHFI()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(JGMJAIPNPJL());
		}
	}

	private IEnumerator MEKDLNMMFDK()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EnableEmote()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("Loop", true);
		}
	}

	public void CKGNOOAIEEI()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BLNGIEIILAL());
		}
	}

	private IEnumerator FLBEFAMONPP()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HJBCLJFKGMC()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(true);
			animationEmote.SetBool("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text", true);
		}
	}

	private IEnumerator AGDALAPOPHL()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	public void NODFGMNLGFC()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(CGKDKPLLHHO());
		}
	}

	public void MBDPOAGDPGI()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(FLBEFAMONPP());
		}
	}

	public void EKKGAKMMGDK()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool("Halloween/Trick/Bark", true);
		}
	}

	private IEnumerator LHCNBDEPODF()
	{
		animationEmote.SetBool("Loop", false);
		yield return CommonReferences.wait05;
		emote.SetActive(false);
	}

	public void MJCIEFBKEAD()
	{
		if (emote.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(LHCNBDEPODF());
		}
	}

	public void CKEHBELKHEI()
	{
		if (!emote.activeInHierarchy)
		{
			emote.SetActive(false);
			animationEmote.SetBool("Sell", false);
		}
	}

	private IEnumerator HDHEEELCJOD()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CDKFCIPJCJB()
	{
		return new ONBPDICNJKM(1)
		{
			_003C_003E4__this = this
		};
	}
}
