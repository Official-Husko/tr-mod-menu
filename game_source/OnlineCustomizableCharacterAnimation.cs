using System;
using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(CharacterAnimBase))]
public class OnlineCustomizableCharacterAnimation : OnlineBaseCharacterAnimation
{
	public CharacterAnimator characterAnimator;

	public CharacterCreator characterCreator;

	[PunRPC]
	public void ReceiveCleanSprites(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
			characterAnimator.ActivateCleanSprites(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: false);
		}
	}

	protected void GOOPOBMDALA()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(DGFBDGLOICJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(HDIJBMMNAOP));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(NFKPPNPPPGF));
		}
	}

	public void FMBKKPJJIFG(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = GLFNNCJKOEN;
		array[0] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "Small room ", (RpcTarget)1, array);
	}

	public void PLECHHHGMEM(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.NCAJNNHBHJM((Direction)FCGBJEIIMBC);
			characterAnimator.ActivateCleanSprites(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: false);
		}
	}

	protected void IKMPNICLPBM()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(PAHELFDIOKG));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(JJAIKHICHOP));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(FAJGCNKJMGI));
		}
	}

	[PunRPC]
	public void ReceiveSetDirection(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	private void GCFCJDEDMOC(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.LHBLJGNANHI((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	public void SendActivateEatGameObjects(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveActivateEatGameObjects", (RpcTarget)1, GLFNNCJKOEN, PJEILLAADOC);
	}

	private void PFOFICOJHOL(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.CheckFaceActivation((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	public void AEKBKFNKPGL(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	private void HDIJBMMNAOP(Direction MPLCIAKAPGL)
	{
		if (!OEAKPHGPCOD())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "HorizontalMove", (RpcTarget)1, (byte)MPLCIAKAPGL);
		}
	}

	private void PNHOONIOHCK(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Serve", (RpcTarget)1, (byte)MPLCIAKAPGL, (byte)OHMAEGCHIOC, null, null, null, null);
		}
	}

	public void GPGLHFIMEAJ(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	protected void JCNGGPIICIN()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(ELPOBBJGKPJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(OLNJDCFEJEM));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(AAFHKAOFEJD));
		}
	}

	private void DGFBDGLOICJ(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[3];
			array[0] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "[", (RpcTarget)0, array);
		}
	}

	private void LJJAMOHLFKE(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	protected void EGHOIJHBDBP()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(DGFBDGLOICJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(OLNJDCFEJEM));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(AAFHKAOFEJD));
		}
	}

	public void MBOEJELDHCG()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	[PunRPC]
	private void OnFaceActivationRPC(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.CheckFaceActivation((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	public void Configuration()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	protected void KCLKEAHGGEK()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(HNNFGEODJMP));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(MLNLEGEOKJF));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(AGNCDHJLCIO));
		}
	}

	private void FDOGLDLKINC(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.CheckFaceActivation((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	protected override void Awake()
	{
		base.Awake();
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
			return;
		}
		if ((Object)(object)characterAnimator == (Object)null)
		{
			characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		}
		if ((Object)(object)characterCreator == (Object)null)
		{
			characterCreator = ((Component)this).GetComponentInChildren<CharacterCreator>();
		}
		characterAnimator.onlineAnimation = this;
		CharacterAnimator obj = characterAnimator;
		obj.FaceActivation = (Action<Direction, Gender>)Delegate.Combine(obj.FaceActivation, new Action<Direction, Gender>(OLGFKEBFCIE));
		CharacterAnimator obj2 = characterAnimator;
		obj2.LayerOrder = (Action<Direction>)Delegate.Combine(obj2.LayerOrder, new Action<Direction>(ACNAIBGPKOF));
		CharacterAnimator obj3 = characterAnimator;
		obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Combine(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(SendCleanSprites));
		CharacterAnimator obj4 = characterAnimator;
		obj4.ActivatedEatObjects = (Action<int, bool>)Delegate.Combine(obj4.ActivatedEatObjects, new Action<int, bool>(SendActivateEatGameObjects));
	}

	public void ENLLANGMACG(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.NCAJNNHBHJM((Direction)FCGBJEIIMBC);
	}

	protected void AGILHHEMEFC()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(HEKHKADKIHN));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(JJAIKHICHOP));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(DPJGIIEMLKC));
		}
	}

	private void DGGMOPBIPMH(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.CheckFaceActivation((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	public void JFFECPPCMPE(Direction FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "Items/item_name_627", (RpcTarget)1, array);
	}

	private void KCKEAGALGBA(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[0] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "Items/item_name_697", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	public void ReceiveActivateEatGameObjects(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		characterAnimator.ActivateEatGameObjects(GLFNNCJKOEN, PJEILLAADOC);
	}

	public void HEHBGHLDGFP()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	protected void HKECEBGKACL()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(PNHOONIOHCK));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(NFMJNELGHHE));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(AAFHKAOFEJD));
		}
	}

	public void LJJNJGIKCBC(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = DAEMAAOLHMG;
		array[1] = HBHBGBLCPAM;
		array[7] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[3] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "NinjaChallengeEvent/Win", (RpcTarget)0, array);
	}

	private void MGFBPFMEPAK(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	protected void ELEGGKIBHGC()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(HNNFGEODJMP));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(JJAIKHICHOP));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(FAJGCNKJMGI));
		}
	}

	public void CFBGABHAEEL(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = GLFNNCJKOEN;
		array[0] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "<b><color=#9a672a>", (RpcTarget)0, array);
	}

	private void MFGILGGFBLJ(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	public void SendCleanSprites(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCleanSprites", (RpcTarget)1, DAEMAAOLHMG, HBHBGBLCPAM, PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId, FCGBJEIIMBC);
	}

	public void LKIBJBEFJBK(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = GLFNNCJKOEN;
		array[1] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "Selected", (RpcTarget)0, array);
	}

	public void MLNNFHKKFCF()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	public void MKFFCAJBEIA(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		characterAnimator.ActivateEatGameObjects(GLFNNCJKOEN, PJEILLAADOC);
	}

	public void IDEKEOBOLMO(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.NCAJNNHBHJM((Direction)FCGBJEIIMBC);
	}

	public void JNKHPKBNANC(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.NCAJNNHBHJM((Direction)FCGBJEIIMBC);
			characterAnimator.DNHLCKHCANN(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: false);
		}
	}

	private void ELPOBBJGKPJ(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[0] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, " plus price satisfaction ", (RpcTarget)0, array);
		}
	}

	private void GNHDCKMPIMB(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "hardware_info", (RpcTarget)0, array);
		}
	}

	public void POBFIGNBKOE(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	private void GAEJBPAJFKJ(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.CheckFaceActivation((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	private void ANKFENMHEFJ(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = (byte)MPLCIAKAPGL;
			array[1] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "RoadBlocked/Main 2", (RpcTarget)0, array);
		}
	}

	public void BFJBBLLFOFG(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = GLFNNCJKOEN;
		array[0] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
	}

	private void PAHELFDIOKG(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!GPGHCFJHCAP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "itemSageSeeds", (RpcTarget)1, array);
		}
	}

	public void HLCGMPPNGEO(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = GLFNNCJKOEN;
		array[1] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "GalaxyInstance.Storage.FileShare method started", (RpcTarget)1, array);
	}

	public void NFKPPNPPPGF(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Serve", (RpcTarget)0, DAEMAAOLHMG, HBHBGBLCPAM, PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId, FCGBJEIIMBC);
	}

	public void SendSetDirection(Direction FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetDirection", (RpcTarget)1, (byte)FCGBJEIIMBC);
	}

	private void HEKHKADKIHN(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "version numbers of different size", (RpcTarget)0, array);
		}
	}

	protected void HMOMBAFIJAI()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(DGFBDGLOICJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(HDIJBMMNAOP));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(NFKPPNPPPGF));
		}
	}

	public void PFIADFFGMDD(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
			characterAnimator.ActivateCleanSprites(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: false);
		}
	}

	protected void GADEGOPBNGC()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(PGGACNCEDBJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(NFMJNELGHHE));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(JGLLBLLIAKJ));
		}
	}

	public void NKAGIIEFOIJ()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	protected void FLOFJHNAIKP()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(MAJENNAAPOG));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(ACNAIBGPKOF));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(FEBOGJEPCPP));
		}
	}

	public void DKKKCANMJBF(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	public void APHJMKACDGF(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
			characterAnimator.DNHLCKHCANN(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: true);
		}
	}

	private void JJAIKHICHOP(Direction MPLCIAKAPGL)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)MPLCIAKAPGL;
			OnlineManager.SendRPC(photonView, "Moving", (RpcTarget)0, array);
		}
	}

	public void AGNCDHJLCIO(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = DAEMAAOLHMG;
		array[1] = HBHBGBLCPAM;
		array[1] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[1] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "BuzzBuildExit", (RpcTarget)0, array);
	}

	public void FAJGCNKJMGI(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = DAEMAAOLHMG;
		array[0] = HBHBGBLCPAM;
		array[4] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[5] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "Halloween/Trick/Main", (RpcTarget)0, array);
	}

	protected void CHDEOJALBFK()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(ELPOBBJGKPJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(FLIFAJKAIHB));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(JGLLBLLIAKJ));
		}
	}

	public void KHMOEDMODIP(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = GLFNNCJKOEN;
		array[0] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "Run", (RpcTarget)1, array);
	}

	public void EGBBPNEFMMG(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = DAEMAAOLHMG;
		array[0] = HBHBGBLCPAM;
		array[0] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[2] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "Items/item_name_1132", (RpcTarget)0, array);
	}

	private void PGGACNCEDBJ(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "OnlinePlayer", (RpcTarget)1, array);
		}
	}

	public void KDMCAHKANEA(Direction FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "Walk", (RpcTarget)1, array);
	}

	public void OJOPCFNAOIF(Direction FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Roll", (RpcTarget)0, (byte)FCGBJEIIMBC);
	}

	public void LIMJNJFENEH()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	[PunRPC]
	private void OnLayerOrderedRPC(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.CheckFaceActivation((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	private void HNNFGEODJMP(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "Items/item_description_1134", (RpcTarget)0, array);
		}
	}

	public void GFCGENLFPJJ(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.NCAJNNHBHJM((Direction)FCGBJEIIMBC);
	}

	public void ONBHFHNLMHN(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		characterAnimator.ActivateEatGameObjects(GLFNNCJKOEN, PJEILLAADOC, CDPAMNIPPEC: false);
	}

	public void CCCFPCGDLKM()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	public void JNOAAMPGOCM(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = GLFNNCJKOEN;
		array[1] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "LE_11", (RpcTarget)0, array);
	}

	public void OLPCPDJCENA(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		characterAnimator.ActivateEatGameObjects(GLFNNCJKOEN, PJEILLAADOC);
	}

	private void EALDMEOGLNP(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	public void LLHCMILHIIP(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = GLFNNCJKOEN;
		array[0] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "LicenciaDeApertura/TheloniousDialogue 01", (RpcTarget)0, array);
	}

	public void JGLLBLLIAKJ(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = DAEMAAOLHMG;
		array[0] = HBHBGBLCPAM;
		array[2] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[6] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "DecorationTile_12", (RpcTarget)1, array);
	}

	protected void KPILPDFCHBG()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(KCKEAGALGBA));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(NFMJNELGHHE));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(JGLLBLLIAKJ));
		}
	}

	private void GACJLHHHOMN(Direction MPLCIAKAPGL)
	{
		if (!OEAKPHGPCOD())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Keg empty", (RpcTarget)1, (byte)MPLCIAKAPGL);
		}
	}

	private void MLNLEGEOKJF(Direction MPLCIAKAPGL)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)MPLCIAKAPGL;
			OnlineManager.SendRPC(photonView, "/", (RpcTarget)0, array);
		}
	}

	public void LPADEJFCCEK(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.NCAJNNHBHJM((Direction)FCGBJEIIMBC);
			characterAnimator.ActivateCleanSprites(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: false);
		}
	}

	private void NFMJNELGHHE(Direction MPLCIAKAPGL)
	{
		if (!OEAKPHGPCOD())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Hat", (RpcTarget)1, (byte)MPLCIAKAPGL);
		}
	}

	public void DHOCIFBCNAD()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	public void AAFHKAOFEJD(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = DAEMAAOLHMG;
		array[1] = HBHBGBLCPAM;
		array[3] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[5] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "The tavern is still open, are you sure you want to sleep?\n The tavern will close and you might lose reputation.", (RpcTarget)0, array);
	}

	public void FEBOGJEPCPP(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = DAEMAAOLHMG;
		array[1] = HBHBGBLCPAM;
		array[7] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[5] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, ", ", (RpcTarget)0, array);
	}

	public void LFELMFNIDHO()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	public void JLHKDOLNDDO(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
			characterAnimator.ActivateCleanSprites(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: true);
		}
	}

	public void MCMEILPECNP(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = GLFNNCJKOEN;
		array[1] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Standar/Entry/4/Dialogue Text", (RpcTarget)0, array);
	}

	protected void PCEFNHADDIG()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(ELPOBBJGKPJ));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(HDIJBMMNAOP));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(AGNCDHJLCIO));
		}
	}

	private void ACNAIBGPKOF(Direction MPLCIAKAPGL)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "OnLayerOrderedRPC", (RpcTarget)1, (byte)MPLCIAKAPGL);
		}
	}

	public void KMGFJIDCGIH()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void OLGFKEBFCIE(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "OnFaceActivationRPC", (RpcTarget)1, (byte)MPLCIAKAPGL, (byte)OHMAEGCHIOC);
		}
	}

	public void MGOJDINHEFE(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GLFNNCJKOEN;
		array[0] = PJEILLAADOC;
		OnlineManager.SendRPC(photonView, "Ax Level Low", (RpcTarget)1, array);
	}

	private void AFKLCPBFNHD(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.LHBLJGNANHI((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	public void DPJGIIEMLKC(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = DAEMAAOLHMG;
		array[1] = HBHBGBLCPAM;
		array[8] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[2] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "ReceiveChangeDrinkColorMaster", (RpcTarget)1, array);
	}

	private void HEMLFFABJEJ(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.LHBLJGNANHI((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	public void BFJKBBJGBEB(Direction FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)1, (byte)FCGBJEIIMBC);
	}

	public void LLKDAOEKHOB()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	protected void OJAJLIAMGEJ()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(OLGFKEBFCIE));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(ACNAIBGPKOF));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(LJJNJGIKCBC));
		}
	}

	public void BCJOIHDEBMI(Direction FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/TavernClean/Entry/5/Dialogue Text", (RpcTarget)0, array);
	}

	public void IFHAPHABHCK(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	private void MHKLNIFMNFB(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.LHBLJGNANHI((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	public void HBAOLBEJCMJ()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void OLNJDCFEJEM(Direction MPLCIAKAPGL)
	{
		if (!OEAKPHGPCOD())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)MPLCIAKAPGL;
			OnlineManager.SendRPC(photonView, "File ", (RpcTarget)1, array);
		}
	}

	private void JEJOBNMJFHF(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.LHBLJGNANHI((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	private void EHGKBJCDAFI(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text", (RpcTarget)1, array);
		}
	}

	public void GPJAOOAJFKF(bool DAEMAAOLHMG, bool HBHBGBLCPAM, SurfaceSortOrder PHCPMJAIDMC, byte FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = DAEMAAOLHMG;
		array[1] = HBHBGBLCPAM;
		array[8] = PHCPMJAIDMC.placeable.onlinePlaceable.uniqueId;
		array[7] = FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "City/Amos/Bark/Stand", (RpcTarget)0, array);
	}

	public void GCLOPBMFHLP()
	{
		characterAnimator = ((Component)this).GetComponentInChildren<CharacterAnimator>();
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	private void NLIJMJBJKIJ(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "\n \n", (RpcTarget)0, array);
		}
	}

	public void HAAHLJAJODK(Direction FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "Checking is DLC ", (RpcTarget)1, array);
	}

	public void BHJHHKAHFHD(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		characterAnimator.ActivateEatGameObjects(GLFNNCJKOEN, PJEILLAADOC, CDPAMNIPPEC: false);
	}

	private void GHMKFLOBPCH(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	private void MJDBDBDLIMC(byte MPLCIAKAPGL, byte OHMAEGCHIOC)
	{
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, (Gender)OHMAEGCHIOC);
	}

	protected void OnDestroy()
	{
		if (OnlineManager.PlayingOnline())
		{
			CharacterAnimator obj = characterAnimator;
			obj.FaceActivation = (Action<Direction, Gender>)Delegate.Remove(obj.FaceActivation, new Action<Direction, Gender>(OLGFKEBFCIE));
			CharacterAnimator obj2 = characterAnimator;
			obj2.LayerOrder = (Action<Direction>)Delegate.Remove(obj2.LayerOrder, new Action<Direction>(ACNAIBGPKOF));
			CharacterAnimator obj3 = characterAnimator;
			obj3.ActivatedCleanSprites = (Action<bool, bool, SurfaceSortOrder, byte>)Delegate.Remove(obj3.ActivatedCleanSprites, new Action<bool, bool, SurfaceSortOrder, byte>(SendCleanSprites));
		}
	}

	public void HCAHONBEHEM(int GLFNNCJKOEN, bool PJEILLAADOC)
	{
		characterAnimator.ActivateEatGameObjects(GLFNNCJKOEN, PJEILLAADOC, CDPAMNIPPEC: false);
	}

	private void OKAFNDJBCCH(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	private void FLIFAJKAIHB(Direction MPLCIAKAPGL)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)MPLCIAKAPGL;
			OnlineManager.SendRPC(photonView, "Hair", (RpcTarget)0, array);
		}
	}

	private void NBCECMEADEJ(byte MPLCIAKAPGL)
	{
		characterAnimator.CheckOrderInLayers((Direction)MPLCIAKAPGL);
		characterAnimator.FOGOOAHJODH((Direction)MPLCIAKAPGL, characterCreator.humanInfo.gender);
	}

	public void IBOHCNLLDDL(bool DAEMAAOLHMG, bool LCOADOCAFEO, int CDILLEBMLHE, byte FCGBJEIIMBC)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(CDILLEBMLHE, out var value))
		{
			characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
			characterAnimator.ActivateCleanSprites(DAEMAAOLHMG, LCOADOCAFEO, (value as OnlinePlaceable).placeable.placeableSurface, CDPAMNIPPEC: true);
		}
	}

	public void HIHOALFFFDC(Direction FCGBJEIIMBC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)FCGBJEIIMBC;
		OnlineManager.SendRPC(photonView, "ReceiveClockMessage", (RpcTarget)1, array);
	}

	public void GGAEHOOGIGJ(byte FCGBJEIIMBC)
	{
		characterAnimator.animation.FCGBJEIIMBC = (Direction)FCGBJEIIMBC;
	}

	private void MAJENNAAPOG(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[3];
			array[0] = (byte)MPLCIAKAPGL;
			array[0] = (byte)OHMAEGCHIOC;
			OnlineManager.SendRPC(photonView, "Unlocked at Tavern Reputation {0}", (RpcTarget)1, array);
		}
	}
}
