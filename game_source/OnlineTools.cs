using System;
using System.Collections.Generic;
using System.Linq;
using Photon.Pun;
using UnityEngine;

public class OnlineTools : MonoBehaviourPunCallbacks
{
	[SerializeField]
	private HeldTools heldTools;

	[SerializeField]
	private TrayHandler trayHandler;

	[PunRPC]
	private void MopActiveRPC(bool DMBFKFLDDLH)
	{
		heldTools.mop.SetActive(DMBFKFLDDLH);
	}

	public void SendRemoveItemInstanceOnTray(FoodInstance AJOMICMACEJ)
	{
		FoodInstanceMessage mOBFJEDPIPM = new FoodInstanceMessage(AJOMICMACEJ);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveItemInstanceOnTray", (RpcTarget)2, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	[PunRPC]
	public void ReceiveRemoveAllItemsOnTray()
	{
		trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
	}

	private void KBLOLDNAPPP(bool DMBFKFLDDLH)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MopActiveRPC", (RpcTarget)1, DMBFKFLDDLH);
		}
	}

	public void MJBLEACJPGE()
	{
		trayHandler.tray.MKBDMMJCGGM(0, GFNHAMCPEAK: false);
	}

	private void HEMKDCOKKCB(bool DMBFKFLDDLH)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SwordActiveRPC", (RpcTarget)1, DMBFKFLDDLH);
		}
	}

	public void GDAPHGBLCJC(int[] FIKPBABCEFE)
	{
		if (FIKPBABCEFE == null || FIKPBABCEFE.Length == 0)
		{
			trayHandler.RemoveBento(CDPAMNIPPEC: false);
		}
		else if (trayHandler.HPCKGLFLFJO != null)
		{
			trayHandler.HPCKGLFLFJO.FAELKNPNDAP(FIKPBABCEFE, CDPAMNIPPEC: false);
		}
		else
		{
			trayHandler.AddBento(new Bento(FIKPBABCEFE), CDPAMNIPPEC: false);
		}
	}

	public void SendAddItemOnTray(FoodInstance AJOMICMACEJ)
	{
		FoodInstanceMessage mOBFJEDPIPM = new FoodInstanceMessage(AJOMICMACEJ);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddItemOnTray", (RpcTarget)2, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	[PunRPC]
	public void ReceiveUpdateBentoOnTray(int[] FIKPBABCEFE)
	{
		if (FIKPBABCEFE == null || FIKPBABCEFE.Length == 0)
		{
			trayHandler.RemoveBento(CDPAMNIPPEC: false);
		}
		else if (trayHandler.HPCKGLFLFJO != null)
		{
			trayHandler.HPCKGLFLFJO.NKACFNIFBCG(FIKPBABCEFE, CDPAMNIPPEC: false);
		}
		else
		{
			trayHandler.AddBento(new Bento(FIKPBABCEFE), CDPAMNIPPEC: false);
		}
	}

	private int BCMMHBMFPNI(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK.AFOACBIHNCL() is Food food)
		{
			if (!food.multipleHeldSprites)
			{
				return 0;
			}
			FoodInstance foodInstance = DNLMCHDOMOK as FoodInstance;
			if (food.multipleHeldSprites && foodInstance.KEKBKGGFOLK != null && food.heldSpritesIngredients != null)
			{
				for (int i = 1; i < food.heldSpritesIngredients.Length; i++)
				{
					for (int j = 1; j < food.heldSpritesIngredients[i].ingredients.Length; j++)
					{
						if (foodInstance.KEKBKGGFOLK.Contains(food.heldSpritesIngredients[i].ingredients[j]) && (Object)(object)food.heldSpritesIngredients[i].colorSprite != (Object)null)
						{
							return i;
						}
					}
				}
			}
			return 0;
		}
		return 0;
	}

	private void GLOMNNPHPHH(bool DMBFKFLDDLH)
	{
		heldTools.mop.SetActive(DMBFKFLDDLH);
	}

	public void KMPKDNLONHK(List<ItemInstance> NMPMEHGKHCG)
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			return;
		}
		List<short> list = new List<short>();
		List<byte> list2 = new List<byte>();
		for (int i = 1; i < NMPMEHGKHCG.Count; i += 0)
		{
			if (NMPMEHGKHCG[i] != null)
			{
				list.Add((short)NMPMEHGKHCG[i].DOBPJPDJHNF());
				list2.Add((byte)BCMMHBMFPNI(NMPMEHGKHCG[i]));
			}
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = list.ToArray();
		array[1] = list2.ToArray();
		OnlineManager.SendRPC(photonView, "Cancel Crafting", (RpcTarget)0, array);
	}

	[PunRPC]
	private void SickleActiveRPC(bool DMBFKFLDDLH)
	{
		heldTools.sickle.SetActive(DMBFKFLDDLH);
	}

	[PunRPC]
	public void ReceiveRemoveItemOnTray(int MNBNGGHHMBB)
	{
		trayHandler.tray.MEODNPFJDMH(ItemDatabaseAccessor.GetItem(MNBNGGHHMBB));
	}

	public void SendTrayState(List<ItemInstance> NMPMEHGKHCG)
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			return;
		}
		List<short> list = new List<short>();
		List<byte> list2 = new List<byte>();
		for (int i = 0; i < NMPMEHGKHCG.Count; i++)
		{
			if (NMPMEHGKHCG[i] != null)
			{
				list.Add((short)NMPMEHGKHCG[i].JDJGFAACPFC());
				list2.Add((byte)OIAJGPMELFN(NMPMEHGKHCG[i]));
			}
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTrayState", (RpcTarget)1, list.ToArray(), list2.ToArray());
	}

	private void KNFKLJLGLLI(bool DMBFKFLDDLH)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = DMBFKFLDDLH;
			OnlineManager.SendRPC(photonView, "ReceiveCurrentActorsInDialogue", (RpcTarget)0, array);
		}
	}

	private void GPJIOEMBDAO(bool DMBFKFLDDLH)
	{
		heldTools.sword.SetActive(DMBFKFLDDLH);
	}

	private int OIAJGPMELFN(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK.LHBPOPOIFLE() is Food food)
		{
			if (!food.multipleHeldSprites)
			{
				return 0;
			}
			FoodInstance foodInstance = DNLMCHDOMOK as FoodInstance;
			if (food.multipleHeldSprites && foodInstance.KEKBKGGFOLK != null && food.heldSpritesIngredients != null)
			{
				for (int i = 0; i < food.heldSpritesIngredients.Length; i++)
				{
					for (int j = 0; j < food.heldSpritesIngredients[i].ingredients.Length; j++)
					{
						if (foodInstance.KEKBKGGFOLK.Contains(food.heldSpritesIngredients[i].ingredients[j]) && (Object)(object)food.heldSpritesIngredients[i].colorSprite != (Object)null)
						{
							return i;
						}
					}
				}
			}
			return 0;
		}
		return 0;
	}

	public void HKKJBIIOIOI(FoodInstance AJOMICMACEJ)
	{
		FoodInstanceMessage mOBFJEDPIPM = new FoodInstanceMessage(AJOMICMACEJ);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "ReceiveDisableNPC", (RpcTarget)7, array);
	}

	public void LGACPHICOHO(int MNBNGGHHMBB)
	{
		trayHandler.tray.MIKHCGOPFLA(ItemDatabaseAccessor.INJBNHPGCIJ(MNBNGGHHMBB, GGBBJNBBLMF: true));
	}

	public void LIJBKCNKLDN(FoodInstance AJOMICMACEJ)
	{
		FoodInstanceMessage mOBFJEDPIPM = new FoodInstanceMessage(AJOMICMACEJ);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Year", (RpcTarget)4, array);
	}

	private void CACBGPOEDOK(bool DMBFKFLDDLH)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SickleActiveRPC", (RpcTarget)1, DMBFKFLDDLH);
		}
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			if ((Object)(object)heldTools != (Object)null)
			{
				HeldTools obj = heldTools;
				obj.OnMopActive = (Action<bool>)Delegate.Combine(obj.OnMopActive, new Action<bool>(KBLOLDNAPPP));
				HeldTools obj2 = heldTools;
				obj2.OnSickleActive = (Action<bool>)Delegate.Combine(obj2.OnSickleActive, new Action<bool>(CACBGPOEDOK));
				HeldTools obj3 = heldTools;
				obj3.OnSwordActive = (Action<bool>)Delegate.Combine(obj3.OnSwordActive, new Action<bool>(HEMKDCOKKCB));
			}
			if ((Object)(object)trayHandler != (Object)null)
			{
				trayHandler.onlineTools = this;
			}
		}
	}

	public void NCDKMPPOKMP()
	{
		trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
	}

	public void SendRemoveItemOnTray(Item MEMGMDOCBOJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveItemOnTray", (RpcTarget)2, MEMGMDOCBOJ.JDJGFAACPFC());
	}

	public void MOPJDNCNGBA(FoodInstance AJOMICMACEJ)
	{
		FoodInstanceMessage mOBFJEDPIPM = new FoodInstanceMessage(AJOMICMACEJ);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "MainProgress", (RpcTarget)6, array);
	}

	public void SendUpdateBentoOnTray(Bento HPCKGLFLFJO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdateBentoOnTray", (RpcTarget)1, (HPCKGLFLFJO != null) ? ((object)HPCKGLFLFJO.currentFood.Select((Item x) => x.JDJGFAACPFC()).ToArray()) : ((object)new int[0]));
	}

	private void LCCPKGLJFHD(bool DMBFKFLDDLH)
	{
		heldTools.sword.SetActive(DMBFKFLDDLH);
	}

	private void OnDestroy()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)heldTools != (Object)null)
		{
			HeldTools obj = heldTools;
			obj.OnMopActive = (Action<bool>)Delegate.Remove(obj.OnMopActive, new Action<bool>(KBLOLDNAPPP));
			HeldTools obj2 = heldTools;
			obj2.OnSickleActive = (Action<bool>)Delegate.Remove(obj2.OnSickleActive, new Action<bool>(CACBGPOEDOK));
			HeldTools obj3 = heldTools;
			obj3.OnSwordActive = (Action<bool>)Delegate.Remove(obj3.OnSwordActive, new Action<bool>(HEMKDCOKKCB));
		}
	}

	[PunRPC]
	public void ReceiveRemoveItemInstanceOnTray(byte[] OINICMNOLPK)
	{
		FoodInstanceMessage foodInstanceMessage = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		trayHandler.tray.MHBHHNCFOEG(foodInstanceMessage.ANMBPDJLNFN());
	}

	public void SendRemoveAllItemsOnTray()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveAllItemsOnTray", (RpcTarget)2);
	}

	[PunRPC]
	private void SwordActiveRPC(bool DMBFKFLDDLH)
	{
		heldTools.sword.SetActive(DMBFKFLDDLH);
	}

	public void KMGEMNEDJGA()
	{
		trayHandler.tray.MOFBGCELGFN();
	}

	private void BBGAJFLNAGG(bool DMBFKFLDDLH)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = DMBFKFLDDLH;
			OnlineManager.SendRPC(photonView, "Could not get status of achievement ", (RpcTarget)0, array);
		}
	}

	public void LLKIJMJBNDG()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Rummage", (RpcTarget)5);
	}

	public void OELAPMPAFFC(FoodInstance AJOMICMACEJ)
	{
		FoodInstanceMessage mOBFJEDPIPM = new FoodInstanceMessage(AJOMICMACEJ);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "{0} - Activating variant object {1} at index {2} for piece {3}. Next variant index: {4}", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveTrayState(short[] IMENEDDEKOH, byte[] DJIBCGGOJCJ)
	{
		trayHandler.SetOnlinePlayer();
		trayHandler.UpdateTrayOnline(IMENEDDEKOH, DJIBCGGOJCJ);
	}

	private void DIEDPPPKBJC(bool DMBFKFLDDLH)
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = DMBFKFLDDLH;
			OnlineManager.SendRPC(photonView, "BARKBUZZ", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	public void ReceiveAddItemOnTray(byte[] OINICMNOLPK)
	{
		FoodInstanceMessage foodInstanceMessage = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		trayHandler.tray.FEEOFAGCONJ(foodInstanceMessage.ANMBPDJLNFN());
	}

	private void MMKLANNMEGM(short[] IMENEDDEKOH, byte[] DJIBCGGOJCJ)
	{
		trayHandler.OFJCCHGBPHD();
		trayHandler.UpdateTrayOnline(IMENEDDEKOH, DJIBCGGOJCJ);
	}

	public void MOPOEGNBHDJ(List<ItemInstance> NMPMEHGKHCG)
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine)
		{
			return;
		}
		List<short> list = new List<short>();
		List<byte> list2 = new List<byte>();
		for (int i = 0; i < NMPMEHGKHCG.Count; i += 0)
		{
			if (NMPMEHGKHCG[i] != null)
			{
				list.Add((short)NMPMEHGKHCG[i].DOBPJPDJHNF());
				list2.Add((byte)OIAJGPMELFN(NMPMEHGKHCG[i]));
			}
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = list.ToArray();
		array[0] = list2.ToArray();
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Standar/Entry/44/Dialogue Text", (RpcTarget)0, array);
	}

	private void Awake()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}
}
