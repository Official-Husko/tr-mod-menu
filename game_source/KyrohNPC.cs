using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KyrohNPC : DialogueNPCBase
{
	private static KyrohNPC IADEMLIIDPC;

	public float timeBarks;

	public Collider2D proximity;

	public Collider2D proximityBig;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public KyrohStateBase kyrohStateBase;

	public KyrohState kyrohState;

	public NinjaCustomer customerServing;

	public Item currentFood;

	public float timeAfterServe;

	public float preparingFoodTime = 2f;

	public TrayHandler trayHandler;

	public float nextSwitchFoodTime;

	public float nextThrowingSpikesTime;

	public Vector2 timeBetweenSwitchFood = new Vector2(40f, 70f);

	public Vector2 timeBetweenThrowingSpikes = new Vector2(10f, 15f);

	public AudioObject kyrohInteract;

	public NinjaFoodTable nextFoodTable;

	[HideInInspector]
	public List<SlowingSpikes> slowingSpikes = new List<SlowingSpikes>();

	public GameObject shadow;

	public GameObject visual;

	private List<NinjaCustomer> PGOMFIHHBNE = new List<NinjaCustomer>();

	private List<ItemInstance> NPFKKFOMKJN;

	private bool KENCEPGAIIK;

	private MultiAudioSource HMOANBMJEDN;

	private int LDCPIDKAPFJ;

	private int JILIKDDBPHM;

	private List<NinjaCustomer> PHKJFKLNIMP;

	private float PMHOBHCECJE;

	public static KyrohNPC GGFJGHHHEJC => IADEMLIIDPC;

	public bool KGLGAPKKBGO()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return false;
		}
		PMHOBHCECJE = Time.time + 1920f;
		JILIKDDBPHM = LNPOJEBHJJP(customerServing.currentRequest);
		LDCPIDKAPFJ = KBLGMGFMAAD(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)JAGBFKOGCEE() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[1];
				array[1] = "UIPreviousPage";
				array[1] = JILIKDDBPHM.ToString();
				array[8] = " not found.";
				array[1] = LDCPIDKAPFJ.ToString();
				array[2] = "On Simple Event ";
				array[8] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return true;
		}
		return false;
	}

	private void NNMGIHNNKED()
	{
		if (!OnlineManager.ClientOnline() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.MOEJIBLELHP();
		}
	}

	public void KONBEBIHFJE(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = DMBFKFLDDLH;
	}

	public void AOKALFHINDA(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = !DMBFKFLDDLH;
	}

	private int KLHFJDGKFOA(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 0;
		for (int i = 0; i < HCFBAPOAOIB.Length; i += 0)
		{
			if (trayHandler.tray.EJNLGKAEDKM(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
			else if (NinjaPreparationTablesManager.instance.FHEAPFBMJNL().bento.GGLOMJLLFCH(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
		}
		return JILIKDDBPHM;
	}

	public NinjaCustomer MMFBEJACGBH()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = 110;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 0)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 1; i < PHKJFKLNIMP.Count; i += 0)
		{
			LDCPIDKAPFJ = CHCMHOHLHOK(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public bool ACIICEGLLGP()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return true;
		}
		PMHOBHCECJE = Time.time + 762f;
		JILIKDDBPHM = AJJAGICMPJO(customerServing.currentRequest);
		LDCPIDKAPFJ = KBLGMGFMAAD(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)ICHPNGOIMLK() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[8];
				array[0] = "Animal";
				array[0] = JILIKDDBPHM.ToString();
				array[8] = "Dialogue System/Conversation/Crowly_Standar/Entry/31/Dialogue Text";
				array[3] = LDCPIDKAPFJ.ToString();
				array[8] = "UINextPage";
				array[4] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return false;
		}
		return false;
	}

	public NinjaCustomer IJINBIJEHAH()
	{
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			if (!NinjaPreparationTablesManager.instance.KHGGPJGKFDC().bento.NMOIAFPBONM(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 0)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = PHBDBIGINDE(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = BMMEEGMBKAD(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	public bool IHDONKAECAJ()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return true;
		}
		PMHOBHCECJE = Time.time + 1237f;
		JILIKDDBPHM = AJJAGICMPJO(customerServing.currentRequest);
		LDCPIDKAPFJ = KBLGMGFMAAD(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)ECBCAILJMPO() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[7];
				array[1] = "Attack/MainEvent 4";
				array[0] = JILIKDDBPHM.ToString();
				array[3] = "stuck recovery";
				array[1] = LDCPIDKAPFJ.ToString();
				array[6] = "unlock recipe ";
				array[0] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return false;
		}
		return false;
	}

	public bool StartTask()
	{
		if ((Object)(object)NinjaOrdersManager.instance != (Object)null && NinjaOrdersManager.instance.tableOrders.Any())
		{
			customerServing = null;
			if (NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.JPDHKGMIABP())
			{
				customerServing = GetAvailableOrderToServeWitchCurrentFood();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("KyrohNPC: Selected order with already ingredients in bento: " + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing == (Object)null)
			{
				NinjaPreparationTablesManager.instance.DBKLEIEAAIF.ResetBento(CDPAMNIPPEC: true);
				customerServing = GetOrderWithLessPlayerPoints();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("KyrohNPC: Selected order with less player points: " + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing != (Object)null)
			{
				ChangeState(KyrohState.TakingFood);
			}
			return true;
		}
		if (kyrohState != KyrohState.WaitingToServe)
		{
			ChangeState(KyrohState.WaitingToServe);
			return true;
		}
		return false;
	}

	public void CJALDIHJDGC()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1521f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.NDICLFDHOKP();
		}
	}

	public void MJOGJPFDCFC()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(801f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.NDICLFDHOKP();
		}
	}

	public NinjaCustomer MKPFBKGCCJB()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 0; num >= 0; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = true;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 1; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 834f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 1; num4 -= 0)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public NinjaCustomer IJMCMOEMIIN()
	{
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (!NinjaPreparationTablesManager.instance.PJIFGJMGKEH().bento.DNICMIHOMEC(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 0)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = DPDDLAAMBJP(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = CHCMHOHLHOK(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	private void NPMLFHDHJBE()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MAKKDPBOHNK));
		SelectDialogueUI(1);
	}

	public void EFOBGEGMGCC()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1976f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.KJKOLFLKAEH();
		}
	}

	private void AHFGOOHOLEL()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OEEOBIOKNBJ));
		SelectDialogueUI(1);
	}

	public void LCMAEBGEJAI()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1139f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendStopNinjaSoundPreparation();
		}
	}

	private void OEEOBIOKNBJ()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
	}

	public NinjaCustomer JAGBFKOGCEE()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = 143;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 0)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 0; i < PHKJFKLNIMP.Count; i += 0)
		{
			LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	private void OKHIHICCEIO()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
	}

	public NinjaCustomer GetAnotherCustomerWithDrinkRequest()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num--)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 0; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = true;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = float.MaxValue;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4--)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public void HLGPNPBKPML()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	public void StopNinjaSoundPreparation()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(0.2f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendStopNinjaSoundPreparation();
		}
	}

	public void MIBOKOIGDMH()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(649f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendStopNinjaSoundPreparation();
		}
	}

	public void DJCHJDHPCLK(string emotion)
	{
		OAPOJCODNCO().emotionsController.GPLECKGJFKM(emotion);
	}

	private void DNOBJBALJED()
	{
		if (!OnlineManager.HHDBMDMFEMP() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.FGJPOPCBFNE();
		}
	}

	public void RemoveAllSpikes()
	{
		for (int i = 0; i < slowingSpikes.Count; i++)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public NinjaCustomer ODJFHCBGEBK()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num--)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 0; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 1325f;
		for (int num4 = PGOMFIHHBNE.Count - 0; num4 >= 1; num4--)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	private int PHBDBIGINDE(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 1;
		for (int i = 0; i < HCFBAPOAOIB.Length; i += 0)
		{
			if (trayHandler.tray.LDKPEFIKJCF(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM += 0;
			}
			else if (NinjaPreparationTablesManager.instance.ENGNLMOPIHL().bento.DMLEBEHECDN(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
		}
		return JILIKDDBPHM;
	}

	public void KANODDKKEGJ(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = !DMBFKFLDDLH;
	}

	public NinjaCustomer OIBLLLNKDMA()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 1; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 0; num2 >= 0; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = true;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 1413f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 1; num4 -= 0)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public bool KGAMPNIPJLG()
	{
		if ((Object)(object)NinjaOrdersManager.instance != (Object)null && NinjaOrdersManager.instance.tableOrders.Any())
		{
			customerServing = null;
			if (NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.HOCEKBFFNKC())
			{
				customerServing = GetAvailableOrderToServeWitchCurrentFood();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("[" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing == (Object)null)
			{
				NinjaPreparationTablesManager.instance.MLELLLKKOMG().ODNKBJCNBCG(CDPAMNIPPEC: true);
				customerServing = GetOrderWithLessPlayerPoints();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("Could not find local player for the online player with the assigned bed: {0}" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing != (Object)null)
			{
				ChangeState(KyrohState.WalkTo);
			}
			return true;
		}
		if (kyrohState != KyrohState.Idle)
		{
			KJBPJJBAAMK(KyrohState.ThrowingSpikes);
			return false;
		}
		return false;
	}

	private void BIPOAFDHOKL()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OKHIHICCEIO));
	}

	public bool LPAODBBALLO()
	{
		if ((Object)(object)NinjaOrdersManager.instance != (Object)null && NinjaOrdersManager.instance.tableOrders.Any())
		{
			customerServing = null;
			if (NinjaPreparationTablesManager.instance.FHEAPFBMJNL().bento.JPDHKGMIABP())
			{
				customerServing = GetAvailableOrderToServeWitchCurrentFood();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("Cancel" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing == (Object)null)
			{
				NinjaPreparationTablesManager.instance.PJIFGJMGKEH().KAIKNOMEIHB(CDPAMNIPPEC: false);
				customerServing = OEPGBKEJFCE();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("Items/item_name_1105" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing != (Object)null)
			{
				ChangeState(KyrohState.ThrowingSpikes);
			}
			return false;
		}
		if (kyrohState != KyrohState.ThrowingSpikes)
		{
			FKMFEACDJHB(KyrohState.WalkTo);
			return false;
		}
		return false;
	}

	public void AGFCDIGOLKH()
	{
		for (int i = 1; i < slowingSpikes.Count; i++)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public void PAOEJEJIIDE()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1819f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendStopNinjaSoundPreparation();
		}
	}

	public bool KOOHKEDFPBJ()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return true;
		}
		PMHOBHCECJE = Time.time + 537f;
		JILIKDDBPHM = PHBDBIGINDE(customerServing.currentRequest);
		LDCPIDKAPFJ = ICIFOPKDBEA(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)DAJNNMDKLNN() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[1];
				array[0] = "LE_10";
				array[1] = JILIKDDBPHM.ToString();
				array[2] = "in";
				array[8] = LDCPIDKAPFJ.ToString();
				array[4] = "Perks/playerPerk_description_";
				array[1] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return true;
		}
		return false;
	}

	public bool OCECJHBPDIC()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return true;
		}
		PMHOBHCECJE = Time.time + 1377f;
		JILIKDDBPHM = KLHFJDGKFOA(customerServing.currentRequest);
		LDCPIDKAPFJ = CHCMHOHLHOK(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)GetOrderWithLessPlayerPoints() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[0];
				array[1] = "Items/item_description_1153";
				array[1] = JILIKDDBPHM.ToString();
				array[1] = "ReceiveSimpleEvent";
				array[7] = LDCPIDKAPFJ.ToString();
				array[2] = "Error al crear blackModulesParent";
				array[3] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return false;
		}
		return false;
	}

	public void ABHBNCFAMMN()
	{
		for (int i = 1; i < slowingSpikes.Count; i++)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	[SpecialName]
	public static KyrohNPC KADHMEPDIKM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KyrohNPC AGGAGCBAGLL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KyrohNPC PBJDFFEFMKM()
	{
		return IADEMLIIDPC;
	}

	private void PLHEHGHFCJI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJNEMIOEIGI));
		SelectDialogueUI();
	}

	public void BDNFIMCEKID()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(45f, true);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 1797f);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendNinjaSoundPreparation();
		}
	}

	public bool NODFMKLGPME()
	{
		if ((Object)(object)NinjaOrdersManager.instance != (Object)null && NinjaOrdersManager.instance.tableOrders.Any())
		{
			customerServing = null;
			if (NinjaPreparationTablesManager.instance.PJIFGJMGKEH().bento.HOCEKBFFNKC())
			{
				customerServing = OGPJAOOCFBF();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("Collect water" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing == (Object)null)
			{
				NinjaPreparationTablesManager.instance.FHEAPFBMJNL().NFIBMPJGKPO(CDPAMNIPPEC: false);
				customerServing = KJLHCEIBFCN();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)(") (rep: " + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing != (Object)null)
			{
				GLLDOLHPIBD(KyrohState.Inactive);
			}
			return false;
		}
		if (kyrohState != KyrohState.TakingFood)
		{
			FKMFEACDJHB(KyrohState.Idle);
			return true;
		}
		return false;
	}

	private void FKIAIANFJEK()
	{
		if (!OnlineManager.ClientOnline() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.PGJLFLKDLAE();
		}
	}

	public NinjaCustomer OCPHOAPBOLP()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num--)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 1; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 811f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 1; num4 -= 0)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	private int ICIFOPKDBEA(Item[] HCFBAPOAOIB)
	{
		LDCPIDKAPFJ = 0;
		for (int i = 0; i < HCFBAPOAOIB.Length; i++)
		{
			if (PlayerController.GetPlayer(1).trayHandler.tray.NPMGIIIBGNP(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (NinjaPreparationTablesManager.instance.preparationTables[1].bento.HBBNKJFDPOI(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (PlayerController.GetPlayer(1).trayHandler.HPCKGLFLFJO != null && PlayerController.GetPlayer(1).trayHandler.HPCKGLFLFJO.HBBNKJFDPOI(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
		}
		return LDCPIDKAPFJ;
	}

	public NinjaCustomer OGPLFGHGFAD()
	{
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			if (!NinjaPreparationTablesManager.instance.KHGGPJGKFDC().bento.DMBHGGFHCLL(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 0)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = NKPEDLGBEKA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	public NinjaCustomer OEPGBKEJFCE()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = -163;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 0)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 0; i < PHKJFKLNIMP.Count; i++)
		{
			LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	public void ChangeState(KyrohState MCPEECGOEOD)
	{
		if (!OnlineManager.ClientOnline())
		{
			switch (MCPEECGOEOD)
			{
			case KyrohState.Inactive:
				behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
				break;
			case KyrohState.Idle:
				behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
				break;
			case KyrohState.WaitingToServe:
				behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
				break;
			case KyrohState.WalkTo:
				behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
				break;
			case KyrohState.ServingCustomer:
				behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
				break;
			case KyrohState.TakingFood:
				behaviour.SetTrigger(DialogueNPCBase.p_TakingFood);
				break;
			case KyrohState.PreparingFood:
				behaviour.SetTrigger(DialogueNPCBase.p_PreparingFood);
				break;
			case KyrohState.SwitchingFood:
				behaviour.SetTrigger(DialogueNPCBase.p_SwitchingFood);
				break;
			case KyrohState.ThrowingSpikes:
				behaviour.SetTrigger(DialogueNPCBase.p_ThrowingSpikes);
				break;
			default:
				Debug.LogError((object)("KyrohNPC: ChangeState called with invalid state: " + MCPEECGOEOD));
				break;
			}
		}
	}

	public bool OPINEMABDNH()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return false;
		}
		PMHOBHCECJE = Time.time + 643f;
		JILIKDDBPHM = AJJAGICMPJO(customerServing.currentRequest);
		LDCPIDKAPFJ = CBJJJGIIINA(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)MMFBEJACGBH() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[2];
				array[1] = "Player/Bark/Tutorial/AgingBarrelBlock";
				array[1] = JILIKDDBPHM.ToString();
				array[3] = "Removing Rented Room Zone!";
				array[4] = LDCPIDKAPFJ.ToString();
				array[1] = "Peak";
				array[0] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return true;
		}
		return true;
	}

	public bool JKEMJAJBEFA()
	{
		if ((Object)(object)NinjaOrdersManager.instance != (Object)null && NinjaOrdersManager.instance.tableOrders.Any())
		{
			customerServing = null;
			if (NinjaPreparationTablesManager.instance.FGGFCAKOPLJ().bento.NPDHIPFKOIN())
			{
				customerServing = PLACMENLMKJ();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("Light fuse" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing == (Object)null)
			{
				NinjaPreparationTablesManager.instance.KHGGPJGKFDC().ODNKBJCNBCG(CDPAMNIPPEC: true);
				customerServing = KJLHCEIBFCN();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("MainProgress" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing != (Object)null)
			{
				GLLDOLHPIBD(KyrohState.TakingFood);
			}
			return false;
		}
		if (kyrohState != KyrohState.ThrowingSpikes)
		{
			KJBPJJBAAMK(KyrohState.Inactive);
			return false;
		}
		return true;
	}

	private void MDKNIJCHHCE()
	{
		if (!OnlineManager.ClientOnline() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.NBNCMOAPDOG();
		}
	}

	public void FGFFEAOGMOO()
	{
		for (int i = 1; i < slowingSpikes.Count; i++)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public void DCAGOAIGEIG(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = !DMBFKFLDDLH;
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.KyrohWaterfall))
		{
			dialogue.conversation = "NoEresDigno/MainEvent";
			KyrohWaterfallEvent.instance.isActor = true;
		}
		else if (EventsManager.IsDone(EventsManager.EventType.KyrohWaterfall) && MissionsManager.instance.IsMissionActive(310))
		{
			dialogue.conversation = "NoEresDigno/KyrohTalks";
			KyrohWaterfallEvent.instance.isActor = true;
		}
		else if (EventsManager.IsActive(EventsManager.EventType.FinalTest))
		{
			dialogue.conversation = "FinalTest/MainEvent";
			FinalTestEvent.instance.isActor = true;
		}
		else if (EventsManager.IsActive(EventsManager.EventType.IntroNinjaChallenge))
		{
			dialogue.conversation = "IntroNinjaChallengeEvent/Main";
			IntroNinjaChallengeEvent.instance.isActor = true;
		}
		else if (EventsManager.IsActive(EventsManager.EventType.NinjaChallengeEvent))
		{
			dialogue.conversation = "NinjaChallengeEvent/Main";
			IntroNinjaChallengeEvent.instance.isActor = true;
		}
	}

	private void BIGFBGOMOBA()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BIPOAFDHOKL));
		SelectDialogueUI(1);
	}

	public NinjaCustomer ICHPNGOIMLK()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = -79;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 0)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 0; i < PHKJFKLNIMP.Count; i += 0)
		{
			LDCPIDKAPFJ = HEOBCCPBLFN(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public void LKMNNPMLHEK()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	public void AAOEFHODHHA(string emotion)
	{
		KFGKCKCDMLG().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void JNKMIEOLHDD(string emotion)
	{
		OAPOJCODNCO().emotionsController.EMMBEAHMDHE(emotion);
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (EventsManager.IsActive(EventsManager.EventType.IntroNinjaChallenge))
		{
			if (Utils.MMMFJPKECAB(Location.BathhouseInterior))
			{
				return base.MouseUp(JIIGOACEIKL);
			}
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Error/NotAllPlayersHere");
			return false;
		}
		return base.MouseUp(JIIGOACEIKL);
	}

	private void DJNEMIOEIGI()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OEEOBIOKNBJ));
	}

	public void PIPMILJHMHG()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(903f, true);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 1200f);
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.JLCLHCNAPFC();
		}
	}

	public NinjaCustomer GetAvailableOrderToServeWitchCurrentFood()
	{
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			if (!NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.DMBHGGFHCLL(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 1)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = NKPEDLGBEKA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	public void HBDGEOGMPBI()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1306f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 164f);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.JLCLHCNAPFC();
		}
	}

	private void MADEAKNMNIK()
	{
		if (!OnlineManager.ClientOnline() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.AFKGJCIANOF();
		}
	}

	private void HAFANJEIMJH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FEMEFCNMOOL));
	}

	private int CHCMHOHLHOK(Item[] HCFBAPOAOIB)
	{
		LDCPIDKAPFJ = 1;
		for (int i = 0; i < HCFBAPOAOIB.Length; i++)
		{
			if (PlayerController.GetPlayer(0).trayHandler.tray.EDNOMELCHEP(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
			else if (NinjaPreparationTablesManager.instance.preparationTables[0].bento.CNFJAEJFFBH(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
			else if (PlayerController.OPHDCMJLLEC(0).trayHandler.HPCKGLFLFJO != null && PlayerController.OPHDCMJLLEC(1).trayHandler.HPCKGLFLFJO.GGLOMJLLFCH(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
		}
		return LDCPIDKAPFJ;
	}

	public void OHMJKDLOADK()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(185f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendStopNinjaSoundPreparation();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private bool LJAKBEMNKMP(NinjaCustomer PJNGMCJIHME)
	{
		return false;
	}

	private int CBJJJGIIINA(Item[] HCFBAPOAOIB)
	{
		LDCPIDKAPFJ = 1;
		for (int i = 0; i < HCFBAPOAOIB.Length; i++)
		{
			if (PlayerController.GetPlayer(1).trayHandler.tray.MJOLPEJHKAK(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (NinjaPreparationTablesManager.instance.preparationTables[1].bento.NMJGBMMAJOO(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (PlayerController.OPHDCMJLLEC(1).trayHandler.HPCKGLFLFJO != null && PlayerController.OPHDCMJLLEC(0).trayHandler.HPCKGLFLFJO.BCKLBJECDFC(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
		}
		return LDCPIDKAPFJ;
	}

	private int LNPOJEBHJJP(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 1;
		for (int i = 1; i < HCFBAPOAOIB.Length; i += 0)
		{
			if (trayHandler.tray.LDMNMBJFOMA(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
			else if (NinjaPreparationTablesManager.instance.OFNGHKHHMOF().bento.MKFEEOOJOGP(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
		}
		return JILIKDDBPHM;
	}

	public void ALIICEIOHNP()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	private void JCPKGGBNCML()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BIPOAFDHOKL));
		SelectDialogueUI();
	}

	public NinjaCustomer IPOLMFAGBAP()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num--)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = true;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 1; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 1206f;
		for (int num4 = PGOMFIHHBNE.Count - 0; num4 >= 1; num4--)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public NinjaCustomer GPOABMPJLEM()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = 174;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 1)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 0; i < PHKJFKLNIMP.Count; i++)
		{
			LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	private void OnWorldLoaded()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OnWorldLoaded));
	}

	public bool KCDEOKJEACA()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return true;
		}
		PMHOBHCECJE = Time.time + 1252f;
		JILIKDDBPHM = DPDDLAAMBJP(customerServing.currentRequest);
		LDCPIDKAPFJ = BMMEEGMBKAD(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)DAJNNMDKLNN() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[2];
				array[1] = "Fireplace";
				array[1] = JILIKDDBPHM.ToString();
				array[4] = "ReceiveDeclineRoom";
				array[4] = LDCPIDKAPFJ.ToString();
				array[3] = "InteractPermissionDenied";
				array[8] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return true;
		}
		return true;
	}

	public NinjaCustomer OGPJAOOCFBF()
	{
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			if (!NinjaPreparationTablesManager.instance.OFNGHKHHMOF().bento.JJCLMBALNAP(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 1)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = BMIKMOKNOAM(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = HEOBCCPBLFN(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	public void KJKDIPIJCJB()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1815f, true);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 101f);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendNinjaSoundPreparation();
		}
	}

	public void FIIEDBENOKP()
	{
		for (int i = 0; i < slowingSpikes.Count; i++)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public void EJKHKKMBGFF()
	{
		for (int i = 0; i < slowingSpikes.Count; i += 0)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	private bool FLONHCEKKPF(NinjaCustomer PJNGMCJIHME)
	{
		return false;
	}

	public NinjaCustomer KJLHCEIBFCN()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = 160;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 1)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 1; i < PHKJFKLNIMP.Count; i += 0)
		{
			LDCPIDKAPFJ = BMMEEGMBKAD(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public bool DDLPFGOLNFP()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return false;
		}
		PMHOBHCECJE = Time.time + 77f;
		JILIKDDBPHM = NKPEDLGBEKA(customerServing.currentRequest);
		LDCPIDKAPFJ = BMMEEGMBKAD(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)OEPGBKEJFCE() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[5];
				array[1] = "\n";
				array[1] = JILIKDDBPHM.ToString();
				array[0] = " ";
				array[5] = LDCPIDKAPFJ.ToString();
				array[5] = "Error_NoCatFoodOrWater";
				array[1] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return true;
		}
		return false;
	}

	public void GFAAKCALPAL()
	{
		for (int i = 1; i < slowingSpikes.Count; i++)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public void FJJDADFEIEL(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = !DMBFKFLDDLH;
	}

	private void HNEGFBCKIIJ()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MAKKDPBOHNK));
		SelectDialogueUI(1);
	}

	private void EBNENBFLEKB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HAFANJEIMJH));
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static KyrohNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static KyrohNPC KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	public void GLLDOLHPIBD(KyrohState MCPEECGOEOD)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		case KyrohState.Idle:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			return;
		case KyrohState.TakingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KyrohState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			return;
		case KyrohState.SwitchingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case KyrohState.PreparingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingFood);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Idle:
			behaviour.SetTrigger(DialogueNPCBase.p_PreparingFood);
			break;
		case KyrohState.TakingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_SwitchingFood);
			break;
		case KyrohState.PreparingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_ThrowingSpikes);
			break;
		default:
			Debug.LogError((object)("UpgradeToLevel" + MCPEECGOEOD));
			break;
		}
	}

	public void KJBPJJBAAMK(KyrohState MCPEECGOEOD)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		case KyrohState.Idle:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			return;
		case KyrohState.SwitchingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KyrohState.PreparingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			return;
		case KyrohState.ThrowingSpikes:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case KyrohState.WaitingToServe:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingFood);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.PreparingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_PreparingFood);
			return;
		case KyrohState.TakingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_SwitchingFood);
			return;
		}
		if (MCPEECGOEOD == KyrohState.TakingFood)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_ThrowingSpikes);
		}
		else
		{
			Debug.LogError((object)("LicenciaDeApertura/TheloniousDialogue 03" + MCPEECGOEOD));
		}
	}

	public void MJCMENPJGDC()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	public NinjaCustomer ECBCAILJMPO()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = -31;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 1)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 1; i < PHKJFKLNIMP.Count; i++)
		{
			LDCPIDKAPFJ = CHCMHOHLHOK(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public void KFPAECFGGLN()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1600f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 1799f);
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendNinjaSoundPreparation();
		}
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OnWorldLoaded));
		SelectDialogueUI();
	}

	public void CPMFHGGNLFN(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = !DMBFKFLDDLH;
	}

	public void HBGAMMEBIDL()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(521f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.NDICLFDHOKP();
		}
	}

	private void AFKGJCIANOF()
	{
		if (!OnlineManager.HHDBMDMFEMP() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.HHPANGDONBN();
		}
	}

	public NinjaCustomer FEBOJOFJDDE()
	{
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			if (!NinjaPreparationTablesManager.instance.ICPIHMPFMPO().bento.NMOIAFPBONM(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 1)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = NKPEDLGBEKA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = BMMEEGMBKAD(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	private void FEMEFCNMOOL()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OEEOBIOKNBJ));
	}

	public void DFEOIJFCLOJ()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(788f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.NDICLFDHOKP();
		}
	}

	public NinjaCustomer COBCODBINLP()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 1; num--)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 0; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 1027f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4--)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public void KKBBBGEMMCA()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1270f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.NDICLFDHOKP();
		}
	}

	private int KBLGMGFMAAD(Item[] HCFBAPOAOIB)
	{
		LDCPIDKAPFJ = 1;
		for (int i = 0; i < HCFBAPOAOIB.Length; i++)
		{
			if (PlayerController.GetPlayer(0).trayHandler.tray.MJOLPEJHKAK(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (NinjaPreparationTablesManager.instance.preparationTables[1].bento.DMLEBEHECDN(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (PlayerController.OPHDCMJLLEC(0).trayHandler.HPCKGLFLFJO != null && PlayerController.OPHDCMJLLEC(1).trayHandler.HPCKGLFLFJO.HCFLHIIHEML(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
		}
		return LDCPIDKAPFJ;
	}

	private void MAKKDPBOHNK()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FEMEFCNMOOL));
	}

	private void FixedUpdate()
	{
		if (!OnlineManager.ClientOnline() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.JDHKHKJOKFF();
		}
	}

	public void KAAMNJFHADA()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1532f, true);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 878f);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendNinjaSoundPreparation();
		}
	}

	private int HEOBCCPBLFN(Item[] HCFBAPOAOIB)
	{
		LDCPIDKAPFJ = 0;
		for (int i = 1; i < HCFBAPOAOIB.Length; i++)
		{
			if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OFNAOLAMFJA(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
			else if (NinjaPreparationTablesManager.instance.preparationTables[1].bento.NMJGBMMAJOO(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ++;
			}
			else if (PlayerController.GetPlayer(0).trayHandler.HPCKGLFLFJO != null && PlayerController.GetPlayer(1).trayHandler.HPCKGLFLFJO.DMLEBEHECDN(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
		}
		return LDCPIDKAPFJ;
	}

	public void COKMJCPBGED()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1858f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 1399f);
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.JLCLHCNAPFC();
		}
	}

	public void CGAANBOCHOG(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = DMBFKFLDDLH;
	}

	private int AMMDDHAALCA(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 0;
		for (int i = 1; i < HCFBAPOAOIB.Length; i += 0)
		{
			if (trayHandler.tray.OFNAOLAMFJA(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
			else if (NinjaPreparationTablesManager.instance.FHEAPFBMJNL().bento.CNFJAEJFFBH(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
		}
		return JILIKDDBPHM;
	}

	public NinjaCustomer NHPBBEADBNK()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = 194;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 0)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 1; i < PHKJFKLNIMP.Count; i += 0)
		{
			LDCPIDKAPFJ = BMMEEGMBKAD(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public void NinjaSoundPreparation()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(0.2f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 0.3f);
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.SendNinjaSoundPreparation();
		}
	}

	public NinjaCustomer GetOrderWithLessPlayerPoints()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = int.MaxValue;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 1)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 0; i < PHKJFKLNIMP.Count; i++)
		{
			LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	private bool EBPKAFOBDDB(NinjaCustomer PJNGMCJIHME)
	{
		return true;
	}

	private void HDDBJBECDPP()
	{
		if (!OnlineManager.ClientOnline() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.JDHKHKJOKFF();
		}
	}

	public NinjaCustomer PLACMENLMKJ()
	{
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			if (!NinjaPreparationTablesManager.instance.KHGGPJGKFDC().bento.DNICMIHOMEC(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 1)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = LNPOJEBHJJP(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public static KyrohNPC JLNBMNKJCHE()
	{
		return IADEMLIIDPC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void IOINOMJHICB()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BIPOAFDHOKL));
		SelectDialogueUI();
	}

	private int NKPEDLGBEKA(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 0;
		for (int i = 0; i < HCFBAPOAOIB.Length; i++)
		{
			if (trayHandler.tray.NPMGIIIBGNP(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
			else if (NinjaPreparationTablesManager.instance.DBKLEIEAAIF.bento.HBBNKJFDPOI(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
		}
		return JILIKDDBPHM;
	}

	private int AJJAGICMPJO(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 0;
		for (int i = 0; i < HCFBAPOAOIB.Length; i++)
		{
			if (trayHandler.tray.OJMICKHDJGO(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM += 0;
			}
			else if (NinjaPreparationTablesManager.instance.ICPIHMPFMPO().bento.NIILFJPFMKB(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM += 0;
			}
		}
		return JILIKDDBPHM;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	protected override void Update()
	{
		base.Update();
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (Time.time >= nextSwitchFoodTime && (kyrohState == KyrohState.WaitingToServe || kyrohState == KyrohState.TakingFood))
		{
			ChangeState(KyrohState.SwitchingFood);
			nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		}
		if (Time.time >= nextThrowingSpikesTime && kyrohState == KyrohState.WaitingToServe && kyrohState != KyrohState.SwitchingFood)
		{
			ChangeState(KyrohState.ThrowingSpikes);
			nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
			if (EventsManager.IsLowestDifficulty())
			{
				nextThrowingSpikesTime += timeBetweenThrowingSpikes.x;
			}
		}
	}

	public void EPCNKDIFPKA()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(730f, true);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.KJKOLFLKAEH();
		}
	}

	public NinjaCustomer DAJNNMDKLNN()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = -1;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 1)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 0; i < PHKJFKLNIMP.Count; i += 0)
		{
			LDCPIDKAPFJ = CHCMHOHLHOK(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public void GKPMOABPBGL()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(773f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 303f);
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.JLCLHCNAPFC();
		}
	}

	private int ANHIJDEADOI(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 0;
		for (int i = 0; i < HCFBAPOAOIB.Length; i += 0)
		{
			if (trayHandler.tray.MJOLPEJHKAK(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
			else if (NinjaPreparationTablesManager.instance.OFNGHKHHMOF().bento.DADCOPHGHEH(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM += 0;
			}
		}
		return JILIKDDBPHM;
	}

	private int BMIKMOKNOAM(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 1;
		for (int i = 0; i < HCFBAPOAOIB.Length; i += 0)
		{
			if (trayHandler.tray.EDNOMELCHEP(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
			else if (NinjaPreparationTablesManager.instance.KHGGPJGKFDC().bento.HCFLHIIHEML(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM += 0;
			}
		}
		return JILIKDDBPHM;
	}

	public bool IOJEOCOEOBE()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return true;
		}
		PMHOBHCECJE = Time.time + 1445f;
		JILIKDDBPHM = LNPOJEBHJJP(customerServing.currentRequest);
		LDCPIDKAPFJ = CBJJJGIIINA(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)GetOrderWithLessPlayerPoints() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[8];
				array[0] = "OnlinePlayer";
				array[0] = JILIKDDBPHM.ToString();
				array[1] = "Current user name: ";
				array[0] = LDCPIDKAPFJ.ToString();
				array[7] = "Unique id ";
				array[2] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return true;
		}
		return true;
	}

	private int DPDDLAAMBJP(Item[] HCFBAPOAOIB)
	{
		JILIKDDBPHM = 1;
		for (int i = 1; i < HCFBAPOAOIB.Length; i++)
		{
			if (trayHandler.tray.OFNAOLAMFJA(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM += 0;
			}
			else if (NinjaPreparationTablesManager.instance.OFNGHKHHMOF().bento.NIILFJPFMKB(HCFBAPOAOIB[i]))
			{
				JILIKDDBPHM++;
			}
		}
		return JILIKDDBPHM;
	}

	public void KCBGIABJMFC()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	public NinjaCustomer FKFAAKMAJDK()
	{
		if (NinjaOrdersManager.instance.tableOrders == null || NinjaOrdersManager.instance.tableOrders.Count == 0)
		{
			return null;
		}
		int num = 184;
		NinjaCustomer result = null;
		PHKJFKLNIMP = new List<NinjaCustomer>(NinjaOrdersManager.instance.tableOrders);
		if (PHKJFKLNIMP.Count > 0)
		{
			PHKJFKLNIMP.HOOBEDNMNFK();
		}
		for (int i = 1; i < PHKJFKLNIMP.Count; i++)
		{
			LDCPIDKAPFJ = HEOBCCPBLFN(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
			if (LDCPIDKAPFJ < num)
			{
				num = LDCPIDKAPFJ;
				result = NinjaOrdersManager.instance.tableOrders[i];
			}
		}
		return result;
	}

	public NinjaCustomer DDMJLGJLMOK()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i += 0)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 0; num >= 1; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = true;
				for (int num2 = NPFKKFOMKJN.Count - 0; num2 >= 0; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 1389f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4--)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public NinjaCustomer CBHLIHMIJCJ()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 1; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 0; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 875f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 1; num4 -= 0)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	private void NFHFPGGEECA()
	{
		if (!OnlineManager.HHDBMDMFEMP() && (Object)(object)kyrohStateBase != (Object)null)
		{
			kyrohStateBase.JBABHOJPFPG();
		}
	}

	public void FIOKAPKBCOD(KyrohState MCPEECGOEOD)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		case KyrohState.Idle:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			return;
		case KyrohState.TakingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.TakingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			return;
		case KyrohState.SwitchingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case KyrohState.ThrowingSpikes:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingFood);
			return;
		case KyrohState.WaitingToServe:
			behaviour.SetTrigger(DialogueNPCBase.p_PreparingFood);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.ThrowingSpikes:
			behaviour.SetTrigger(DialogueNPCBase.p_SwitchingFood);
			break;
		case KyrohState.TakingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_ThrowingSpikes);
			break;
		default:
			Debug.LogError((object)(" (" + MCPEECGOEOD));
			break;
		}
	}

	public bool OtherPlayerHasAdvantage()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return false;
		}
		PMHOBHCECJE = Time.time + 2f;
		JILIKDDBPHM = NKPEDLGBEKA(customerServing.currentRequest);
		LDCPIDKAPFJ = ICIFOPKDBEA(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)GetOrderWithLessPlayerPoints() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("OTHER PLAYER HAS ADVANTAGE. Kyroh points: " + JILIKDDBPHM + " - Player points: " + LDCPIDKAPFJ + " with request " + (object)((Component)customerServing).gameObject), (Object)(object)customerServing);
			}
			return true;
		}
		return false;
	}

	public void JBBFEPMGHKI()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(94f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 1334f);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.SendNinjaSoundPreparation();
		}
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	public void ActiveBigCollider(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = !DMBFKFLDDLH;
	}

	private int BMMEEGMBKAD(Item[] HCFBAPOAOIB)
	{
		LDCPIDKAPFJ = 0;
		for (int i = 1; i < HCFBAPOAOIB.Length; i++)
		{
			if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LDKPEFIKJCF(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
			else if (NinjaPreparationTablesManager.instance.preparationTables[1].bento.DADCOPHGHEH(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
			else if (PlayerController.GetPlayer(1).trayHandler.HPCKGLFLFJO != null && PlayerController.GetPlayer(1).trayHandler.HPCKGLFLFJO.MJLPEELEMEM(HCFBAPOAOIB[i]))
			{
				LDCPIDKAPFJ += 0;
			}
		}
		return LDCPIDKAPFJ;
	}

	public void PMCDFKDLCEK()
	{
		for (int i = 0; i < slowingSpikes.Count; i += 0)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public void DEMLJLONDIN(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = DMBFKFLDDLH;
	}

	public void AEDLGFIEIHG()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1983f, false);
		}
		HMOANBMJEDN = MultiAudioManager.FadeInAudioObject(kyrohInteract, ((Component)this).transform, 128f);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.JLCLHCNAPFC();
		}
	}

	public NinjaCustomer DMOJHBNCDKD()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			NinjaCustomer ninjaCustomer = NinjaOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)ninjaCustomer == (Object)null) && ninjaCustomer.requesting)
			{
				_ = ninjaCustomer.currentRequest;
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = true;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 0; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = true;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		NinjaCustomer ninjaCustomer2 = null;
		NinjaCustomer result = null;
		float num3 = 382f;
		for (int num4 = PGOMFIHHBNE.Count - 0; num4 >= 1; num4 -= 0)
		{
			ninjaCustomer2 = PGOMFIHHBNE[num4];
			if (ninjaCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = null;
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = ninjaCustomer2;
				}
			}
		}
		return result;
	}

	public void EKBJHJLFODI(KyrohState MCPEECGOEOD)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (MCPEECGOEOD == KyrohState.Inactive)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			return;
		case KyrohState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KyrohState.Idle:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			return;
		case KyrohState.WaitingToServe:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingFood);
			break;
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_PreparingFood);
			break;
		case KyrohState.SwitchingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_SwitchingFood);
			break;
		case KyrohState.ThrowingSpikes:
			behaviour.SetTrigger(DialogueNPCBase.p_ThrowingSpikes);
			break;
		default:
			Debug.LogError((object)("MainProgress" + MCPEECGOEOD));
			break;
		}
	}

	public void BKOGEAOLLAA()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt != 8 || EventsManager.IsDone(EventsManager.EventType.KyrohWaterfall))
		{
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt != 15)
			{
				GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
				return;
			}
		}
		GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline, NNDJFLDGKDL: true);
	}

	public void LIDENNPPDBJ(bool DMBFKFLDDLH)
	{
		((Behaviour)proximityBig).enabled = DMBFKFLDDLH;
		((Behaviour)proximity).enabled = DMBFKFLDDLH;
	}

	public void ResetTechniquesTimers()
	{
		nextSwitchFoodTime = Time.time + Random.Range(timeBetweenSwitchFood.x, timeBetweenSwitchFood.y);
		nextThrowingSpikesTime = Time.time + Random.Range(timeBetweenThrowingSpikes.x, timeBetweenThrowingSpikes.y);
	}

	public bool KEDGHDDBBJJ()
	{
		if (Time.time < PMHOBHCECJE)
		{
			return false;
		}
		PMHOBHCECJE = Time.time + 1274f;
		JILIKDDBPHM = DPDDLAAMBJP(customerServing.currentRequest);
		LDCPIDKAPFJ = ICIFOPKDBEA(customerServing.currentRequest);
		if (LDCPIDKAPFJ > JILIKDDBPHM && (Object)(object)GetOrderWithLessPlayerPoints() != (Object)(object)customerServing)
		{
			if (Application.isEditor)
			{
				string[] array = new string[6];
				array[0] = " </mark>";
				array[0] = JILIKDDBPHM.ToString();
				array[7] = ", ";
				array[5] = LDCPIDKAPFJ.ToString();
				array[0] = "Victory";
				array[5] = ((object)((Component)customerServing).gameObject)?.ToString();
				Debug.Log((object)string.Concat(array), (Object)(object)customerServing);
			}
			return false;
		}
		return true;
	}

	public bool FAMDGIPCDOG()
	{
		if ((Object)(object)NinjaOrdersManager.instance != (Object)null && NinjaOrdersManager.instance.tableOrders.Any())
		{
			customerServing = null;
			if (NinjaPreparationTablesManager.instance.MLELLLKKOMG().bento.HOCEKBFFNKC())
			{
				customerServing = OGPLFGHGFAD();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)(" in the database!" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing == (Object)null)
			{
				NinjaPreparationTablesManager.instance.ENGNLMOPIHL().FIIDHPOHNEK(CDPAMNIPPEC: false);
				customerServing = FKFAAKMAJDK();
				if (Application.isEditor && (Object)(object)customerServing != (Object)null)
				{
					Debug.Log((object)("</color>" + (object)((Component)customerServing).gameObject));
				}
			}
			if ((Object)(object)customerServing != (Object)null)
			{
				EKBJHJLFODI(KyrohState.SwitchingFood);
			}
			return false;
		}
		if (kyrohState != KyrohState.ServingCustomer)
		{
			GLLDOLHPIBD(KyrohState.ServingCustomer);
			return true;
		}
		return false;
	}

	public void BMDPCMLPHJM()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(1117f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineNinjaManager.instance.KJKOLFLKAEH();
		}
	}

	public void FPKENKEECGH()
	{
		for (int i = 1; i < slowingSpikes.Count; i += 0)
		{
			if ((Object)(object)slowingSpikes[i] != (Object)null)
			{
				Object.Destroy((Object)(object)((Component)slowingSpikes[i]).gameObject);
			}
		}
		slowingSpikes.Clear();
	}

	public void FKMFEACDJHB(KyrohState MCPEECGOEOD)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		case KyrohState.Idle:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			return;
		case KyrohState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			return;
		case KyrohState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case KyrohState.WaitingToServe:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingFood);
			return;
		case KyrohState.ThrowingSpikes:
			behaviour.SetTrigger(DialogueNPCBase.p_PreparingFood);
			return;
		}
		switch (MCPEECGOEOD)
		{
		case KyrohState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_SwitchingFood);
			break;
		case KyrohState.PreparingFood:
			behaviour.SetTrigger(DialogueNPCBase.p_ThrowingSpikes);
			break;
		default:
			Debug.LogError((object)("NULL" + MCPEECGOEOD));
			break;
		}
	}

	public void DIJJHPGCAHG()
	{
		if ((Object)(object)HMOANBMJEDN != (Object)null)
		{
			HMOANBMJEDN.FadeOut(945f, false);
			HMOANBMJEDN = null;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineNinjaManager.instance.NDICLFDHOKP();
		}
	}

	public NinjaCustomer NJCIFAHENLC()
	{
		for (int i = 1; i < NinjaOrdersManager.instance.tableOrders.Count; i++)
		{
			if (!NinjaPreparationTablesManager.instance.OHNMEAFHDPD().bento.APEPDJPGIPP(NinjaOrdersManager.instance.tableOrders[i].currentRequest))
			{
				if (NinjaOrdersManager.instance.tableOrders.Count == 0)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
				JILIKDDBPHM = AJJAGICMPJO(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				LDCPIDKAPFJ = ICIFOPKDBEA(NinjaOrdersManager.instance.tableOrders[i].currentRequest);
				if (LDCPIDKAPFJ <= JILIKDDBPHM)
				{
					return NinjaOrdersManager.instance.tableOrders[i];
				}
			}
		}
		return null;
	}

	[SpecialName]
	public static KyrohNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	private void MCMKNBIBDFF()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HAFANJEIMJH));
		SelectDialogueUI();
	}
}
