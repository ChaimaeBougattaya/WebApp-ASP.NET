using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Model;

namespace WebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext datacontext;
        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext data)
        {
            _logger = logger;
            this.datacontext = data;
        }

        public void OnGet()
        {
            var student = new Student() { nom = "ghita" , prenom ="alaoui" , username = "ghitaA" };
            datacontext.students.Add(student);
            datacontext.SaveChanges();

        }
    }
}
