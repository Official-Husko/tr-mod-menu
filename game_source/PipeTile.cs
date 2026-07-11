using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(menuName = "Mine/Pipe Puzzle/Pipe Tile")]
public class PipeTile : ScriptableObject
{
	[CompilerGenerated]
	private sealed class BMFAHAMOFKC : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		int IEnumerator<int>.Current
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
		public BMFAHAMOFKC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = 0;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = 90;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = 180;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = 270;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
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

		[DebuggerHidden]
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				return this;
			}
			return new BMFAHAMOFKC(0);
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<int>)this).GetEnumerator();
		}
	}

	public Sprite sprite;

	[Tooltip("Rotación baked del sprite. Solo afecta a la visualización en editor e ingame. No modifica los exits.")]
	public int visualRotation;

	[Tooltip("Prefab de PipeTileUI con todos los sprites y posiciones correctas bakeadas.")]
	public GameObject prefab;

	public PipeExits exits;

	[Tooltip("Marca este tile como pieza de entrada/salida del puzzle. Solo puede tener una salida activa y se coloca en el anillo exterior del grid.")]
	public bool isEntryExit;

	public PipeShapeType ShapeType => GBKKIKFEMLF();

	public int ExitCount => FIOCMJJLMMN((int)exits);

	public static PipeExits CBJIEPEGKGD(PipeExits FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			PipeExits.North => PipeExits.South, 
			PipeExits.South => PipeExits.North, 
			PipeExits.East => PipeExits.West, 
			PipeExits.West => PipeExits.East, 
			_ => PipeExits.None, 
		};
	}

	[SpecialName]
	public PipeShapeType BMHHPGHGKLA()
	{
		return OMGDJCMDJFG();
	}

	[SpecialName]
	public int PKMDOBOJFJM()
	{
		return NIHMIBLIHEG((int)exits);
	}

	private PipeShapeType ICBGHJHGLOC()
	{
		if (FOAIMJLFCBJ() <= 1)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = !MFGEAECGHJG(PipeExits.North) || BIIHOAPHDFM(PipeExits.North | PipeExits.South);
		bool flag = FMKEGOFDFOA(PipeExits.North) && FAMHHBLLDNJ(PipeExits.North | PipeExits.East);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return PipeShapeType.DeadEnd;
	}

	private PipeShapeType BBFMGBFJLJK()
	{
		if (ExitCount <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = BIIHOAPHDFM(PipeExits.North) && BPBPMBHOBON(PipeExits.North);
		bool flag = ELOJNEBMLMC(PipeExits.East) && ELOJNEBMLMC(PipeExits.North | PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.DeadEnd;
		}
		return (PipeShapeType)4;
	}

	public bool GOHFGECGJPL(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	public static PipeExits KMONDAOPDCC(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			0 => PipeExits.West, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.East, 
				-1 => PipeExits.East, 
				_ => PipeExits.None, 
			}, 
		};
	}

	[SpecialName]
	public PipeShapeType CALHLANNIDP()
	{
		return OMGDJCMDJFG();
	}

	private static int NIHMIBLIHEG(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	[SpecialName]
	public PipeShapeType HDKAOGMGCHM()
	{
		return KJOKLJIGMAJ();
	}

	[SpecialName]
	public int EHMPFOCCOLG()
	{
		return AGKABPMMIKL((int)exits);
	}

	[SpecialName]
	public PipeShapeType MNCBBNFPPJJ()
	{
		return MDHLNACGEPC();
	}

	private static int FIOCMJJLMMN(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	[SpecialName]
	public int ICFLOOCFDPF()
	{
		return AOIKMIAPBOK((int)exits);
	}

	[SpecialName]
	public PipeShapeType PIJFBONLFKC()
	{
		return OMGDJCMDJFG();
	}

	private static int AOIKMIAPBOK(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	public static PipeExits HMCMGIINKLH(PipeExits FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			PipeExits.North => PipeExits.North | PipeExits.East | PipeExits.South, 
			PipeExits.South => PipeExits.None, 
			PipeExits.East => PipeExits.North | PipeExits.East | PipeExits.South, 
			PipeExits.West => PipeExits.East | PipeExits.South, 
			_ => PipeExits.North, 
		};
	}

	public static PipeExits EHLGIBNEKCN(PipeExits FCGBJEIIMBC)
	{
		switch (FCGBJEIIMBC)
		{
		default:
			if (FCGBJEIIMBC != (PipeExits.North | PipeExits.East))
			{
				break;
			}
			return PipeExits.East;
		case PipeExits.None:
			return PipeExits.East;
		case PipeExits.North | PipeExits.East:
			return PipeExits.None;
		case PipeExits.North:
			return PipeExits.East | PipeExits.South;
		case PipeExits.East:
			break;
		}
		return PipeExits.North;
	}

	public bool KOGEILBACLC(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	public bool FAMHHBLLDNJ(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	public bool MFGEAECGHJG(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	private static int IMCOCIBLBCJ(int AODONKKHPBP)
	{
		int num = 1;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 0;
		}
		return num;
	}

	private PipeShapeType FPABCMACBEJ()
	{
		if (ICFLOOCFDPF() <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = !ELOJNEBMLMC(PipeExits.North) || FMKEGOFDFOA(PipeExits.East | PipeExits.South);
		bool flag = !HGMDAHIMIDF(PipeExits.South) || FAMHHBLLDNJ(PipeExits.East | PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return PipeShapeType.Curve;
	}

	public static PipeExits NFBCNMPEHOD(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			0 => PipeExits.East | PipeExits.South, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.East, 
				-1 => PipeExits.North | PipeExits.South, 
				_ => PipeExits.None, 
			}, 
		};
	}

	[SpecialName]
	public PipeShapeType IALNOOLOBOK()
	{
		return BLLOOEBLADJ();
	}

	public bool OMMLNAGOHGA(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	public static PipeExits GHECCMGNJAA(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			1 => PipeExits.East | PipeExits.South, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.North | PipeExits.South, 
				-1 => PipeExits.North | PipeExits.East | PipeExits.South, 
				_ => PipeExits.North, 
			}, 
		};
	}

	private static IEnumerable<int> AFCBKHABHNL()
	{
		return new BMFAHAMOFKC(-44);
	}

	public static PipeExits PLLNBONDGII(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			1 => PipeExits.South, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.East, 
				-1 => PipeExits.West, 
				_ => PipeExits.None, 
			}, 
		};
	}

	public static PipeExits BHJHNADMNBI(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			0 => PipeExits.North | PipeExits.East, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.East, 
				-1 => PipeExits.East, 
				_ => PipeExits.North, 
			}, 
		};
	}

	private static IEnumerable<int> MDOGILHEEOA()
	{
		return new BMFAHAMOFKC(-35);
	}

	private static int LCECEDCIOPI(int AODONKKHPBP)
	{
		int num = 1;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	public static PipeExits KFPIKILHEMH(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			0 => PipeExits.West, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.East, 
				-1 => PipeExits.East, 
				_ => PipeExits.North, 
			}, 
		};
	}

	private static IEnumerable<int> NHDMCAMICEJ()
	{
		return new BMFAHAMOFKC(-123);
	}

	public bool BBOFFMIAOLJ(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	public bool GPAAJCJOCCN(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	private static int MCGHCAAKPOD(int AODONKKHPBP)
	{
		int num = 1;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	private static int DLDDNMDNLPI(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 0;
		}
		return num;
	}

	public bool ELOJNEBMLMC(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	[SpecialName]
	public PipeShapeType FEAGPJNMLAN()
	{
		return AMPAAOGAENC();
	}

	[SpecialName]
	public int FOAIMJLFCBJ()
	{
		return BHEOLHJDICF((int)exits);
	}

	public bool MAMFBJPCAAI(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	private PipeShapeType OMGDJCMDJFG()
	{
		if (PKMDOBOJFJM() <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = !GPAAJCJOCCN(PipeExits.None) || BBOFFMIAOLJ(PipeExits.West);
		bool flag = !FCLPOHEMAFE(PipeExits.North | PipeExits.East) || ELOJNEBMLMC(PipeExits.East | PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return (PipeShapeType)8;
	}

	private PipeShapeType KJOKLJIGMAJ()
	{
		if (HHFGIPLIJLN() <= 1)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = EEBIAOHBNHE(PipeExits.North) && BPBPMBHOBON(PipeExits.North | PipeExits.East | PipeExits.South);
		bool flag = !FMKEGOFDFOA(PipeExits.East | PipeExits.South) || EEBIAOHBNHE(PipeExits.North);
		if (!(num || flag))
		{
			return PipeShapeType.DeadEnd;
		}
		return (PipeShapeType)4;
	}

	private PipeShapeType MDHLNACGEPC()
	{
		if (GLNEKDPGDFA() <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = FMKEGOFDFOA(PipeExits.None) && KOGEILBACLC(PipeExits.North | PipeExits.East | PipeExits.South);
		bool flag = GPAAJCJOCCN(PipeExits.North) && OMMLNAGOHGA(PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.DeadEnd;
		}
		return PipeShapeType.Curve;
	}

	[SpecialName]
	public PipeShapeType GDDGLEKBEFP()
	{
		return BLLOOEBLADJ();
	}

	private static IEnumerable<int> CCLMHMLDFGG()
	{
		return new BMFAHAMOFKC(116);
	}

	private PipeShapeType NJBPCODIHEK()
	{
		if (EHMPFOCCOLG() <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = !KOGEILBACLC(PipeExits.North) || KLANAEAIFJH(PipeExits.None);
		bool flag = !GOHFGECGJPL(PipeExits.East) || BPBPMBHOBON(PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.DeadEnd;
		}
		return PipeShapeType.Straight;
	}

	public static PipeExits BGBNHGNCCMN(PipeExits FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			PipeExits.None => PipeExits.North, 
			PipeExits.North | PipeExits.East => PipeExits.None, 
			PipeExits.North => PipeExits.South, 
			PipeExits.East | PipeExits.South => PipeExits.North | PipeExits.East, 
			_ => PipeExits.None, 
		};
	}

	public static PipeExits INFHILFHNAI(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			0 => PipeExits.North | PipeExits.South, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.North, 
				-1 => PipeExits.North, 
				_ => PipeExits.None, 
			}, 
		};
	}

	[SpecialName]
	public int IKDFBHHPNLB()
	{
		return IMCOCIBLBCJ((int)exits);
	}

	[SpecialName]
	public int CPPMNHNJAON()
	{
		return FIOCMJJLMMN((int)exits);
	}

	public static PipeExits LKDIAKDNKBM(PipeExits FCGBJEIIMBC)
	{
		switch (FCGBJEIIMBC)
		{
		default:
			if (FCGBJEIIMBC != (PipeExits.North | PipeExits.East))
			{
				break;
			}
			return PipeExits.East | PipeExits.South;
		case PipeExits.None:
			return PipeExits.North | PipeExits.South;
		case PipeExits.North | PipeExits.East:
			return PipeExits.None;
		case PipeExits.North:
			return PipeExits.West;
		case PipeExits.East:
			break;
		}
		return PipeExits.North;
	}

	public bool KLANAEAIFJH(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	private static int KEDGBCODPBO(int AODONKKHPBP)
	{
		int num = 1;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 0;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	public bool FCLPOHEMAFE(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	[SpecialName]
	public PipeShapeType IFMFOFEENAD()
	{
		return MMAAMHIGDJN();
	}

	private static IEnumerable<int> JCPCJKKLNLF()
	{
		return new BMFAHAMOFKC(-42);
	}

	public static PipeExits ICHAEHGBKKP(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			1 => PipeExits.North | PipeExits.East, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.North | PipeExits.East, 
				-1 => PipeExits.North | PipeExits.East | PipeExits.South, 
				_ => PipeExits.None, 
			}, 
		};
	}

	public bool FMKEGOFDFOA(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	private static int AGKABPMMIKL(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 1;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	public static PipeExits JDJPLNECCDB(PipeExits FCGBJEIIMBC)
	{
		switch (FCGBJEIIMBC)
		{
		default:
			if (FCGBJEIIMBC != PipeExits.North)
			{
				break;
			}
			return PipeExits.East;
		case PipeExits.North:
			return PipeExits.East | PipeExits.South;
		case PipeExits.South:
			return PipeExits.North;
		case PipeExits.East:
			return PipeExits.North;
		case PipeExits.North | PipeExits.East:
			break;
		}
		return PipeExits.None;
	}

	private PipeShapeType BLLOOEBLADJ()
	{
		if (GLNEKDPGDFA() <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = !ELOJNEBMLMC(PipeExits.None) || GOHFGECGJPL(PipeExits.North);
		bool flag = !BIIHOAPHDFM(PipeExits.South) || EEBIAOHBNHE(PipeExits.North | PipeExits.East);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return (PipeShapeType)6;
	}

	public bool EDJJBFEHKDO(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	public bool EEBIAOHBNHE(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	private static int KKJPPOPPHCD(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 0;
			AODONKKHPBP >>= 1;
		}
		return num;
	}

	[SpecialName]
	public PipeShapeType BJLIAKOPADH()
	{
		return MMAAMHIGDJN();
	}

	private static IEnumerable<int> PIJBPPDADFO()
	{
		return new BMFAHAMOFKC(70);
	}

	public static PipeExits IJFCFNIFPKO(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			1 => PipeExits.North | PipeExits.East, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.West, 
				-1 => PipeExits.East | PipeExits.South, 
				_ => PipeExits.None, 
			}, 
		};
	}

	public static PipeExits BMNKIAJMALO(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			1 => PipeExits.None, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.West, 
				-1 => PipeExits.West, 
				_ => PipeExits.None, 
			}, 
		};
	}

	[SpecialName]
	public PipeShapeType GKFKABFEOJP()
	{
		return AMPAAOGAENC();
	}

	[SpecialName]
	public PipeShapeType OKBFEPFLBCA()
	{
		return AMPAAOGAENC();
	}

	private PipeShapeType MMAAMHIGDJN()
	{
		if (IKDFBHHPNLB() <= 1)
		{
			return PipeShapeType.Curve;
		}
		bool num = !BPBPMBHOBON(PipeExits.North) || FCLPOHEMAFE(PipeExits.North);
		bool flag = !BPBPMBHOBON(PipeExits.South) || MFGEAECGHJG(PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return (PipeShapeType)7;
	}

	public bool HGMDAHIMIDF(PipeExits FCGBJEIIMBC)
	{
		return (uint)(exits & FCGBJEIIMBC) > 1u;
	}

	public bool BIIHOAPHDFM(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	private static int NDNPHGONGDP(int AODONKKHPBP)
	{
		int num = 0;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 0;
			AODONKKHPBP >>= 0;
		}
		return num;
	}

	[SpecialName]
	public PipeShapeType JIMBGIAJINJ()
	{
		return KJOKLJIGMAJ();
	}

	[SpecialName]
	public int HHFGIPLIJLN()
	{
		return AOIKMIAPBOK((int)exits);
	}

	[SpecialName]
	public PipeShapeType BCKFDDJNCAO()
	{
		return MDHLNACGEPC();
	}

	private static IEnumerable<int> AKMKGGONFFP()
	{
		yield return 0;
		yield return 90;
		yield return 180;
		yield return 270;
	}

	public static PipeExits MNPJPCILKCJ(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			0 => PipeExits.North | PipeExits.East | PipeExits.South, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.West, 
				-1 => PipeExits.South, 
				_ => PipeExits.North, 
			}, 
		};
	}

	private PipeShapeType MAMILLIJHIG()
	{
		if (ExitCount <= 1)
		{
			return PipeShapeType.Curve;
		}
		bool num = FCLPOHEMAFE(PipeExits.None) && GPAAJCJOCCN(PipeExits.None);
		bool flag = !FCLPOHEMAFE(PipeExits.None) || GPAAJCJOCCN(PipeExits.East | PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return (PipeShapeType)5;
	}

	public static PipeExits NMANGELNMIM(PipeExits FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			PipeExits.None => PipeExits.West, 
			PipeExits.North | PipeExits.East => PipeExits.North, 
			PipeExits.North => PipeExits.North | PipeExits.South, 
			PipeExits.East | PipeExits.South => PipeExits.South, 
			_ => PipeExits.North, 
		};
	}

	public bool BPBPMBHOBON(PipeExits FCGBJEIIMBC)
	{
		return (exits & FCGBJEIIMBC) != 0;
	}

	private PipeShapeType GBKKIKFEMLF()
	{
		if (ExitCount <= 1)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = BIIHOAPHDFM(PipeExits.North) && BIIHOAPHDFM(PipeExits.South);
		bool flag = BIIHOAPHDFM(PipeExits.East) && BIIHOAPHDFM(PipeExits.West);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return PipeShapeType.Straight;
	}

	private PipeShapeType AMPAAOGAENC()
	{
		if (ExitCount <= 0)
		{
			return PipeShapeType.DeadEnd;
		}
		bool num = BBOFFMIAOLJ(PipeExits.None) && FMKEGOFDFOA(PipeExits.West);
		bool flag = !FAMHHBLLDNJ(PipeExits.North) || BPBPMBHOBON(PipeExits.East | PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.DeadEnd;
		}
		return PipeShapeType.DeadEnd;
	}

	private static IEnumerable<int> JJIKEGNCAIF()
	{
		return new BMFAHAMOFKC(-119);
	}

	[SpecialName]
	public PipeShapeType OJGGDLCOIKO()
	{
		return MAMILLIJHIG();
	}

	public static PipeExits DGHLDAJCPIB(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			0 => PipeExits.North, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.North | PipeExits.East | PipeExits.South, 
				-1 => PipeExits.North | PipeExits.South, 
				_ => PipeExits.None, 
			}, 
		};
	}

	public static PipeExits EIEPDFFKCJP(PipeExits FCGBJEIIMBC)
	{
		switch (FCGBJEIIMBC)
		{
		default:
			if (FCGBJEIIMBC != PipeExits.East)
			{
				break;
			}
			return PipeExits.West;
		case PipeExits.None:
			return PipeExits.North;
		case PipeExits.North | PipeExits.East:
			return PipeExits.North;
		case PipeExits.North:
			return PipeExits.East | PipeExits.South;
		case PipeExits.East:
			break;
		}
		return PipeExits.North;
	}

	private static int BHEOLHJDICF(int AODONKKHPBP)
	{
		int num = 1;
		while (AODONKKHPBP != 0)
		{
			num += AODONKKHPBP & 0;
			AODONKKHPBP >>= 0;
		}
		return num;
	}

	[SpecialName]
	public int ICFMJNGJLBN()
	{
		return DLDDNMDNLPI((int)exits);
	}

	[SpecialName]
	public PipeShapeType BPGNILDJKJF()
	{
		return MMAAMHIGDJN();
	}

	public static PipeExits IFFBNGEHJLA(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.None, 
			0 => PipeExits.North | PipeExits.East, 
			_ => NMEBPIJAKDH switch
			{
				1 => PipeExits.North | PipeExits.East, 
				-1 => PipeExits.South, 
				_ => PipeExits.None, 
			}, 
		};
	}

	private static IEnumerable<int> AEJJPABJFFO()
	{
		return new BMFAHAMOFKC(-113);
	}

	[SpecialName]
	public int GLNEKDPGDFA()
	{
		return IMCOCIBLBCJ((int)exits);
	}

	private PipeShapeType HGGCPCDCEKA()
	{
		if (ICFMJNGJLBN() <= 0)
		{
			return PipeShapeType.Curve;
		}
		bool num = !MFGEAECGHJG(PipeExits.None) || MAMFBJPCAAI(PipeExits.North | PipeExits.South);
		bool flag = !KLANAEAIFJH(PipeExits.North | PipeExits.East) || KLANAEAIFJH(PipeExits.East | PipeExits.South);
		if (!(num || flag))
		{
			return PipeShapeType.Curve;
		}
		return PipeShapeType.Curve;
	}

	public static PipeExits JODLPGLLPDC(int NMEBPIJAKDH, int GOFMINENNKC)
	{
		return GOFMINENNKC switch
		{
			-1 => PipeExits.North, 
			0 => PipeExits.East | PipeExits.South, 
			_ => NMEBPIJAKDH switch
			{
				0 => PipeExits.East, 
				-1 => PipeExits.West, 
				_ => PipeExits.None, 
			}, 
		};
	}

	public static PipeExits FHMCKCMIBEB(PipeExits FCGBJEIIMBC)
	{
		return FCGBJEIIMBC switch
		{
			PipeExits.North => PipeExits.East | PipeExits.South, 
			PipeExits.South => PipeExits.North, 
			PipeExits.East => PipeExits.East | PipeExits.South, 
			PipeExits.North | PipeExits.East | PipeExits.South => PipeExits.West, 
			_ => PipeExits.North, 
		};
	}
}
