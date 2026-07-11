using UnityEngine;

public class TurkeyAnimation : CharacterAnimBase
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	public TurkeyAnimationState turkeyAnimationState;

	public TurkeyNPC turkeyNPC;

	public bool random;

	private float EILNHFEBPNM = 15f;

	private float LKEBIJOJAOG = 60f;

	private float NMBEPAGELPO;

	private float GPCOFKEEKFI;

	private Vector3 AADMIOHCEEB;

	private Vector3 EJACBOOECHP;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			if (FCGBJEIIMBC == value)
			{
				return;
			}
			base.FCGBJEIIMBC = value;
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
		}
	}

	private void FFLLCOBFIPE()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(47, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(79, 71);
		FCGBJEIIMBC = (Direction)7;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EFCNKPEPELL()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(45, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-9, -72);
		FCGBJEIIMBC = Direction.Down;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BABJAGOPCOA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1559f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || JEJPKGILEDB("Items/item_description_730") || GetBool("UIPreviousCategory") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Level ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-30, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("LE_3");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(1, 1);
		}
	}

	private void GFABFDHPJOK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 319f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("Stop") || GetBool("LE_10") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Error_PlaceItInChickenCoop");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-21, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Forward");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)5);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(89, 5);
		}
	}

	private void NJAFKFAPDIE()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(39, 8);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(25, -35);
		NCAJNNHBHJM(Direction.Up);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OCBPECIEPMI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 80f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || JEJPKGILEDB("[Brown") || GetBool("ReceiveFoodRequestAsDrink") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("MopUp");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(95, 1);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("ReceiveAnimalWalk");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Hurt);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(66, 5);
		}
	}

	private void PNJJEDEFAGO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-40, 2);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(108, 123);
		NCAJNNHBHJM(Direction.Right);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void AMNCIAEMBFO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(100, 6);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-9, -120);
		NCAJNNHBHJM((Direction)8);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void LILOALHNAND()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 847f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Dialogue System/Conversation/EnterTavernFood/Entry/2/Dialogue Text") || GetBool("      Magic Broom assigned: ") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("ReceiveStartWork ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-59, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("ReceiveCurrentActorsInDialogue");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)5);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-23, 1);
		}
	}

	private void EIHMDMMOPCM()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-102, 0);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-56, -77);
		FCGBJEIIMBC = Direction.Diagonal;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FCNKGINGJNM()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(126, 7);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-96, -46);
		NCAJNNHBHJM((Direction)6);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EIMIDCDEIDD()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(111, 7);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-45, -117);
		NCAJNNHBHJM(Direction.Up);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PCPNEJOIKAN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1490f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("AdventureContinues/Main") || GetBool("[") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("City/Bruce/Bark/Stand");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(106, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Items/item_name_706");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Random);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-62, 6);
		}
	}

	private void HHPANGDONBN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 412f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || JEJPKGILEDB("") || GetBool("Polling") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Item nulo en el índice {0}.");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(60, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Writing file ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)6);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-91, 5);
		}
	}

	private void HDDBJBECDPP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 357f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || JEJPKGILEDB("OnlinePlayer") || JEJPKGILEDB("intensity:") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Walk");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(78, 3);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("FloorMaterial");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(115, 7);
		}
	}

	private void DGIFHBIJDDE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1771f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || JEJPKGILEDB("") || JEJPKGILEDB("/") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Items/item_name_1069");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(58, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger(" door: ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Random);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-3, 1);
		}
	}

	private void FGJPOPCBFNE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 66f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || GetBool("Dialogue System/Conversation/NeutralInTavern/Entry/11/Dialogue Text") || GetBool("GOG ") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Intro/TavernAlone");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(33, 7);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Arguing");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Random);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-87, 6);
		}
	}

	private void KIGPIILBDAC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 292f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("CheckArea") || JEJPKGILEDB("Door") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger(" seconds.");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-85, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("{0} doesn't have a parameter with that hash.");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.FANGKFNHAPC((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-71, 1);
		}
	}

	private void IBMDFNKKPJF()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(57, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(6, -48);
		NCAJNNHBHJM(Direction.Diagonal);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void IGNEGEOPLOP()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(4, 4);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-111, -18);
		FCGBJEIIMBC = (Direction)5;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HAHFKJCIPKH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 897f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || GetBool("Placed item has no item setup component: ") || JEJPKGILEDB("IsWeatheringToday") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Make bed");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-104, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Level {0}: {1}");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN((OnlineTurkey.TriggerName)5);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(75, 6);
		}
	}

	private void NAOBODGBECL()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-11, 7);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(82, 125);
		NCAJNNHBHJM((Direction)5);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FKIAIANFJEK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1414f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("BarIdle") || GetBool("City/Hallmund/Talk/GiveTool") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("ReceiveFountainsPuzzle");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-59, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("pirate");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(83, 6);
		}
	}

	private void MMNBJPDJHGK()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(125, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(34, -16);
		FCGBJEIIMBC = Direction.Left;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MENCIOFBFIE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 927f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || JEJPKGILEDB("Chest opened, granting loot to player ") || JEJPKGILEDB("ErrorMessageTooLong") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("-> ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-43, 7);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Disabled");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-80, 7);
		}
	}

	private void KDHLJKMKFMG()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-65, 6);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-76, 112);
		NCAJNNHBHJM((Direction)7);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void NLGHNDLPPKI()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-110, 2);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-22, 121);
		FCGBJEIIMBC = Direction.Left;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MOEJIBLELHP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 662f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Demolish") || GetBool("") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("City/Chuck/Stand");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-101, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Items/item_name_593");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ((OnlineTurkey.TriggerName)6);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(117, 4);
		}
	}

	private void EFLEPALELDJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 731f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || GetBool("Open") || GetBool("ReceiveLoadRecipes") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("ReceiveBathhouseEntranceEventMoveToPlayer");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-58, 3);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Tutorial/T115/Dialogue1");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Hurt);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(48, 1);
		}
	}

	private void GJGMDNEKAEG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1454f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || GetBool("00") || JEJPKGILEDB("A number is needed.") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("ReceiveAddQuestInfo");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(118, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("<color=");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(51, 6);
		}
	}

	private void OMBHDODDHNO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(48, 3);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(114, -61);
		FCGBJEIIMBC = (Direction)8;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void IHICKHAABJH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(48, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(89, 124);
		NCAJNNHBHJM((Direction)6);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PGJLFLKDLAE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 146f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Items/item_description_640") || JEJPKGILEDB("itemMintSeeds") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("itemBrownWort");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-8, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)7);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-36, 0);
		}
	}

	private void ODJPLNDJKEA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 63f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("ConnectionTimeout") || JEJPKGILEDB("Tile_{0}_{1}") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-3, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("\n");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-15, 7);
		}
	}

	private void HFPDNCBLNDE()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-32, 3);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(54, 2);
		FCGBJEIIMBC = Direction.Right;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HKOFLOPDCEJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1589f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("[MinePuzzleManager] Devolviendo control al jugador {0}.") || JEJPKGILEDB("cameraZoom") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Kyroh doesnt has drinks in tray");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.FANGKFNHAPC(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(41, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Current crafting:");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-62, 2);
		}
	}

	private void PKPHKBMPJGJ()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(6, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-73, 113);
		NCAJNNHBHJM(Direction.Down);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GECHJIGBPEN()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(108, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(33, -47);
		NCAJNNHBHJM((Direction)8);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void ILCLIJOHKHG()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(3, 7);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(4, 22);
		FCGBJEIIMBC = Direction.Diagonal;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DNBGIIGAKMJ()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-49, 0);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(36, -12);
		FCGBJEIIMBC = Direction.Right;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OBJHHNMMCGF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 986f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("tutorialPopUp102") || GetBool("") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("centimeters");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(33, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger(" seconds if next theme ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-86, 7);
		}
	}

	private void ALEAOANPHIO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-100, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-105, -18);
		NCAJNNHBHJM((Direction)8);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HDNHNMJHOJM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1460f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool(")") || JEJPKGILEDB("Items/item_description_734") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/12/Dialogue Text");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(57, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/11/Dialogue Text");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ((OnlineTurkey.TriggerName)7);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(20, 2);
		}
	}

	private void BODICIENBEH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(102, 3);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-96, -62);
		FCGBJEIIMBC = (Direction)6;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KHONOODGLBI()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(28, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-83, 33);
		NCAJNNHBHJM(Direction.Left);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CLJBKGOGBII()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 340f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || JEJPKGILEDB("LoveB&H") || JEJPKGILEDB("ReceiveCompleteServeNinjaCustomer") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Action");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(105, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Rummage");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-101, 4);
		}
	}

	private void EENAJABELBJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1065f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("Invalid playerNum ") || GetBool("itemPaperCoaster") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Player Bed not found");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-14, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("</color>");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-33, 5);
		}
	}

	private void EEPKGNNILBE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1378f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("Precision/DrinkEvent3") || JEJPKGILEDB("MopRight") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Decline");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-75, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("AcceptRoomSecondFloor");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(23, 5);
		}
	}

	private void DHJOHHEMMFK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 905f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || JEJPKGILEDB("position") || GetBool("Dialogue System/Conversation/TavernFilthy/Entry/4/Dialogue Text") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Current game language is ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.FANGKFNHAPC(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(29, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("FishMiniGameWin");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)5);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-63, 1);
		}
	}

	private void AHPNEDOLBII()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1269f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || JEJPKGILEDB("Player/Bark/Tutorial/CantDoYet") || JEJPKGILEDB("ReceiveSleepStart") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Right Shoulder");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-78, 8);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger(" I");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(82, 4);
		}
	}

	private void PMLHDLPJPDG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1755f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Dismissed") || JEJPKGILEDB(" / base price: ") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Items/item_name_1094");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-77, 8);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Beard");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC((OnlineTurkey.TriggerName)7);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(11, 2);
		}
	}

	private void AJGLDLLIIFO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-104, 6);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-85, 32);
		FCGBJEIIMBC = Direction.Down;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DNKEFFMOCKP()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-105, 6);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(24, -46);
		FCGBJEIIMBC = Direction.Left;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HINEHDJIPGP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 645f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool(" ") || GetBool("No seat found!") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger(" for reason: ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-99, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Style");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Hurt);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(113, 4);
		}
	}

	private void HINGECEDJAP()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(74, 6);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(59, -10);
		NCAJNNHBHJM(Direction.Diagonal);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MJENOBKFPIN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 170f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || GetBool("Tavern must be closed") || GetBool("ReceiveAwakeBob") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Disabled");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(62, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("\n  animationSprites:   ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-27, 6);
		}
	}

	private void BFJOEMCBJJO()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(40, 7);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-60, 117);
		FCGBJEIIMBC = (Direction)8;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FALKANGNMJI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 619f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("Dialogue System/Conversation/TooCold/Entry/1/Dialogue Text") || JEJPKGILEDB("SprintHoldAction") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("ReceiveLoadEvents");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.FANGKFNHAPC(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-53, 8);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Sit");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-128, 5);
		}
	}

	private void FOJJKOJBHEI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 480f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Till") || JEJPKGILEDB("") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("talent_name_110");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-9, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Dots");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(10, 2);
		}
	}

	private void BGBFJPJLPMF()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-117, 8);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-9, -107);
		NCAJNNHBHJM(Direction.Left);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FKIEEDDAGKG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1195f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || JEJPKGILEDB("Items/item_name_627") || GetBool("Could not get name of achievement ") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("StartObserver SalonDelTrono");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-2, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("SelectedNotFocused");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC((OnlineTurkey.TriggerName)6);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-55, 7);
		}
	}

	private void NLOEGNNLKKE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 824f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || GetBool("Player") || GetBool(" Galaxy ID") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("End");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(76, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Shader Model 4.0 ( DX10.0 )");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-48, 6);
		}
	}

	private void DKDLOBOLNFH()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-35, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(89, 74);
		NCAJNNHBHJM((Direction)5);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JMLDAJEFMPE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 928f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || GetBool("LE_8") || JEJPKGILEDB(" ") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Items/item_name_1047");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-60, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Items/item_description_1176");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-22, 8);
		}
	}

	private void FJIJNLKJGKC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1497f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || GetBool("Items/item_description_647") || GetBool(")") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Aged price");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(96, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Items/item_name_1065");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-72, 7);
		}
	}

	private void EIOFKDODGKK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 699f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || JEJPKGILEDB("Items/item_description_1140") || GetBool(">") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("talentShelves");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-27, 8);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("HaveGoldenTicket");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-101, 3);
		}
	}

	private void Awake()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-3, 3);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-15, 15);
		FCGBJEIIMBC = Direction.Right;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OOBDKJHKPEP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1526f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("end conversation") || JEJPKGILEDB("itemWatermelonSeeds") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Items/item_description_670");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(125, 1);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Care");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(86, 5);
		}
	}

	private void JMCJFCPCDKL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1727f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Pause") || GetBool("Dialogue System/Conversation/BirdPositiveComments/Entry/12/Dialogue Text") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/30/Dialogue Text");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(49, 1);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("NormalRightExterior");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(119, 7);
		}
	}

	private void GMCKBBECJOE()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(112, 2);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(73, 55);
		NCAJNNHBHJM(Direction.Left);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void AGLMGDNBHBF()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(113, 7);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(78, -40);
		FCGBJEIIMBC = (Direction)6;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void LALGIJBMOMI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1730f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || GetBool("Open") || GetBool("Item") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("[");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-26, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Scene");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)8);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-93, 1);
		}
	}

	private void CMJJFJFDNED()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 235f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("{0}\nPlayers: {1}/{2}") || GetBool("MainProgress") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("NinjaChallengeEvent/Lose 2");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(41, 6);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("]");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)8);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-97, 8);
		}
	}

	private void EJJKCAPPKLL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1344f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || JEJPKGILEDB("Configure") || JEJPKGILEDB("itemPumpkinSeeds") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("xpModDescCleaning");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-78, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("NPC");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN((OnlineTurkey.TriggerName)7);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-28, 1);
		}
	}

	private void AFKGJCIANOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 765f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("Items/item_description_648") || JEJPKGILEDB("Calm down") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Hanghover");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.LEFDLNIOELM(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(8, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("LE_10");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)8);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(24, 8);
		}
	}

	private void DGDCMLPELHD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 598f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("[Brown") || JEJPKGILEDB("OpenTavern") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("CutEnd");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(10, 5);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("ChangeLocationRPC");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM((OnlineTurkey.TriggerName)3);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-5, 5);
		}
	}

	private void EHBFECEJGCE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 561f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("sForSeconds") || GetBool("Interact") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("(P{0}) ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(7, 6);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Gass_CoctelQuest");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(126, 5);
		}
	}

	private void ACFMEGDHELN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 841f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || JEJPKGILEDB("Sit") || JEJPKGILEDB("Dialogue System/Conversation/Gass_Introduce/Entry/25/Dialogue Text") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Use");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(68, 7);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("launchTheGame");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM((OnlineTurkey.TriggerName)7);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(31, 7);
		}
	}

	private void CEOEHODJAJK()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(95, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(69, 7);
		FCGBJEIIMBC = Direction.Diagonal;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FixedUpdate()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 0f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("Moving") || GetBool("Run") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Peek");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-2, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Random");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Random);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-2, 2);
		}
	}

	private void KAOLCOJBFCE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1283f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || JEJPKGILEDB("Invite region: ") || JEJPKGILEDB("UpgradeToLevel") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger(")\n");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.JBDJOIACLKJ(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(116, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("You have to assign a UI camera!");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)8);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-124, 3);
		}
	}

	private void IGNLHLAAMMN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1607f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB(" ") || JEJPKGILEDB("talent_name_101") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Items/item_description_1109");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(70, 0);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Disabled");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-108, 2);
		}
	}

	private void MGMJCAKILCO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1408f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || JEJPKGILEDB("Tutorial/MaiPatch") || JEJPKGILEDB("HouseKeeper") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("City/Carpenters/Oak/Bark/Stand");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(110, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("ReceiveChessPillarSegmentChanged");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.BPPPJHPCDLN((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(95, 5);
		}
	}

	private void DIMAPDNCBAN()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(12, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-32, 127);
		NCAJNNHBHJM(Direction.Diagonal);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MPLHFJGFKJD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1226f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || base.CNKHDCIKHCO || JEJPKGILEDB("Room missing required items") || JEJPKGILEDB("SetMinigame") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger(" not found. Cannot set isSelected to ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(63, 8);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("BuzzProgress");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)7);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-46, 1);
		}
	}

	private void FKCOPHFELKD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 44f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.PGAGDFAEEFB() || LHGMJFGOHFD() || JEJPKGILEDB("City/Rhia/Bark/Bye") || JEJPKGILEDB("") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("All bubbles in use!");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-3, 4);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger(" ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.SendTrigger((OnlineTurkey.TriggerName)6);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(87, 8);
		}
	}

	private void PCKOHAIPHFI()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(115, 1);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(10, 78);
		FCGBJEIIMBC = Direction.Diagonal;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BNFGHAGJEGG()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-121, 5);
		GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(48, -38);
		NCAJNNHBHJM(Direction.Down);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GAEDNJMJDJD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 751f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || JEJPKGILEDB("LE_11") || GetBool("%") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("Key item fished: ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-6, 3);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("LicenciaDeApertura/KlaynDialogue 05");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.DLGEKEDJFLM((OnlineTurkey.TriggerName)5);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-97, 7);
		}
	}

	private void MAGACCHLAOE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1438f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || LHGMJFGOHFD() || GetBool("Items/item_name_670") || JEJPKGILEDB("' no referencia correctamente al item '") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger("ScrollUp");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG(OnlineTurkey.TriggerName.Peek);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(0, 3);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("Items/item_name_1444");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.GJENKGNLLMG((OnlineTurkey.TriggerName)4);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-79, 5);
		}
	}

	private void CNHEMKHJPPN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1483f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!OnlineManager.MasterOrOffline() || base.CNKHDCIKHCO || GetBool("MenuMode") || GetBool("Press SPACE to continue") || !turkeyAnimationState.safeMovement)
		{
			return;
		}
		if (Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger(" ");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.COMHPHBBLOH(OnlineTurkey.TriggerName.Hurt);
			}
			NMBEPAGELPO = Time.time + EILNHFEBPNM + (float)Random.Range(-51, 2);
		}
		if (random && Time.time >= GPCOFKEEKFI)
		{
			animator.SetTrigger("StopMusic/ButtonEndSegment");
			if (OnlineManager.PlayingOnline())
			{
				turkeyNPC.onlineTurkey.OGECCJPBDPC((OnlineTurkey.TriggerName)6);
			}
			GPCOFKEEKFI = Time.time + LKEBIJOJAOG + (float)Random.Range(-97, 0);
		}
	}
}
