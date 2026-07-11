using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CropToolTip : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MFIIOIJJBCN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CropToolTip _003C_003E4__this;

		public int playerNum;

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
		public MFIIOIJJBCN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CropToolTip cropToolTip = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)cropToolTip.NAIBCCAOBIL != (Object)null && Object.op_Implicit((Object)(object)cropToolTip.NAIBCCAOBIL.plantedCropSetter) && (Object)(object)cropToolTip.NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF != (Object)null && cropToolTip.NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems != null && cropToolTip.NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems.Length != 0 && Item.MLBOMGHINCA(cropToolTip.NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item, null))
				{
					cropToolTip.NAIBCCAOBIL.plantedCropSetter.FocusCrop(playerNum);
					Vector2 val = ((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? cropToolTip.PJCHGKHIAML : cropToolTip.BJIDLCGEGHE);
					CropInfoUI.Get(playerNum).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)cropToolTip.NAIBCCAOBIL).transform.position.x + val.x, ((Component)cropToolTip.NAIBCCAOBIL).transform.position.y + val.y), Vector2.zero, cropToolTip.NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), cropToolTip.BGKKKEHHNBE(cropToolTip.NAIBCCAOBIL.plantedCropSetter), Mathf.Clamp(cropToolTip.DMBBLIAEIGA(cropToolTip.NAIBCCAOBIL.plantedCropSetter), 0, cropToolTip.BGKKKEHHNBE(cropToolTip.NAIBCCAOBIL.plantedCropSetter)), cropToolTip.LDJNGLHKDME(), Mathf.Clamp(cropToolTip.CMICJJLNJHB(), 0, cropToolTip.LDJNGLHKDME()), cropToolTip.IBECKFNJICA(cropToolTip.NAIBCCAOBIL.plantedCropSetter), Object.op_Implicit((Object)(object)cropToolTip.NAIBCCAOBIL.plantedCropSetter.growable) && cropToolTip.NAIBCCAOBIL.plantedCropSetter.growable.isDead);
				}
				else if ((Object)(object)cropToolTip.DMOOOHEKDJC != (Object)null)
				{
					cropToolTip.DMOOOHEKDJC.FocusCrop(playerNum);
					Vector2 val2 = ((GraphicsMenuUI.CurrentZoomIndex(playerNum) == 0) ? cropToolTip.PJCHGKHIAML : cropToolTip.BJIDLCGEGHE);
					CropInfoUI.Get(playerNum).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)cropToolTip.DMOOOHEKDJC).transform.position.x + val2.x, ((Component)cropToolTip.DMOOOHEKDJC).transform.position.y + val2.y), Vector2.zero, cropToolTip.DMOOOHEKDJC.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), cropToolTip.BGKKKEHHNBE(cropToolTip.DMOOOHEKDJC), Mathf.Clamp(cropToolTip.DMBBLIAEIGA(cropToolTip.DMOOOHEKDJC), 0, cropToolTip.BGKKKEHHNBE(cropToolTip.DMOOOHEKDJC)), cropToolTip.LDJNGLHKDME(), Mathf.Clamp(cropToolTip.CMICJJLNJHB(), 0, cropToolTip.LDJNGLHKDME()), cropToolTip.IBECKFNJICA(cropToolTip.DMOOOHEKDJC));
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

	private bool GMBENOFKHND;

	private Coroutine BLEDLOEPHDO;

	[SerializeField]
	private int playerNum;

	private FertileSoil NAIBCCAOBIL;

	private CropSetter DMOOOHEKDJC;

	private Vector2 BJIDLCGEGHE = new Vector2(-1.25f, 1.5f);

	private Vector2 PJCHGKHIAML = new Vector2(-1.75f, 1.75f);

	private bool JIONFOENLJI(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	public void HLJPMDHFCOM()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(APABLNBBIGF(playerNum));
			GMBENOFKHND = false;
		}
	}

	private int IDLJIEGEGOA(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.GAHOHPPOFFD().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 0;
	}

	private bool AIONOHLLJBA(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private bool KJEDJCNDKLI(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	private int DKDJPMIIBNB(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 1;
	}

	private bool EHGJOOOIGDB(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private int OPMFLHCOFPN(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.CKMLILLFDMJ().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 0;
	}

	private int BMAIAMODBJA()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 4)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 1;
		}
		return 0;
	}

	public void KMHOJMHMHAK()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(KKEOFHBNMOO(playerNum));
			GMBENOFKHND = true;
		}
	}

	private bool FPNMLEIGIHJ(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	private void EEHOIHGGMID()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.IGHMHMNPMLB(playerNum).CloseUI();
			GMBENOFKHND = true;
		}
	}

	public void LFKONICIDEI()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(JHBEHKAJBIB(playerNum));
			GMBENOFKHND = true;
		}
	}

	private void Update()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum) && Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.Road && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 2)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.UnfocusCrop();
				}
				if (GMBENOFKHND)
				{
					KPECIIHFGLC();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				ShowCropUI();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				UnfocusAndHide();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.UnfocusCrop();
					}
					if (GMBENOFKHND)
					{
						KPECIIHFGLC();
					}
					DMOOOHEKDJC = cropSetter;
					ShowCropUI();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					UnfocusAndHide();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			KPECIIHFGLC();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA != Location.Road)
		{
			UnfocusAndHide();
		}
	}

	private int CBNPALGPIHF()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 8)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 0;
		}
		return 0;
	}

	private IEnumerator GEJLBPPFNHG(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private int OOPBJLCMOOH()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 7)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 1;
		}
		return 0;
	}

	public void DIBPEIMFKHH()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.UnfocusCrop();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.HKHFKAEEONM();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			KHHLKNDNIJF();
		}
	}

	public void ShowCropInfoWithGamepad(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			ShowCropUI();
		}
	}

	private int DMBBLIAEIGA(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 0;
	}

	public void BHLOCGOGMNA(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			HLJPMDHFCOM();
		}
	}

	private int LDBOCGEDFPB()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 4)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 0;
		}
		return 0;
	}

	public void HABGKKNOMCM()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(DFDCNMPEJAO(playerNum));
			GMBENOFKHND = false;
		}
	}

	private void HCPKBJDHLAC()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum) && Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.Tavern && (playerNum == 0 || (GameManager.LocalCoop() && playerNum == 1)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.HKHFKAEEONM();
				}
				if (GMBENOFKHND)
				{
					NMBAIIGPEKO();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				KMHOJMHMHAK();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				HOGEMJKIJEN();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.HKHFKAEEONM();
					}
					if (GMBENOFKHND)
					{
						NMBAIIGPEKO();
					}
					DMOOOHEKDJC = cropSetter;
					HABGKKNOMCM();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					CCHGJCOBAFE();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			KHHLKNDNIJF();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA != (Location.Tavern | Location.River))
		{
			GAPHENJGLHK();
		}
	}

	public void IEHDNOMLCIB()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.PGOFDJOBJNN();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.PGOFDJOBJNN();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			NEECPDPMEOB();
		}
	}

	private bool MLKAKCMLAHE(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private int HBGAIELEPEM(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.MIIKIEAINAL().daysToGrow > 0)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow;
		}
		if (BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 0;
	}

	private IEnumerator APABLNBBIGF(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private bool NOLPFFNPGOJ(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private void NEECPDPMEOB()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.NIDHCIHFOHB(playerNum).BOBCIFEDJED();
			GMBENOFKHND = true;
		}
	}

	private bool PNJJAKNFAAD(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	private bool JOJLLIIEFOC(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	private int DLDNKACIBGP(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow > 1)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow;
		}
		if (BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	private int MEAPPDDOBKE(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysToGrow;
		}
		if (BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	private void ONOAGANPECB()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum) && Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == (Location.Tavern | Location.Road) && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 5)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.LNOIGEGEIGJ();
				}
				if (GMBENOFKHND)
				{
					AOFHHBOBADF();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				HABGKKNOMCM();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				GAPHENJGLHK();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.HKHFKAEEONM();
					}
					if (GMBENOFKHND)
					{
						KPECIIHFGLC();
					}
					DMOOOHEKDJC = cropSetter;
					KMHOJMHMHAK();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					HOGEMJKIJEN();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			NMBAIIGPEKO();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA != (Location.Road | Location.River))
		{
			CCHGJCOBAFE();
		}
	}

	private void KFBOPABEJNL()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum) && Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.None && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 7)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.LNOIGEGEIGJ();
				}
				if (GMBENOFKHND)
				{
					EEHOIHGGMID();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				HLJPMDHFCOM();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				IEHDNOMLCIB();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.PGOFDJOBJNN();
					}
					if (GMBENOFKHND)
					{
						NEECPDPMEOB();
					}
					DMOOOHEKDJC = cropSetter;
					GKOENJDNJLE();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					UnfocusAndHide();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			GDBBPPDPAAI();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River))
		{
			BBJCIAPJKNJ();
		}
	}

	public void GAPHENJGLHK()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.LNOIGEGEIGJ();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.UnfocusCrop();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			KHHLKNDNIJF();
		}
	}

	private int CMICJJLNJHB()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 0;
	}

	private void GDBBPPDPAAI()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.IGHMHMNPMLB(playerNum).BOBCIFEDJED();
			GMBENOFKHND = true;
		}
	}

	private void AOFHHBOBADF()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.HJHCKIAKCKD(playerNum).BOBCIFEDJED();
			GMBENOFKHND = false;
		}
	}

	private int KFPDFGBBKHB(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 1;
	}

	private int JIHEBHGJDMH(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.CKMLILLFDMJ().daysToGrow > 0)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow;
		}
		if (BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	private int LDJNGLHKDME()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 3)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 3;
		}
		return 0;
	}

	public void BBJCIAPJKNJ()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.LNOIGEGEIGJ();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.UnfocusCrop();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			KHNMLDJIDAI();
		}
	}

	private int FIDBIGFDHGH(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.MIIKIEAINAL().daysToGrow > 0)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow;
		}
		if (BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	public void AJIHBMJGINO(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			HABGKKNOMCM();
		}
	}

	private void KHHLKNDNIJF()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.HJHCKIAKCKD(playerNum).CloseUI();
			GMBENOFKHND = false;
		}
	}

	private int BGKKKEHHNBE(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow > 0)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow;
		}
		if (BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 0;
	}

	private void KPECIIHFGLC()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.Get(playerNum).CloseUI();
			GMBENOFKHND = false;
		}
	}

	private IEnumerator JHBEHKAJBIB(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator NDPKIKEBPFI(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private int NOLBKAHCHHN(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysToGrow;
		}
		if (BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 1;
	}

	private int FECLKLCBHNI(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.MIIKIEAINAL().daysToGrow > 0)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow;
		}
		if (BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	public void DMMMMAEGCAF(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			LFKONICIDEI();
		}
	}

	private void NMBAIIGPEKO()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.AIMEAJAHLAA(playerNum).CloseUI();
			GMBENOFKHND = true;
		}
	}

	private bool KGNAIKNFNNA(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	public void GKOENJDNJLE()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(GEJLBPPFNHG(playerNum));
			GMBENOFKHND = true;
		}
	}

	private void KHNMLDJIDAI()
	{
		if (GMBENOFKHND)
		{
			if (BLEDLOEPHDO != null)
			{
				((MonoBehaviour)this).StopCoroutine(BLEDLOEPHDO);
				BLEDLOEPHDO = null;
			}
			CropInfoUI.HJHCKIAKCKD(playerNum).CloseUI();
			GMBENOFKHND = false;
		}
	}

	private int NOEGDECNFIP(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow > 1)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	private bool OOFECGJDHOG(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	private int OKEHBDOPDDM(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.CKMLILLFDMJ().daysToGrow > 0)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysToGrow;
		}
		if (BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 1;
	}

	private int OCIEKEALNKJ()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 7)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 8;
		}
		return 1;
	}

	public void CKDJEHANNOP()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(BMAFPDBEDLH(playerNum));
			GMBENOFKHND = false;
		}
	}

	private int ANOPFAFEGBL()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 1;
	}

	public void ShowCropUI()
	{
		if (!GMBENOFKHND)
		{
			BLEDLOEPHDO = ((MonoBehaviour)this).StartCoroutine(KGNADHHMGHE(playerNum));
			GMBENOFKHND = true;
		}
	}

	private void JMDOCHBJGKG()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum) && Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA == Location.Road && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 6)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.PGOFDJOBJNN();
				}
				if (GMBENOFKHND)
				{
					GDBBPPDPAAI();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				HLJPMDHFCOM();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				UnfocusAndHide();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.HKHFKAEEONM();
					}
					if (GMBENOFKHND)
					{
						KHHLKNDNIJF();
					}
					DMOOOHEKDJC = cropSetter;
					LFKONICIDEI();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					IEHDNOMLCIB();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			AOFHHBOBADF();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA != (Location.Tavern | Location.River))
		{
			DIBPEIMFKHH();
		}
	}

	private int HKLJFNCOMNN()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 5)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 7;
		}
		return 0;
	}

	private IEnumerator DFDCNMPEJAO(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private int KCFAJEPBGNP()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 1;
	}

	public void HOGEMJKIJEN()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.LNOIGEGEIGJ();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.PGOFDJOBJNN();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			NMBAIIGPEKO();
		}
	}

	private bool IEPMFIHJGOL(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private bool EPEFDDDAHKP(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private IEnumerator KKEOFHBNMOO(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		if ((Object)(object)NAIBCCAOBIL != (Object)null && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter) && (Object)(object)NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF != (Object)null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems != null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems.Length != 0 && Item.MLBOMGHINCA(NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item, null))
		{
			NAIBCCAOBIL.plantedCropSetter.FocusCrop(JIIGOACEIKL);
			Vector2 val = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)NAIBCCAOBIL).transform.position.x + val.x, ((Component)NAIBCCAOBIL).transform.position.y + val.y), Vector2.zero, NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter), Mathf.Clamp(DMBBLIAEIGA(NAIBCCAOBIL.plantedCropSetter), 0, BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(NAIBCCAOBIL.plantedCropSetter), Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.plantedCropSetter.growable.isDead);
		}
		else if ((Object)(object)DMOOOHEKDJC != (Object)null)
		{
			DMOOOHEKDJC.FocusCrop(JIIGOACEIKL);
			Vector2 val2 = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)DMOOOHEKDJC).transform.position.x + val2.x, ((Component)DMOOOHEKDJC).transform.position.y + val2.y), Vector2.zero, DMOOOHEKDJC.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(DMOOOHEKDJC), Mathf.Clamp(DMBBLIAEIGA(DMOOOHEKDJC), 0, BGKKKEHHNBE(DMOOOHEKDJC)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(DMOOOHEKDJC));
		}
	}

	private int KNEGKFGLPKC()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 0;
	}

	private int NOJDKGHMIHH()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 1;
	}

	public void MHDFHJIMEDC(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			HLJPMDHFCOM();
		}
	}

	private int DCMMICOFKGE(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.MIIKIEAINAL().daysToGrow > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysToGrow;
		}
		if (BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 1;
	}

	private int GIFNNIDHCMM()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 0;
	}

	public void CCHGJCOBAFE()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.PGOFDJOBJNN();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.LNOIGEGEIGJ();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			NMBAIIGPEKO();
		}
	}

	private int NDPJKLBHMON(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.GAHOHPPOFFD().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.FJJCOJGJCLF.daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 0;
	}

	private int OHFAHOEKENP(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.CKMLILLFDMJ().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest == 0)
		{
			return 0;
		}
		return 1;
	}

	private IEnumerator GNILMKLEEHF(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		if ((Object)(object)NAIBCCAOBIL != (Object)null && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter) && (Object)(object)NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF != (Object)null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems != null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems.Length != 0 && Item.MLBOMGHINCA(NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item, null))
		{
			NAIBCCAOBIL.plantedCropSetter.FocusCrop(JIIGOACEIKL);
			Vector2 val = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)NAIBCCAOBIL).transform.position.x + val.x, ((Component)NAIBCCAOBIL).transform.position.y + val.y), Vector2.zero, NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter), Mathf.Clamp(DMBBLIAEIGA(NAIBCCAOBIL.plantedCropSetter), 0, BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(NAIBCCAOBIL.plantedCropSetter), Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.plantedCropSetter.growable.isDead);
		}
		else if ((Object)(object)DMOOOHEKDJC != (Object)null)
		{
			DMOOOHEKDJC.FocusCrop(JIIGOACEIKL);
			Vector2 val2 = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)DMOOOHEKDJC).transform.position.x + val2.x, ((Component)DMOOOHEKDJC).transform.position.y + val2.y), Vector2.zero, DMOOOHEKDJC.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(DMOOOHEKDJC), Mathf.Clamp(DMBBLIAEIGA(DMOOOHEKDJC), 0, BGKKKEHHNBE(DMOOOHEKDJC)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(DMOOOHEKDJC));
		}
	}

	private void EJMAJFGPGEC()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum) && Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.None && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 6)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.UnfocusCrop();
				}
				if (GMBENOFKHND)
				{
					NMBAIIGPEKO();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				HABGKKNOMCM();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				IEHDNOMLCIB();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.UnfocusCrop();
					}
					if (GMBENOFKHND)
					{
						KHHLKNDNIJF();
					}
					DMOOOHEKDJC = cropSetter;
					ShowCropUI();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					GAPHENJGLHK();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			GDBBPPDPAAI();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA != (Location.Road | Location.River))
		{
			IEHDNOMLCIB();
		}
	}

	private IEnumerator BMAFPDBEDLH(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		if ((Object)(object)NAIBCCAOBIL != (Object)null && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter) && (Object)(object)NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF != (Object)null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems != null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems.Length != 0 && Item.MLBOMGHINCA(NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item, null))
		{
			NAIBCCAOBIL.plantedCropSetter.FocusCrop(JIIGOACEIKL);
			Vector2 val = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)NAIBCCAOBIL).transform.position.x + val.x, ((Component)NAIBCCAOBIL).transform.position.y + val.y), Vector2.zero, NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter), Mathf.Clamp(DMBBLIAEIGA(NAIBCCAOBIL.plantedCropSetter), 0, BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(NAIBCCAOBIL.plantedCropSetter), Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.plantedCropSetter.growable.isDead);
		}
		else if ((Object)(object)DMOOOHEKDJC != (Object)null)
		{
			DMOOOHEKDJC.FocusCrop(JIIGOACEIKL);
			Vector2 val2 = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)DMOOOHEKDJC).transform.position.x + val2.x, ((Component)DMOOOHEKDJC).transform.position.y + val2.y), Vector2.zero, DMOOOHEKDJC.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(DMOOOHEKDJC), Mathf.Clamp(DMBBLIAEIGA(DMOOOHEKDJC), 0, BGKKKEHHNBE(DMOOOHEKDJC)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(DMOOOHEKDJC));
		}
	}

	private int KJJFOMCNCNE()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 1)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 5;
		}
		return 0;
	}

	private bool IBECKFNJICA(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private int FHCGNIOLGCO(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.FJJCOJGJCLF.daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 1;
	}

	public void GILAMNFBLFE(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			KMHOJMHMHAK();
		}
	}

	public void UnfocusAndHide()
	{
		if (GMBENOFKHND)
		{
			if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
			{
				NAIBCCAOBIL.plantedCropSetter.UnfocusCrop();
			}
			if ((Object)(object)DMOOOHEKDJC != (Object)null)
			{
				DMOOOHEKDJC.UnfocusCrop();
			}
			NAIBCCAOBIL = null;
			DMOOOHEKDJC = null;
			KPECIIHFGLC();
		}
	}

	private bool BMDPHKLAMGE(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	private bool KEPKCJFHFMD(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return true;
	}

	public void ECHPKLDOIBA(FertileSoil NAIBCCAOBIL = null, CropSetter BOIGHCFJHPF = null)
	{
		if ((Object)(object)this.NAIBCCAOBIL != (Object)(object)NAIBCCAOBIL || (Object)(object)DMOOOHEKDJC != (Object)(object)BOIGHCFJHPF)
		{
			this.NAIBCCAOBIL = NAIBCCAOBIL;
			DMOOOHEKDJC = BOIGHCFJHPF;
			HLJPMDHFCOM();
		}
	}

	private bool PMLFHILANNJ(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable))
		{
			return BOIGHCFJHPF.growable.grown;
		}
		return false;
	}

	private int IHECPCKCBMF()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.daysUntilDry > 0)
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return 7;
		}
		return 1;
	}

	private void DDLLFPICOJK()
	{
		if (!PlayerInputs.EEJEOALIHFJ(playerNum) && Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River) && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 3)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.UnfocusCrop();
				}
				if (GMBENOFKHND)
				{
					KHNMLDJIDAI();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				ShowCropUI();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				DIBPEIMFKHH();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.UnfocusCrop();
					}
					if (GMBENOFKHND)
					{
						NEECPDPMEOB();
					}
					DMOOOHEKDJC = cropSetter;
					LFKONICIDEI();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					UnfocusAndHide();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			GDBBPPDPAAI();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA != Location.Camp)
		{
			GAPHENJGLHK();
		}
	}

	private IEnumerator CPNEICBGDPK(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator KGNADHHMGHE(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait02;
		if ((Object)(object)NAIBCCAOBIL != (Object)null && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter) && (Object)(object)NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF != (Object)null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems != null && NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems.Length != 0 && Item.MLBOMGHINCA(NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item, null))
		{
			NAIBCCAOBIL.plantedCropSetter.FocusCrop(JIIGOACEIKL);
			Vector2 val = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)NAIBCCAOBIL).transform.position.x + val.x, ((Component)NAIBCCAOBIL).transform.position.y + val.y), Vector2.zero, NAIBCCAOBIL.plantedCropSetter.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter), Mathf.Clamp(DMBBLIAEIGA(NAIBCCAOBIL.plantedCropSetter), 0, BGKKKEHHNBE(NAIBCCAOBIL.plantedCropSetter)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(NAIBCCAOBIL.plantedCropSetter), Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable) && NAIBCCAOBIL.plantedCropSetter.growable.isDead);
		}
		else if ((Object)(object)DMOOOHEKDJC != (Object)null)
		{
			DMOOOHEKDJC.FocusCrop(JIIGOACEIKL);
			Vector2 val2 = ((GraphicsMenuUI.CurrentZoomIndex(JIIGOACEIKL) == 0) ? PJCHGKHIAML : BJIDLCGEGHE);
			CropInfoUI.Get(JIIGOACEIKL).ShowCropInfoPanel(MDIKPGGBNLI: true, new Vector2(((Component)DMOOOHEKDJC).transform.position.x + val2.x, ((Component)DMOOOHEKDJC).transform.position.y + val2.y), Vector2.zero, DMOOOHEKDJC.FJJCOJGJCLF.harvestedItems[0].item.JMDALJBNFML(), BGKKKEHHNBE(DMOOOHEKDJC), Mathf.Clamp(DMBBLIAEIGA(DMOOOHEKDJC), 0, BGKKKEHHNBE(DMOOOHEKDJC)), LDJNGLHKDME(), Mathf.Clamp(CMICJJLNJHB(), 0, LDJNGLHKDME()), IBECKFNJICA(DMOOOHEKDJC));
		}
	}

	private void MGMLDHPOLGK()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum) && Object.op_Implicit((Object)(object)PlayerController.GetPlayer(playerNum)) && PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA == Location.Road && (playerNum == 1 || (GameManager.LocalCoop() && playerNum == 3)))
		{
			FertileSoil fertileSoil = Utils.COGFNHHIAML<FertileSoil>(playerNum);
			if ((Object)(object)fertileSoil != (Object)null && ((Object)(object)NAIBCCAOBIL == (Object)null || (Object)(object)NAIBCCAOBIL != (Object)(object)fertileSoil))
			{
				if ((Object)(object)NAIBCCAOBIL != (Object)null && (Object)(object)NAIBCCAOBIL.plantedCropSetter != (Object)null)
				{
					NAIBCCAOBIL.plantedCropSetter.HKHFKAEEONM();
				}
				if (GMBENOFKHND)
				{
					GDBBPPDPAAI();
				}
				NAIBCCAOBIL = fertileSoil;
				DMOOOHEKDJC = null;
				KMHOJMHMHAK();
			}
			if (((Object)(object)fertileSoil == (Object)null || (Object)(object)fertileSoil.plantedCropSetter == (Object)null) && (Object)(object)NAIBCCAOBIL != (Object)null)
			{
				GAPHENJGLHK();
				NAIBCCAOBIL = null;
			}
			if ((Object)(object)NAIBCCAOBIL == (Object)null)
			{
				CropSetter cropSetter = Utils.COGFNHHIAML<CropSetter>(playerNum);
				if ((Object)(object)cropSetter != (Object)null && ((Object)(object)DMOOOHEKDJC == (Object)null || (Object)(object)DMOOOHEKDJC != (Object)(object)cropSetter))
				{
					if ((Object)(object)DMOOOHEKDJC != (Object)null)
					{
						DMOOOHEKDJC.LNOIGEGEIGJ();
					}
					if (GMBENOFKHND)
					{
						AOFHHBOBADF();
					}
					DMOOOHEKDJC = cropSetter;
					ShowCropUI();
				}
				else if ((Object)(object)cropSetter == (Object)null && (Object)(object)DMOOOHEKDJC != (Object)null)
				{
					HOGEMJKIJEN();
					DMOOOHEKDJC = null;
				}
			}
		}
		if ((Object)(object)NAIBCCAOBIL == (Object)null && (Object)(object)DMOOOHEKDJC == (Object)null && GMBENOFKHND)
		{
			NEECPDPMEOB();
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(playerNum)) && PlayerController.GetPlayer(playerNum).LEOIMFNKFGA != Location.Tavern)
		{
			GAPHENJGLHK();
		}
	}

	private int KJHLGFGBKJH(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.CKMLILLFDMJ().daysToGrow > 1)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest > 0)
		{
			return BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 1;
	}

	private int OEICOEIOOLJ()
	{
		if (Object.op_Implicit((Object)(object)NAIBCCAOBIL) && Object.op_Implicit((Object)(object)NAIBCCAOBIL.plantedCropSetter.growable))
		{
			return NAIBCCAOBIL.daysUntilDry;
		}
		return 0;
	}

	private int AJKMOFEBLEF(CropSetter BOIGHCFJHPF)
	{
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.growable) && !BOIGHCFJHPF.growable.grown && BOIGHCFJHPF.CKMLILLFDMJ().daysToGrow > 0)
		{
			return BOIGHCFJHPF.growable.daysPlanted;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.CKMLILLFDMJ().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.GAHOHPPOFFD().daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && !BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.BEHHLAKBJHH().daysUntilNewHarvest > 1)
		{
			return BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest - BOIGHCFJHPF.growable.daysUntilNewHarvest;
		}
		if (Object.op_Implicit((Object)(object)BOIGHCFJHPF.harvestable) && BOIGHCFJHPF.harvestable.isHarvestable && BOIGHCFJHPF.MIIKIEAINAL().daysUntilNewHarvest == 0)
		{
			return 1;
		}
		return 0;
	}

	private IEnumerator LFHENPHGDBP(int JIIGOACEIKL)
	{
		return new MFIIOIJJBCN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}
}
