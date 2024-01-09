using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreApp.Pages
{
    public class ProductsModel : PageModel
    {
        [Required, StringLength(10)]
        [BindProperty(SupportsGet =true)]
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Test";
        }

        public void OnPost()
        {
            Message = "Form Posted";
        }

        public void OnPostEdit(int id)
        {
            Message = "Edit handler fired";
        }
    }
}