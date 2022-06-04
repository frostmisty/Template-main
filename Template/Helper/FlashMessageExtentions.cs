using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Helper
{
    public static class Alerts
    {
        public const string SUCCESS = "success";
        public const string ATTENTION = "attention";
        public const string WARNING = "warning";
        public const string ERROR = "danger";
        public const string INFORMATION = "info";

        public const string ICONSUCCESS = "fas fa-check";
        public const string ICONATTENTION = "fas fa-info";
        public const string ICONWARNING = "fas fa-exclamation-triangle";
        public const string ICONERROR = "fas fa-ban";
        public const string ICONINFORMATION = "fas fa-info";

        public static string[] ALL
        {
            get { 
                return new[] { SUCCESS, ATTENTION, WARNING, ERROR, INFORMATION }; 
            }
        }

        public static string[,] ALLS
        {
            get
            {
                return new[,] {
                    { SUCCESS, ICONSUCCESS },
                    { ATTENTION,ICONATTENTION },
                    { WARNING,ICONWARNING },
                    { ERROR,ICONERROR },
                    { INFORMATION, ICONINFORMATION } };
            }
        }
    }
}
