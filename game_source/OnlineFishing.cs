using System;
using Photon.Pun;
using UnityEngine;

public class OnlineFishing : MonoBehaviourPunCallbacks
{
	[SerializeField]
	private FishingController fishingController;

	[PunRPC]
	private void ReeledInRPC()
	{
		fishingController.FinishFishingOnline();
	}

	private void DFFDKIPCCKK()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(CICEKEBCKEN));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(NKCKMFPKHHG));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(BFILIDJMDMG));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(LPOLLCIJOAO));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(IGOOBEAHCIK));
		}
	}

	private void HPIMHEMJMAA()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(MJLNEFHPFKL));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(EHHABABNKAH));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(NPFFONNJIMJ));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(CHJCFDPKECF));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(NNHMEKBBKKC));
	}

	private void PKPHKBMPJGJ()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void ECDCNAEJHGL()
	{
		fishingController.fishingHook.CONOJLFMFAG();
		fishingController.fishingHook.OILEJHOJJMI(NJHMBMGKCPL: false);
	}

	private void OLNDLAHKCDJ()
	{
		fishingController.JPICEOBDLIH();
	}

	private void PMLBFEFMNPF()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(NHJACLDBLHO));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(NKCKMFPKHHG));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(ENNAJCNFFKB));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(CHJCFDPKECF));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
		}
	}

	private void OOGNFAIEPGF(byte FCGBJEIIMBC)
	{
		fishingController.LDMHJDDPHKF(FCGBJEIIMBC);
	}

	private void DOPBMJIHIHD(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.IJLFHJKNMGI(FFNOEIENNFM, KKANDELPDKP);
	}

	[PunRPC]
	private void ThrownHookRPC(byte FCGBJEIIMBC)
	{
		fishingController.ThrowFishHookOnline(FCGBJEIIMBC);
	}

	private void GGLBOPDIEJF()
	{
		fishingController.fishingHook.DFMOKMJGMLM();
		fishingController.fishingHook.KHNCBBCCHJJ(NJHMBMGKCPL: false);
	}

	private void CHIJGHPHCNA()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(OENHJMDLLHD));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(IGPEOAOPNKC));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(IAFBAOGMPFP));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(NGCODPLNLAI));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(NOHKGFDILHN));
	}

	private void EIFPCFCJFCL(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "Items/item_name_1057", (RpcTarget)0, array);
		}
	}

	private void NJHLHFALJBK(byte FCGBJEIIMBC)
	{
		fishingController.KEFKEAGHDMM(FCGBJEIIMBC);
	}

	private void BFILIDJMDMG()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReeledInRPC", (RpcTarget)1);
		}
	}

	private void HBMFCGEPFNH(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.LJCNGJHKCFN(FFNOEIENNFM, KKANDELPDKP);
	}

	private void KACEOJDPLKB()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(MJLNEFHPFKL));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(MOLLGFPCEMI));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(BFILIDJMDMG));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(PLKPPNILDLC));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(OFNHFIGMOJI));
	}

	private void EBMIPMLNLPI()
	{
		fishingController.fishingHook.PFGLANFEAOL();
		fishingController.fishingHook.EOKGECHIOGJ(NJHMBMGKCPL: false);
	}

	private void CIGNJNCLOPL()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)1);
		}
	}

	private void OOAJNOEDJLE()
	{
		fishingController.fishingHook.PFGLANFEAOL();
		fishingController.fishingHook.IGKKOHHJPMO(NJHMBMGKCPL: false);
	}

	private void HNEGFBCKIIJ()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(NHJACLDBLHO));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(EHHABABNKAH));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(NPFFONNJIMJ));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(LPOLLCIJOAO));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
	}

	private void IAFBAOGMPFP()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[HierarchyPrinter] ✅ Fichero guardado en: <color=cyan>", (RpcTarget)0);
		}
	}

	private void FJBPFOIALMK()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(CICEKEBCKEN));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(OMAMFPHKPKB));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(ENNAJCNFFKB));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(DFFLAILKJAB));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(IGOOBEAHCIK));
		}
	}

	private void HEANCLLNPID(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "Not enough money", (RpcTarget)1, array);
		}
	}

	private void NNMFLMJDKNH()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(MJLNEFHPFKL));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(EIFPCFCJFCL));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(ENNAJCNFFKB));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(CHJCFDPKECF));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(ABCJPGMOMPM));
		}
	}

	private void DIMAPDNCBAN()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void OnDestroy()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(OENHJMDLLHD));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(EHHABABNKAH));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(BFILIDJMDMG));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(PLKPPNILDLC));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
		}
	}

	private void IGHMMOKFINH()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void EGCKELNEICN(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.LJCNGJHKCFN(FFNOEIENNFM, KKANDELPDKP);
	}

	private void CILNBLLHJDH(short FFNOEIENNFM, short KKANDELPDKP)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "sForSeconds", (RpcTarget)0, FFNOEIENNFM, KKANDELPDKP, null, null, null, null);
		}
	}

	private void KLHIMJFCHPD()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void DIOGBHGKILK()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ToggleEntityView", (RpcTarget)0);
		}
	}

	private void OIDLKGBGKCN()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "TimeLeft", (RpcTarget)0);
		}
	}

	private void LIJIADPBODK()
	{
		fishingController.GLMMPEEJKEM();
	}

	private void IKPADHAEFDD()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemMildWort", (RpcTarget)0);
		}
	}

	private void JAJFGMJELLO()
	{
		fishingController.MEEMNIEGNLK();
	}

	private void JEDCDKEPBHA(short FFNOEIENNFM, short KKANDELPDKP)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = FFNOEIENNFM;
			array[0] = KKANDELPDKP;
			OnlineManager.SendRPC(photonView, "LE_10", (RpcTarget)0, array);
		}
	}

	private void JPHEOLEEAPB()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(MJLNEFHPFKL));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(NKCKMFPKHHG));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(IAFBAOGMPFP));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(LPOLLCIJOAO));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(NOHKGFDILHN));
	}

	private void FNFNLFOJHHA()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(MJLNEFHPFKL));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(OMAMFPHKPKB));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(DIOGBHGKILK));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(CHJCFDPKECF));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(NNHMEKBBKKC));
		}
	}

	private void HCIINEILMKK(byte FCGBJEIIMBC)
	{
		fishingController.LDMHJDDPHKF(FCGBJEIIMBC);
	}

	private void DMOLMIDHIJA()
	{
		fishingController.KFCBDPBJHLD();
	}

	private void IAAGKLPMAMK()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(NHJACLDBLHO));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(EHHABABNKAH));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(BFILIDJMDMG));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(LPOLLCIJOAO));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(ABCJPGMOMPM));
	}

	private void EJFFONKCIKM(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.IJLFHJKNMGI(FFNOEIENNFM, KKANDELPDKP);
	}

	private void DFFLAILKJAB()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "#.##%", (RpcTarget)1);
		}
	}

	[PunRPC]
	private void KeyItemFishedRPC()
	{
		fishingController.ShowOnlineKeyItem();
	}

	private void MMPAIPCILEN()
	{
		fishingController.LPPDGNMMNHE();
	}

	private void OFNHFIGMOJI()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "The room code is not valid. It must be a {0} digit number.", (RpcTarget)1);
		}
	}

	private void NPFFONNJIMJ()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "NinjaOrdersManager is not initialized.", (RpcTarget)1);
		}
	}

	private void IAFKAKBPKIN(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "talentGreens", (RpcTarget)0, array);
		}
	}

	private void MDGLECECOIG()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(NHJACLDBLHO));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(IGPEOAOPNKC));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(BFILIDJMDMG));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(LPOLLCIJOAO));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(OFNHFIGMOJI));
		}
	}

	[PunRPC]
	private void FishBiteRPC()
	{
		fishingController.fishingHook.SetBait();
		fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: true);
	}

	private void ABODAMIPHNI()
	{
		fishingController.fishingHook.LPLJMNPFMGE();
		fishingController.fishingHook.OILEJHOJJMI(NJHMBMGKCPL: true);
	}

	[PunRPC]
	private void FishCaughtRPC(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.ShowCaughtFishOnline(FFNOEIENNFM, KKANDELPDKP);
	}

	private void LBHFJANGIKE()
	{
		fishingController.fishingHook.NJBJALMMMNK();
		fishingController.fishingHook.MBMLEPFHPNL(NJHMBMGKCPL: false);
	}

	private void ENNAJCNFFKB()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Happy", (RpcTarget)0);
		}
	}

	private void MMBGIHOHIBF()
	{
		fishingController.FinishFishingOnline();
	}

	private void JEBKDDPNLJP(byte FCGBJEIIMBC)
	{
		fishingController.KEFKEAGHDMM(FCGBJEIIMBC);
	}

	private void IGOOBEAHCIK()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Week", (RpcTarget)1);
		}
	}

	private void LICCAJPPOFB(byte FCGBJEIIMBC)
	{
		fishingController.GJKBNFMCNDE(FCGBJEIIMBC);
	}

	private void LOBDBLACCNG(byte FCGBJEIIMBC)
	{
		fishingController.BAHGNKCCBHD(FCGBJEIIMBC);
	}

	private void PLKPPNILDLC()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "FishBiteRPC", (RpcTarget)1);
		}
	}

	private void LFDEPLLOJEK()
	{
		fishingController.MEEMNIEGNLK();
	}

	private void PKDIGABDEGO()
	{
		fishingController.fishingHook.DFMOKMJGMLM();
		fishingController.fishingHook.OILEJHOJJMI(NJHMBMGKCPL: false);
	}

	private void Awake()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void GMCKBBECJOE()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void NNHMEKBBKKC()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Walking", (RpcTarget)0);
		}
	}

	private void NKCKMFPKHHG(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "itemOlive", (RpcTarget)1, array);
		}
	}

	private void NOHKGFDILHN()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveVacateRoom", (RpcTarget)1);
		}
	}

	private void FHEGBNMJADG()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(CICEKEBCKEN));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(EHHABABNKAH));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(IAFBAOGMPFP));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(PLKPPNILDLC));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
	}

	private void IKBDHHIHHHL(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
		}
	}

	private void FEOIIBHPCJE()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RegisterExclusionZone - Spawner: ", (RpcTarget)1);
		}
	}

	private void EHHABABNKAH(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ThrownHookRPC", (RpcTarget)1, FCGBJEIIMBC);
		}
	}

	private void Start()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(OENHJMDLLHD));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(EHHABABNKAH));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(BFILIDJMDMG));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(PLKPPNILDLC));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
	}

	private void OLCBMGDDGHN()
	{
		fishingController.KEAMLOBPGPL();
	}

	private void LBJMMLDLCCM(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.AHFPNFOPMKA(FFNOEIENNFM, KKANDELPDKP);
	}

	private void PNLAJCHBHPH()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void PKFKKAAOHAO()
	{
		fishingController.LPPDGNMMNHE();
	}

	private void CHJCFDPKECF()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Gass_Introduce", (RpcTarget)1);
		}
	}

	private void FAIDKJBKDPO(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Space", (RpcTarget)0, FCGBJEIIMBC);
		}
	}

	private void KCMDMGOJCBK()
	{
		fishingController.IJJCPNOJAGF();
	}

	private void NDLCHBEALIH(byte FCGBJEIIMBC)
	{
		fishingController.FGLKDAAHKKH(FCGBJEIIMBC);
	}

	private void LMMAALGFHMO()
	{
		fishingController.fishingHook.APOFIFNLBLJ();
		fishingController.fishingHook.AGNOFAMHKLD(NJHMBMGKCPL: true);
	}

	private void ABCJPGMOMPM()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Fortitude/MainEvent 1", (RpcTarget)0);
		}
	}

	private void MOLLGFPCEMI(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "[GetFallbackCandidates] Total fallback candidates: {0}", (RpcTarget)0, array);
		}
	}

	private void IGPEOAOPNKC(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Quest/Entry/23/Dialogue Text", (RpcTarget)1, array);
		}
	}

	private void MJLNEFHPFKL(short FFNOEIENNFM, short KKANDELPDKP)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = FFNOEIENNFM;
			array[1] = KKANDELPDKP;
			OnlineManager.SendRPC(photonView, "Items/item_description_1041", (RpcTarget)1, array);
		}
	}

	private void DIHNLANLCCG(byte FCGBJEIIMBC)
	{
		fishingController.LDMHJDDPHKF(FCGBJEIIMBC);
	}

	private void NCLNBMPPBHH(short FFNOEIENNFM, short KKANDELPDKP)
	{
		fishingController.IJLFHJKNMGI(FFNOEIENNFM, KKANDELPDKP);
	}

	private void OPBALFGKBKO(byte FCGBJEIIMBC)
	{
		fishingController.FGLKDAAHKKH(FCGBJEIIMBC);
	}

	private void BJBPHIFNKIF()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(CILNBLLHJDH));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(MOLLGFPCEMI));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(BFILIDJMDMG));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(NGCODPLNLAI));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(IGOOBEAHCIK));
	}

	private void MFJIHCKEIIF()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void ALEAOANPHIO()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void CICEKEBCKEN(short FFNOEIENNFM, short KKANDELPDKP)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = FFNOEIENNFM;
			array[0] = KKANDELPDKP;
			OnlineManager.SendRPC(photonView, "Left Stick Down", (RpcTarget)0, array);
		}
	}

	private void HDBOGPMFICL()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSimpleEvent", (RpcTarget)0);
		}
	}

	private void BNACCHEHKHE()
	{
		fishingController.fishingHook.NJBJALMMMNK();
		fishingController.fishingHook.AGNOFAMHKLD(NJHMBMGKCPL: true);
	}

	private void MLBPCMMJCJK()
	{
		fishingController.BHOBBOBMGBP();
	}

	private void OMAMFPHKPKB(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Unique id ", (RpcTarget)1, FCGBJEIIMBC);
		}
	}

	private void CAOKPIIFHBJ()
	{
		FishingController obj = fishingController;
		obj.OnFishCaught = (Action<short, short>)Delegate.Combine(obj.OnFishCaught, new Action<short, short>(CILNBLLHJDH));
		FishingController obj2 = fishingController;
		obj2.OnHookThrown = (Action<byte>)Delegate.Combine(obj2.OnHookThrown, new Action<byte>(NKCKMFPKHHG));
		FishingController obj3 = fishingController;
		obj3.OnReeledIn = (Action)Delegate.Combine(obj3.OnReeledIn, new Action(NPFFONNJIMJ));
		FishingController obj4 = fishingController;
		obj4.OnFishBite = (Action)Delegate.Combine(obj4.OnFishBite, new Action(CHJCFDPKECF));
		FishingController obj5 = fishingController;
		obj5.OnKeyItemFished = (Action)Delegate.Combine(obj5.OnKeyItemFished, new Action(NOHKGFDILHN));
	}

	private void LMPPJKMGPEB(byte FCGBJEIIMBC)
	{
		fishingController.ThrowFishHookOnline(FCGBJEIIMBC);
	}

	private void OENHJMDLLHD(short FFNOEIENNFM, short KKANDELPDKP)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "FishCaughtRPC", (RpcTarget)1, FFNOEIENNFM, KKANDELPDKP);
		}
	}

	private void NHJACLDBLHO(short FFNOEIENNFM, short KKANDELPDKP)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player", (RpcTarget)0, FFNOEIENNFM, KKANDELPDKP, null, null, null, null, null, null);
		}
	}

	private void JBEKDFDMLKB()
	{
		fishingController.fishingHook.DFMOKMJGMLM();
		fishingController.fishingHook.EIOHGBKIHNI(NJHMBMGKCPL: false);
	}

	private void BMLDPJNFMKH(byte FCGBJEIIMBC)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = FCGBJEIIMBC;
			OnlineManager.SendRPC(photonView, ":", (RpcTarget)1, array);
		}
	}

	private void KCKIGMFELKI()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "KeyItemFishedRPC", (RpcTarget)1);
		}
	}

	private void GOOPOBMDALA()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(MJLNEFHPFKL));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(EIFPCFCJFCL));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(NPFFONNJIMJ));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(NGCODPLNLAI));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
		}
	}

	private void NGCODPLNLAI()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Pause", (RpcTarget)0);
		}
	}

	private void LPOLLCIJOAO()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Not enough experience!", (RpcTarget)0);
		}
	}

	private void GBKNIJENJEF()
	{
		if (OnlineManager.PlayingOnline())
		{
			FishingController obj = fishingController;
			obj.OnFishCaught = (Action<short, short>)Delegate.Remove(obj.OnFishCaught, new Action<short, short>(OENHJMDLLHD));
			FishingController obj2 = fishingController;
			obj2.OnHookThrown = (Action<byte>)Delegate.Remove(obj2.OnHookThrown, new Action<byte>(OMAMFPHKPKB));
			FishingController obj3 = fishingController;
			obj3.OnReeledIn = (Action)Delegate.Remove(obj3.OnReeledIn, new Action(ENNAJCNFFKB));
			FishingController obj4 = fishingController;
			obj4.OnFishBite = (Action)Delegate.Remove(obj4.OnFishBite, new Action(CHJCFDPKECF));
			FishingController obj5 = fishingController;
			obj5.OnKeyItemFished = (Action)Delegate.Remove(obj5.OnKeyItemFished, new Action(KCKIGMFELKI));
		}
	}

	private void PDFFOBGMEIB()
	{
		fishingController.FinishFishingOnline();
	}
}
