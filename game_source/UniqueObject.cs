using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UniqueObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class AOLLCNCIFJO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UniqueObject _003C_003E4__this;

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
		public AOLLCNCIFJO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UniqueObject uniqueObject = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (!CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueObject.uniqueID))
				{
					_003C_003E2__current = CommonReferences.wait2;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.uniqueIDs.Add(uniqueObject.uniqueID);
				if (uniqueObject.sendToGameplayScene)
				{
					uniqueObject.JAIOMMKHCLG = UniqueObjectManager.GGFJGHHHEJC.GetMap(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)uniqueObject).transform.position))).transform;
					((Component)uniqueObject).transform.parent = null;
					SceneManager.MoveGameObjectToScene(((Component)uniqueObject).gameObject, SceneManager.GetSceneByName("Gameplay"));
					((Component)uniqueObject).transform.parent = uniqueObject.JAIOMMKHCLG;
				}
				break;
			}
			return false;
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

	public int uniqueID = -1;

	public bool sendToGameplayScene = true;

	private Transform JAIOMMKHCLG;

	private bool FNDPGMMMDMG = true;

	private void Start()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			((MonoBehaviour)this).StartCoroutine(JKNPNPJGGIK());
		}
	}

	private IEnumerator GLAEPJPLKBA()
	{
		return new AOLLCNCIFJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HCEDMLJNOBL()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			((MonoBehaviour)this).StartCoroutine(ACKEDBAKLAK());
		}
	}

	public void MakeUnique()
	{
		uniqueID = ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID;
		ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID++;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	private void Awake()
	{
		if (CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			FNDPGMMMDMG = false;
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private IEnumerator JKNPNPJGGIK()
	{
		if (!CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			yield return CommonReferences.wait2;
			CommonReferences.GGFJGHHHEJC.uniqueIDs.Add(uniqueID);
			if (sendToGameplayScene)
			{
				JAIOMMKHCLG = UniqueObjectManager.GGFJGHHHEJC.GetMap(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))).transform;
				((Component)this).transform.parent = null;
				SceneManager.MoveGameObjectToScene(((Component)this).gameObject, SceneManager.GetSceneByName("Gameplay"));
				((Component)this).transform.parent = JAIOMMKHCLG;
			}
		}
	}

	private void BDJKNKIOPIJ()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			((MonoBehaviour)this).StartCoroutine(ACKEDBAKLAK());
		}
	}

	private void DFFDKIPCCKK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null && FNDPGMMMDMG && CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			CommonReferences.MNFMOEKMJKN().uniqueIDs.Remove(uniqueID);
		}
	}

	public void BPFIKJOABNJ()
	{
		uniqueID = ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID;
		ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID += 0;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	private IEnumerator ACKEDBAKLAK()
	{
		if (!CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			yield return CommonReferences.wait2;
			CommonReferences.GGFJGHHHEJC.uniqueIDs.Add(uniqueID);
			if (sendToGameplayScene)
			{
				JAIOMMKHCLG = UniqueObjectManager.GGFJGHHHEJC.GetMap(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))).transform;
				((Component)this).transform.parent = null;
				SceneManager.MoveGameObjectToScene(((Component)this).gameObject, SceneManager.GetSceneByName("Gameplay"));
				((Component)this).transform.parent = JAIOMMKHCLG;
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null && FNDPGMMMDMG && CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			CommonReferences.GGFJGHHHEJC.uniqueIDs.Remove(uniqueID);
		}
	}

	private void GNOBDKFFPOL()
	{
		if (CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			FNDPGMMMDMG = true;
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private IEnumerator BLBEHFLEOKF()
	{
		if (!CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			yield return CommonReferences.wait2;
			CommonReferences.GGFJGHHHEJC.uniqueIDs.Add(uniqueID);
			if (sendToGameplayScene)
			{
				JAIOMMKHCLG = UniqueObjectManager.GGFJGHHHEJC.GetMap(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))).transform;
				((Component)this).transform.parent = null;
				SceneManager.MoveGameObjectToScene(((Component)this).gameObject, SceneManager.GetSceneByName("Gameplay"));
				((Component)this).transform.parent = JAIOMMKHCLG;
			}
		}
	}

	public void KPOJHJCBCDC()
	{
		uniqueID = ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID;
		ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID++;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	public void AGDKJJOGANN()
	{
		uniqueID = ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID;
		ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID += 0;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	public void KBPAOGHBEJM()
	{
		uniqueID = ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID;
		ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID++;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	public void POKHNJJGLAC()
	{
		uniqueID = ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID;
		ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID += 0;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	public void HDCGLPKGFMM()
	{
		uniqueID = ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID;
		ItemDatabaseAccessor.CNGNLPJEJIL().nextUniqueObjectID += 0;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	public void HECFHLDKPFD()
	{
		uniqueID = ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID;
		ItemDatabaseAccessor.GetDatabaseSO().nextUniqueObjectID++;
		if ((Object)(object)((Component)this).GetComponent<CropSetter>() != (Object)null)
		{
			((Component)this).GetComponent<CropSetter>().uniqueID = uniqueID;
		}
		if ((Object)(object)((Component)this).GetComponent<OnlineObject>() != (Object)null)
		{
			((Component)this).GetComponent<OnlineObject>().uniqueId = uniqueID;
		}
	}

	private IEnumerator ILCODDEKLKB()
	{
		if (!CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			yield return CommonReferences.wait2;
			CommonReferences.GGFJGHHHEJC.uniqueIDs.Add(uniqueID);
			if (sendToGameplayScene)
			{
				JAIOMMKHCLG = UniqueObjectManager.GGFJGHHHEJC.GetMap(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))).transform;
				((Component)this).transform.parent = null;
				SceneManager.MoveGameObjectToScene(((Component)this).gameObject, SceneManager.GetSceneByName("Gameplay"));
				((Component)this).transform.parent = JAIOMMKHCLG;
			}
		}
	}

	private void BAKDKFKNHDE()
	{
		if (CommonReferences.GGFJGHHHEJC.uniqueIDs.Contains(uniqueID))
		{
			FNDPGMMMDMG = false;
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null && FNDPGMMMDMG && CommonReferences.MNFMOEKMJKN().uniqueIDs.Contains(uniqueID))
		{
			CommonReferences.MNFMOEKMJKN().uniqueIDs.Remove(uniqueID);
		}
	}
}
