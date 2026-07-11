using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BanquetRoundsManager : EventRoundsManager
{
	[Serializable]
	public struct RoundInfo
	{
		public string roundName;

		public bool drinksVisibleInBarrels;

		public bool colorVisibleInOrders;
	}

	[CompilerGenerated]
	private sealed class KKPCHKINMGA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BanquetRoundsManager _003C_003E4__this;

		private float _003CremainingTime_003E5__2;

		private float _003ChitPlayerRandomTime_003E5__3;

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
		public KKPCHKINMGA(int _003C_003E1__state)
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
			BanquetRoundsManager banquetRoundsManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CremainingTime_003E5__2 = banquetRoundsManager.roundTime;
				_003ChitPlayerRandomTime_003E5__3 = Random.Range(5f, banquetRoundsManager.roundTime / 2f);
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003CremainingTime_003E5__2 > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
			{
				if (!(_003CremainingTime_003E5__2 < _003ChitPlayerRandomTime_003E5__3))
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 1;
					return true;
				}
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
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

	public static BanquetRoundsManager instance;

	[SerializeField]
	private RoundInfo[] roundsInfo;

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator LLIJGOCKPBB(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator IEDNMBALHGC()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGCPONLCEGG()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}

	public bool MNEABKKFCDI()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return true;
	}

	private void DGOGKLMHJEG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public bool FCCOOKFJPGE()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return true;
	}

	private void OHKIOLCEMLM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator ONPHNPMEDCC()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	protected override IEnumerator LOCDIHNIMFI(bool HPNPAKJCDAB = true)
	{
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		KlaynNPC.instance.animationBase.CNKHDCIKHCO = false;
		KlaynNPC.instance.animationBase.IGONGEODOFP = false;
		KlaynNPC.instance.ChangeState(KlaynState.Wait);
		yield return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator IJPNECICBHC()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator IJFMAOFELMP()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HINGECEDJAP()
	{
		instance = this;
	}

	protected override void BIKCLHEPPNB(int BEFKNAPMAAG, bool FJEIAKMNOLG = true)
	{
		base.BIKCLHEPPNB(BEFKNAPMAAG, FJEIAKMNOLG);
		RoundInfo roundInfo = roundsInfo[currentRound];
		BanquetDrinksManager.instance.SetVisibleDrinkInBarrels(roundInfo.drinksVisibleInBarrels);
		BanquetOrdersManager.instance.SetVisibleColorInOrders(roundInfo.colorVisibleInOrders);
		BanquetOrdersManager.instance.ResetAllOrders();
		BanquetOrdersManager.instance.pauseOrders = true;
		KlaynNPC.instance.ChangeState(KlaynState.WaitingToServe);
	}

	private void CLLAKJADGIH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator LLLMNEKKIEC(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	public override void UnblockPlayers()
	{
		base.UnblockPlayers();
	}

	private void IGBEKHCLKFD()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator KPLKJALHIGI(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator LGLEALIPBJB(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	public override void BlockPlayers()
	{
		base.BlockPlayers();
	}

	private IEnumerator GFLGMKCGEAO(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	public override void RestartAllCharactersPositions()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		base.RestartAllCharactersPositions();
		PlayerController.TeleportPlayer(1, startPositionPlayers[Bed.instance.numInstance - 1].position, PlayerController.GetPlayer(1).LEOIMFNKFGA);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(2, startPositionPlayers[1].position, PlayerController.GetPlayer(1).LEOIMFNKFGA);
			PlayerController.GetPlayer(2).SetDirection(Direction.Down);
		}
		((Component)KlaynNPC.instance).transform.position = BanquetEvent.instance.klaynWaitingPosition.position;
		KlaynNPC.instance.ChangeState(KlaynState.WaitingToServe);
		((Component)RefereeNPC.GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(-991.3125f, 36.875f));
		BanquetOrdersManager.instance.ResetAllOrders();
	}

	private IEnumerator BHEKEJFONAI(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator AFFMKFDCMLP(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator GGPFPGFDABH()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KDGKLNEEEAF(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private void ELEGGKIBHGC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator HBFNAIALOEH(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void Awake()
	{
		instance = this;
	}

	private IEnumerator MHOMNLCBDIK()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private IEnumerator KHJEGPEGLPH(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator LPIGGGHIODE()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private void LJHIPOLCFBP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void HNNBAAJAHEN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerator IBDHIPLELBI(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator EFDLOJIJDPF()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ONFAANMMGBJ()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private IEnumerator ABKEEMILIIG(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	public bool JFFICGAOHDC()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return false;
	}

	protected override void HLCNHMOFNIE()
	{
		PlayerController.GetPlayer(1).trayHandler.RemoveAllDrinks();
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).trayHandler.RemoveAllDrinks();
		}
		BanquetOrdersManager.instance.ResetAllOrders();
		BanquetOrdersManager.instance.pauseOrders = true;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.trayHandler.RemoveAllDrinks();
		}
		KlaynNPC.instance.animationBase.CNKHDCIKHCO = false;
		KlaynNPC.instance.ChangeState(KlaynState.Wait);
		if (BanquetEvent.Replaying)
		{
			BanquetEvent.instance.ReturnToCastle();
		}
		else
		{
			OathFeastEvent.instance.StartWinnerScene();
		}
	}

	private void HLHHDNGOGNI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public bool OGNJCKELNEK()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return true;
	}

	private IEnumerator LKGHCACALPO(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator CIDGHCIDJEL(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator FDKNLCJDPDL(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	public bool JEPDCGINBJK()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return true;
	}

	private IEnumerator OPPJILLHPED(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator NBHJFBNLNJA()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool IsColorVisibleInOrders()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return false;
	}

	protected override IEnumerator NBCIALFNLAA(int KFHIFOABOFP)
	{
		yield return base.NBCIALFNLAA(KFHIFOABOFP);
		BanquetOrdersManager.instance.pauseOrders = false;
		if (OnlineManager.MasterOrOffline())
		{
			RefereeNPC.GGFJGHHHEJC.animationBase.SetBool("Cheer", EGFGNGJGBOP: true);
		}
		if (currentRound == 2)
		{
			((MonoBehaviour)this).StartCoroutine(OGCPONLCEGG());
		}
	}

	private IEnumerator FBKHDODMHIN()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private IEnumerator MBOGJICKDME(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator MEBAPBOGOCE()
	{
		return new KKPCHKINMGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ABGAEGAEJHK()
	{
		float remainingTime = roundTime;
		float hitPlayerRandomTime = Random.Range(5f, roundTime / 2f);
		while (remainingTime > 0f && !EventRoundsManager.forceNextRound && !EventRoundsManager.forceSkipChallenge)
		{
			if (remainingTime < hitPlayerRandomTime)
			{
				KlaynNPC.instance.ChangeState(KlaynState.HittingPlayer);
				break;
			}
			yield return CommonReferences.wait1;
		}
	}

	private IEnumerator NBCBKEDOJIE(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	public bool EBMHOLCJCHG()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return false;
	}

	public bool NCOCHBDHOMG()
	{
		if (currentRound < roundsInfo.Length)
		{
			return roundsInfo[currentRound].colorVisibleInOrders;
		}
		return false;
	}

	private void MBBIGANCPNE()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}
}
