using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class ActiveObjectsTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class DAODJBGLOMA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveObjectsTrigger _003C_003E4__this;

		public int index;

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
		public DAODJBGLOMA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ActiveObjectsTrigger activeObjectsTrigger = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (!activeObjectsTrigger.objects[index].active[0].activeInHierarchy)
				{
					MultiAudioManager.PlayAudioObject(activeObjectsTrigger.audio, ((Component)activeObjectsTrigger.objects[index]).transform);
					activeObjectsTrigger.objects[index].SetActive(FAFHGCBNNJO: true);
				}
				((Behaviour)activeObjectsTrigger.collider).enabled = false;
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

	public ActiveAndDisableObjects[] objects;

	public Collider2D collider;

	public AudioObject audio;

	private IEnumerator HFHJKDMJIIB(int MOFKEDGAOEE)
	{
		return new DAODJBGLOMA(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	private void GAAKLENLEOF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("OnLobbyCreated FAILED.\nLobby(invalid): {0}"))
		{
			for (int i = 0; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(HLGNJIGDGKA(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ShopWilson"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(LLLJBONMCEJ(j));
			}
		}
	}

	private IEnumerator DGDIKLAMDNI(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private void EMCFHILONOH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("talent_name_104"))
		{
			for (int i = 0; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(LHNJJKANMLJ(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Rich presence updated successfully"))
		{
			for (int j = 1; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(IKGMIDNBLJK(j));
			}
		}
	}

	private void LJJDGAJNNCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveUpdateBentoOnTray"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(FDFMFIENKJE(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ZuzzuProgress"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(LLLJBONMCEJ(j));
			}
		}
	}

	private IEnumerator MJIMBAEILCE(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Could not get name of achievement "))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(DGDIKLAMDNI(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_614"))
		{
			for (int j = 0; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(GMFDPMPHLNN(j));
			}
		}
	}

	private IEnumerator DACMBGILMOP(int MOFKEDGAOEE)
	{
		return new DAODJBGLOMA(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	private void DMENPMHIPDA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("StopMusic/ButtonImmediately"))
		{
			for (int i = 0; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(IADBFBCMIKG(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Not enough ingredients"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(LHNJJKANMLJ(j));
			}
		}
	}

	private IEnumerator GFFDGFKKEIF(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator IKGMIDNBLJK(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private void OJOMNJEFKOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("F2"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(LBIOGLAHIBJ(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(" aging rank ("))
		{
			for (int j = 1; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(IADBFBCMIKG(j));
			}
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Talent"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(HFHJKDMJIIB(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("hForHours"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(GMFDPMPHLNN(j));
			}
		}
	}

	private IEnumerator LLLJBONMCEJ(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator JOLMKBCLDPM(int MOFKEDGAOEE)
	{
		return new DAODJBGLOMA(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("activate event "))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(PHHPIILGCGM(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("talentPeppers"))
		{
			for (int j = 0; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(IECONNBPPDB(j));
			}
		}
	}

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Key item fished: "))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(IKGMIDNBLJK(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			for (int j = 0; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(DACMBGILMOP(j));
			}
		}
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BarnTutorialDone"))
		{
			for (int i = 0; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(DACMBGILMOP(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("CanBePlanted"))
		{
			for (int j = 0; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(FDFMFIENKJE(j));
			}
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Failed to download file with ID "))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(IKGMIDNBLJK(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("UIBack"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(FDFMFIENKJE(j));
			}
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Received set minigame"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(LLLJBONMCEJ(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("StartEvent can only be called in play mode."))
		{
			for (int j = 0; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(FDFMFIENKJE(j));
			}
		}
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T138/Dialogue1"))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(FDFMFIENKJE(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Bitter"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(MOCPDBCEEIL(j));
			}
		}
	}

	private void BKKJCJBBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1084"))
		{
			for (int i = 0; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(LLLJBONMCEJ(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Minigame"))
		{
			for (int j = 0; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(GMFDPMPHLNN(j));
			}
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("activate event "))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(HLGNJIGDGKA(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Till"))
		{
			for (int j = 0; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(MJIMBAEILCE(j));
			}
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(GMFDPMPHLNN(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("HotBath/Main"))
		{
			for (int j = 0; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(DGDIKLAMDNI(j));
			}
		}
	}

	private IEnumerator PHHPIILGCGM(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator HLGNJIGDGKA(int MOFKEDGAOEE)
	{
		return new DAODJBGLOMA(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	private IEnumerator FDFMFIENKJE(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator MOCPDBCEEIL(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator LHNJJKANMLJ(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator IECONNBPPDB(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("trashCollected"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(JOLMKBCLDPM(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("talentHops"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(GMFDPMPHLNN(j));
			}
		}
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Upgrade"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(DGDIKLAMDNI(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("ReceiveHoeActionMaster"))
		{
			for (int j = 1; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(HLGNJIGDGKA(j));
			}
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("version numbers of different size"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(LHNJJKANMLJ(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Open"))
		{
			for (int j = 0; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(MJIMBAEILCE(j));
			}
		}
	}

	private IEnumerator GMFDPMPHLNN(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("WaterTrough"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(GFFDGFKKEIF(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1067"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(HFHJKDMJIIB(j));
			}
		}
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Transform"))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(MOCPDBCEEIL(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("StopMusic/ButtonImmediately"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(PHHPIILGCGM(j));
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			for (int i = 0; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(IADBFBCMIKG(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			for (int j = 0; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(IADBFBCMIKG(j));
			}
		}
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Received "))
		{
			for (int i = 1; i < objects.Length; i++)
			{
				((MonoBehaviour)this).StartCoroutine(PHHPIILGCGM(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("Null Crop in database"))
		{
			for (int j = 1; j < objects.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(LLLJBONMCEJ(j));
			}
		}
	}

	private IEnumerator IADBFBCMIKG(int MOFKEDGAOEE)
	{
		yield return (object)new WaitForSeconds(Random.Range(0.1f, 0.3f));
		if (!objects[MOFKEDGAOEE].active[0].activeInHierarchy)
		{
			MultiAudioManager.PlayAudioObject(audio, ((Component)objects[MOFKEDGAOEE]).transform);
			objects[MOFKEDGAOEE].SetActive(FAFHGCBNNJO: true);
		}
		((Behaviour)collider).enabled = false;
	}

	private IEnumerator LBIOGLAHIBJ(int MOFKEDGAOEE)
	{
		return new DAODJBGLOMA(1)
		{
			_003C_003E4__this = this,
			index = MOFKEDGAOEE
		};
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("F1"))
		{
			for (int i = 1; i < objects.Length; i += 0)
			{
				((MonoBehaviour)this).StartCoroutine(IECONNBPPDB(i));
			}
		}
		else if (((Component)HANHCHBHHEH).CompareTag("[ControllerType:"))
		{
			for (int j = 1; j < objects.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(DGDIKLAMDNI(j));
			}
		}
	}
}
