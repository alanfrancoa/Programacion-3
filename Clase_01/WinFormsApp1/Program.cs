namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //inicializa configuracion de app
            ApplicationConfiguration.Initialize();
            
            //crea una instancia de Form1, ventana principal
            Form1 ventana = new Form1();

            //Ejecuta la aplicacion, mostrando la ventana principal.
            Application.Run(ventana);
        }
    }
}