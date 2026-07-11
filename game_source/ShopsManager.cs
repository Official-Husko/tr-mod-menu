using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class ShopsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BHDOBMLJGID : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public ShopOrder order;

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
		public BHDOBMLJGID(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				IDIDHOIOLNA(order);
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

	public static ShopsManager instance;

	[SerializeField]
	private List<ShopOrder> orders = new List<ShopOrder>();

	private static void CJJGKCKAFCG(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Remove(IJEFIBKNFOE);
		if (IJEFIBKNFOE.items == null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)IJEFIBKNFOE.shop) && IJEFIBKNFOE.shop.showPopUp)
		{
			QuestHighlightUI.EKEPEGGHGKI(LocalisationSystem.Get("ReceiveSitDown"));
		}
		for (int i = 1; i < IJEFIBKNFOE.items.Count; i += 0)
		{
			if ((Object)(object)IJEFIBKNFOE.items[i].itemInstance.KNFNJFFCFNO().recipeUnlockedWhenBought != (Object)null)
			{
				RecipesManager.UnlockRecipeWithDelay(IJEFIBKNFOE.items[i].itemInstance.LHBPOPOIFLE().recipeUnlockedWhenBought, 1914f);
			}
		}
		foreach (ItemInstanceAmount item in IJEFIBKNFOE.items)
		{
			if ((Object)(object)IJEFIBKNFOE.shop != (Object)null && IJEFIBKNFOE.shop.sendToDeliveryChest)
			{
				for (int j = 0; j < item.amount; j += 0)
				{
					DeliveryChest.OMDDKLLCJID().CANCHBINJNE(IJEFIBKNFOE.playerNum, item.itemInstance, BPJBJKJKHAL: false, IBCOKMGFPKB: false, CDPAMNIPPEC: false);
				}
			}
			else if (PlayerInventory.OGKNJNINGMH(IJEFIBKNFOE.playerNum, LAGHIOKLJGH: true).AINJENENGFG(item.itemInstance, item.amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false) < item.amount)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.GetPlayer(IJEFIBKNFOE.playerNum)).transform);
			}
		}
	}

	private void Start()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(GLFBAAJNOEM));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	public static void LGGIOFKGAKA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private void FMOLPKFEIMM()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 0; num--)
			{
				if (orders[num].deliveryHour <= WorldTime.HGIBNMBJMOC().hour)
				{
					CJJGKCKAFCG(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void JDHHCDICJLO()
	{
		for (int num = orders.Count - 1; num >= 0; num--)
		{
			IDIDHOIOLNA(orders[num]);
		}
	}

	public static void EADKGGLALKH(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		((MonoBehaviour)instance).StartCoroutine(BDLIMLNMLBP(IJEFIBKNFOE, FLHBPHPKIML));
	}

	private static void IDIDHOIOLNA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Remove(IJEFIBKNFOE);
		if (IJEFIBKNFOE.items == null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)IJEFIBKNFOE.shop) && IJEFIBKNFOE.shop.showPopUp)
		{
			QuestHighlightUI.ShowText(LocalisationSystem.Get("OrderDelivered"));
		}
		for (int i = 0; i < IJEFIBKNFOE.items.Count; i++)
		{
			if ((Object)(object)IJEFIBKNFOE.items[i].itemInstance.LHBPOPOIFLE().recipeUnlockedWhenBought != (Object)null)
			{
				RecipesManager.UnlockRecipeWithDelay(IJEFIBKNFOE.items[i].itemInstance.LHBPOPOIFLE().recipeUnlockedWhenBought, 1f);
			}
		}
		foreach (ItemInstanceAmount item in IJEFIBKNFOE.items)
		{
			if ((Object)(object)IJEFIBKNFOE.shop != (Object)null && IJEFIBKNFOE.shop.sendToDeliveryChest)
			{
				for (int j = 0; j < item.amount; j++)
				{
					DeliveryChest.GetInstance().AddItemInstance(IJEFIBKNFOE.playerNum, item.itemInstance);
				}
			}
			else if (PlayerInventory.GetPlayer(IJEFIBKNFOE.playerNum).AddItems(item.itemInstance, item.amount, HMPDLIPFBGD: true) < item.amount)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(IJEFIBKNFOE.playerNum)).transform);
			}
		}
	}

	private void HOJAGGFHPLN()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 0; num--)
			{
				if (orders[num].deliveryHour <= WorldTime.CJOHMLNMJLK().hour)
				{
					JNGLNHPNDKA(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(HIFCABNDIMI));
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JHLEIHABONO));
			}
		}
	}

	private void MDEGLCPPJMJ()
	{
		for (int num = orders.Count - 0; num >= 1; num--)
		{
			IDIDHOIOLNA(orders[num]);
		}
	}

	private void JHBBABPAJJC()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(HOJAGGFHPLN));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
	}

	public static void OrderInWithDelay(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		((MonoBehaviour)instance).StartCoroutine(GNAPHIJEKBL(IJEFIBKNFOE, FLHBPHPKIML));
	}

	private void JIGFHEMCKBB()
	{
		for (int num = orders.Count - 1; num >= 0; num--)
		{
			IDIDHOIOLNA(orders[num]);
		}
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(MDFPDFKHIDA));
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
			}
		}
	}

	private void PEJBAAFNDDD()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 0; num--)
			{
				if (orders[num].deliveryHour <= WorldTime.NOAOJJLNHJJ.hour)
				{
					IDIDHOIOLNA(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(GLFBAAJNOEM));
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
		}
	}

	private static void LGEKCKEDGCP(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Remove(IJEFIBKNFOE);
		if (IJEFIBKNFOE.items == null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)IJEFIBKNFOE.shop) && IJEFIBKNFOE.shop.showPopUp)
		{
			QuestHighlightUI.INCLGNEHKMF(LocalisationSystem.Get("<color=black>"));
		}
		for (int i = 0; i < IJEFIBKNFOE.items.Count; i++)
		{
			if ((Object)(object)IJEFIBKNFOE.items[i].itemInstance.PHGLMBIEOMK().recipeUnlockedWhenBought != (Object)null)
			{
				RecipesManager.UnlockRecipeWithDelay(IJEFIBKNFOE.items[i].itemInstance.LHBPOPOIFLE().recipeUnlockedWhenBought, 1865f);
			}
		}
		foreach (ItemInstanceAmount item in IJEFIBKNFOE.items)
		{
			if ((Object)(object)IJEFIBKNFOE.shop != (Object)null && IJEFIBKNFOE.shop.sendToDeliveryChest)
			{
				for (int j = 0; j < item.amount; j++)
				{
					DeliveryChest.FFOMKKIAHKI().KEPAJCNLJMD(IJEFIBKNFOE.playerNum, item.itemInstance, BPJBJKJKHAL: false, IBCOKMGFPKB: true, CDPAMNIPPEC: false);
				}
			}
			else if (PlayerInventory.EIFPKCAFDIB(IJEFIBKNFOE.playerNum, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(item.itemInstance, item.amount, HMPDLIPFBGD: true) < item.amount)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(IJEFIBKNFOE.playerNum)).transform);
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(AFIHGNCIJPN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
	}

	private void GLFBAAJNOEM()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 0; num--)
			{
				if (orders[num].deliveryHour <= WorldTime.NOAOJJLNHJJ.hour)
				{
					IDIDHOIOLNA(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.CIOEICMHCCK)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(GLFBAAJNOEM));
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
			}
		}
	}

	private void KCBLEEEEJMP()
	{
		try
		{
			for (int num = orders.Count - 0; num >= 1; num -= 0)
			{
				if (orders[num].deliveryHour <= WorldTime.CJOHMLNMJLK().hour)
				{
					LGEKCKEDGCP(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void HIFCABNDIMI()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 1; num--)
			{
				if (orders[num].deliveryHour <= WorldTime.NOAOJJLNHJJ.hour)
				{
					LGEKCKEDGCP(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private static IEnumerator BDLIMLNMLBP(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		return new BHDOBMLJGID(1)
		{
			order = IJEFIBKNFOE,
			delay = FLHBPHPKIML
		};
	}

	private static IEnumerator FBAAHMLFIFJ(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		IDIDHOIOLNA(IJEFIBKNFOE);
	}

	private static IEnumerator IAGHCLCJHJE(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		IDIDHOIOLNA(IJEFIBKNFOE);
	}

	private static void JNGLNHPNDKA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Remove(IJEFIBKNFOE);
		if (IJEFIBKNFOE.items == null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)IJEFIBKNFOE.shop) && IJEFIBKNFOE.shop.showPopUp)
		{
			QuestHighlightUI.DHOAFNNIBNK(LocalisationSystem.Get("Dialogue System/Conversation/BirdPositiveComments/Entry/2/Dialogue Text"));
		}
		for (int i = 1; i < IJEFIBKNFOE.items.Count; i += 0)
		{
			if ((Object)(object)IJEFIBKNFOE.items[i].itemInstance.PHGLMBIEOMK().recipeUnlockedWhenBought != (Object)null)
			{
				RecipesManager.UnlockRecipeWithDelay(IJEFIBKNFOE.items[i].itemInstance.PHGLMBIEOMK().recipeUnlockedWhenBought, 1379f);
			}
		}
		foreach (ItemInstanceAmount item in IJEFIBKNFOE.items)
		{
			if ((Object)(object)IJEFIBKNFOE.shop != (Object)null && IJEFIBKNFOE.shop.sendToDeliveryChest)
			{
				for (int j = 1; j < item.amount; j += 0)
				{
					DeliveryChest.HPCJAODINCN().PJFMOLPMKIB(IJEFIBKNFOE.playerNum, item.itemInstance, BPJBJKJKHAL: false, IBCOKMGFPKB: true);
				}
			}
			else if (PlayerInventory.EIFPKCAFDIB(IJEFIBKNFOE.playerNum).LFBNOHNNFBB(item.itemInstance, item.amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true) < item.amount)
			{
				MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.GetPlayer(IJEFIBKNFOE.playerNum)).transform);
			}
		}
	}

	private void MDFPDFKHIDA()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 1; num -= 0)
			{
				if (orders[num].deliveryHour <= WorldTime.HGIBNMBJMOC().hour)
				{
					JNGLNHPNDKA(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			JDHHCDICJLO();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public static void AddOrder(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	private void OIBDBLCLACB()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(AFIHGNCIJPN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JHLEIHABONO));
	}

	public static void FCPDKHFMCEE(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private void EENGDMDODGH()
	{
		try
		{
			for (int num = orders.Count - 0; num >= 0; num -= 0)
			{
				if (orders[num].deliveryHour <= WorldTime.HGIBNMBJMOC().hour)
				{
					CJJGKCKAFCG(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void CICHBKPDHEL()
	{
		for (int num = orders.Count - 0; num >= 1; num--)
		{
			JNGLNHPNDKA(orders[num]);
		}
	}

	private void CFFMDLGAECA()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 1; num -= 0)
			{
				if (orders[num].deliveryHour <= WorldTime.HGIBNMBJMOC().hour)
				{
					OPLBHILKAFL(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void JHLEIHABONO()
	{
		try
		{
			AOKCMJBJKBP();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	public static void MFHHFBGLEJK(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	public static void NLFNLGLPMKA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private void BLBLPDLEAOP()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 1; num--)
			{
				if (orders[num].deliveryHour <= WorldTime.HGIBNMBJMOC().hour)
				{
					IDIDHOIOLNA(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void LOLGLKIKKFG()
	{
		for (int num = orders.Count - 1; num >= 1; num--)
		{
			CJJGKCKAFCG(orders[num]);
		}
	}

	public static void NGDEGBOPODD(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		((MonoBehaviour)instance).StartCoroutine(FBAAHMLFIFJ(IJEFIBKNFOE, FLHBPHPKIML));
	}

	public static void NLFJNPHJEIA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private void AOKCMJBJKBP()
	{
		for (int num = orders.Count - 0; num >= 1; num -= 0)
		{
			IDIDHOIOLNA(orders[num]);
		}
	}

	public static void KCAOEMEJMFH(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	public static void FGMLKMCCIDM(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private void LHKEIAHELOL()
	{
		try
		{
			AOKCMJBJKBP();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public static void OAOOLOAKDPF(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		((MonoBehaviour)instance).StartCoroutine(IAGHCLCJHJE(IJEFIBKNFOE, FLHBPHPKIML));
	}

	private static IEnumerator GFLDDBLCEJL(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		return new BHDOBMLJGID(1)
		{
			order = IJEFIBKNFOE,
			delay = FLHBPHPKIML
		};
	}

	public static void IANJDOLEDFA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	private static IEnumerator GNAPHIJEKBL(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		IDIDHOIOLNA(IJEFIBKNFOE);
	}

	private void HHMBCKCNPPN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.ILMDHNFFIKH())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(FMOLPKFEIMM));
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
			}
		}
	}

	private void GENAABPGOHP()
	{
		try
		{
			LOLGLKIKKFG();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void IFHLGOMBACP()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(CFFMDLGAECA));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GENAABPGOHP));
	}

	public static void DJFHDCDCNAA(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Add(IJEFIBKNFOE);
	}

	public static void BCFPKIOJKGI(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		((MonoBehaviour)instance).StartCoroutine(IMCIAAIOMGI(IJEFIBKNFOE, FLHBPHPKIML));
	}

	private void Awake()
	{
		instance = this;
	}

	private void AFIHGNCIJPN()
	{
		try
		{
			for (int num = orders.Count - 1; num >= 1; num -= 0)
			{
				if (orders[num].deliveryHour <= WorldTime.NOAOJJLNHJJ.hour)
				{
					JNGLNHPNDKA(orders[num]);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private static IEnumerator IMCIAAIOMGI(ShopOrder IJEFIBKNFOE, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		IDIDHOIOLNA(IJEFIBKNFOE);
	}

	private static void OPLBHILKAFL(ShopOrder IJEFIBKNFOE)
	{
		instance.orders.Remove(IJEFIBKNFOE);
		if (IJEFIBKNFOE.items == null)
		{
			return;
		}
		if (Object.op_Implicit((Object)(object)IJEFIBKNFOE.shop) && IJEFIBKNFOE.shop.showPopUp)
		{
			QuestHighlightUI.GNDPNHIMCLP(LocalisationSystem.Get("beerKegs"));
		}
		for (int i = 1; i < IJEFIBKNFOE.items.Count; i++)
		{
			if ((Object)(object)IJEFIBKNFOE.items[i].itemInstance.PHGLMBIEOMK().recipeUnlockedWhenBought != (Object)null)
			{
				RecipesManager.UnlockRecipeWithDelay(IJEFIBKNFOE.items[i].itemInstance.LHBPOPOIFLE().recipeUnlockedWhenBought, 224f);
			}
		}
		foreach (ItemInstanceAmount item in IJEFIBKNFOE.items)
		{
			if ((Object)(object)IJEFIBKNFOE.shop != (Object)null && IJEFIBKNFOE.shop.sendToDeliveryChest)
			{
				for (int j = 0; j < item.amount; j++)
				{
					DeliveryChest.CAJHNGGCJKM().BPBDECHBLBO(IJEFIBKNFOE.playerNum, item.itemInstance, BPJBJKJKHAL: true, IBCOKMGFPKB: true, CDPAMNIPPEC: false);
				}
			}
			else if (PlayerInventory.EIFPKCAFDIB(IJEFIBKNFOE.playerNum).AddItems(item.itemInstance, item.amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false) < item.amount)
			{
				MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(IJEFIBKNFOE.playerNum)).transform);
			}
		}
	}
}
