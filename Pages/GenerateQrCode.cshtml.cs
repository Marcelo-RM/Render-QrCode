using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace render_qrcode.Pages;

public class GenerateQrCodeModel : PageModel
{
	private readonly ILogger<GenerateQrCodeModel> _logger;

	public GenerateQrCodeModel(ILogger<GenerateQrCodeModel> logger)
	{
		_logger = logger;
	}

	[Required(ErrorMessage = "Favor informar o conteúdo do QR Code!")]
	public string ContentQrCode { get; set; } = null!;

	public void OnGet()
	{
	}
}