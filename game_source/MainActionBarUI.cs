using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainActionBarUI : ActionBarUI
{
	[CompilerGenerated]
	private sealed class HDMGMKBDJKO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainActionBarUI _003C_003E4__this;

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
		public HDMGMKBDJKO(int _003C_003E1__state)
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
			MainActionBarUI mainActionBarUI = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(mainActionBarUI.JIIGOACEIKL))
				{
					UISelectionManager.GetPlayer(mainActionBarUI.JIIGOACEIKL).Select(((Component)mainActionBarUI.uiSlots[0]).gameObject);
				}
				else
				{
					UISelectionManager.GetPlayer(mainActionBarUI.JIIGOACEIKL).Deselect();
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

	private IEnumerator DJJCICNCBFM()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HMGAAINDHEL()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator MNIBNCIBAKI()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator NIJNMNKCKID()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator NDJHJGGJGBE()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EJFPIDAAODG()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AKAJIFCFBIA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public override bool SlotRightClicked(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		return Utils.ELFGBIGCFGL(JIIGOACEIKL, ADEBNALPEHE, Inventory.GetPlayer(JIIGOACEIKL));
	}

	private IEnumerator AHBMMLBJDFE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator KHILGHGDADB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator GNDAKEKDPKB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator MJDMBNPHPNL()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator INJMPMFGLPB()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OCIJMEEFBCM()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator HGMDNIKCBNE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		((MonoBehaviour)this).StartCoroutine(HMGAAINDHEL());
	}

	private IEnumerator CKAKOHCHPHH()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DHJEFDJBKML()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator KAJLONNJFPE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)uiSlots[0]).gameObject);
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private IEnumerator GCGPGNJGEFF()
	{
		return new HDMGMKBDJKO(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override bool GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		return Utils.FNCKBOHPFFJ(JIIGOACEIKL, ADEBNALPEHE, Inventory.GetPlayer(JIIGOACEIKL));
	}
}
