using UnityEngine;

public class CustomerStateEatingAtTable : CustomerStateBase
{
	private int JNBLECJGIAK;

	private float IMJOEDNNHEJ;

	private bool JOHHKCPAADH;

	private bool NKALKOBINOP;

	private void FOFOCKJJEDJ()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void AAMNABCKFEG()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void ODEPGPIBOKD()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void FPOJKIOFLJK()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void AOHAFGHNHPJ()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(0.7f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 0.02f, 1f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(40) / 100f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 0.5f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void FPKMMGAHCGE()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1221f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1660f, 519f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(60) / 159f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 405f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void GOHEHNONKJG()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1350f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1166f, 1252f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-52) / 904f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 680f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void HEMMNDKDLKD()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void FALLGMGCIHJ()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void EDKAGLAKLBC()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void AEHBGKCLKEF()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1640f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1862f, 255f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(101) / 1136f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1061f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void OOHLCMLEINI()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1461f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1381f, 1018f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-119) / 429f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1774f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void OKMFPJMGLBC()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void BIFOKLDIHID()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void FPPIMDNBCJB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(819f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1835f, 231f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-53) / 362f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1936f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void DDFPNNKJGNI()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(849f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 0f, 352f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(83) / 1641f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1681f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void PLENNNDGPBF()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void MEAJGEGOGAF()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void MOKPHIDNCPJ()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(891f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 515f, 792f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-31) / 60f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1594f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	public override void UpdateState(bool GDHCBGCIIKG = false)
	{
		base.UpdateState(GDHCBGCIIKG);
		if (JOHHKCPAADH)
		{
			return;
		}
		if (WorldTime.TickTimeIsBlocked())
		{
			IMJOEDNNHEJ += Time.deltaTime;
			PJNGMCJIHME.currentFinishEatTime += Time.deltaTime;
			return;
		}
		if (Time.time > IMJOEDNNHEJ)
		{
			IMJOEDNNHEJ = Time.time + Random.Range(2f, 4f);
			NKALKOBINOP = !NKALKOBINOP;
			if (NKALKOBINOP)
			{
				JHIFLALPEBF.FJHKGBNBNKL.Eat(PJNGMCJIHME.npcHoldItem.ODDHGLHEHLA);
			}
			else
			{
				JHIFLALPEBF.FJHKGBNBNKL.StopEating();
			}
		}
		if ((Object)(object)JHIFLALPEBF.seat != (Object)null && (Object)(object)JHIFLALPEBF.seat.table != (Object)null && OnlineManager.MasterOrOffline())
		{
			JHIFLALPEBF.seat.table.AddDirtiness(Time.deltaTime * CommonReferences.GGFJGHHHEJC.customerInfo.dirtinessMultiplier, KGCEBPFKPOG: true, CDPAMNIPPEC: false);
			if (JHIFLALPEBF.seat.table.JNHCCCBICDM == TableDirtLevel.Dirty)
			{
				PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.tableDirtyPenalty;
			}
			else if (JHIFLALPEBF.seat.table.JNHCCCBICDM == TableDirtLevel.VeryDirty)
			{
				PJNGMCJIHME.NGDAJGCPJEC -= Time.deltaTime * PJNGMCJIHME.customerInfo.tableVeryDirtyPenalty;
			}
		}
		if (Time.time > PJNGMCJIHME.currentFinishEatTime)
		{
			if (NewTutorialManager.NewOrdersBlocked())
			{
				AOHAFGHNHPJ();
			}
			else if (!TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
			{
				float num = PJNGMCJIHME.customerInfo.requestAgainProbability;
				if (Waiter.JHLLELHBIDA)
				{
					num += (float)(PJNGMCJIHME.customerInfo.requestAgainProbability * Waiter.GetEmployeePerkValue(32)) / 100f;
					num -= (float)(PJNGMCJIHME.customerInfo.requestAgainProbability * Waiter.GetEmployeePerkValue(70)) / 100f;
				}
				if (PJNGMCJIHME.currentMoodState == MoodState.Rowdy)
				{
					PJNGMCJIHME.BecomeNuisance(CDPAMNIPPEC: true);
				}
				else if ((JNBLECJGIAK < 2 && (float)Random.Range(0, 100) < num) || (PJNGMCJIHME.customerType == CustomerType.ImportantGuest && JNBLECJGIAK < 3))
				{
					JNBLECJGIAK++;
					if (NewTutorialManager.ForceDrinkOrders())
					{
						TableOrdersManager.instance.StartNewOrderInTable(PJNGMCJIHME);
					}
					else
					{
						JOHHKCPAADH = true;
						PJNGMCJIHME.ChangeState(CustomerState.WaitingForBarSpot);
					}
				}
				else
				{
					FHBBLAIOPJD();
				}
			}
			else
			{
				FHBBLAIOPJD();
			}
		}
		PJNGMCJIHME.customerSpeech.CustomerSittingDown();
	}

	private void OBDNPEAJENF()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void JFPJEJGJJEO()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1329f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1636f, 259f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(109) / 1446f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 487f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void MPELIOBKHOB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(18f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1724f, 1910f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-92) / 1051f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 619f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void LMKCMNAHMKJ()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1432f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1853f, 515f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-26) / 1103f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1012f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void ABFNIJLPEOA()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void NFAKODHBKBM()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void DPLINJOJKOH()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1364f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1138f, 1532f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-7) / 1003f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 489f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void MDAILBNOFBM()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1639f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 957f, 99f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(92) / 313f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 750f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void HICKBPMBFPA()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(765f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1320f, 203f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(20) / 88f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1883f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void EDNCKNMLBAG()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void NPCJDNFBNDJ()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1947f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1199f, 145f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-127) / 344f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 721f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void OHKAKEHNJON()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void KPCLCNJNHLE()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void NAGBEOHEDBE()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void PLEHMLGFLHG()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void NLPDGBNNEHJ()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void JFICBFMICGB()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void EOFODJLONPC()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		PJNGMCJIHME.LeaveWillingly();
	}

	public override int GetStateEnumID()
	{
		return 6;
	}

	private void IMDGFFNILKN()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1489f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 954f, 493f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-41) / 1934f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 747f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void HMGONOMJONB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1259f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1980f, 1059f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(16) / 741f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 72f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void OMAJNNODHLN()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(806f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 552f, 67f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-121) / 1892f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1564f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void DDPAALEEEBF()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void HNENAKGPOBL()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void MDEELJMIJDH()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void IGPJEBGPPMK()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(878f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1031f, 539f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-41) / 215f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 243f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void LMKFOAHOJOB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(579f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1114f, 1979f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-68) / 1550f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 829f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void NBBCOHHNACJ()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(12f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 211f, 1831f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(66) / 1235f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 959f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void APDBDLJPEHM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(24f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1492f, 1450f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(19) / 1650f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1328f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void AEFKOBOGCHG()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1661f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1211f, 1556f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-9) / 260f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 75f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		AOHAFGHNHPJ();
		JNBLECJGIAK = 0;
		IMJOEDNNHEJ = 0f;
		NKALKOBINOP = false;
		JOHHKCPAADH = false;
		if (OnlineManager.IsMasterClient())
		{
			PJNGMCJIHME.LJOHCJAOADD.SendStartEatingAtTable();
		}
	}

	private void MLDPGDHKILC()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(21f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 56f, 722f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-96) / 1191f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1714f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void JGANBPPLOJP()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1982f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1553f, 473f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-71) / 667f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1378f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void DOLKEDOAPAK()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(214f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 574f, 1923f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(66) / 65f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1533f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void JBMKIHKCNGO()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void IDEHNADHHEF()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void JFMAMGPHLHN()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void CIIHMDMIGEO()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToSeat, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void NIMDPCMDPIO()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void IJDAPBCFOEO()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1476f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1981f, 697f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-52) / 393f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 647f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void EMGECKDMLPF()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void PBJBMEJEDEM()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void POPEMAKFBEM()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(404f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 990f, 152f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-65) / 1906f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1777f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void GHGOIIADAJM()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1958f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 137f, 938f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(23) / 1665f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1932f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void IHNDGJPHJEP()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void FHBBLAIOPJD()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void MOJNHJJLEPC()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void GOHMIHKMFGK()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1181f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 48f, 799f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(85) / 1058f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1984f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void NOENMGFCKEG()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void FJFKFJKDCAL()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1372f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1567f, 1526f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(31) / 1460f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1286f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void FEMFACIOGCF()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void OLNBIGOFGEC()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void LLLLDAAMCNP()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1425f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 886f, 1493f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(96) / 224f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1302f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void NJOCAECMPFH()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(732f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 699f, 101f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-6) / 703f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1697f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void OPLOEGLMDOD()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void BOEFIDEKHPG()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void EACJABICKPL()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1670f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 403f, 1585f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(61) / 334f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 476f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		if ((Object)(object)JHIFLALPEBF.seat != (Object)null && (Object)(object)JHIFLALPEBF.seat.table != (Object)null && OnlineManager.IsMasterClient())
		{
			PJNGMCJIHME.LJOHCJAOADD.SendEndEatingAtTable(JHIFLALPEBF.seat.table.PDPKEPEBPIK);
		}
		base.ExitState(GDHCBGCIIKG);
	}

	private void JMPFMMBBMCA()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1477f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 514f, 875f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-107) / 1978f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 666f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void GEIBFHFPCIC()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void BOACDIELKHB()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1607f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1212f, 913f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(6) / 1552f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 722f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void NOIIGCMJDJG()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void ECKJCLGEKNG()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1385f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1864f, 1353f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(101) / 1376f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 844f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void LEABMBKEBBH()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1888f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 265f, 624f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-120) / 418f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1666f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void BNMDHCKGHOB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(586f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1030f, 1524f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.GetEmployeePerkValue(-14) / 467f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 947f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void CODICEEJHNN()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void BMIJBLIBNAO()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void PMAMMMDHFOE()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(310f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 634f, 223f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(-81) / 481f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 170f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void ALDFKILIMPL()
	{
		JOHHKCPAADH = false;
		PJNGMCJIHME.ChangeState(CustomerState.BeingANuisance);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void IMFKHGABJBL()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1619f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 497f, 1919f);
		}
		if (Bouncer.INOKIOHEDEH())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(6) / 1704f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 1475f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void JCCOJLBLNHF()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void JNMCJIEIANA()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingLastOrdersMin, PJNGMCJIHME.customerInfo.timeEatingLastOrdersMax);
		}
		else
		{
			PJNGMCJIHME.currentFinishEatTime = Random.Range(PJNGMCJIHME.customerInfo.timeEatingMin, PJNGMCJIHME.customerInfo.timeEatingMax);
			PJNGMCJIHME.currentFinishEatTime *= Mathf.Min(1765f + (float)TavernManager.GGFJGHHHEJC.customers.Count * 1962f, 915f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * (float)Bouncer.NADBCNFALNF(3) / 359f;
		}
		if (NewTutorialManager.EatFast())
		{
			PJNGMCJIHME.currentFinishEatTime -= PJNGMCJIHME.currentFinishEatTime * 913f;
		}
		PJNGMCJIHME.currentFinishEatTime += Time.time;
	}

	private void LCCACFEPCCA()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		PJNGMCJIHME.LeaveWillingly();
	}

	private void MAOFNCEHANG()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		PJNGMCJIHME.HCADDDFCHBL();
	}

	private void AHMPBPMAIJA()
	{
		JOHHKCPAADH = true;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning);
		PJNGMCJIHME.HCADDDFCHBL();
	}
}
