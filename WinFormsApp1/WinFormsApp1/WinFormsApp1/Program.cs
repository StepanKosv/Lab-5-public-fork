

namespace WinFormsApp1
{
    internal static class Program
    {
        public static decimal[,] arr2d = new decimal[0,0];
        public static bool isArr2dCreated = false;
        public static decimal[][] jaggedArr = new decimal[0][];
        public static bool isJaggedCreated = false;
        public static Random random = new Random();

        public static bool isStrProcessed; //{ get; internal set; }
        public static string str; //{ get; internal set; }
        public static string processedsStr; //{ get; internal set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
