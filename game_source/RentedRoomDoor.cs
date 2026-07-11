using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RentedRoomDoor : Door
{
	[CompilerGenerated]
	private sealed class FAKHEIIGNML : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RentedRoomDoor _003C_003E4__this;

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
		public FAKHEIIGNML(int _003C_003E1__state)
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
			RentedRoomDoor rentedRoomDoor = _003C_003E4__this;
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
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				rentedRoomDoor.CheckOccupiedSprite();
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

	public SpriteRenderer symbolsBaseSpriteRenderer;

	public SpriteRenderer symbolsSpriteRenderer;

	public SpriteRenderer doorOccupiedSpriteRenderer;

	public Sprite[] doorOccupiedAnimationSprites;

	public Sprite[] symbolsBaseAnimationSprites;

	public Transform orderPositionAbove;

	public Transform orderPositionBelow;

	public RentedRoom rentedRoom;

	private IEnumerator GFLGMKCGEAO()
	{
		return base.KPHEJFJNELL();
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		rentedRoom.door = this;
		((MonoBehaviour)this).StartCoroutine(CheckOccupiedSpriteNextFrame());
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (rentedRoom.customerOrder.requesting)
		{
			if (inputEnabled && IsAvailableByProximity(JIIGOACEIKL))
			{
				if (rentedRoom.customerOrder.roomItemRequest.JEPBBEBJEFI() && !PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(rentedRoom.customerOrder.roomItemRequest))
				{
					return false;
				}
				rentedRoom.customerOrder.ServeRoomCustomer(JIIGOACEIKL, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
				return true;
			}
			return false;
		}
		return base.MouseUp(JIIGOACEIKL);
	}

	private IEnumerator CIICJLAANEK()
	{
		return base.DJMLAMGMGAP();
	}

	public void FOFHMGNDKAC()
	{
		if (rentedRoom.zone == null)
		{
			return;
		}
		if (rentedRoom.FKGBMIBFAGG())
		{
			if (!rentedRoom.occupied)
			{
				((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
			}
			else
			{
				((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
			}
		}
		else if (!rentedRoom.occupied)
		{
			((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
		}
		else
		{
			((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
		}
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator IBDHIPLELBI()
	{
		return base.FEPOADLMEFB();
	}

	public override void SetAnimationSprites(bool INLCKKBGHMF)
	{
		base.SetAnimationSprites(INLCKKBGHMF);
		if (open)
		{
			symbolsBaseSpriteRenderer.sprite = symbolsBaseAnimationSprites[PHKJJFEHBMK.Length - 1];
			symbolsSpriteRenderer.sprite = RentedRoomsManager.GetSymbolAnimationSprites(rentedRoom.symbolID)[PHKJJFEHBMK.Length - 1];
			return;
		}
		symbolsBaseSpriteRenderer.sprite = symbolsBaseAnimationSprites[0];
		if (rentedRoom.symbolID >= 0)
		{
			symbolsSpriteRenderer.sprite = RentedRoomsManager.GetInstance().roomsSymbols[rentedRoom.symbolID].symbolsAnimationSprites[0];
		}
	}

	protected override void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		base.ABLJNBFNMHI(JIIGOACEIKL, OKNOJJEFEBE, GFNHAMCPEAK);
		rentedRoom.RemoveRoomZone();
	}

	private IEnumerator LJBIHHOENKD()
	{
		return base.CALGEIKINMB();
	}

	protected override void JGDGOCLJHJJ(int JIIGOACEIKL)
	{
		base.JGDGOCLJHJJ(JIIGOACEIKL);
		rentedRoom.CreateRoomZone();
		((MonoBehaviour)this).StartCoroutine(CheckOccupiedSpriteNextFrame());
	}

	protected override IEnumerator FEPOADLMEFB()
	{
		CheckOccupiedSprite();
		yield return base.FEPOADLMEFB();
		rentedRoom.CheckVisibility(MAPFDGCKBLD: true);
	}

	protected override void LHIJLCIDHPC(int MENBAFNNBFB)
	{
		base.LHIJLCIDHPC(MENBAFNNBFB);
		if (MENBAFNNBFB < doorOccupiedAnimationSprites.Length)
		{
			doorOccupiedSpriteRenderer.sprite = doorOccupiedAnimationSprites[MENBAFNNBFB];
		}
		if (MENBAFNNBFB < symbolsBaseAnimationSprites.Length)
		{
			symbolsBaseSpriteRenderer.sprite = symbolsBaseAnimationSprites[MENBAFNNBFB];
		}
		if (MENBAFNNBFB < RentedRoomsManager.GetSymbolAnimationSprites(rentedRoom.symbolID)?.Length)
		{
			symbolsSpriteRenderer.sprite = RentedRoomsManager.GetSymbolAnimationSprites(rentedRoom.symbolID)[MENBAFNNBFB];
		}
	}

	public bool FLLPJCAKPIL()
	{
		return rentedRoom.occupied;
	}

	private IEnumerator PPEFNFPKONO()
	{
		return base.IMANBDAEFKD();
	}

	private IEnumerator KHJEGPEGLPH()
	{
		return base.FEPOADLMEFB();
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator LLIJGOCKPBB()
	{
		return base.NNKGHFMJCGD();
	}

	public void GKPJKIOCKGF()
	{
		if (rentedRoom.zone == null)
		{
			return;
		}
		if (rentedRoom.FKGBMIBFAGG())
		{
			if (!rentedRoom.occupied)
			{
				((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
			}
			else
			{
				((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(true);
			}
		}
		else if (!rentedRoom.occupied)
		{
			((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
		}
		else
		{
			((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
		}
	}

	public bool FOIPINGHLAE()
	{
		return rentedRoom.occupied;
	}

	public IEnumerator DBFPGJMHGNE()
	{
		return new FAKHEIIGNML(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator CheckOccupiedSpriteNextFrame()
	{
		yield return null;
		yield return null;
		CheckOccupiedSprite();
	}

	public void CheckOccupiedSprite()
	{
		if (rentedRoom.zone == null)
		{
			return;
		}
		if (rentedRoom.BAKBJEOMLHN)
		{
			if (!rentedRoom.occupied)
			{
				((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(true);
			}
			else
			{
				((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
			}
		}
		else if (!rentedRoom.occupied)
		{
			((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(false);
		}
		else
		{
			((Component)doorOccupiedSpriteRenderer).gameObject.SetActive(true);
		}
	}

	public bool IsOccupied()
	{
		return rentedRoom.occupied;
	}

	protected override IEnumerator NNKGHFMJCGD()
	{
		yield return base.NNKGHFMJCGD();
		CheckOccupiedSprite();
		rentedRoom.CheckVisibility(MAPFDGCKBLD: true);
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (rentedRoom.customerOrder.requesting)
		{
			if (IsAvailableByProximity(JIIGOACEIKL))
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Serve"));
				return true;
			}
			return false;
		}
		return base.OnHover(JIIGOACEIKL, IIEDALMMNLI);
	}

	public IEnumerator IGDMDPIOABP()
	{
		return new FAKHEIIGNML(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator POIPPBBBNIG()
	{
		return base.FIFMOIOAPLO();
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (rentedRoom.customerOrder.requesting)
		{
			if (rentedRoom.customerOrder.roomItemRequest.JEPBBEBJEFI())
			{
				return PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(rentedRoom.customerOrder.roomItemRequest);
			}
			return true;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}
}
