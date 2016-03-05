using System.Web.Mvc;

namespace FilemanagerMvcDemo.Areas.Filemanager
{
    /// <summary>
    /// Register the Filemanager Area 
    /// </summary>
    public class DebugAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// Returns the AreaName 
        /// </summary>
        public override string AreaName
        {
            get
            {
                return "Filemanager";
            }
        }

        /// <summary>
        /// Registers the area 
        /// </summary>
        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Filemanager_default",
                "FileManager/connectors/mvc/filemanager",
                new { controller = "Filemanager", action = "Index" },
                new string[] { "FilemanagerMvcDemo.Areas.FilemanagerArea.Controllers" }
            );
        }
    }
}