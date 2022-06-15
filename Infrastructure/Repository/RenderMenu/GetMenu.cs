using ApplicationCore.Additional;
using ApplicationCore.Base.Spesification;
using Infrastructure.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Additional;
using Template.Domain.Base;

namespace Infrastructure.Repository.RenderMenu
{
    public class GetMenu : IGetMenu
    {
        protected readonly MainTemplateContext _mainTemplateContext;
        public GetMenu(MainTemplateContext mainTemplateContext)
        {
            _mainTemplateContext = mainTemplateContext;
        }
        public string GetMenuList(string UserId, string userRoleId)
        {
            var menuList = new List<DtoGetMenu>();
            var menu = new DtoGetMenu();
            var Param1 = new SqlParameter("@UserID", UserId);
            var Param2 = new SqlParameter("@UserRoleID", userRoleId);
            //menu = _mainTemplateContext.Database.ExecuteSqlRaw("EXEC GetMenu @UserID,@UserRoleID", Param1, Param2).ToList();
            using(var db = _mainTemplateContext.Database.GetDbConnection().CreateCommand())
            {
                db.CommandText = "GetMenu";
                db.CommandType = System.Data.CommandType.StoredProcedure;
                if (db.Connection.State != System.Data.ConnectionState.Open)
                {
                    db.Connection.Open();
                } else {
                    db.Connection.Close(); 
                }

                db.Parameters.Add(Param1);
                db.Parameters.Add(Param2);
                using DbDataReader reader = db.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        menuList.Add(new DtoGetMenu()
                        {
                            PageId = reader["PageID"].ToString() ?? "",
                            ParentId = reader["ParentId"].ToString() ?? "",
                            MenuId = reader["MenuId"].ToString() ?? "",
                            MenuText = reader["MenuText"].ToString() ?? "",
                            Seq = (Int32)reader["Seq"],
                        });
                    }
                }
            }
            var builder = new StringBuilder();
            foreach (var parent in menuList.Where(x => x.ParentId != null))
            {
                builder.AppendLine("<li class=\"nav-item\"'>");
                builder.AppendLine("<a href=\"#\" class=\"nav-link\">");
                builder.AppendLine("<i class=\"nav-icon fas fa-circle\"></i>");
                builder.AppendLine("<p>" + parent.MenuText + " <i> right fas fa-angle-left</i></p>");
                builder.AppendLine("</a>");
                builder.AppendLine("<ul class =\"nav nav-treeview\" >");
                foreach (var child in menuList.Where(x => x.ParentId.Equals(parent.ParentId)))
                {
                    builder.AppendLine("<li class=\"nav-item\">");
                    builder.AppendLine("<a asp-controller=\"" + child.PageName + "\" asp-action=\"Index\" class=\"nav-link\">");
                    builder.AppendLine("<i class=\"fas " + child.PageIcon + " nav-icon\"></i><p>" + child.MenuText + "</p>");
                    builder.AppendLine("</a>");
                    builder.AppendLine("<li class=\"nav-item\">");
                    builder.AppendLine("</li>");
                }
                builder.AppendLine("</ul>");
                builder.AppendLine("</li>");
            }
            //var strings = new HtmlString(builder.ToString());
            return builder.ToString();
        }

        public List<DtoGetMenu> GetMenuListDto(string UserId, string userRoleId)
        {
            var menuList = new List<DtoGetMenu>();
            var menu = new DtoGetMenu();
            var header = readers(UserId, userRoleId, "Header");
            if (header.HasRows)
            {
                while (header.Read())
                {
                    menuList.Add(new DtoGetMenu()
                    {
                        PageId = header["PageID"].ToString() ?? "",
                        ParentId = header["ParentId"].ToString() ?? "",
                        MenuId = header["MenuId"].ToString() ?? "",
                        MenuText = header["MenuText"].ToString() ?? "",
                        Seq = (Int32)header["Seq"],
                    });
                }

            }
            return menuList;
        }
        public List<DtoGetMenuChild> GetMenuListChild(string UserId, string userRoleId)
        {
            var menuList = new List<DtoGetMenuChild>();
            var menu = new DtoGetMenu();
            var child = readers(UserId, userRoleId, "Child");
            if (child.HasRows)
            {
                while (child.Read())
                {
                    menuList.Add(new DtoGetMenuChild()
                    {
                        PageId = child["PageID"].ToString() ?? "",
                        ParentId = child["ParentId"].ToString() ?? "",
                        MenuId = child["MenuId"].ToString() ?? "",
                        PageName = child["PageName"].ToString() ?? "",
                        PageIcon = child["PageIcon"].ToString() ?? "",
                        MenuText = child["MenuText"].ToString() ?? "",
                        Seq = (Int32)child["Seq"],
                    });
                }

            }
            return menuList;
        }
        public DbDataReader readers(string UserId, string userRoleId, string Posisi) 
        {
            var Param1 = new SqlParameter("@UserID", UserId);
            var Param2 = new SqlParameter("@UserRoleID", userRoleId);
            var Param3 = new SqlParameter("@Posisi", Posisi);
            using (var db = _mainTemplateContext.Database.GetDbConnection().CreateCommand())
            {
                db.CommandText = "GetMenu";
                db.CommandType = System.Data.CommandType.StoredProcedure;
                db.Connection.Close();
                if (db.Connection.State != System.Data.ConnectionState.Open)
                {
                    db.Connection.Open();
                }
                

                db.Parameters.Add(Param1);
                db.Parameters.Add(Param2);
                db.Parameters.Add(Param3);
                DbDataReader reader = db.ExecuteReader();

                return reader;
            }
        }
        
    }
}
