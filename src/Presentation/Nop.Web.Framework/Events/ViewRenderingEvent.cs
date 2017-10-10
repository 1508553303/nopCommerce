using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Nop.Web.Framework.Events
{
    /// <summary>
    /// Represents an event that occurs before the view is rendered
    /// </summary>
    public class ViewRenderingEvent
    {
        #region Ctor

        public ViewRenderingEvent(IView view, ViewContext viewContext)
        {
            this.View = view;
            this.ViewContext = viewContext;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets a view
        /// </summary>
        public IView View { get; private set; }

        /// <summary>
        /// Gets a view context
        /// </summary>
        public ViewContext ViewContext { get; private set; }

        #endregion
    }
}