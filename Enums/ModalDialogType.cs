using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSC.Blazor.Components.ModalDialog.Enums
{
	/// <summary>
	/// Enum ModalDialogType
	/// </summary>
	public enum ModalDialogType
	{
		/// <summary>
		/// The ok
		/// </summary>
		Ok,
		/// <summary>
		/// The ok or cancel
		/// </summary>
		OkCancel,
		/// <summary>
		/// The delete or cancel
		/// </summary>
		DeleteCancel,
		/// <summary>
		/// The yes or no
		/// </summary>
		YesNo
	}
}