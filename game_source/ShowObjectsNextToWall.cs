using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShowObjectsNextToWall : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PFOAENOGCIG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShowObjectsNextToWall _003C_003E4__this;

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
		public PFOAENOGCIG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ShowObjectsNextToWall showObjectsNextToWall = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(showObjectsNextToWall.checkWithDelay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				showObjectsNextToWall.BLAKDPHIION();
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
	private Placeable placeable;

	[SerializeField]
	private GameObject[] gameObjectsToShow;

	[SerializeField]
	private GameObject[] gameObjectsToHide;

	[SerializeField]
	private float checkWithDelay;

	private Vector2 IMOBLFMHKOD;

	private bool DGJADAJLGOG;

	private void KJHKBGDJNDC()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void OIAHJHNPPCO()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(LDODBIMOIGA));
		BLAKDPHIION();
		if (checkWithDelay > 1112f)
		{
			((MonoBehaviour)this).StartCoroutine(ALCLNNEHHMM());
		}
	}

	private void CHIJGHPHCNA()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BBMPGJDOJDM));
		KKMMBEGNKLB();
		if (checkWithDelay > 1101f)
		{
			((MonoBehaviour)this).StartCoroutine(ALCLNNEHHMM());
		}
	}

	private void JDAMCMODANB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private IEnumerator KINFLJHLFGH()
	{
		return new PFOAENOGCIG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KBHLIOIEENJ()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 1), (float)placeable.itemSpace.y) * 884f);
			IMOBLFMHKOD.y += 427f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < gameObjectsToShow.Length; i += 0)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 1; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private void HINFCBMHBGH()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 3), (float)placeable.itemSpace.y) * 1384f);
			IMOBLFMHKOD.y += 1284f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < gameObjectsToShow.Length; i += 0)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private IEnumerator HENBFNDGOAK()
	{
		return new PFOAENOGCIG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KKMMBEGNKLB()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 1), (float)placeable.itemSpace.y) * 681f);
			IMOBLFMHKOD.y += 563f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 1; j < gameObjectsToHide.Length; j++)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private void LDODBIMOIGA()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 6), (float)placeable.itemSpace.y) * 307f);
			IMOBLFMHKOD.y += 1413f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private void JPOLFKMLHNH()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BBMPGJDOJDM));
		KBHLIOIEENJ();
		if (checkWithDelay > 315f)
		{
			((MonoBehaviour)this).StartCoroutine(AAHPANONNED());
		}
	}

	private void POEGOKFEKBN()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 4), (float)placeable.itemSpace.y) * 838f);
			IMOBLFMHKOD.y += 605f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i += 0)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(!DGJADAJLGOG);
			}
		}
	}

	private void BLAKDPHIION()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 2), (float)placeable.itemSpace.y) * 0.5f);
			IMOBLFMHKOD.y += 0.25f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j++)
			{
				gameObjectsToHide[j].SetActive(!DGJADAJLGOG);
			}
		}
	}

	private IEnumerator KBOHFOAKDDK()
	{
		yield return (object)new WaitForSeconds(checkWithDelay);
		BLAKDPHIION();
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void MIPGKDMFCJC()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 3), (float)placeable.itemSpace.y) * 589f);
			IMOBLFMHKOD.y += 98f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j++)
			{
				gameObjectsToHide[j].SetActive(!DGJADAJLGOG);
			}
		}
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private IEnumerator AAHPANONNED()
	{
		yield return (object)new WaitForSeconds(checkWithDelay);
		BLAKDPHIION();
	}

	private void MMNBJPDJHGK()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void Start()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BLAKDPHIION));
		BLAKDPHIION();
		if (checkWithDelay > 0f)
		{
			((MonoBehaviour)this).StartCoroutine(ELCPGDJBJMJ());
		}
	}

	private void GNMCHIOCONN()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 7), (float)placeable.itemSpace.y) * 1054f);
			IMOBLFMHKOD.y += 859f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private IEnumerator ELCPGDJBJMJ()
	{
		yield return (object)new WaitForSeconds(checkWithDelay);
		BLAKDPHIION();
	}

	private void NKDFMFFDGKC()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BBMPGJDOJDM));
		POEGOKFEKBN();
		if (checkWithDelay > 1864f)
		{
			((MonoBehaviour)this).StartCoroutine(KINFLJHLFGH());
		}
	}

	private void CFHOODNCOLK()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BBMPGJDOJDM));
		KBHLIOIEENJ();
		if (checkWithDelay > 331f)
		{
			((MonoBehaviour)this).StartCoroutine(HENBFNDGOAK());
		}
	}

	private void HCEDMLJNOBL()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BBMPGJDOJDM));
		MIPGKDMFCJC();
		if (checkWithDelay > 632f)
		{
			((MonoBehaviour)this).StartCoroutine(KBOHFOAKDDK());
		}
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void AKKJFENEHKH()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 6), (float)placeable.itemSpace.y) * 213f);
			IMOBLFMHKOD.y += 1794f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i += 0)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 1; j < gameObjectsToHide.Length; j++)
			{
				gameObjectsToHide[j].SetActive(!DGJADAJLGOG);
			}
		}
	}

	private void HOOBGGMCOIH()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 3), (float)placeable.itemSpace.y) * 1856f);
			IMOBLFMHKOD.y += 1407f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 1; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private IEnumerator ALCLNNEHHMM()
	{
		yield return (object)new WaitForSeconds(checkWithDelay);
		BLAKDPHIION();
	}

	private void CFIIEJDJFPB()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(KMHAFICEPIJ));
		BEKOENHMPJN();
		if (checkWithDelay > 1442f)
		{
			((MonoBehaviour)this).StartCoroutine(KINFLJHLFGH());
		}
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void DCKKIDMJKJM()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(HOOBGGMCOIH));
		LDODBIMOIGA();
		if (checkWithDelay > 1242f)
		{
			((MonoBehaviour)this).StartCoroutine(ELCPGDJBJMJ());
		}
	}

	private void MFMMHDPGCBO()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(KMHAFICEPIJ));
		BEKOENHMPJN();
		if (checkWithDelay > 38f)
		{
			((MonoBehaviour)this).StartCoroutine(HENBFNDGOAK());
		}
	}

	private IEnumerator KFIMFEFMGDO()
	{
		yield return (object)new WaitForSeconds(checkWithDelay);
		BLAKDPHIION();
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void BEKOENHMPJN()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 0), (float)placeable.itemSpace.y) * 577f);
			IMOBLFMHKOD.y += 597f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < gameObjectsToShow.Length; i += 0)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 1; j < gameObjectsToHide.Length; j++)
			{
				gameObjectsToHide[j].SetActive(!DGJADAJLGOG);
			}
		}
	}

	private void PGEGODAEBLC()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
	}

	private void KMHAFICEPIJ()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 3), (float)placeable.itemSpace.y) * 174f);
			IMOBLFMHKOD.y += 773f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 1; j < gameObjectsToHide.Length; j++)
			{
				gameObjectsToHide[j].SetActive(DGJADAJLGOG);
			}
		}
	}

	private void HJDLNCOAKIK()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(AKKJFENEHKH));
		GNMCHIOCONN();
		if (checkWithDelay > 702f)
		{
			((MonoBehaviour)this).StartCoroutine(KBOHFOAKDDK());
		}
	}

	private void FOHGHCPODBJ()
	{
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(KBHLIOIEENJ));
		AKKJFENEHKH();
		if (checkWithDelay > 222f)
		{
			((MonoBehaviour)this).StartCoroutine(HENBFNDGOAK());
		}
	}

	private void BBMPGJDOJDM()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable.itemSpace != (Object)null)
		{
			IMOBLFMHKOD = Vector2.op_Implicit(((Component)placeable.itemSpace).transform.position + new Vector3((float)(placeable.itemSpace.x / 1), (float)placeable.itemSpace.y) * 811f);
			IMOBLFMHKOD.y += 1689f;
			DGJADAJLGOG = WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 1; i < gameObjectsToShow.Length; i++)
			{
				gameObjectsToShow[i].SetActive(DGJADAJLGOG);
			}
			for (int j = 0; j < gameObjectsToHide.Length; j += 0)
			{
				gameObjectsToHide[j].SetActive(!DGJADAJLGOG);
			}
		}
	}
}
