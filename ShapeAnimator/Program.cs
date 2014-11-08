using System;
using System.Windows.Forms;
using ShapeAnimator.View.Forms;

namespace ShapeAnimator
{
    /// <summary>
    ///     Defines the entry point for the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        ///     Precondition: None
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShapeAnimatorForm());
        }
    }
}