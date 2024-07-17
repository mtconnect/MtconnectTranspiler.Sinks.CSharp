using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.DataItemTypesForInterface;
// using Mtconnect;

namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DataItemTypesForInterfacePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MaterialFeedClass,
			MaterialChangeClass,
			MaterialChangeRequestClass,
			MaterialChangeResponseClass,
			MaterialFeedRequestClass,
			MaterialFeedResponseClass,
			MaterialRetractClass,
			MaterialRetractRequestClass,
			MaterialRetractResponseClass,
			MaterialLoadClass,
			MaterialLoadRequestClass,
			MaterialLoadResponseClass,
			MaterialUnloadClass,
			MaterialUnloadRequestClass,
			MaterialUnloadResponseClass,
			OpenChuckClass,
			OpenChuckRequestClass,
			OpenChuckResponseClass,
			OpenDoorClass,
			OpenDoorRequestClass,
			OpenDoorResponseClass,
			PartChangeClass,
			PartChangeRequestClass,
			PartChangeResponseClass,
			CloseDoorClass,
			CloseDoorRequestClass,
			CloseDoorResponseClass,
			CloseChuckClass,
			CloseChuckRequestClass,
			CloseChuckResponseClass,
			InterfaceStateClass,
		};

	private Package.MaterialFeedClass _MaterialFeedClass;
	public Package.MaterialFeedClass MaterialFeedClass => _MaterialFeedClass ?? (_MaterialFeedClass = new Package.MaterialFeedClass());
	private Package.MaterialChangeClass _MaterialChangeClass;
	public Package.MaterialChangeClass MaterialChangeClass => _MaterialChangeClass ?? (_MaterialChangeClass = new Package.MaterialChangeClass());
	private Package.MaterialChangeRequestClass _MaterialChangeRequestClass;
	public Package.MaterialChangeRequestClass MaterialChangeRequestClass => _MaterialChangeRequestClass ?? (_MaterialChangeRequestClass = new Package.MaterialChangeRequestClass());
	private Package.MaterialChangeResponseClass _MaterialChangeResponseClass;
	public Package.MaterialChangeResponseClass MaterialChangeResponseClass => _MaterialChangeResponseClass ?? (_MaterialChangeResponseClass = new Package.MaterialChangeResponseClass());
	private Package.MaterialFeedRequestClass _MaterialFeedRequestClass;
	public Package.MaterialFeedRequestClass MaterialFeedRequestClass => _MaterialFeedRequestClass ?? (_MaterialFeedRequestClass = new Package.MaterialFeedRequestClass());
	private Package.MaterialFeedResponseClass _MaterialFeedResponseClass;
	public Package.MaterialFeedResponseClass MaterialFeedResponseClass => _MaterialFeedResponseClass ?? (_MaterialFeedResponseClass = new Package.MaterialFeedResponseClass());
	private Package.MaterialRetractClass _MaterialRetractClass;
	public Package.MaterialRetractClass MaterialRetractClass => _MaterialRetractClass ?? (_MaterialRetractClass = new Package.MaterialRetractClass());
	private Package.MaterialRetractRequestClass _MaterialRetractRequestClass;
	public Package.MaterialRetractRequestClass MaterialRetractRequestClass => _MaterialRetractRequestClass ?? (_MaterialRetractRequestClass = new Package.MaterialRetractRequestClass());
	private Package.MaterialRetractResponseClass _MaterialRetractResponseClass;
	public Package.MaterialRetractResponseClass MaterialRetractResponseClass => _MaterialRetractResponseClass ?? (_MaterialRetractResponseClass = new Package.MaterialRetractResponseClass());
	private Package.MaterialLoadClass _MaterialLoadClass;
	public Package.MaterialLoadClass MaterialLoadClass => _MaterialLoadClass ?? (_MaterialLoadClass = new Package.MaterialLoadClass());
	private Package.MaterialLoadRequestClass _MaterialLoadRequestClass;
	public Package.MaterialLoadRequestClass MaterialLoadRequestClass => _MaterialLoadRequestClass ?? (_MaterialLoadRequestClass = new Package.MaterialLoadRequestClass());
	private Package.MaterialLoadResponseClass _MaterialLoadResponseClass;
	public Package.MaterialLoadResponseClass MaterialLoadResponseClass => _MaterialLoadResponseClass ?? (_MaterialLoadResponseClass = new Package.MaterialLoadResponseClass());
	private Package.MaterialUnloadClass _MaterialUnloadClass;
	public Package.MaterialUnloadClass MaterialUnloadClass => _MaterialUnloadClass ?? (_MaterialUnloadClass = new Package.MaterialUnloadClass());
	private Package.MaterialUnloadRequestClass _MaterialUnloadRequestClass;
	public Package.MaterialUnloadRequestClass MaterialUnloadRequestClass => _MaterialUnloadRequestClass ?? (_MaterialUnloadRequestClass = new Package.MaterialUnloadRequestClass());
	private Package.MaterialUnloadResponseClass _MaterialUnloadResponseClass;
	public Package.MaterialUnloadResponseClass MaterialUnloadResponseClass => _MaterialUnloadResponseClass ?? (_MaterialUnloadResponseClass = new Package.MaterialUnloadResponseClass());
	private Package.OpenChuckClass _OpenChuckClass;
	public Package.OpenChuckClass OpenChuckClass => _OpenChuckClass ?? (_OpenChuckClass = new Package.OpenChuckClass());
	private Package.OpenChuckRequestClass _OpenChuckRequestClass;
	public Package.OpenChuckRequestClass OpenChuckRequestClass => _OpenChuckRequestClass ?? (_OpenChuckRequestClass = new Package.OpenChuckRequestClass());
	private Package.OpenChuckResponseClass _OpenChuckResponseClass;
	public Package.OpenChuckResponseClass OpenChuckResponseClass => _OpenChuckResponseClass ?? (_OpenChuckResponseClass = new Package.OpenChuckResponseClass());
	private Package.OpenDoorClass _OpenDoorClass;
	public Package.OpenDoorClass OpenDoorClass => _OpenDoorClass ?? (_OpenDoorClass = new Package.OpenDoorClass());
	private Package.OpenDoorRequestClass _OpenDoorRequestClass;
	public Package.OpenDoorRequestClass OpenDoorRequestClass => _OpenDoorRequestClass ?? (_OpenDoorRequestClass = new Package.OpenDoorRequestClass());
	private Package.OpenDoorResponseClass _OpenDoorResponseClass;
	public Package.OpenDoorResponseClass OpenDoorResponseClass => _OpenDoorResponseClass ?? (_OpenDoorResponseClass = new Package.OpenDoorResponseClass());
	private Package.PartChangeClass _PartChangeClass;
	public Package.PartChangeClass PartChangeClass => _PartChangeClass ?? (_PartChangeClass = new Package.PartChangeClass());
	private Package.PartChangeRequestClass _PartChangeRequestClass;
	public Package.PartChangeRequestClass PartChangeRequestClass => _PartChangeRequestClass ?? (_PartChangeRequestClass = new Package.PartChangeRequestClass());
	private Package.PartChangeResponseClass _PartChangeResponseClass;
	public Package.PartChangeResponseClass PartChangeResponseClass => _PartChangeResponseClass ?? (_PartChangeResponseClass = new Package.PartChangeResponseClass());
	private Package.CloseDoorClass _CloseDoorClass;
	public Package.CloseDoorClass CloseDoorClass => _CloseDoorClass ?? (_CloseDoorClass = new Package.CloseDoorClass());
	private Package.CloseDoorRequestClass _CloseDoorRequestClass;
	public Package.CloseDoorRequestClass CloseDoorRequestClass => _CloseDoorRequestClass ?? (_CloseDoorRequestClass = new Package.CloseDoorRequestClass());
	private Package.CloseDoorResponseClass _CloseDoorResponseClass;
	public Package.CloseDoorResponseClass CloseDoorResponseClass => _CloseDoorResponseClass ?? (_CloseDoorResponseClass = new Package.CloseDoorResponseClass());
	private Package.CloseChuckClass _CloseChuckClass;
	public Package.CloseChuckClass CloseChuckClass => _CloseChuckClass ?? (_CloseChuckClass = new Package.CloseChuckClass());
	private Package.CloseChuckRequestClass _CloseChuckRequestClass;
	public Package.CloseChuckRequestClass CloseChuckRequestClass => _CloseChuckRequestClass ?? (_CloseChuckRequestClass = new Package.CloseChuckRequestClass());
	private Package.CloseChuckResponseClass _CloseChuckResponseClass;
	public Package.CloseChuckResponseClass CloseChuckResponseClass => _CloseChuckResponseClass ?? (_CloseChuckResponseClass = new Package.CloseChuckResponseClass());
	private Package.InterfaceStateClass _InterfaceStateClass;
	public Package.InterfaceStateClass InterfaceStateClass => _InterfaceStateClass ?? (_InterfaceStateClass = new Package.InterfaceStateClass());
	}
}