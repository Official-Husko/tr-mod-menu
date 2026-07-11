using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraRenderSettings : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OLBMBNGKIFN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraRenderSettings _003C_003E4__this;

		public bool force;

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
		public OLBMBNGKIFN(int _003C_003E1__state)
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
			CameraRenderSettings cameraRenderSettings = _003C_003E4__this;
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
				cameraRenderSettings.RenderOccupiedPositions(force);
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

	[SerializeField]
	private int playerNum = 1;

	[SerializeField]
	private GameObject worldLight;

	[SerializeField]
	private Camera mainCamera;

	private Placeable HMBOBOMFBBC;

	public static Placeable placeablePlayer;

	private IEnumerator LDHKGGCKKFL(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	private void AGLMANDDNNM(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.JFJOKGAOPHA().globalLight.color = DayLight.JFJOKGAOPHA().dayColor;
				DayLight.LADDMEMMJFP().globalLight.intensity = DayLight.AJIGOHGPFPP().dayIntensity;
			}
			else if (playerNum == 1)
			{
				DayLight.LADDMEMMJFP().globalLight.color = DayLight.JFJOKGAOPHA().dayColor2;
				DayLight.JFJOKGAOPHA().globalLight.intensity = DayLight.PDECKLKPKCG().dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IKAEFEPNADI(playerNum).ABKOAIKBFIF());
			}
			IKMNBBNPDIE();
			OKPMPIPPNOB(AINPJHKNJGL: true);
			ParallaxBackground.KAEBEPOOIOJ(playerNum);
		}
	}

	private IEnumerator BMHOEBMJBJA(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	private IEnumerator HNDHGLABOHF(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	private void IAIDKPJKLIC()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		ONDMNCNJKIH();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GCFOOMIJPCA));
		}
		RenderPipelineManager.beginCameraRendering += JFNCIAEFFLG;
	}

	private void EKJBNEFAHPB()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: false);
			for (int i = 0; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].EHGFFELHNKJ();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 6 : 0).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 2 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum == 1) ? 1 : 0).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.DIHCEGINELM()) || WorkAreasManager.MJCMPKPCNGB().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.ABDJJBFNLBJ().workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void ALIKMEAPHAA()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].KIIHGAFIFPC();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 1 : 1).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 2).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 5).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LPFNKEOJJKE()) || WorkAreasManager.LPFNKEOJJKE().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.OMFKNGDCJFN().workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void LJLKBKEADGI()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		PGDEIFILCGE();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MICDAJNBEKJ));
		}
		RenderPipelineManager.beginCameraRendering += IJHIBDJGLAE;
	}

	private void IJHIBDJGLAE(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.GGFJGHHHEJC.globalLight.color = DayLight.GGFJGHHHEJC.dayColor;
				DayLight.GGFJGHHHEJC.globalLight.intensity = DayLight.GGFJGHHHEJC.dayIntensity;
			}
			else if (playerNum == 2)
			{
				DayLight.GGFJGHHHEJC.globalLight.color = DayLight.GGFJGHHHEJC.dayColor2;
				DayLight.GGFJGHHHEJC.globalLight.intensity = DayLight.GGFJGHHHEJC.dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.GetPlayer(playerNum).IKNOJDMCFOK);
			}
			ICIKPECCEDF();
			RenderOccupiedPositions();
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void FELDNFFIJGP()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].DGFANNACCAB();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 2 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 5 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum == 1) ? 1 : 1).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LFPEPJBNCBF()) || WorkAreasManager.MJCMPKPCNGB().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.LFPEPJBNCBF().workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	public void MOHNJICMBDG(bool AINPJHKNJGL = false)
	{
		if (Item.MLBOMGHINCA(SelectObject.BNMEANGDMIP(playerNum).DPIGODELPGH(), null))
		{
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, null);
			return;
		}
		HMBOBOMFBBC = SelectObject.BNMEANGDMIP(playerNum).placeable;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
		{
			if (AINPJHKNJGL || !((object)HMBOBOMFBBC).Equals((object?)placeablePlayer))
			{
				placeablePlayer = HMBOBOMFBBC;
				GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, HMBOBOMFBBC);
			}
		}
		else
		{
			placeablePlayer = null;
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, HMBOBOMFBBC, DPAGEJGMCKD: true);
		}
	}

	private void JPCBDKFLFJL()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].KKCKOEFGLDN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 5 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 3 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum == 0) ? 1 : 1).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.MJCMPKPCNGB()) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.DIHCEGINELM().workAreas.Count; j += 0)
		{
			for (int k = 0; k < WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void LOHAMDHOLDD()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		ONBGIEHHFFD();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IOLHGHOICCG));
		}
		RenderPipelineManager.beginCameraRendering += AEPHKMCGPJH;
	}

	private void BOEOHBAFMEN(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.BNMEANGDMIP(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.GGFJGHHHEJC.globalLight.color = DayLight.MOJDNGDNCCO().dayColor;
				DayLight.KPDFIEMDDCL().globalLight.intensity = DayLight.KPDFIEMDDCL().dayIntensity;
			}
			else if (playerNum == 8)
			{
				DayLight.MOJDNGDNCCO().globalLight.color = DayLight.JFJOKGAOPHA().dayColor2;
				DayLight.LADDMEMMJFP().globalLight.intensity = DayLight.MOJDNGDNCCO().dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IPBEEBLCHHA(playerNum).KHJOICBMIKN());
			}
			LGDCHADNGAG();
			OKPMPIPPNOB(AINPJHKNJGL: true);
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void NBEIMFMBHEM()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].DGFANNACCAB();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum != 0) ? 1 : 6).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 8 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum != 1) ? 1 : 7).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.DIHCEGINELM()) || WorkAreasManager.DIHCEGINELM().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.DIHCEGINELM().workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void AGJEKFEOANI()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: false);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].KIIHGAFIFPC();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 1 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 2 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum == 0) ? 5 : 0).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.MJCMPKPCNGB()) || WorkAreasManager.DIHCEGINELM().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.LFPEPJBNCBF().workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private IEnumerator ICOOKAMMFKL(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	private void BDJKNKIOPIJ()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		PGDEIFILCGE();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MJONBMJFDAC));
		}
		RenderPipelineManager.beginCameraRendering += INHAIBAAGFG;
	}

	private IEnumerator FFPAKGEKAJL(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	public void AAAFHBGCNCL(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(APFFOBJOLBG(AINPJHKNJGL));
	}

	private void HCEDMLJNOBL()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		MHIKDANJNNC();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MHIKDANJNNC));
		}
		RenderPipelineManager.beginCameraRendering += JFNCIAEFFLG;
	}

	public void ABDCENONBPB(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(GAIPCHHEKDG(AINPJHKNJGL));
	}

	public void KMGBPEFHFOD(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(BEFBPCIBCCG(AINPJHKNJGL));
	}

	private void OEMGDNIMMAB(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.BNMEANGDMIP(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 0)
			{
				DayLight.JFJOKGAOPHA().globalLight.color = DayLight.GGFJGHHHEJC.dayColor;
				DayLight.JFJOKGAOPHA().globalLight.intensity = DayLight.LADDMEMMJFP().dayIntensity;
			}
			else if (playerNum == 2)
			{
				DayLight.LADDMEMMJFP().globalLight.color = DayLight.LADDMEMMJFP().dayColor2;
				DayLight.MOJDNGDNCCO().globalLight.intensity = DayLight.JFJOKGAOPHA().dayIntensity2;
			}
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IFGBDFBGAED(playerNum).EOAJCBCCBBM());
			}
			FEDDFLKDOGP();
			COODAEPKKDO();
			ParallaxBackground.MHILKJPMINO(playerNum);
		}
	}

	private void DBKNEIOPCMK()
	{
		if (SceneReferences.IsValid())
		{
			worldLight = SceneReferences.FAOPFMBMMJJ().worldLight;
		}
	}

	private void LGDCHADNGAG()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].JIHCMABECBD();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 5).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 2).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 1) ? 1 : 5).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.MJCMPKPCNGB()) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.MJCMPKPCNGB().workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void INHAIBAAGFG(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 0)
			{
				DayLight.KPDFIEMDDCL().globalLight.color = DayLight.PDECKLKPKCG().dayColor;
				DayLight.PDECKLKPKCG().globalLight.intensity = DayLight.MOJDNGDNCCO().dayIntensity;
			}
			else if (playerNum == 5)
			{
				DayLight.KPDFIEMDDCL().globalLight.color = DayLight.KPDFIEMDDCL().dayColor2;
				DayLight.GGFJGHHHEJC.globalLight.intensity = DayLight.MOJDNGDNCCO().dayIntensity2;
			}
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i += 0)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.BCIIIGAFBMB(playerNum).NBFODKENEAN());
			}
			ICIKPECCEDF();
			PAIFLOGILFD(AINPJHKNJGL: true);
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void FEDDFLKDOGP()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].KKCKOEFGLDN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum == 0) ? 7 : 0).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 1 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum == 0) ? 4 : 0).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.MJCMPKPCNGB()) || WorkAreasManager.ABDJJBFNLBJ().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.MJCMPKPCNGB().workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void AHGPALJKOKP()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		MJONBMJFDAC();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(MJONBMJFDAC));
		}
		RenderPipelineManager.beginCameraRendering += INHAIBAAGFG;
	}

	private void HOFKJPBBLGP()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		IENILBHJHBD();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MHIKDANJNNC));
		}
		RenderPipelineManager.beginCameraRendering += FEBKCNEHPEE;
	}

	private void OHPIHNJOHFN()
	{
		if (SceneReferences.EEHODLICINM())
		{
			worldLight = SceneReferences.CFAMKBHIGLO().worldLight;
		}
	}

	private void NCIBKMLIIAJ()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		MICDAJNBEKJ();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OHPIHNJOHFN));
		}
		RenderPipelineManager.beginCameraRendering += FEBKCNEHPEE;
	}

	private void GCFOOMIJPCA()
	{
		if (SceneReferences.IsValid())
		{
			worldLight = SceneReferences.GetSceneReferences().worldLight;
		}
	}

	private void IENILBHJHBD()
	{
		if (SceneReferences.AKEMBBNDPNH())
		{
			worldLight = SceneReferences.CFAMKBHIGLO().worldLight;
		}
	}

	private void IMIONHLAKIH()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		IENILBHJHBD();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OHPIHNJOHFN));
		}
		RenderPipelineManager.beginCameraRendering += JFNCIAEFFLG;
	}

	public void OKPMPIPPNOB(bool AINPJHKNJGL = false)
	{
		if (Item.FKLOBGBIHLB(SelectObject.GetPlayer(playerNum).ELBNNJOALFG, null))
		{
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, null, DPAGEJGMCKD: true);
			return;
		}
		HMBOBOMFBBC = SelectObject.GetPlayer(playerNum).placeable;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
		{
			if (AINPJHKNJGL || !((object)HMBOBOMFBBC).Equals((object?)placeablePlayer))
			{
				placeablePlayer = HMBOBOMFBBC;
				GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, HMBOBOMFBBC);
			}
		}
		else
		{
			placeablePlayer = null;
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, HMBOBOMFBBC, DPAGEJGMCKD: true);
		}
	}

	private void EBNENBFLEKB()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		PGDEIFILCGE();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MHIKDANJNNC));
		}
		RenderPipelineManager.beginCameraRendering += FEBKCNEHPEE;
	}

	private IEnumerator MGEPOPBADKE(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	public void RenderOccupiedPositionsNextFrame(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(APFFOBJOLBG(AINPJHKNJGL));
	}

	private void DDKPAPNNDME()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].LIGKHPIBELN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 1 : 1).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 4).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum != 1) ? 1 : 4).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LFPEPJBNCBF()) || WorkAreasManager.LFPEPJBNCBF().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void ONDMNCNJKIH()
	{
		if (SceneReferences.FMIGGMHHJNM())
		{
			worldLight = SceneReferences.GetSceneReferences().worldLight;
		}
	}

	public void NCCHEJJEIGO(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(PPDMHGMLCOJ(AINPJHKNJGL));
	}

	private void ODKGLIDMCNP()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		IOLHGHOICCG();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DBKNEIOPCMK));
		}
		RenderPipelineManager.beginCameraRendering += JFNCIAEFFLG;
	}

	private void FEBKCNEHPEE(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.KPDFIEMDDCL().globalLight.color = DayLight.JFJOKGAOPHA().dayColor;
				DayLight.JFJOKGAOPHA().globalLight.intensity = DayLight.AJIGOHGPFPP().dayIntensity;
			}
			else if (playerNum == 3)
			{
				DayLight.KPDFIEMDDCL().globalLight.color = DayLight.PDECKLKPKCG().dayColor2;
				DayLight.LADDMEMMJFP().globalLight.intensity = DayLight.GGFJGHHHEJC.dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i += 0)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.GetPlayer(playerNum).KHJOICBMIKN());
			}
			DDKPAPNNDME();
			PAIFLOGILFD();
			ParallaxBackground.MHILKJPMINO(playerNum);
		}
	}

	private IEnumerator MHANHCNGGBJ(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private void CIAGAOGKCIA()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: false);
			for (int i = 1; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].JIHCMABECBD();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 8).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 5 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum != 1) ? 1 : 7).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.MJCMPKPCNGB()) || WorkAreasManager.DIHCEGINELM().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.LPFNKEOJJKE().workAreas.Count; j += 0)
		{
			for (int k = 0; k < WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private IEnumerator APFFOBJOLBG(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private IEnumerator GAIPCHHEKDG(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	private void DHHNJFIJFFK(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 0)
			{
				DayLight.AJIGOHGPFPP().globalLight.color = DayLight.MOJDNGDNCCO().dayColor;
				DayLight.AJIGOHGPFPP().globalLight.intensity = DayLight.KPDFIEMDDCL().dayIntensity;
			}
			else if (playerNum == 7)
			{
				DayLight.PDECKLKPKCG().globalLight.color = DayLight.MOJDNGDNCCO().dayColor2;
				DayLight.JFJOKGAOPHA().globalLight.intensity = DayLight.GGFJGHHHEJC.dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IPBEEBLCHHA(playerNum).LJAKJBBLCKA());
			}
			ALIKMEAPHAA();
			MOHNJICMBDG();
			ParallaxBackground.KAEBEPOOIOJ(playerNum);
		}
	}

	private void MDNNFJPEOLG(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.BNMEANGDMIP(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.LADDMEMMJFP().globalLight.color = DayLight.GGFJGHHHEJC.dayColor;
				DayLight.AJIGOHGPFPP().globalLight.intensity = DayLight.JFJOKGAOPHA().dayIntensity;
			}
			else if (playerNum == 4)
			{
				DayLight.MOJDNGDNCCO().globalLight.color = DayLight.KPDFIEMDDCL().dayColor2;
				DayLight.KPDFIEMDDCL().globalLight.intensity = DayLight.LADDMEMMJFP().dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.BCIIIGAFBMB(playerNum).ABKOAIKBFIF());
			}
			PPCFEHFFIKK();
			PAIFLOGILFD(AINPJHKNJGL: true);
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void HHODHFNIICF()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: false);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].JKDGLDEBDDG();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 7 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum == 0) ? 3 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 8).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LFPEPJBNCBF()) || WorkAreasManager.DIHCEGINELM().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.OMFKNGDCJFN().workAreas.Count; j += 0)
		{
			for (int k = 0; k < WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	public void MBOMNLPFDMP(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(MHANHCNGGBJ(AINPJHKNJGL));
	}

	private IEnumerator FDJAAGEHONK(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private void GJMLHECPGBP()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		GCFOOMIJPCA();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ONDMNCNJKIH));
		}
		RenderPipelineManager.beginCameraRendering += BOEOHBAFMEN;
	}

	private void MIHJFMPJKFK()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: false);
			for (int i = 1; i < SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].DGFANNACCAB();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 6).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 1 : 1).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum == 0) ? 6 : 0).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LFPEPJBNCBF()) || WorkAreasManager.LPFNKEOJJKE().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void ONBGIEHHFFD()
	{
		if (SceneReferences.AKEMBBNDPNH())
		{
			worldLight = SceneReferences.CKDKHMPHENE().worldLight;
		}
	}

	private IEnumerator BEFBPCIBCCG(bool AINPJHKNJGL)
	{
		return new OLBMBNGKIFN(1)
		{
			_003C_003E4__this = this,
			force = AINPJHKNJGL
		};
	}

	public void COODAEPKKDO(bool AINPJHKNJGL = false)
	{
		if (Item.FKLOBGBIHLB(SelectObject.GetPlayer(playerNum).DPIGODELPGH(), null))
		{
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, null, DPAGEJGMCKD: true);
			return;
		}
		HMBOBOMFBBC = SelectObject.GetPlayer(playerNum).placeable;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
		{
			if (AINPJHKNJGL || !((object)HMBOBOMFBBC).Equals((object?)placeablePlayer))
			{
				placeablePlayer = HMBOBOMFBBC;
				GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, HMBOBOMFBBC);
			}
		}
		else
		{
			placeablePlayer = null;
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, HMBOBOMFBBC);
		}
	}

	public void LOBLHBOBLOE(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(FKNBJBPNIGN(AINPJHKNJGL));
	}

	private void IDHPPNPLLOI()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: false);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].LIGKHPIBELN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 1) ? 1 : 5).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 6 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum == 0) ? 1 : 1).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.ABDJJBFNLBJ().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.LFPEPJBNCBF().workAreas.Count; j++)
		{
			for (int k = 1; k < WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void IKMNBBNPDIE()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].KKCKOEFGLDN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 4).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 0) ? 1 : 2).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum == 1) ? 0 : 0).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.MJCMPKPCNGB().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.DIHCEGINELM().workAreas.Count; j += 0)
		{
			for (int k = 0; k < WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void IABEJCPMJOF()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		GCFOOMIJPCA();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ONBGIEHHFFD));
		}
		RenderPipelineManager.beginCameraRendering += AGLMANDDNNM;
	}

	private void FGOLBHCNCPJ()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: false);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].JKDGLDEBDDG();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 8).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 1) ? 8 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum == 0) ? 6 : 0).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LFPEPJBNCBF()) || WorkAreasManager.LPFNKEOJJKE().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.ABDJJBFNLBJ().workAreas.Count; j += 0)
		{
			for (int k = 0; k < WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void IOLHGHOICCG()
	{
		if (SceneReferences.IsValid())
		{
			worldLight = SceneReferences.CFAMKBHIGLO().worldLight;
		}
	}

	private void AEPHKMCGPJH(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.BNMEANGDMIP(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.PDECKLKPKCG().globalLight.color = DayLight.KPDFIEMDDCL().dayColor;
				DayLight.AJIGOHGPFPP().globalLight.intensity = DayLight.LADDMEMMJFP().dayIntensity;
			}
			else if (playerNum == 1)
			{
				DayLight.AJIGOHGPFPP().globalLight.color = DayLight.PDECKLKPKCG().dayColor2;
				DayLight.KPDFIEMDDCL().globalLight.intensity = DayLight.PDECKLKPKCG().dayIntensity2;
			}
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IKAEFEPNADI(playerNum).KOLINMJFBMC());
			}
			FGOLBHCNCPJ();
			MOHNJICMBDG();
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void GEBOEPBMKFC(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.BNMEANGDMIP(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 0)
			{
				DayLight.MOJDNGDNCCO().globalLight.color = DayLight.MOJDNGDNCCO().dayColor;
				DayLight.KPDFIEMDDCL().globalLight.intensity = DayLight.KPDFIEMDDCL().dayIntensity;
			}
			else if (playerNum == 6)
			{
				DayLight.JFJOKGAOPHA().globalLight.color = DayLight.MOJDNGDNCCO().dayColor2;
				DayLight.LADDMEMMJFP().globalLight.intensity = DayLight.AJIGOHGPFPP().dayIntensity2;
			}
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i += 0)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.DAEEJGKLOCF(playerNum).EOAJCBCCBBM());
			}
			IDHPPNPLLOI();
			OKPMPIPPNOB(AINPJHKNJGL: true);
			ParallaxBackground.KAEBEPOOIOJ(playerNum);
		}
	}

	private void JMJEMCAANCL(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.MOJDNGDNCCO().globalLight.color = DayLight.AJIGOHGPFPP().dayColor;
				DayLight.LADDMEMMJFP().globalLight.intensity = DayLight.GGFJGHHHEJC.dayIntensity;
			}
			else if (playerNum == 6)
			{
				DayLight.PDECKLKPKCG().globalLight.color = DayLight.MOJDNGDNCCO().dayColor2;
				DayLight.PDECKLKPKCG().globalLight.intensity = DayLight.JFJOKGAOPHA().dayIntensity2;
			}
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i += 0)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IPBEEBLCHHA(playerNum).GENBKJNGEAB());
			}
			HNCNOCEAPHP();
			COODAEPKKDO();
			ParallaxBackground.MHILKJPMINO(playerNum);
		}
	}

	private void EDAOABICGFH()
	{
		if (SceneReferences.IsValid())
		{
			worldLight = SceneReferences.FAOPFMBMMJJ().worldLight;
		}
	}

	private void BGENEAOILOF()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		IENILBHJHBD();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ONDMNCNJKIH));
		}
		RenderPipelineManager.beginCameraRendering += OEMGDNIMMAB;
	}

	private void AEPBFPCHGPP()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		EDAOABICGFH();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HGKDLCFFNPL));
		}
		RenderPipelineManager.beginCameraRendering += IJHIBDJGLAE;
	}

	public void PMLBMOOCMPF(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(KMHLODOBPAC(AINPJHKNJGL));
	}

	private IEnumerator ADGOJKFDICF(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private void PAHEKJNKJMN()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].LIGKHPIBELN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 4 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 0) ? 1 : 5).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 1) ? 1 : 7).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.DIHCEGINELM().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.MJCMPKPCNGB().workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void Start()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		MJONBMJFDAC();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(MJONBMJFDAC));
		}
		RenderPipelineManager.beginCameraRendering += IJHIBDJGLAE;
	}

	public void HALKPCFLOJF(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(FDJAAGEHONK(AINPJHKNJGL));
	}

	private void KGOPPKMMHAO(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.BNMEANGDMIP(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.PDECKLKPKCG().globalLight.color = DayLight.AJIGOHGPFPP().dayColor;
				DayLight.LADDMEMMJFP().globalLight.intensity = DayLight.GGFJGHHHEJC.dayIntensity;
			}
			else if (playerNum == 5)
			{
				DayLight.LADDMEMMJFP().globalLight.color = DayLight.JFJOKGAOPHA().dayColor2;
				DayLight.PDECKLKPKCG().globalLight.intensity = DayLight.LADDMEMMJFP().dayIntensity2;
			}
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.IGMCBPOPNCA(playerNum).EGPEHBKMIOE());
			}
			DDKPAPNNDME();
			COODAEPKKDO();
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void MHIKDANJNNC()
	{
		if (SceneReferences.FMIGGMHHJNM())
		{
			worldLight = SceneReferences.CFAMKBHIGLO().worldLight;
		}
	}

	private void PPCFEHFFIKK()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].CheckIsValidWhileSelected();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum == 0) ? 6 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 0) ? 1 : 7).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 1) ? 1 : 6).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.OMFKNGDCJFN()) || WorkAreasManager.LPFNKEOJJKE().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.ABDJJBFNLBJ().workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private IEnumerator KMHLODOBPAC(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private void JFNCIAEFFLG(ScriptableRenderContext DFDAJCMBHLJ, Camera IHIOCPGNCOI)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((object)mainCamera).Equals((object?)IHIOCPGNCOI) && !((Object)(object)SelectObject.GetPlayer(playerNum) == (Object)null) && !((Object)(object)worldLight == (Object)null))
		{
			if (playerNum == 1)
			{
				DayLight.KPDFIEMDDCL().globalLight.color = DayLight.PDECKLKPKCG().dayColor;
				DayLight.MOJDNGDNCCO().globalLight.intensity = DayLight.MOJDNGDNCCO().dayIntensity;
			}
			else if (playerNum == 8)
			{
				DayLight.KPDFIEMDDCL().globalLight.color = DayLight.AJIGOHGPFPP().dayColor2;
				DayLight.KPDFIEMDDCL().globalLight.intensity = DayLight.PDECKLKPKCG().dayIntensity2;
			}
			for (int i = 1; i < TavernManager.GGFJGHHHEJC.customersRowdy.Count; i++)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy[i].UpdateTavernVisionColor(TavernVisionManager.CPOONCIFDIC(playerNum).EOAJCBCCBBM());
			}
			CIAGAOGKCIA();
			PAIFLOGILFD();
			ParallaxBackground.RenderParallax(playerNum);
		}
	}

	private void MJONBMJFDAC()
	{
		if (SceneReferences.IsValid())
		{
			worldLight = SceneReferences.GetSceneReferences().worldLight;
		}
	}

	private void ICIKPECCEDF()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].CheckIsValidWhileSelected();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 2).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 2).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum != 1) ? 1 : 2).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	public void GMNKJMBIKHG(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(FFPAKGEKAJL(AINPJHKNJGL));
	}

	public void NEKEPJELPAE(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(NKOIPPOFHAO(AINPJHKNJGL));
	}

	public void CDOBIEEMOLI(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(HNDHGLABOHF(AINPJHKNJGL));
	}

	private void MICDAJNBEKJ()
	{
		if (SceneReferences.FMIGGMHHJNM())
		{
			worldLight = SceneReferences.GetSceneReferences().worldLight;
		}
	}

	private void HNCNOCEAPHP()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].JKDGLDEBDDG();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 1 : 1).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 7 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 1) ? 1 : 0).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.LPFNKEOJJKE()) || WorkAreasManager.ABDJJBFNLBJ().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.DIHCEGINELM().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	public void PAIFLOGILFD(bool AINPJHKNJGL = false)
	{
		if (Item.MLBOMGHINCA(SelectObject.GetPlayer(playerNum).ELBNNJOALFG, null))
		{
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, null, DPAGEJGMCKD: true);
			return;
		}
		HMBOBOMFBBC = SelectObject.BNMEANGDMIP(playerNum).placeable;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
		{
			if (AINPJHKNJGL || !((object)HMBOBOMFBBC).Equals((object?)placeablePlayer))
			{
				placeablePlayer = HMBOBOMFBBC;
				GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, HMBOBOMFBBC);
			}
		}
		else
		{
			placeablePlayer = null;
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, HMBOBOMFBBC);
		}
	}

	private void MAGIHNMLMLH()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].KIIHGAFIFPC();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 8 : 0).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 2).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum != 1) ? 1 : 2).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.ABDJJBFNLBJ()) || WorkAreasManager.MJCMPKPCNGB().workAreas == null)
		{
			return;
		}
		for (int j = 1; j < WorkAreasManager.LFPEPJBNCBF().workAreas.Count; j++)
		{
			for (int k = 0; k < WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	public void DLNPFDIGHLL(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(GAIPCHHEKDG(AINPJHKNJGL));
	}

	private void PGDEIFILCGE()
	{
		if (SceneReferences.FMIGGMHHJNM())
		{
			worldLight = SceneReferences.FAOPFMBMMJJ().worldLight;
		}
	}

	public void LDPAEMEGJDD(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(NKOIPPOFHAO(AINPJHKNJGL));
	}

	public void GIPPCBHNLIB(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(PPDMHGMLCOJ(AINPJHKNJGL));
	}

	private void HGKDLCFFNPL()
	{
		if (SceneReferences.IsValid())
		{
			worldLight = SceneReferences.FAOPFMBMMJJ().worldLight;
		}
	}

	private IEnumerator PPDMHGMLCOJ(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	public void CAJBHKMCLLF(bool AINPJHKNJGL = false)
	{
		((MonoBehaviour)this).StartCoroutine(GAIPCHHEKDG(AINPJHKNJGL));
	}

	public void RenderOccupiedPositions(bool AINPJHKNJGL = false)
	{
		if (Item.MLBOMGHINCA(SelectObject.GetPlayer(playerNum).ELBNNJOALFG, null))
		{
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, null, DPAGEJGMCKD: true);
			return;
		}
		HMBOBOMFBBC = SelectObject.GetPlayer(playerNum).placeable;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
		{
			if (AINPJHKNJGL || !((object)HMBOBOMFBBC).Equals((object?)placeablePlayer))
			{
				placeablePlayer = HMBOBOMFBBC;
				GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: true, HMBOBOMFBBC);
			}
		}
		else
		{
			placeablePlayer = null;
			GameTileMaps.GGFJGHHHEJC.ShowCanPlaceObjects(playerNum, HGNKFFMDOOL: false, HMBOBOMFBBC);
		}
	}

	private IEnumerator NKOIPPOFHAO(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private void KLEBBGFFILB()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].PGHCDGKBOHC();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 7).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum == 1) ? 3 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum != 0) ? 1 : 0).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: false);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.LFPEPJBNCBF().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; j++)
		{
			for (int k = 1; k < WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces.Count; k += 0)
			{
				if ((Object)(object)WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LPFNKEOJJKE().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void DBHMOFOGDJC()
	{
		if ((Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.FCJDEDFGEKN(DAEMAAOLHMG: true);
			for (int i = 1; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i += 0)
			{
				SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares[i].LIGKHPIBELN();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 0 : 0).placeable != (Object)null && (Object)(object)SelectObject.BNMEANGDMIP((playerNum == 0) ? 3 : 0).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer((playerNum != 0) ? 1 : 7).placeable.areaSpace.EGGCICPNBOL(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.ABDJJBFNLBJ()) || WorkAreasManager.MJCMPKPCNGB().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.ABDJJBFNLBJ().workAreas.Count; j++)
		{
			for (int k = 1; k < WorkAreasManager.MJCMPKPCNGB().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.OMFKNGDCJFN().workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.LFPEPJBNCBF().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private void GJCGECHHDAN()
	{
		if ((Object)(object)SelectObject.GetPlayer(playerNum).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer(playerNum).placeable.areaSpace != (Object)null)
		{
			SelectObject.GetPlayer(playerNum).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
			for (int i = 0; i < SelectObject.GetPlayer(playerNum).placeable.areaSpace.areaSquares.Length; i++)
			{
				SelectObject.BNMEANGDMIP(playerNum).placeable.areaSpace.areaSquares[i].JKDGLDEBDDG();
			}
		}
		if (GameManager.LocalCoop() && (Object)(object)SelectObject.GetPlayer((playerNum != 1) ? 1 : 4).placeable != (Object)null && (Object)(object)SelectObject.GetPlayer((playerNum != 0) ? 1 : 2).placeable.areaSpace != (Object)null)
		{
			SelectObject.BNMEANGDMIP((playerNum == 0) ? 4 : 0).placeable.areaSpace.ActivateParent(DAEMAAOLHMG: true);
		}
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.OMFKNGDCJFN()) || WorkAreasManager.LFPEPJBNCBF().workAreas == null)
		{
			return;
		}
		for (int j = 0; j < WorkAreasManager.LPFNKEOJJKE().workAreas.Count; j += 0)
		{
			for (int k = 1; k < WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces.Count; k++)
			{
				if ((Object)(object)WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k] != (Object)null)
				{
					WorkAreasManager.GGFJGHHHEJC.workAreas[j].areaSpaces[k].ActivateParentIfIsVisible(playerNum);
					WorkAreasManager.ABDJJBFNLBJ().workAreas[j].areaSpaces[k].ActivateAreaSquares(playerNum);
				}
			}
		}
	}

	private IEnumerator FKNBJBPNIGN(bool AINPJHKNJGL)
	{
		yield return null;
		RenderOccupiedPositions(AINPJHKNJGL);
	}

	private void IAAGKLPMAMK()
	{
		if ((Object)(object)mainCamera == (Object)null)
		{
			mainCamera = ((Component)this).GetComponent<Camera>();
		}
		DBKNEIOPCMK();
		if ((Object)(object)worldLight == (Object)null)
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ONBGIEHHFFD));
		}
		RenderPipelineManager.beginCameraRendering += AGLMANDDNNM;
	}
}
