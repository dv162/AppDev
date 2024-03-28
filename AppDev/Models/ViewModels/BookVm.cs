using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppDev.Models.ViewModels
{
	public class BookVm
	{
		public Book Book { get; set; }
		public IEnumerable<SelectListItem> Categories { get; set; }
	}
}
