using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MultipleNPCBarksController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class HBPKPGAIEGF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultipleNPCBarksController _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public HBPKPGAIEGF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MultipleNPCBarksController multipleNPCBarksController = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				multipleNPCBarksController.IBFCBKFNMIO = true;
				goto IL_0121;
			}
			_003C_003E1__state = -1;
			multipleNPCBarksController.IBFCBKFNMIO = false;
			multipleNPCBarksController.LFCHGJGBBDP = Random.Range(1, multipleNPCBarksController.maxSimlutaneousBarks + 1);
			_003Ci_003E5__2 = 0;
			goto IL_015b;
			IL_012f:
			if (!multipleNPCBarksController.IBFCBKFNMIO && multipleNPCBarksController.CNKOJJMNBHB < 20)
			{
				multipleNPCBarksController.LLPGKHHKCLC = Random.Range(0, multipleNPCBarksController.dialogueNpcsList.Count);
				if (multipleNPCBarksController.dialogueNpcsList.Count > 0 && !multipleNPCBarksController.dialogueNpcsList[multipleNPCBarksController.LLPGKHHKCLC].inUse && !multipleNPCBarksController.dialogueNpcsList[multipleNPCBarksController.LLPGKHHKCLC].inBark && multipleNPCBarksController.dialogueNpcsList[multipleNPCBarksController.LLPGKHHKCLC].canTalk && ((Component)multipleNPCBarksController.dialogueNpcsList[multipleNPCBarksController.LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					multipleNPCBarksController.dialogueNpcsList[multipleNPCBarksController.LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					_003C_003E2__current = (object)new WaitForSeconds(Random.Range(3f, 7f));
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0121;
			}
			multipleNPCBarksController.IBFCBKFNMIO = false;
			_003Ci_003E5__2++;
			goto IL_015b;
			IL_0121:
			multipleNPCBarksController.CNKOJJMNBHB++;
			goto IL_012f;
			IL_015b:
			if (_003Ci_003E5__2 >= multipleNPCBarksController.LFCHGJGBBDP + 1)
			{
				multipleNPCBarksController.CNKOJJMNBHB = 0;
				multipleNPCBarksController.AELCMIGFOAK = Random.Range(multipleNPCBarksController.minBarkTime, multipleNPCBarksController.maxBarkTime) + Time.time;
				multipleNPCBarksController.BEGCPKOAJCP = null;
				return false;
			}
			goto IL_012f;
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

	public int maxSimlutaneousBarks;

	public float minBarkTime;

	public float maxBarkTime;

	public SimpleDialogueNPC[] dialogueNpcs;

	private float AELCMIGFOAK;

	private int LFCHGJGBBDP;

	private int LLPGKHHKCLC;

	private int CNKOJJMNBHB;

	private bool IBFCBKFNMIO;

	private Coroutine BEGCPKOAJCP;

	public List<SimpleDialogueNPC> dialogueNpcsList;

	private IEnumerator BAAOJKMODJP()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NJGKPGHNLDO()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 1; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(MOCCIIOJPGJ());
		}
	}

	private void LAABMDDEGCG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NJGKPGHNLDO();
		}
	}

	private IEnumerator LPHBNGPDHNE()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HFFFFAJFIPB()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OMOMBEBJLHG()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(MKAIPIAFEPA());
		}
	}

	private void KINDENLIOEH()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(MCDLEIHALIL());
		}
	}

	private void OAGBBKNOHAL()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(COOLFBMCCHG());
		}
	}

	private void HKKDEKIFPPJ()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void ICBBMEKEMBK()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(FLBDAIPFJOM());
		}
	}

	private void GHDNPKJFHEE()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(DIKIAEBKLIF());
		}
	}

	private void CHIJGHPHCNA()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator PPLNONIDHGD()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JCEBEDFCJAM()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private void OGBGFLMKFHH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IHGEPHPHFHM();
		}
	}

	private void LANGHIOBJIH()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator DIKIAEBKLIF()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IAAGKLPMAMK()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OGNIDHAIABM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GJDBEJJFBCH();
		}
	}

	private void MNFJELNEGPG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OFIIHJLMLHG();
		}
	}

	private void DOKHLDBIDJB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			EHPDBAEHGPF();
		}
	}

	private IEnumerator NDAIGCOIGHD()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CBALKGMHPBJ()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(AINEJONDLLK());
		}
	}

	private void IAIDKPJKLIC()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void LHHHGBEJAPC()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 1; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NGOPMBMDLBO());
		}
	}

	private void FPOIFOGELHC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BKFNPGONJKK();
		}
	}

	private void NNBIAIMPNGL()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void ILNLIDKHEBH()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(FLBDAIPFJOM());
		}
	}

	private void OFIIHJLMLHG()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(DIKIAEBKLIF());
		}
	}

	private void JPHFCJIBBMI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			KINDENLIOEH();
		}
	}

	private void Update()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OMOMBEBJLHG();
		}
	}

	private void LLIALNPHBJB()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(BAAOJKMODJP());
		}
	}

	private void FCCFKNEALEB()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(MKAIPIAFEPA());
		}
	}

	private void GJDBEJJFBCH()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 1; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(MKAIPIAFEPA());
		}
	}

	private void OLDDEAJMHNI()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void NCIBKMLIIAJ()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void DHBMBJOLGDE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			NJGKPGHNLDO();
		}
	}

	private IEnumerator COOLFBMCCHG()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private IEnumerator FLBDAIPFJOM()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private void BHKNJOEBCKA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MOFDIIMKEOP();
		}
	}

	private IEnumerator FPKIAEOKKHE()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MEAFJDDNAJB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KINDENLIOEH();
		}
	}

	private void EHPDBAEHGPF()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 1; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(OBBFHPLLHOE());
		}
	}

	private void EOGHJNGJFID()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void EEKOJEKPIMP()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator OHMPPOAHIDA()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private void IAICCKPOBMJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GJDBEJJFBCH();
		}
	}

	private void EGACIHOKJLH()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void FOHGHCPODBJ()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void HCPKBJDHLAC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OIDJOEDBPAA();
		}
	}

	private void IMIONHLAKIH()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OIDJOEDBPAA()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i++)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(NDAIGCOIGHD());
		}
	}

	private IEnumerator GHILCALEOGP()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KGGOIIMNAFI()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MOCCIIOJPGJ()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HBMDEHPHAPF()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator OBBFHPLLHOE()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private void IHGEPHPHFHM()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(OBBFHPLLHOE());
		}
	}

	private void HCEDMLJNOBL()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void KDBJHCAEGCM()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator NGOPMBMDLBO()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private void MOFDIIMKEOP()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 0; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 1)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(GHILCALEOGP());
		}
	}

	private void BKFNPGONJKK()
	{
		if (!(Time.time > AELCMIGFOAK) || BEGCPKOAJCP != null)
		{
			return;
		}
		for (int i = 1; i < dialogueNpcs.Length; i += 0)
		{
			if (((Component)dialogueNpcs[i]).gameObject.activeInHierarchy)
			{
				if (!dialogueNpcsList.Contains(dialogueNpcs[i]))
				{
					dialogueNpcsList.Add(dialogueNpcs[i]);
				}
			}
			else if (dialogueNpcsList.Contains(dialogueNpcs[i]))
			{
				dialogueNpcsList.Remove(dialogueNpcs[i]);
			}
		}
		if (dialogueNpcsList.Count > 0)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(KGGOIIMNAFI());
		}
	}

	private IEnumerator AINEJONDLLK()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private IEnumerator OLOKCAMHKOJ()
	{
		return new HBPKPGAIEGF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PLHEHGHFCJI()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void ODNGBEOKEFK()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private IEnumerator MKAIPIAFEPA()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}

	private void CLOKMCONOMN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			FCCFKNEALEB();
		}
	}

	private void PBFGFECPPPO()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void Start()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			((Behaviour)this).enabled = false;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void IDPHKHGHJGN()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			((Behaviour)this).enabled = true;
		}
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	private void OHGABHEDILE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCCFKNEALEB();
		}
	}

	private IEnumerator MCDLEIHALIL()
	{
		IBFCBKFNMIO = false;
		LFCHGJGBBDP = Random.Range(1, maxSimlutaneousBarks + 1);
		for (int i = 0; i < LFCHGJGBBDP + 1; i++)
		{
			while (!IBFCBKFNMIO && CNKOJJMNBHB < 20)
			{
				LLPGKHHKCLC = Random.Range(0, dialogueNpcsList.Count);
				if (dialogueNpcsList.Count > 0 && !dialogueNpcsList[LLPGKHHKCLC].inUse && !dialogueNpcsList[LLPGKHHKCLC].inBark && dialogueNpcsList[LLPGKHHKCLC].canTalk && ((Component)dialogueNpcsList[LLPGKHHKCLC]).gameObject.activeInHierarchy)
				{
					dialogueNpcsList[LLPGKHHKCLC].StartBark(CDPAMNIPPEC: true);
					yield return (object)new WaitForSeconds(Random.Range(3f, 7f));
					IBFCBKFNMIO = true;
				}
				CNKOJJMNBHB++;
			}
			IBFCBKFNMIO = false;
		}
		CNKOJJMNBHB = 0;
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
		BEGCPKOAJCP = null;
	}
}
