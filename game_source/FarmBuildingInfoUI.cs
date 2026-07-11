using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarmBuildingInfoUI : UIWindow
{
	[CompilerGenerated]
	private sealed class FDEAPGEPOFH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FarmBuildingInfoUI _003C_003E4__this;

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
		public FDEAPGEPOFH(int _003C_003E1__state)
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
			FarmBuildingInfoUI farmBuildingInfoUI = _003C_003E4__this;
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
				((Component)farmBuildingInfoUI.slotsRectTransform).gameObject.SetActive(false);
				((Component)farmBuildingInfoUI.slotsRectTransform).gameObject.SetActive(true);
				farmBuildingInfoUI.slotsRectTransform.ForceUpdateRectTransforms();
				((Component)farmBuildingInfoUI.panelRectTransform).gameObject.SetActive(false);
				((Component)farmBuildingInfoUI.panelRectTransform).gameObject.SetActive(true);
				farmBuildingInfoUI.panelRectTransform.ForceUpdateRectTransforms();
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

	public static FarmBuildingInfoUI[] instances = new FarmBuildingInfoUI[3];

	public FarmBuilding farmBuilding;

	public FarmBuildingInfoElementUI[] buildingInfoElementsUI;

	public RectTransform panelRectTransform;

	public RectTransform slotsRectTransform;

	public static FarmBuildingInfoUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void COENJDKIANC()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].HACIMPFAPDK(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].SetAnimal(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator ELHMKNIBODP()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HKCJMLGPMDL()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].MLJDKBFGFFI(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].GECFABPBACA(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator HMLJACDDJIE()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI KLJCCHJHDGG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator KKDCCGNJMPC()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKKAKFPCCGG()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].ADDOGEEBFBC(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].OBAAIGNMHIF(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator DLPJHFOABBP()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void IPBCGDFNFOA()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].OPJFIDIMLFP(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].DHFBOJHOMBL(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator MIHIOHBNIPI()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator COALEEPFDAH()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FarmBuildingInfoUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MINKCNDFOGH()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].OPJFIDIMLFP(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].MOMJKAJHMJO(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
	}

	private void FHKJPIPPFIK()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].NHLNOOFDIJG(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].HACIMPFAPDK(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator NLECPFPJKPN()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FarmBuildingInfoUI NAGEHKBLJDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI GGMEKCGEAME(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ACMCEMDGFKD()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI BBDNJAKIBFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator EJEHFHPHKEC()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			GameActionBarUI.Get(base.JIIGOACEIKL).Close();
			base.OpenUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Sound.GGFJGHHHEJC.openWood[0], HOMFPAFAOGD: true);
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			DFEFDEFAOEP();
			((MonoBehaviour)this).StartCoroutine(ACLJCPIGFIJ());
		}
	}

	private void PPPMDEHEONN()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].JNCBMKIIDEE(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].AJMOLKNJEKC(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI FHKGDLNJFFA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator CDCDJOAFCKP()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IOJDLCGFMEC()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void MLKAPHKIKMJ()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].MKBNFFCHOLF(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].GLAHBFDLBFG(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator MPNPNEKMODC()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DFEFDEFAOEP()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].SetAnimal(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].SetAnimal(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI BDJFHFHLJGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LJHOKDHKDDJ()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].FPCNLCLMGLF(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].COKJNCGMHMD(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void DAIOAJPBGDM()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].OPJFIDIMLFP(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].FOJLBBHLLLE(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator NBNIOECLIPA()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ABFNLLCIEGA()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].AJLNLIGJMMO(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].HACIMPFAPDK(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator GIHLDMEKGEA()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FarmBuildingInfoUI BMFHCBOFHCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator DICPEOFDBBM()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FarmBuildingInfoUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI EOPIEMLAPFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OLJEFMBBAPI()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].NHLNOOFDIJG(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].NHLNOOFDIJG(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI JCBPABNCBPI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator AIMDBGJFIPG()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NICOBMANBHJ()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].DHFBOJHOMBL(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].MAGNGFJIMFD(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI AFABPBHKCNG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JDFCKPOFMGK()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].FOJLBBHLLLE(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].HACIMPFAPDK(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator LGILFEOAIGN()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI HILKHEKNGIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI NHOFBAMNELD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI PNBHIEINMGH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CABAPCHAJDM()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].AJMOLKNJEKC(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].AJLNLIGJMMO(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void LJDFOMAHOJN()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].MLJDKBFGFFI(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].SetAnimal(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator KCEFHCCNOMH()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI BALFIBPNIMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void JDJJEDCDEKD()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].ADDOGEEBFBC(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].BONNALKFCMC(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator NJEKEMCCMNF()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FarmBuildingInfoUI FKFNANNBIAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator LGFLDAJEAKK()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ENDAJFBJLGM()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void ODFCAFIHCOO()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].MOMJKAJHMJO(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].MOMJKAJHMJO(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator HEFKLOAHOLN()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JCMMCLHHGON()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].MLJDKBFGFFI(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].HACIMPFAPDK(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KEDABJCJHBA()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].BONNALKFCMC(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].COKJNCGMHMD(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EEMOKIAMJNE()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].GECFABPBACA(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].AJLNLIGJMMO(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator CHIFOMLBOKA()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void OGDAGDGBIPF()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].DHFBOJHOMBL(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].BONNALKFCMC(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator EDLAKDLALLL()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void LJLNGFKFPJH()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].AJLNLIGJMMO(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].HACIMPFAPDK(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI GFPBMGCMHHC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI IEHEFJBFHJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator AMJKBEBNAJN()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static FarmBuildingInfoUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ECEBGJJFLMF()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HDOCNJPHMIH()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].SetAnimal(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].AJMOLKNJEKC(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void JANKJNDOOIA()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].COKJNCGMHMD(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].SetAnimal(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void HLCAHGDAKNK()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].MOMJKAJHMJO(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].FPCNLCLMGLF(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator NHDGENKMLLE()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator MNAAGHJPBAD()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI IEPGACAGIPO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator MCCLBFJDAMN()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void ICBMMHBKCJN()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].SetAnimal(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].ADDOGEEBFBC(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void PDCAPNMEDHN()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].OPJFIDIMLFP(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].COKJNCGMHMD(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI KGGNGGIMANJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI BFCEHJIIAHN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator KOCMMLCIIJG()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BEIDBNLPJMO()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].GLAHBFDLBFG(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].DMBOEAOMOJP(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void EMAFPKJFGGH()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].MOMJKAJHMJO(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].JNCBMKIIDEE(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI OKLAEBFGLDP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void GHDDAKPJMKC()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].AJMOLKNJEKC(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].ADDOGEEBFBC(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void JKGFBHOLCJJ()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].MOMJKAJHMJO(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].OBAAIGNMHIF(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator NHOKBPHNDIP()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EPMHMOLCECL()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].HACIMPFAPDK(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].COKJNCGMHMD(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator POBEAKMBBEA()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			farmBuilding = null;
		}
	}

	private void MKEHMFBMJBN()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].MLJDKBFGFFI(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].OPJFIDIMLFP(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void ELEJEIELLKL()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].COKJNCGMHMD(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].COKJNCGMHMD(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void DIGKFCFOGMC()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].DMBOEAOMOJP(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].DMBOEAOMOJP(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void JKHKGKAEIEG()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].FOJLBBHLLLE(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].HACIMPFAPDK(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator ACLJCPIGFIJ()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator KKINCGPBEGA()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator MCCNGBJJOEB()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void AMLPEAAOLGJ()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i += 0)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].GECFABPBACA(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j += 0)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].NHLNOOFDIJG(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmBuildingInfoUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KJDEIBCNHAA()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(true);
			buildingInfoElementsUI[i].SetAnimal(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
				buildingInfoElementsUI[j].SetAnimal(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	public static FarmBuildingInfoUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator GELIKOBANEL()
	{
		return new FDEAPGEPOFH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DJJKMICOLBO()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].SetAnimal(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].JNCBMKIIDEE(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(false);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(false);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private void IJHLHIHDOJA()
	{
		List<AnimalNPC> allAnimals = farmBuilding.GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			((Component)buildingInfoElementsUI[i]).gameObject.SetActive(false);
			buildingInfoElementsUI[i].AJMOLKNJEKC(base.JIIGOACEIKL, allAnimals[i]);
		}
		for (int j = allAnimals.Count; j < buildingInfoElementsUI.Length; j++)
		{
			if (j < farmBuilding.maxAnimalsAssigned[farmBuilding.EONJGMONIOM])
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
				buildingInfoElementsUI[j].MOMJKAJHMJO(base.JIIGOACEIKL, null);
			}
			else
			{
				((Component)buildingInfoElementsUI[j]).gameObject.SetActive(true);
			}
		}
		((Component)slotsRectTransform).gameObject.SetActive(true);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(true);
		((Component)panelRectTransform).gameObject.SetActive(false);
		panelRectTransform.ForceUpdateRectTransforms();
	}

	private IEnumerator OPAFDIKFFHI()
	{
		yield return null;
		((Component)slotsRectTransform).gameObject.SetActive(false);
		((Component)slotsRectTransform).gameObject.SetActive(true);
		slotsRectTransform.ForceUpdateRectTransforms();
		((Component)panelRectTransform).gameObject.SetActive(false);
		((Component)panelRectTransform).gameObject.SetActive(true);
		panelRectTransform.ForceUpdateRectTransforms();
	}
}
