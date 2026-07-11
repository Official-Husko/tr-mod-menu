using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class BlueFire : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LALMJAHBICN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BlueFire _003C_003E4__this;

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
		public LALMJAHBICN(int _003C_003E1__state)
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
			BlueFire blueFire = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(10f, 20f));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (!blueFire.MJGGACBHMHO && !blueFire.IMEKKIFIBBP)
				{
					MultiAudioManager.PlayAudioObject(blueFire.fireUpSound, ((Component)blueFire).transform);
					blueFire.anim.SetBool("FireUp", true);
					blueFire.anim.SetBool("FadeOut", false);
				}
				blueFire.COEOKNKNBIH = null;
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

	public Animator anim;

	public AudioObject fireUpSound;

	public AudioObject fadeOutSound;

	private bool MJGGACBHMHO;

	private bool IMEKKIFIBBP;

	private Coroutine COEOKNKNBIH;

	private void FMOINAMHCAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("#.##%"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Request begin minigame"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(JPOOCKBLHFM());
		}
	}

	private IEnumerator ODIBMDJPHHA()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EMALKCLEPOK()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GPBIMIPAMDA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Hammer") || ((Component)HANHCHBHHEH).CompareTag("Sick"))
		{
			anim.SetBool("LE_21", false);
			anim.SetBool("OnlinePlaceable doesn't have an OnlineDialogueNPC component", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("quest_description_25"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("tutorialPopUp76"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private IEnumerator CGBJEAENKHA()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AIIBGNEPMHA()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void OEMHMPPCNOB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<sprite name=") || ((Component)HANHCHBHHEH).CompareTag("add item 1440"))
		{
			anim.SetBool("Dialogue System/Conversation/Crowly_Introduce/Entry/15/Dialogue Text", false);
			anim.SetBool("LE_10", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Hair"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("itemGrainBag"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void IDPJLIBONPF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("windy") || ((Component)HANHCHBHHEH).CompareTag("ReceiveSetNewOccupierInRoom"))
		{
			anim.SetBool("Back", true);
			anim.SetBool("Changing quality ", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("ObjectVerticalMove"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/1/Dialogue Text"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void FJOGFDEEOAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("SetBoolRPC") || ((Component)HANHCHBHHEH).CompareTag("Inventory full"))
		{
			anim.SetBool("Hovel", true);
			anim.SetBool("El componente ItemSetup del prefab '{0}' no referencia correctamente al item '{1}' (ID: {2}).", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Scene"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Checking tile "))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private IEnumerator BKCJJMLBCMJ()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void GGDINGHDFPI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_21"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("itemBeefSteak"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StartCoroutine(OFGAFBJLCJA());
		}
	}

	private void LKDOCPGOHAO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Meditation") || ((Component)HANHCHBHHEH).CompareTag(")"))
		{
			anim.SetBool("Player", false);
			anim.SetBool("Unsaved progress will be lost.", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("ClosePopUp"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Setup "))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private IEnumerator LNDMEODKMGE()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private IEnumerator CPILPGFLJOG()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DEKJGPJMAPC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("SetTriggerRPC") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_1082"))
		{
			anim.SetBool("Not found ingredients for trends ", false);
			anim.SetBool("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/3/Dialogue Text", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("MopRight"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Perks/playerPerk_description_"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void POOHBAHCDJF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveToolUpgradingRPC"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("UINextCategory"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(LNDMEODKMGE());
		}
	}

	private IEnumerator JPOOCKBLHFM()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void DFFDKIPCCKK()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.KGPJPILAHDE()))
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void JDICPIOKEMJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Locked") || ((Component)HANHCHBHHEH).CompareTag("Decline"))
		{
			anim.SetBool("Disconnecting...", true);
			anim.SetBool("File ", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Light Fire"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("LE_10"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void LKNMBEMPBOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("</size>"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("TavernInConstruction"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(JLLIKJIDGOP());
		}
	}

	private void EIHHJKFDCCC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("[NPCGender=") || ((Component)HANHCHBHHEH).CompareTag(":</color> "))
		{
			anim.SetBool("ReceiveLoadSlots", true);
			anim.SetBool("Disabled", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("LucenGrab"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Meditation"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void OBHFJIDKBJN()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.GGFJGHHHEJC))
		{
			((MonoBehaviour)GameplayUI.LKOABOAADCD()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator POBGOFHONIM()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FOJAHMIJJJM()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.KIALFDOKABP()))
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void DGOGKLMHJEG()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.POAGAIBEFBF()))
		{
			((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void OHLBPABJGFA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(")"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(BBLIDEKFLDJ());
		}
	}

	private void GHDBHNMOBMN()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.BAKPBHPNKPB()))
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void BNNLNCGNHFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NotMyChest") || ((Component)HANHCHBHHEH).CompareTag("ActionBar8"))
		{
			anim.SetBool("Items/item_description_623", true);
			anim.SetBool("SendEnabledNPCs", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/8/Dialogue Text"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Unique id "))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void GBKNIJENJEF()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.CFHEJAGKIII()))
		{
			((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator APODJGFNALE()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CMFKHDBCJNO()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LKLNELLKOPD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Game is already running"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Crowly_Barks_Shop"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StartCoroutine(LNDMEODKMGE());
		}
	}

	private void LALJNGFGKPA()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.CFHEJAGKIII()))
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void OnDestroy()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.GGFJGHHHEJC))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void CHDEOJALBFK()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.DICHPHEOINO()))
		{
			((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator BMOHHOPKIIG()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void MPDOFGBMDPD()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.LKOABOAADCD()))
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator IGOBEMCHGND()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void CMLFBCFLPBJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/36/Dialogue Text") || ((Component)HANHCHBHHEH).CompareTag(" / "))
		{
			anim.SetBool("quest_name_30", true);
			anim.SetBool("WheatAleAbbreviation", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Door"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveAddZone"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void MEAKJFEPKHF()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.IDIGFHEHIDM()))
		{
			((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator NJKNAMICDJF()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ACFABFCGIGH()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.NGIMIHFFNMH()))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void ILCBKEIEOAN()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.DGCNCEDIFOF()))
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void MGCIGOHKLML(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("TavernFilthy"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Gass_CoctelQuest"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(HONKCNBABAP());
		}
	}

	private void FDNAEJDHODK()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.KGPJPILAHDE()))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void KIJDNFODCKJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveDirtDish") || ((Component)HANHCHBHHEH).CompareTag("Backache"))
		{
			anim.SetBool("CannotPickUpWhileWorking", false);
			anim.SetBool("Wall", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("stuck recovery"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveEmployeeWorking"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void HHBJICLBNPE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ERROR: The object "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Tap"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(LGPNBINHGKD());
		}
	}

	private void PEOPFPEDFAK()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.NGIMIHFFNMH()))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("GetFloorEntrance travelZone null ") || ((Component)HANHCHBHHEH).CompareTag("Received {0} appearance data as byte array: {1}"))
		{
			anim.SetBool("LE_10", false);
			anim.SetBool("Dialogue System/Conversation/BirdPositiveComments/Entry/8/Dialogue Text", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Spring"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Game"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("GO"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(APODJGFNALE());
		}
	}

	private void PMLPGABFLGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects") || ((Component)HANHCHBHHEH).CompareTag("- "))
		{
			anim.SetBool("Sit", true);
			anim.SetBool(" : 00", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("OnConversationStarted "))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("MineFloor"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void LAABACOIICH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Angry") || ((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			anim.SetBool("<b><color=#9a672a>", false);
			anim.SetBool(", duration: ", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Error_ICantRepairIt"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Rest"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void DFDPLNHGAOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Direction") || ((Component)HANHCHBHHEH).CompareTag("Stack"))
		{
			anim.SetBool("ChangeAnim", false);
			anim.SetBool("RaraAvisDelivered", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("StartConversation SalonDelTrono"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveThrowFish"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private IEnumerator IMLLLLOPFNP()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void OJJCGNICMBD()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.CFHEJAGKIII()))
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void MFJOBBJOGGB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceivePlaceCharges"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Standar/Entry/39/Dialogue Text"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.IDIGFHEHIDM()).StartCoroutine(BMOHHOPKIIG());
		}
	}

	private IEnumerator FLAFGFJBNIA()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EJDFNBOOAFF()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void IKMPNICLPBM()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.MPJJAPCFENH()))
		{
			((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void BGGNBDDDBFO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_673"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Sit"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StartCoroutine(ODIBMDJPHHA());
		}
	}

	private void EAJDLPCKDEC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Create room list") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_672"))
		{
			anim.SetBool("Waiting", false);
			anim.SetBool("No empty bucket", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 8"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1137"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void EKNEIMIENPG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceivePlayerDisconnected"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("[Player1Name]"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(IMLLLLOPFNP());
		}
	}

	private void OEAAPIBLALL()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.FMIDAFEGDCD()))
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveStatuePuzzle") || ((Component)HANHCHBHHEH).CompareTag("Sprout"))
		{
			anim.SetBool("Arguing", false);
			anim.SetBool("Festín del Juramento/Derrota", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_594"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernFilthy/Entry/1/Dialogue Text"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void EIEKPEEPFGA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" for reason: "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("ReciveInUseOnlineObjects"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StartCoroutine(HJLOCKEMMOB());
		}
	}

	private void NCNGPFDFPKA()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.MPJJAPCFENH()))
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void DAGGKPKBCLD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Toy"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("VerticalMove"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(EMALKCLEPOK());
		}
	}

	private IEnumerator LGPNBINHGKD()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OPMPGLCKOAM()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MDGLECECOIG()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.HNNJEBNIPOI()))
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void KLCFOJHHBJA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1185") || ((Component)HANHCHBHHEH).CompareTag("{0}\nPlayers: {1}/{2}"))
		{
			anim.SetBool("Happy", true);
			anim.SetBool("UseHold", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Sending finish minigame"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void DNLPICFIBDE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Hammer"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("perHour"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StartCoroutine(JLLIKJIDGOP());
		}
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(LNDMEODKMGE());
		}
	}

	private void LHAPMEEADKH()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.FMIDAFEGDCD()))
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void FKILALCMOOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Care"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("SetNPCPosition"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(LNDMEODKMGE());
		}
	}

	private void LDPNAPIGIIA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("windowed mode") || ((Component)HANHCHBHHEH).CompareTag("Items/item_name_"))
		{
			anim.SetBool("OnlinePlayer", true);
			anim.SetBool(": Prefab direction not found!", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Balance/MainEvent2"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void IJDMLKCHPDC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("con {0} required tiles."))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("- "))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(CMFKHDBCJNO());
		}
	}

	private void OHKIOLCEMLM()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.HNNJEBNIPOI()))
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void LLMHIBJOEFD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Cannot place mine block piece at "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_628"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KIALFDOKABP()).StartCoroutine(CMFKHDBCJNO());
		}
	}

	private void INBHNOLGOBP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UpgradeConfirmation"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Configure"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(NJKNAMICDJF());
		}
	}

	private void IKIPGJNEJNG()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.LKOABOAADCD()))
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator BBLIDEKFLDJ()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void PPFCEFLFHFO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<mark=#000000><alpha=#00> "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("NinjaOrdersManager is not initialized."))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(BMOHHOPKIIG());
		}
	}

	private void CEACIBBDEKP(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("NormalLeftExterior") || ((Component)HANHCHBHHEH).CompareTag("SceneReferences Awake"))
		{
			anim.SetBool("El componente ItemSetup del rotatedPrefab '", true);
			anim.SetBool("OnlinePlayer", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("LE_21"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("LevelAbbreviation"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void NPJGOGKKJIO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("): "))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Angry"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(HJLOCKEMMOB());
		}
	}

	private IEnumerator HJLOCKEMMOB()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private IEnumerator MFHIOGDOKBK()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MOCFJMDDNAA()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EBICEBJOKBA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1095") || ((Component)HANHCHBHHEH).CompareTag("Posible Ingredients"))
		{
			anim.SetBool("OnlinePlayer", false);
			anim.SetBool("itemMetalSheet", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Unique id "))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveNinjaCustomerState"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void POHCNHBOMDM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIPreviousCategory") || ((Component)HANHCHBHHEH).CompareTag("MineFloor"))
		{
			anim.SetBool("Open", false);
			anim.SetBool("Player2", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("UIPreviousPage"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Chest opened, granting loot to player "))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void CMJBBBHGHCD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BuzzNPC: ChangeState called with invalid state: "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Tutorial/T132/Dialogue1"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(JLLIKJIDGOP());
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("\n") || ((Component)HANHCHBHHEH).CompareTag("Moving"))
		{
			anim.SetBool("Miners/Mine/Ferro/Stand", true);
			anim.SetBool("Select", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("OnlineObject "))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag(")"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void HHGJLOKEPJE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_703"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Shader Model 4.1 ( DX10.1 )"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(ODIBMDJPHHA());
		}
	}

	private void ACLLIGOCDNN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Key1") || ((Component)HANHCHBHHEH).CompareTag("UI"))
		{
			anim.SetBool("Invalid year: ", false);
			anim.SetBool("UIPreviousCategory", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag(" for reason "))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Players win!"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void HBEBKMNGLBJ()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.GGFJGHHHEJC))
		{
			((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void HBHBMAKMOCM(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Initial Customer State Machine values are null."))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information."))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(HJLOCKEMMOB());
		}
	}

	private void KGAPHAIFAFH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("UIPreviousPage"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Unique ID not set for "))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(FLAFGFJBNIA());
		}
	}

	private void IMOHIBLLPIB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("qualityWater"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Inventory full"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(BKCJJMLBCMJ());
		}
	}

	private void PKFMLJGJKCP()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.DICHPHEOINO()))
		{
			((MonoBehaviour)GameplayUI.DGCNCEDIFOF()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void GKKAMMGOJEJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/Crowly_Introduce/Entry/19/Dialogue Text"))
		{
			anim.SetBool("Random", true);
			anim.SetBool("/Male/", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("MilkAction"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Fruit"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private IEnumerator BPMCGGJGLPE()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void FCMFGPKMKBI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Drink"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Animal"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(BKCJJMLBCMJ());
		}
	}

	private void IJEGBBPOAPI(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Error_TableNeedsFreeSpace"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(MFHIOGDOKBK());
		}
	}

	private void PKDNMBGODAJ()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.DBJCACLEFGK()))
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator JLLIKJIDGOP()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NJFDKCMBMDH()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.DICHPHEOINO()))
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void LFPJOBMFDAC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("quest_description_20") || ((Component)HANHCHBHHEH).CompareTag("talentTea"))
		{
			anim.SetBool("Inventory full", true);
			anim.SetBool("Intro16", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("[GetAllValidCandidates] Skipped spawner {0} from piece {1} - TypeAllowed:{2} ActiveOrForced:{3}"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_673"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void ELKDCKDCKHL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("psai: The game object lacks a local Collider component for psai Trigger: {0}") || ((Component)HANHCHBHHEH).CompareTag("0"))
		{
			anim.SetBool("Inventory full", true);
			anim.SetBool("Information", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("UIAddRemove"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Interact"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void JKGOPEMLKAG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" set to follow: ") || ((Component)HANHCHBHHEH).CompareTag("ReceiveRemoveHeldItem"))
		{
			anim.SetBool("Fishing", false);
			anim.SetBool("Fish", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Walk"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("bob"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void DAKJMHHICEN(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("LE_10") || ((Component)HANHCHBHHEH).CompareTag("Object "))
		{
			anim.SetBool("set Start-Intensity: ", true);
			anim.SetBool("Comfort", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Beach"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("activate event"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void JOAGNMPLDLH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 5") || ((Component)HANHCHBHHEH).CompareTag("unlock recipe "))
		{
			anim.SetBool("Frog(Clone)", false);
			anim.SetBool("─── Fragmento {0}/{1} ───\n{2}", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Fortitude/MainEvent 3"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("MenuMode/ButtonEnter"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void AINPGHBODGD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" not found. Cannot set isSelected to ") || ((Component)HANHCHBHHEH).CompareTag("'"))
		{
			anim.SetBool("", true);
			anim.SetBool("ReceiveEmployeeWorking", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("NotEnoughProfessionPoints"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag(""))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void NOADCLDBEOG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_621") || ((Component)HANHCHBHHEH).CompareTag("talentTea"))
		{
			anim.SetBool("Save Game", true);
			anim.SetBool("Dialogue System/Conversation/BirdNegativeComments/Entry/1/Dialogue Text", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Missing fade image"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("{0} - Restoring non-altar variant object {1} at index {2} for piece {3}. Next variant index: {4}"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private IEnumerator PGNHJLMONMB()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GEFCGLEGHOA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Attack/MainEvent 2"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Disabled"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(NGBHAHEEOJI());
		}
	}

	private void LMNMPBNMGCH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Wort"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag(" </color>"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KIALFDOKABP()).StartCoroutine(EMALKCLEPOK());
		}
	}

	private IEnumerator NGBHAHEEOJI()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("talent_name_103") || ((Component)HANHCHBHHEH).CompareTag("\n<color=#BF0000>"))
		{
			anim.SetBool("", false);
			anim.SetBool("positions count is 0", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Cellar"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("ReceiveInfoWorldTiles"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void EMFALNDKLOO(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Cat"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Error_CellarZone"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StartCoroutine(ALEMOOOPNFM());
		}
	}

	private void FLOFJHNAIKP()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.DGCNCEDIFOF()))
		{
			((MonoBehaviour)GameplayUI.LKOABOAADCD()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator OHGKDNEEDPG()
	{
		yield return (object)new WaitForSeconds(Random.Range(10f, 20f));
		if (!MJGGACBHMHO && !IMEKKIFIBBP)
		{
			MultiAudioManager.PlayAudioObject(fireUpSound, ((Component)this).transform);
			anim.SetBool("FireUp", true);
			anim.SetBool("FadeOut", false);
		}
		COEOKNKNBIH = null;
	}

	private IEnumerator OFGAFBJLCJA()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LBNOOAHEHNH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Crop needs a harvested replace by item "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("Gameplay"))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(LGPNBINHGKD());
		}
	}

	private void ABKKNODLBNL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_1086") || ((Component)HANHCHBHHEH).CompareTag("ReceiveLookAtPlayer"))
		{
			anim.SetBool("Items/item_name_608", false);
			anim.SetBool("Interact", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("itemPear"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_684"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void HIMBLFNCDLL(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" has null in occupy nodes with colliders list.") || ((Component)HANHCHBHHEH).CompareTag("increase xp"))
		{
			anim.SetBool("Player", true);
			anim.SetBool(" seconds.", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("SkeletonBird"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("talentTea"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void BLBJCANJNBG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<color=#BF0000>"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag(""))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(HONKCNBABAP());
		}
	}

	private IEnumerator HONKCNBABAP()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ADIGNNPBACJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("wForWeeks") || ((Component)HANHCHBHHEH).CompareTag("On Simple Event "))
		{
			anim.SetBool("CheckArea", false);
			anim.SetBool("Tail", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("DisableLeft"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Items/item_name_616"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void CLLAKJADGIH()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.IDIGFHEHIDM()))
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void AEDIIIAECIC()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.KIALFDOKABP()))
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void JOPNDBLNDMA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("itemRoastedBeef"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("</color>"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(HJLOCKEMMOB());
		}
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			anim.SetBool("FadeOut", true);
			anim.SetBool("FireUp", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("Player"))
			{
				MJGGACBHMHO = true;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Player2"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void AKPLLNELLJK()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.BAKPBHPNKPB()))
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void MPDHPPDAGMB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Bounce"))
		{
			MJGGACBHMHO = false;
		}
		if (((Component)HANHCHBHHEH).CompareTag("F2"))
		{
			IMEKKIFIBBP = false;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StartCoroutine(ALEMOOOPNFM());
		}
	}

	private void FNFNLFOJHHA()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.FMIDAFEGDCD()))
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void OAMKILKEDCJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("BARKDOOR") || ((Component)HANHCHBHHEH).CompareTag(""))
		{
			anim.SetBool("xpModDescFarming", false);
			anim.SetBool("Interact", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("ErrorMessageTooLong"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("El prefab '{0}' del item '{1}' (ID: {2}) no tiene el componente ItemSetup."))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void NMAMFJAHDNN()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.LKOABOAADCD()))
		{
			((MonoBehaviour)GameplayUI.IDIGFHEHIDM()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void NOILIOLOOBJ()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.OKAPNFPFPFP()))
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private IEnumerator ALEMOOOPNFM()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPBBBADDNAC()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.ELGNEJNLBNO()))
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}

	private void EEFKKLDCGAE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("ReceiveOfferingUIOpened") || ((Component)HANHCHBHHEH).CompareTag("In item "))
		{
			anim.SetBool("Eat", false);
			anim.SetBool("Occupied Positions", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("contentLockRepMessage"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Moving"))
			{
				IMEKKIFIBBP = true;
			}
		}
	}

	private void GAANFGOOBGC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Door animation error: currentAnimationSprites is null") || ((Component)HANHCHBHHEH).CompareTag("Xbox"))
		{
			anim.SetBool("\n", true);
			anim.SetBool("Interact", true);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("\n\n"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Not all players are near Kyroh to start the event"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private void OAENLLEOCNH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Close Multiple Choice") || ((Component)HANHCHBHHEH).CompareTag("LE_10"))
		{
			anim.SetBool("itemBreadYeast", false);
			anim.SetBool("Bug report POST failed: ", false);
			if (!MJGGACBHMHO && !IMEKKIFIBBP)
			{
				MultiAudioManager.PlayAudioObject(fadeOutSound, ((Component)this).transform);
			}
			if (((Component)HANHCHBHHEH).CompareTag("VERSION"))
			{
				MJGGACBHMHO = false;
			}
			if (((Component)HANHCHBHHEH).CompareTag("Farm/Bob/Barks_Shop"))
			{
				IMEKKIFIBBP = false;
			}
		}
	}

	private IEnumerator MKJJGJCIACM()
	{
		return new LALMJAHBICN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ILOJBCEKLDF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(" "))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings."))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(ODIBMDJPHHA());
		}
	}

	private void HJIJHEONIIG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1121"))
		{
			MJGGACBHMHO = true;
		}
		if (((Component)HANHCHBHHEH).CompareTag("User "))
		{
			IMEKKIFIBBP = true;
		}
		if (COEOKNKNBIH == null)
		{
			COEOKNKNBIH = ((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(BKCJJMLBCMJ());
		}
	}

	private void BDDBDNPCPGC()
	{
		if (COEOKNKNBIH != null && Object.op_Implicit((Object)(object)GameplayUI.BAKPBHPNKPB()))
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StopCoroutine(COEOKNKNBIH);
			COEOKNKNBIH = null;
		}
	}
}
