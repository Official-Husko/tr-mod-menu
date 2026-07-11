using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SeatFinder
{
	[CompilerGenerated]
	private sealed class EKIPEOCBEIA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeatFinder _003C_003E4__this;

		public HumanNPC npc;

		public Seat[] availableSeats;

		public Action<HumanNPC, Seat, bool> callback;

		private int _003Ci_003E5__2;

		private Vector2[] _003CneighbourTiles_003E5__3;

		private int _003Cj_003E5__4;

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
		public EKIPEOCBEIA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			SeatFinder seatFinder = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_018b;
			}
			_003C_003E1__state = -1;
			if (seatFinder.OEBNHGNJEJL)
			{
				Debug.Log((object)"FindSeat Corroutine");
			}
			_003Ci_003E5__2 = 0;
			goto IL_0292;
			IL_018b:
			if (seatFinder.BICLADPDJLP)
			{
				if (seatFinder.OEBNHGNJEJL)
				{
					Debug.Log((object)"waiting for path");
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (seatFinder.NBJAHOBPJAP && (!availableSeats[_003Ci_003E5__2].reserved || Object.op_Implicit((Object)(object)availableSeats[_003Ci_003E5__2].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
			{
				availableSeats[_003Ci_003E5__2].entryPosition = _003CneighbourTiles_003E5__3[_003Cj_003E5__4];
				callback(npc, availableSeats[_003Ci_003E5__2], arg3: true);
				return false;
			}
			_003Cj_003E5__4++;
			goto IL_0237;
			IL_0292:
			if (_003Ci_003E5__2 < availableSeats.Length)
			{
				if (seatFinder.OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking seat " + _003Ci_003E5__2));
				}
				if (!((Object)(object)npc == (Object)null))
				{
					if (!blockedSeats.Contains(availableSeats[_003Ci_003E5__2]))
					{
						_003CneighbourTiles_003E5__3 = availableSeats[_003Ci_003E5__2].entryNodes;
						_003Cj_003E5__4 = 0;
						goto IL_0237;
					}
					goto IL_0282;
				}
			}
			if ((Object)(object)npc != (Object)null)
			{
				callback(npc, null, arg3: false);
			}
			return false;
			IL_0237:
			if (_003Cj_003E5__4 < _003CneighbourTiles_003E5__3.Length)
			{
				if (seatFinder.OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + _003Cj_003E5__4));
				}
				if (!((Object)(object)npc == (Object)null))
				{
					seatFinder.BICLADPDJLP = true;
					seatFinder.NBJAHOBPJAP = false;
					NPCWalkTo nPCWalkTo = new NPCWalkTo(npc);
					nPCWalkTo.FNNPPBDFBCI(_003CneighbourTiles_003E5__3[_003Cj_003E5__4]);
					nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(seatFinder.FDDJKPPNLKG));
					nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(seatFinder.OBMLBADMBFD));
					nPCWalkTo.PEHELKCIECB();
					goto IL_018b;
				}
			}
			if (!blockedSeats.Contains(availableSeats[_003Ci_003E5__2]))
			{
				blockedSeats.Add(availableSeats[_003Ci_003E5__2]);
			}
			_003CneighbourTiles_003E5__3 = null;
			goto IL_0282;
			IL_0282:
			_003Ci_003E5__2++;
			goto IL_0292;
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

	public static HashSet<Seat> blockedSeats = new HashSet<Seat>();

	private bool BICLADPDJLP;

	private bool NBJAHOBPJAP;

	private Vector3[] GDHHIIMLBEL;

	private bool OEBNHGNJEJL;

	private void OBMLBADMBFD()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Path Not Found");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private void JJKFBNDMCHP()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"next pos ");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	private void NGLNOOIHOEH()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Eat");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	private void HOEBNFEGOFL()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Spawning special item event: ");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private IEnumerator FNHCFGJIFIN(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	public void CAFOJKFHJLF(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Level ");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.CDDAKMKNJLP();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(CBHIGAMFGIH(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	public void DLGHLOMHGIO(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"setDefaultSettings");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.OBHGDHFPDCO();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(IJJLABPLJPD(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	public void PCAHPNIBBIO(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Items/item_description_1074");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.OBHGDHFPDCO();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(ELGBKDHLDLN(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private void OIMLJIEGMBF()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"</color>");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = true;
	}

	private void LFPDLACENGN()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Disabled");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	private void KDDNHDPPOGB()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Open");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	private IEnumerator BNCCBMCJAOO(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		return new EKIPEOCBEIA(1)
		{
			_003C_003E4__this = this,
			npc = JHIFLALPEBF,
			availableSeats = KABPFOBPBJK,
			callback = AABDPKCDEKB
		};
	}

	private void APKBGPOCMFM()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"place charges");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	private void HLMGHCOBCBC()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Up Arrow");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = true;
	}

	public void PMMFPKDMKHH(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"(");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.FindAvailableSeats();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(OFNMGPIFAPL(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private void JFGGFDIMKNJ()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Error_Money");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private IEnumerator ELGBKDHLDLN(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private IEnumerator PDCLCBAPNDL(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		return new EKIPEOCBEIA(1)
		{
			_003C_003E4__this = this,
			npc = JHIFLALPEBF,
			availableSeats = KABPFOBPBJK,
			callback = AABDPKCDEKB
		};
	}

	private IEnumerator BAMKNNLCMOC(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private void HIPIPGACKJA()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"in ");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private void FDDJKPPNLKG()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Path Found");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = true;
	}

	public void LAAGLLLMOEJ(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Precision/DrinkEvent2");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.IGNOOODLMDG();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(MDAEMKIBIMK(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	public void KNCBMLIEEEJ(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)" for reason ");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.OBHGDHFPDCO();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(FNHCFGJIFIN(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	public void IAMIJKOCPAO(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"quest_reward_27_28_29");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.JJAAMOOGKCA();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(CBHIGAMFGIH(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private void FFOGHKCHLEO()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"NormalRight");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	public void JGKJMIKKFIN(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ReceiveDirtDish");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.MFJNPDIKNBA();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(PDCLCBAPNDL(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private IEnumerator CBHIGAMFGIH(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private void LFMJFHFECGK()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Attack/MainEvent 12");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = true;
	}

	private void AJGPDANCJAD()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"LE_12");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	private void CJIJMFKCNJC()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"UIBack");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private void EMOFJFLNCHA()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)" and ");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private void IAGPKGLLJDG()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"\n");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = true;
	}

	private IEnumerator KPGBGODADKA(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private void ANKJFINLHJF()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private void BKOMANJJBIC()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"{0}: {1}\n");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private void JNIOLKCBBCG()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/14/Dialogue Text");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = true;
	}

	private void GLAAAINCNGA()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ReceiveStartIntroMasters");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	public void BDGLAFIOAGF(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Tray");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.CDDAKMKNJLP();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(PBCOMAFHFFE(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private IEnumerator EFBDBJMJHND(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private void MAFFMCKMDFC()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Brandy");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = true;
	}

	private IEnumerator MDAEMKIBIMK(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private void MPIHOHINCNG()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"StaffEnd");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = true;
	}

	private void BBBJCIHOHDO()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Send info for ");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = false;
	}

	private IEnumerator IJJLABPLJPD(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	public void OBPONHFCBGB(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"ReceiveBallPosition");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.OBHGDHFPDCO();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(OFNMGPIFAPL(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private void HCFJCFNFGIL()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Player");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = false;
	}

	public void GMHHCAJIJGP(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.FindAvailableSeats();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(ELGBKDHLDLN(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private IEnumerator OFNMGPIFAPL(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		return new EKIPEOCBEIA(1)
		{
			_003C_003E4__this = this,
			npc = JHIFLALPEBF,
			availableSeats = KABPFOBPBJK,
			callback = AABDPKCDEKB
		};
	}

	private void GPIHCALELHK()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"RoadBlocked");
		}
		BICLADPDJLP = false;
		NBJAHOBPJAP = true;
	}

	public void GGHENMDLOJI(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"{0} state changed to: {1}");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.FindAvailableSeats();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(KPGBGODADKA(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	public void GPOEFNLPJKG(HumanNPC JHIFLALPEBF, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)JHIFLALPEBF);
		}
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Items/item_name_1061");
		}
		Seat[] kABPFOBPBJK = TavernSeatingManager.CBBAMFFKOGF();
		((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(EFBDBJMJHND(JHIFLALPEBF, kABPFOBPBJK, AABDPKCDEKB));
	}

	private IEnumerator PBCOMAFHFFE(HumanNPC JHIFLALPEBF, Seat[] KABPFOBPBJK, Action<HumanNPC, Seat, bool> AABDPKCDEKB)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"FindSeat Corroutine");
		}
		for (int i = 0; i < KABPFOBPBJK.Length; i++)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)("Checking seat " + i));
			}
			if ((Object)(object)JHIFLALPEBF == (Object)null)
			{
				break;
			}
			if (blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				continue;
			}
			Vector2[] neighbourTiles = KABPFOBPBJK[i].entryNodes;
			for (int j = 0; j < neighbourTiles.Length; j++)
			{
				if (OEBNHGNJEJL)
				{
					Debug.Log((object)("Checking tile " + j));
				}
				if ((Object)(object)JHIFLALPEBF == (Object)null)
				{
					break;
				}
				BICLADPDJLP = true;
				NBJAHOBPJAP = false;
				NPCWalkTo nPCWalkTo = new NPCWalkTo(JHIFLALPEBF);
				nPCWalkTo.FNNPPBDFBCI(neighbourTiles[j]);
				nPCWalkTo.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo.OnSuccessfulStart, new Action(FDDJKPPNLKG));
				nPCWalkTo.OnFailStart = (Action)Delegate.Combine(nPCWalkTo.OnFailStart, new Action(OBMLBADMBFD));
				nPCWalkTo.PEHELKCIECB();
				while (BICLADPDJLP)
				{
					if (OEBNHGNJEJL)
					{
						Debug.Log((object)"waiting for path");
					}
					yield return null;
				}
				if (NBJAHOBPJAP && (!KABPFOBPBJK[i].reserved || Object.op_Implicit((Object)(object)KABPFOBPBJK[i].occupier) || (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(42))))
				{
					KABPFOBPBJK[i].entryPosition = neighbourTiles[j];
					AABDPKCDEKB(JHIFLALPEBF, KABPFOBPBJK[i], arg3: true);
					yield break;
				}
			}
			if (!blockedSeats.Contains(KABPFOBPBJK[i]))
			{
				blockedSeats.Add(KABPFOBPBJK[i]);
			}
		}
		if ((Object)(object)JHIFLALPEBF != (Object)null)
		{
			AABDPKCDEKB(JHIFLALPEBF, null, arg3: false);
		}
	}

	private void NDHOPOOHDFP()
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"Harvest");
		}
		BICLADPDJLP = true;
		NBJAHOBPJAP = true;
	}
}
