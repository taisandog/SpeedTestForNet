using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpeedTestShell.Pages
{
    [DisableRequestSizeLimit]
    [ValidateAntiForgeryToken]
    public class uploadModel : PageModel
    {
        public void OnGet()
        {
        }
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    return Page();
        //}

        private const int ReadLen = 1024;
        public void OnPost()
        {
            return;
            byte[] buffer = new byte[ReadLen];
            int reader = 0;
            //int total = 0;
            Stream sfile = Request.Body;
            try
            {
                do
                {

                    reader = sfile.ReadAsync(buffer, 0, buffer.Length).Result;

                    //total += reader;
                } while (reader >= ReadLen);
            }
            catch (Exception ex)
            {

            }

        }
    }
}
